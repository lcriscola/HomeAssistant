
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace NetDaemon3Apps.AdjustEcobeeClimateBasedOnPresence
{
    public class EcobeeManager
    {
        private readonly IHaContext _ha;
        private readonly ILogger<AdjustEcobeeClimateBasedOnPresence> _logger;
        private readonly string _apiKey;

        public EcobeeManager(IHaContext _ha, ILogger<AdjustEcobeeClimateBasedOnPresence> logger, string apiKey)
        {
            this._ha = _ha;
            this._logger = logger;
            this._apiKey = apiKey;
        }

        TokenResponse _tokenData = null;

        public void ClearAllSensors(ThermostatList thermostat)
        {
            foreach (var c in thermostat.program.climates)
            {
                var name = c.name;
                c.sensors.Clear();

            }
        }

        public async Task<ThermostatList> GetThermostat()
        {
            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _tokenData.access_token);
            var response = await client.GetAsync("https://api.ecobee.com/1/thermostat?json={\"selection\":{\"includeProgram\":true, \"includeSensors\":\"true\", \"includeAlerts\":\"true\",\"selectionType\":\"registered\",\"selectionMatch\":\"\",\"includeEvents\":\"true\",\"includeSettings\":\"true\",\"includeRuntime\":\"true\"}}");
            var responseText = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(responseText);

            }
            var thermostats = System.Text.Json.JsonSerializer.Deserialize<Thermostat>(responseText);


            ThermostatList thermostat = thermostats.thermostatList[0];
            return thermostat;
        }

        public async Task Authenticate()
        {

            if (File.Exists("/data/token.json"))
            {
                _tokenData = System.Text.Json.JsonSerializer.Deserialize<TokenResponse>(File.ReadAllText("/data/token.json"));
                if (String.IsNullOrEmpty(_tokenData.refresh_token))
                {
                    try
                    {
                        _tokenData = await GetToken(_tokenData.code);

                    }
                    catch (Exception ex)
                    {
                        var code = await GetCode();
                        _tokenData = new TokenResponse();
                        _tokenData.code = code;
                    }   
                }
                else
                {
                    _tokenData = await RefreshToken(_tokenData.refresh_token);
                }
            }
            else
            {
                var code = await GetCode();
                _tokenData = new TokenResponse();
                _tokenData.code = code;  


                //tokenData = await GetToken(code);
            }
            File.WriteAllText("/data/token.json", System.Text.Json.JsonSerializer.Serialize(_tokenData));

        }


        public void UpdateSensor(ThermostatList thermostat, string sensorName, params string[] comfortSettingNames)
        {
            IEnumerable<RemoteSensor> sensors = thermostat.remoteSensors;

            var sensor = sensors.FirstOrDefault(x => x.name == sensorName);
            var climates = thermostat.program.climates.Where(x => comfortSettingNames.Contains(x.name));
            foreach (var c in climates)
            {
                c.sensors.Add(new Sensor() { id = sensor.id + ":1", name = sensor.name });
            }
        }

        public async Task<TokenResponse> GetToken(string code)
        {
            using HttpClient client = new HttpClient();
            var data = $"grant_type=ecobeePin&code={code}&client_id={_apiKey}";

            var response = await client.PostAsync($"https://api.ecobee.com/token", new StringContent(data, Encoding.UTF8, "application/x-www-form-urlencoded"));
            var responseText = "";
            responseText = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                var error = System.Text.Json.JsonSerializer.Deserialize<ErrorResponse>(responseText);
                throw new ApplicationException($"code={code} {error.error_description}");
            }

            var tokenData = System.Text.Json.JsonSerializer.Deserialize<TokenResponse>(responseText);
            return tokenData;
        }
        async Task<TokenResponse> RefreshToken(string refreshToken)
        {
            var code = _tokenData.code;
          
            using HttpClient client = new HttpClient();
            var data = $"grant_type=refresh_token&code={refreshToken}&client_id={_apiKey}";

            var response = await client.PostAsync($"https://api.ecobee.com/token", new StringContent(data, Encoding.UTF8, "application/x-www-form-urlencoded"));
            var responseText = "";
            responseText = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                var error = System.Text.Json.JsonSerializer.Deserialize<ErrorResponse>(responseText);
                throw new ApplicationException(error.error_description);
            }

            var tokenData = System.Text.Json.JsonSerializer.Deserialize<TokenResponse>(responseText);

            _tokenData.code = code;
            File.WriteAllText("/data/token.json", System.Text.Json.JsonSerializer.Serialize(_tokenData));



            _logger.LogDebug("Token updated.");


            return tokenData;
        }
        async Task<string> GetCode()
        {

            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://api.ecobee.com/authorize?response_type=ecobeePin&client_id={_apiKey}&scope=smartWrite");
            response.EnsureSuccessStatusCode();

            var authorizationResponse = await response.Content.ReadFromJsonAsync<AuthorizationResponse>();
            var code = authorizationResponse.code;
            var pin = authorizationResponse.ecobeePin;
            
            _ha.CallService("notify", "persistent_notification", null, new { message = $"A new Pin ({pin}) was generated and needs to be authorized. Goto https://www.ecobee.com/consumerportal/index.html#/my-apps", title = "Ecobee Code" });
            _logger.LogWarning("Pin authorization needed");
            return code;
        }

        internal async Task SetPreset(string presetName)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _tokenData.access_token);
            
            var t2 = new { functions = new[] { new { type = "setHold", @params = new { holdType = "indefinite", holdClimateRef = "away" } } }, selection = new { selectionType = "registered", selectionMatch = "" } };
            var text2 = System.Text.Json.JsonSerializer.Serialize(t2);
            var response = await client.PostAsync("https://api.ecobee.com/1/thermostat?format=json", new StringContent(text2, Encoding.UTF8, "application/json"));
            var responseText = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                var error = System.Text.Json.JsonSerializer.Deserialize<ErrorResponse>(responseText);
                throw new ApplicationException(error.error_description);

            }

        }
        internal async Task ClearPreset()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _tokenData.access_token);

            var t2 = new { functions =new[] { new { type = "resumeProgram" } } , selection = new { selectionType = "registered", selectionMatch = "" } };
            var text2 = System.Text.Json.JsonSerializer.Serialize(t2);
            var response = await client.PostAsync("https://api.ecobee.com/1/thermostat?format=json", new StringContent(text2, Encoding.UTF8, "application/json"));
            var responseText = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                var error = System.Text.Json.JsonSerializer.Deserialize<ErrorResponse>(responseText);
                throw new ApplicationException(error.error_description);

            }

        }
        internal async Task SendUpdates(ThermostatList thermostat)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _tokenData.access_token);

            var t = new { thermostat = thermostat, selection = new { selectionType = "registered", selectionMatch = "" } };
            t.thermostat.runtime = null;
            var text = System.Text.Json.JsonSerializer.Serialize(t);
            var response = await client.PostAsync("https://api.ecobee.com/1/thermostat?format=json", new StringContent(text, Encoding.UTF8, "application/json"));

           var responseText = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                var error = System.Text.Json.JsonSerializer.Deserialize<ErrorResponse>(responseText);
                throw new ApplicationException(error.error_description);

            }


        }
    }

}
