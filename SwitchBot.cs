using Microsoft.AspNetCore.Mvc.Diagnostics;

using NetDaemon.Extensions.MqttEntityManager;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NetDaemon3Apps
{
    [NetDaemonApp]
    public class SwitchBot : IAsyncInitializable
    {
        private readonly IHaContext _ha;
        private readonly ILogger<SwitchBot> _logger;
        private readonly IAppConfig<SwitchBotConfig> _config;
        private readonly IMqttEntityManager _entityManager;
        public SwitchBot(IHaContext ha, ILogger<SwitchBot> logger, IAppConfig<SwitchBotConfig> config, IMqttEntityManager entityManager)
        {
            _ha = ha;
            _logger = logger;
            _config = config;
            _logger.Log(LogLevel.Information, $"{nameof(SwitchBot)} started.");
            _entityManager = entityManager;

        }
        const string DEVICE_CLASS_CURTAIN = "curtain";

            Dictionary<string, string> _curtains = new Dictionary<string, string>();
        public async Task InitializeAsync(CancellationToken cancellationToken)
        {
            SwitchBotApi switchBotApi = new SwitchBotApi(_config.Value.SwitchBotUrl, _config.Value.Secret, _config.Value.Token);
            var devices = await switchBotApi.GetDevices();
            var curtiansSwitchBotDevices = devices.Where(x => x.Type == "Curtain");

            foreach ( var device in curtiansSwitchBotDevices )
            {
                string name = device.Name;
                var deviceId = "cover."+ name.Replace(" ","_").ToLower();
                _curtains[deviceId] = device.Id;

                _logger.LogInformation($"Creating curtain device {deviceId}:{device.Id}");
                await _entityManager.CreateAsync(deviceId, new EntityCreationOptions()
                {
                    DeviceClass = DEVICE_CLASS_CURTAIN,
                    Name = name,
                    UniqueId=$"SwitchBot_{device.Id}",
                    Persist = true
                });

                _ha.Entity(deviceId)
                .StateAllChanges()
                .Subscribe(x =>
                {
                    _logger.LogInformation($"State {deviceId} =  {x?.Old?.State} , {x?.New?.State} ");
                });

            }


            _ha.Events.SubscribeAsync(async x =>
            {
                if (x.EventType == "call_service")
                {
                    _logger.LogInformation($"{x}");
                    var dataElement = System.Text.Json.JsonSerializer.Deserialize<EventData>(x.DataElement.ToString());
                    if (_curtains.TryGetValue(dataElement.ServiceData.EntityId, out var switchBotId))
                    {
                        _logger.LogInformation("Curtain found " + switchBotId);
                        string command = "";
                        if (dataElement.Service == "open_cover")
                        {
                            command = "turnOn";
                        }
                        if (dataElement.Service == "close_cover")
                        {
                            command = "turnOff";
                        }
                        if (dataElement.Service == "stop_cover")
                        {
                            command = "pause";
                        }
                        if (command =="")
                        {
                            _logger.LogInformation($"{dataElement.Service} not supported for {x}");
                            return;
                        }

                        await switchBotApi.SendCommand(switchBotId, command);
                    }
                }

            });

      
        }
    }
}
