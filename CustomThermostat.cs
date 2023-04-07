using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using NetDaemon.AppModel;
using NetDaemon.HassModel;


namespace NetDaemon3Apps
{


    [NetDaemonApp]
    public class CustomThermostat : IAsyncInitializable
    {
        private readonly ILogger<CustomThermostat> _logger;
        private readonly IAppConfig<CustomThermostatConfig> _config;

        public CustomThermostat(IHaContext ha, ILogger<CustomThermostat> logger, IAppConfig<CustomThermostatConfig> config)
        {
            _logger = logger;
            _config = config;
            _logger.Log(LogLevel.Information, $"{nameof(CustomThermostat)} started.");


            _logger.Log(LogLevel.Information, $"Subscribing  to {_config.Value.SensorId}");

            ha.Entity(_config.Value.SensorId)
                .StateChanges()
                .Subscribe(x =>
                {
                    var temp = Convert.ToDecimal(x.New.State);
                    _logger.Log(LogLevel.Information, $"{_config.Value.SensorId} = {temp} .");
                });


            _logger.Log(LogLevel.Information, $"Subscribing  to  {_config.Value.ThermostatId}.");
            var action = "";
            var setTemperature = 0.0;

            ha.Entity(_config.Value.ThermostatId)
                .StateAllChanges()
                .Subscribe(x =>
                {
                    try
                    {
                        eventCounter++;
                        action = x.New.State;

                        _logger.Log(LogLevel.Information, $"{_config.Value.ThermostatId} {x.New.State}");
                        var dict = x.New?.Attributes as Dictionary<string, object>;

                        if (dict != null)
                        {
                            JsonElement json;
                            object obj;
                            if (dict.TryGetValue("temperature", out obj))
                            {
                                if (obj != null)
                                {
                                    json = (JsonElement)obj;
                                    if (!String.IsNullOrEmpty(json.GetRawText()))
                                        setTemperature = json.GetInt32();
                                }

                            }


                            _logger.Log(LogLevel.Information, $"{_config.Value.ThermostatId} {action} temperature = {setTemperature}");



                            //if (dict != null)
                            //{
                            //    foreach (var item in dict)
                            //    {

                            //    _logger.Log(LogLevel.Information, $"{_config.Value.ThermostatId} {item.Key} = {item.Value}");
                            //    }
                            //}
                        }

                    }
                    catch (Exception ex)
                    {
                        _logger.Log(LogLevel.Error, $"Error: {ex.ToString()}");
                    }

                });
        }
        int eventCounter = 0;

        void DumpObject(object obj)
        {
            if (obj == null)
                _logger.LogInformation($"#{eventCounter} -- NULL --");


            _logger.LogInformation($"#{eventCounter} -- {obj} {obj.GetType().Name} --");

            var props = obj.GetType().GetProperties();
            foreach (var p in props)
            {
                _logger.LogInformation($"#{eventCounter} {p.Name}");
            }
        }

        public Task InitializeAsync(CancellationToken cancellationToken)
        {
            _logger.Log(LogLevel.Information, $"ac = {_config.Value.ThermostatId}");

            return Task.CompletedTask;
        }
    }
}
