using Microsoft.Extensions.Hosting;

using MQQTListener.Models;

using System.Diagnostics;
using System.Net.Mqtt;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace MQQTListener
{
    internal class ServiceWorker : BackgroundService
    {
        Settings options;


        async Task Connect()
        {
            while (true)
            {
                try
                {
                    var mqttClient = await MqttClient.CreateAsync(options.MQTT_Host);
                    await mqttClient.ConnectAsync(new MqttClientCredentials("appLauncher", options.MQTT_User, options.MQTT_Password));

                    await mqttClient.SubscribeAsync("appLauncher/start", MqttQualityOfService.AtLeastOnce);
                    await mqttClient.SubscribeAsync("appLauncher/stop", MqttQualityOfService.AtLeastOnce);
                    mqttClient.Disconnected += MqttClient_Disconnected;
                    mqttClient.MessageStream.Subscribe(x =>
                    {
                        try
                        {
                            options = Newtonsoft.Json.JsonConvert.DeserializeObject<Settings>(File.ReadAllText("settings.json"));

                            var app = System.Text.Encoding.UTF8.GetString(x.Payload);
                            if (options.Apps.TryGetValue(app, out var appFound))
                            {

                                if (x.Topic.EndsWith("start"))
                                {

                                    var spi = new ProcessStartInfo();
                                    spi.FileName = appFound.File;
                                    if (!String.IsNullOrEmpty(appFound.Arguments))
                                        spi.Arguments = appFound.Arguments;

                                    if (string.IsNullOrEmpty(appFound.StartupDirectory))
                                        spi.WorkingDirectory = System.Environment.CurrentDirectory;
                                    else
                                        spi.WorkingDirectory = appFound.StartupDirectory;

                                    spi.RedirectStandardOutput = true;
                                    spi.RedirectStandardInput = true;

                                    var proc = Process.Start(spi);
                                    proc.EnableRaisingEvents = true;
                                    proc.ErrorDataReceived += Proc_ErrorDataReceived;
                                    proc.OutputDataReceived += Proc_OutputDataReceived;



                                    Log($"Starting file {spi.FileName} {spi.Arguments} in  {spi.WorkingDirectory}");
                                }
                                else
                                {
                                    Log("Stopping " + appFound.File);
                                    var procs = System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(appFound.File));
                                    foreach (var p in procs)
                                    {
                                        p.Kill(true);
                                    }

                                }
                            }
                            else
                            {
                                throw new ArgumentException($"{app} not found");
                            }
                        }
                        catch (global::System.Exception ex)
                        {
                            LogError(ex.ToString());
                        }
                    });
                    Log("Connected to MQTT");
                    break;

                }
                catch (Exception ex)
                {
                    LogError(ex.ToString());
                    Thread.Sleep(5000);
                }
            }
        }

        private void Proc_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
                Log(e.Data);
        }

        private void Proc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
                Log(e.Data);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {


            Directory.SetCurrentDirectory(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            options = Newtonsoft.Json.JsonConvert.DeserializeObject<Settings>(File.ReadAllText("settings.json"));

            await Connect();

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(TimeSpan.FromSeconds(1), stoppingToken);
            }
        }

        private void MqttClient_Disconnected(object? sender, MqttEndpointDisconnected e)
        {
            LogError(e.Message + " " + e.Reason.ToString());
            Thread.Sleep(5000);
            (sender as IMqttClient).Dispose();
            Connect().Wait();

        }

        static void Log(string message)
        {
            message = DateTime.Now.ToString() + " " + message;
            File.AppendAllText("log.txt", message + Environment.NewLine);
            Console.WriteLine(message);
            System.Diagnostics.Debug.WriteLine(message);
        }
        static void LogError(string message)
        {
            message = DateTime.Now.ToString() + " " + message;
            File.AppendAllText("log.txt", message + Environment.NewLine);
            Console.WriteLine(message);
            System.Diagnostics.Debug.WriteLine("ERROR:" + message);
        }

    }
}