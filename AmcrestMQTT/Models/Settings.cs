using System.Text.Json.Serialization;

namespace AmcrestMQTT.Models
{
    public class Settings
    {
        public string MQTT_Host { get; set; }
        public string MQTT_User { get; set; }
        public string MQTT_Password { get; set; }
        public CameraSetting[] Cameras { get; set; }
        public SensorSetting[] Sensors { get; set; }
        public bool ListenToAllEvents { get; set; }
    }

    public class CameraSetting
    {
        public string Host { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string UniqueId { get; set; }

    }

    public class SensorSetting
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Component { get; set; }
        public string UniqueId { get; set; }
        public string DeviceClass { get; set; }
        public string Code { get; set; }
        public string GetBaseTopic(string name)
        {
            return $"homeassistant/{this.Component}/{name}_{this.UniqueId}";
        }
        public string GetConfigTopic(string name)
        {
            return $"{this.GetBaseTopic(name)}/config";
        }
        public string GetStateTopic(string name)
        {
            return $"{this.GetBaseTopic(name)}/state";
        }



     
    }

}
