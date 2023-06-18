using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon3Apps.AdjustEcobeeClimateBasedOnPresence
{
    public class ErrorResponse
    {
        [JsonPropertyName("error")]
        public string error { get; set; }

        [JsonPropertyName("error_description")]
        public string error_description { get; set; }

        [JsonPropertyName("error_uri")]
        public string error_uri { get; set; }
    }
}
