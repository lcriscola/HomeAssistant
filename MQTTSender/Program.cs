using MQTTnet.Client;
using MQTTnet;

using MQTTSender.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTTSender
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            if (args.Length > 2)
            {
                Console.WriteLine("MQTTSender.exe topic payload");
                return;
            }

            var topic = args[0];
            var payload = args[1];

            _options = Newtonsoft.Json.JsonConvert.DeserializeObject<Settings>(File.ReadAllText("settings.json"));
            await SendStatus(topic, payload);

        }
        static Settings? _options;
        public static async Task SendStatus(string topic, string value)
        {
            DateTime started = DateTime.Now;
            while ((DateTime.Now - started).TotalMinutes < 5)
            {
                try
                {
                    using (IMqttClient mqttClient = await GetMqttClient())
                    {
                        var text = value;
                        await mqttClient.PublishAsync(new MqttApplicationMessage() { Topic = topic, Payload = Encoding.UTF8.GetBytes(text) } );
                        Console.WriteLine($"\tMessage sent to {topic} with  {value}");
                        await mqttClient.DisconnectAsync();
                        return;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Thread.Sleep(5000);
                }
            }

        }

        private static async Task<IMqttClient> GetMqttClient()
        {
            var mqttFactory = new MqttFactory();
            var mqttClient = mqttFactory.CreateMqttClient();

            var mqttClientOptions = new MqttClientOptionsBuilder()
                .WithTcpServer(_options.MQTT_Host)
                .WithCredentials(_options.MQTT_User, _options.MQTT_Password)
                .WithClientId("mqtt-sender")
                .Build();

            await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

            return mqttClient;
        }

    }
}
