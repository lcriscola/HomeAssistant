using System.Text.Json.Serialization;

namespace NetDaemon3Apps
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class EventData
    {
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("service")]
        public string Service { get; set; }

        [JsonPropertyName("service_data")]
        public ServiceData ServiceData { get; set; }
    }

    public class ServiceData
    {
        [JsonPropertyName("entity_id")]
        public string EntityId { get; set; }
    }




}
