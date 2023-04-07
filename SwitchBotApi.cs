using Microsoft.AspNetCore.DataProtection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

using YamlDotNet.Core.Tokens;

using static System.Net.Mime.MediaTypeNames;

namespace NetDaemon3Apps
{
    public class SwitchBotApi
    {
        private readonly string _url;
        private readonly string _secret;
        private readonly string _token;
 

        public SwitchBotApi(string url, string secret, string token)
        {
            _url = url;
            _secret = secret;
            _token = token;


   

        }
        public async Task<(string Id, string Name, string Type)[]> GetDevices()
        {
              var data = await ExecuteHttp<SwitchBotApiDevice>("/devices", HttpMethod.Get);
            return data.Body.DeviceList.Select(x => (x.DeviceId, x.DeviceName, x.DeviceType)).ToArray();
        }

        public async Task SendCommand(string id, string command)
        {
            var url = $"/devices/{id}/commands";
            
             await ExecuteHttp<object>(url, HttpMethod.Post, new { 
            commandType="command", command=command
            });

        }

      
        private async Task<T> ExecuteHttp<T>(string path, HttpMethod method, object body=null)
        {
            DateTime current = DateTime.UtcNow;
            var dt1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var time = current.ToUniversalTime().Subtract(dt1970).TotalMilliseconds;
            string nonce = Guid.NewGuid().ToString();
            string data = _token + time.ToString() + nonce;
            Encoding utf8 = Encoding.UTF8;
            HMACSHA256 hmac = new HMACSHA256(utf8.GetBytes(_secret));
            string signature = Convert.ToBase64String(hmac.ComputeHash(utf8.GetBytes(data)));


            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(method, $"{_url}{path}");
            request.Headers.TryAddWithoutValidation(@"Authorization", _token);
            request.Headers.TryAddWithoutValidation(@"sign", signature);
            request.Headers.TryAddWithoutValidation(@"nonce", nonce);
            request.Headers.TryAddWithoutValidation(@"t", time.ToString()); 

            if (body!=null)
            {
                var text = System.Text.Json.JsonSerializer.Serialize(body);
                request.Content = new StringContent(text, Encoding.UTF8, "application/json");

            }

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadFromJsonAsync<T>();
            return jsonResponse;
        }
    }
}
