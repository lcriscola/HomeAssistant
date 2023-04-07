using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon3Apps
{
 
    public class SwitchBotApiDevice : Response<SwitchBotApiDeviceBody>
    {

    }

    public class SwitchBotApiDeviceBody
    {
        [JsonPropertyName("deviceList")]
        public List<SwitchBotApiDeviceList> DeviceList { get; set; }

        [JsonPropertyName("infraredRemoteList")]
        public List<object> InfraredRemoteList { get; set; }
    }


    public class SwitchBotApiDeviceList
    {
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }

        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }

        [JsonPropertyName("deviceType")]
        public string DeviceType { get; set; }

        [JsonPropertyName("enableCloudService")]
        public bool EnableCloudService { get; set; }

        [JsonPropertyName("hubDeviceId")]
        public string HubDeviceId { get; set; }

        [JsonPropertyName("master")]
        public bool Master { get; set; }
    }
}
