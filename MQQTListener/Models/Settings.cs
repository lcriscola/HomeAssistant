using System.Text.Json.Serialization;

namespace MQQTListener.Models;


public class Settings
{
    [JsonPropertyName("mqtt_host")]
    public string MQTT_Host { get; set; }
    [JsonPropertyName("mqtt_user")]
    public string MQTT_User { get; set; }
    [JsonPropertyName("mqtt_password")]
    public string MQTT_Password { get; set; }
    [JsonPropertyName("apps")]
    public Dictionary<string, App> Apps { get; set; }
}



public class App
{
    [JsonPropertyName("file")]
    public string File { get; set; }
    [JsonPropertyName("arguments")]
    public string Arguments { get; set; }
    [JsonPropertyName("startupDirectory")]
    public string StartupDirectory { get; set; }
}


