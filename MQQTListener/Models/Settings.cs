namespace MQQTListener.Models;


    public class Settings
    {
        public string MQTT_Host { get; set; }
        public string MQTT_User { get; set; }
        public string MQTT_Password { get; set; }
         public Dictionary<string,App> Apps { get; set; }
}



public class App
{
    public string File { get; set; }
    public string Arguments { get; set; }
    public string StartupDirectory { get; set; }
}


 