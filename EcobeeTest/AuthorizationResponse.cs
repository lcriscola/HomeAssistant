using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EcobeeTest
{
    internal class AuthorizationResponse
    {
            [JsonPropertyName("ecobeePin")]
            public string ecobeePin { get; set; }

            [JsonPropertyName("code")]
            public string code { get; set; }

            [JsonPropertyName("interval")]
            public int interval { get; set; }

            [JsonPropertyName("expires_in")]
            public int expires_in { get; set; }

            [JsonPropertyName("scope")]
            public string scope { get; set; }

    }
}
