using AmcrestMQTT.Models;
using AmcrestMQTT.Topics;

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmcrestMQTT
{
    public class MQTTWorker : IHostedService, IDisposable
    {
        private readonly Settings _options;
        private readonly AmcrestToMqttWorker _worker;

        public void Dispose()
        {
        }

        public MQTTWorker(Settings options, AmcrestToMqttWorker worker)
        {
            this._options = options;
            this._worker = worker;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _worker.SendDiscoveryInformationAsync();
            _worker.ConnectToCameras();
        }

 

    
        public   Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }


     
    }
}
