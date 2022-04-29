using MQTTSender.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mqtt;
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
                        await mqttClient.PublishAsync(new MqttApplicationMessage(topic, Encoding.UTF8.GetBytes(text)), MqttQualityOfService.AtLeastOnce);
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
            var mqttClient = await MqttClient.CreateAsync(_options.MQTT_Host);
            await mqttClient.ConnectAsync(new MqttClientCredentials("amcrest2mqtt", _options.MQTT_User, _options.MQTT_Password));
            return mqttClient;
        }
    }
}
