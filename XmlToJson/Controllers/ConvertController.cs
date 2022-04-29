using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace XmlToJson.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConvertController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ConvertController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory httpClientFactory;

        public ConvertController(ILogger<ConvertController> logger, IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            this._configuration = configuration;
            this.httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> RunConversion(string keyUrl)
        {
            var client = httpClientFactory.CreateClient();
            var url = _configuration.GetValue<string>(keyUrl);
            var xmlResult = await client.GetStringAsync(url);


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlResult);
            string jsonText = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
            return this.Content(jsonText, "application/json");
        }
    }
}
