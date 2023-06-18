// See https://aka.ms/new-console-template for more information
using EcobeeTest;

using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;

var apiKey = "yksbDqelD9ImKQ5N6ZnXczQc1bf9aT7a";
var pin = "";

HttpClient client = new HttpClient();


//client.DefaultRequestHeaders.Add("Content-Type", "application/json");


//var response = await client.GetAsync($"https://api.ecobee.com/authorize?response_type=ecobeePin&client_id={apiKey}&scope=smartWrite");
//response.EnsureSuccessStatusCode();

//var authorizationResponse = await response.Content.ReadFromJsonAsync<AuthorizationResponse>();
//var code = authorizationResponse.code;
//var pin = authorizationResponse.ecobeePin;

//var data = $"grant_type=ecobeePin&code={code}&client_id={apiKey}";


TokenResponse tokenData =null;

if (File.Exists("token.json"))
{
    tokenData = System.Text.Json.JsonSerializer.Deserialize<TokenResponse>(File.ReadAllText("token.json"));
    tokenData = await RefreshToken(tokenData.refresh_token);
}
else
{
    var code = await GetCode();
    tokenData = await GetToken(code);
}
File.WriteAllText("token.json", System.Text.Json.JsonSerializer.Serialize(tokenData));

client.DefaultRequestHeaders.Add("Authorization", "Bearer " + tokenData.access_token);


var response = await client.GetAsync("https://api.ecobee.com/1/thermostat?json={\"selection\":{\"includeProgram\":true, \"includeSensors\":\"true\", \"includeAlerts\":\"true\",\"selectionType\":\"registered\",\"selectionMatch\":\"\",\"includeEvents\":\"true\",\"includeSettings\":\"true\",\"includeRuntime\":\"true\"}}");
//var response = await client.GetAsync("https://api.ecobee.com/1/thermostat?json={\"selection\":{\"includeProgram\":true, \"selectionType\":\"registered\",\"selectionMatch\":\"\"}}");
var responseText = await response.Content.ReadAsStringAsync();
if (!response.IsSuccessStatusCode)
{
    throw new ApplicationException(responseText);

}
var thermostats = System.Text.Json.JsonSerializer.Deserialize<Thermostat>(responseText);


var thermostat = thermostats.thermostatList[0];
var sensors = thermostat.remoteSensors;

//foreach (var c in thermostat.program.climates)
//{
//    var name = c.name;
//    c.sensors = sensors.Where(x => true).Select(s => new Sensor() { id = s.id+":1", name = s.name }).ToList();

//}

var climates = thermostat.program.climates.Select(x => x.name).ToArray();

ClearAllSensors(thermostat);
UpdateSensor(thermostat, sensors, "Thermostat","Home","Away","Sleep","Sleeping");

//UpdateSensor(thermostat, sensors, "Master", "Home","Sleep","Sleeping");


var t = new { thermostat = thermostat, selection = new { selectionType = "registered", selectionMatch = "" } } ;

t.thermostat.runtime = null;
var text = System.Text.Json.JsonSerializer.Serialize(t);
response = await client.PostAsync("https://api.ecobee.com/1/thermostat?format=json", new StringContent(text, Encoding.UTF8, "application/json"));
 responseText = await response.Content.ReadAsStringAsync();
if (!response.IsSuccessStatusCode)
{
    throw new ApplicationException(responseText);

}


//var t2 = new { functions =new[] { new { type = "resumeProgram" } } , selection = new { selectionType = "registered", selectionMatch = "" } };
var t2 = new { functions =new[] { new { type = "setHold", @params = new {holdType="indefinite",holdClimateRef="away" } } } , selection = new { selectionType = "registered", selectionMatch = "" } };
var text2 = System.Text.Json.JsonSerializer.Serialize(t2);
response = await client.PostAsync("https://api.ecobee.com/1/thermostat?format=json", new StringContent(text2, Encoding.UTF8, "application/json"));
responseText = await response.Content.ReadAsStringAsync();
if (!response.IsSuccessStatusCode)
{
    throw new ApplicationException(responseText);

}


Console.WriteLine("Done");
Console.ReadLine();


void ClearAllSensors(ThermostatList thermostat)
{
    foreach (var c in thermostat.program.climates)
    {
        var name = c.name;
        c.sensors.Clear();

    }
}


void UpdateSensor(ThermostatList thermostat, IEnumerable<RemoteSensor> sensors, string sensorName, params string[] comfortSettingNames)
{
    var sensor = sensors.FirstOrDefault(x => x.name == sensorName);
    var climates = thermostat.program.climates.Where(x => comfortSettingNames.Contains(x.name));
    foreach (var c in climates)
    {
        c.sensors.Add(new Sensor() { id = sensor.id + ":1", name = sensor.name });
    }
}

async Task<TokenResponse> GetToken(string code)
{
    var data = $"grant_type=ecobeePin&code={code}&client_id={apiKey}";

    var response = await client.PostAsync($"https://api.ecobee.com/token", new StringContent(data, Encoding.UTF8, "application/x-www-form-urlencoded"));
    var responseText = "";
    responseText = await response.Content.ReadAsStringAsync();
    if (!response.IsSuccessStatusCode)
    {
        var errorResponse = System.Text.Json.JsonSerializer.Deserialize<ErrorResponse>(responseText);

        throw new ApplicationException($"{errorResponse.error_description}");
    }

    var tokenData = System.Text.Json.JsonSerializer.Deserialize<TokenResponse>(responseText);
    return tokenData;
}
async Task<TokenResponse> RefreshToken(string refreshToken)
{
    var data = $"grant_type=refresh_token&code={refreshToken}&client_id={apiKey}";

    var response = await client.PostAsync($"https://api.ecobee.com/token", new StringContent(data, Encoding.UTF8, "application/x-www-form-urlencoded"));
    var responseText = "";
    responseText = await response.Content.ReadAsStringAsync();
    if (!response.IsSuccessStatusCode)
    {
        Console.WriteLine("Pin=" + pin);
        throw new ApplicationException(responseText);
    }

    var tokenData = System.Text.Json.JsonSerializer.Deserialize<TokenResponse>(responseText);
    return tokenData;
}

async Task<string> GetCode()
{

    HttpClient client = new HttpClient();
    var response = await client.GetAsync($"https://api.ecobee.com/authorize?response_type=ecobeePin&client_id={apiKey}&scope=smartWrite");
    response.EnsureSuccessStatusCode();

    var authorizationResponse = await response.Content.ReadFromJsonAsync<AuthorizationResponse>();
    var code = authorizationResponse.code;
    var pin = authorizationResponse.ecobeePin;

    var data = $"grant_type=ecobeePin&code={code}&client_id={apiKey}";
    await Console.Out.WriteLineAsync(pin);
    return code;
}
