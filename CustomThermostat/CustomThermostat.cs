using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

using HomeAssistantGenerated;

using Microsoft.Extensions.Logging;

using NetDaemon.AppModel;
using NetDaemon.Client;
using NetDaemon.HassModel;


namespace NetDaemon3Apps
{


    [NetDaemonApp]
    public class CustomThermostat : IAsyncInitializable
    {
        private readonly IHomeAssistantApiManager _apiManager;
        private readonly IHaContext _ha;
        private readonly ILogger<CustomThermostat> _logger;
        private readonly IAppConfig<CustomThermostatConfig> _config;
        private readonly Entities _entities;
        private readonly ClimateEntity _climateController;

        public CustomThermostat(IHomeAssistantApiManager apiManager, IHaContext ha, ILogger<CustomThermostat> logger, IAppConfig<CustomThermostatConfig> config)
        {
            _apiManager = apiManager;
            _ha = ha;
            _logger = logger;
            _config = config;
            _logger.Log(LogLevel.Information, $"{nameof(CustomThermostat)} started.");
            _entities = new Entities(_ha);

            var activeThermostat = new SensorEntity(ha.Entity(_config.Value.SensorId));
            _logger.Log(LogLevel.Information, $"Subscribing  to  {_config.Value.SensorId} state changes.");

            activeThermostat
                .StateChanges()
                .Subscribe(x =>
                {
                    var temp = Convert.ToDecimal(x.New.State);
                    SensorTemperatureChanged(temp);
                });



            _climateController = new ClimateEntity(ha.Entity(_config.Value.ThermostatId));

            _logger.Log(LogLevel.Information, $"Subscribing  to  {_config.Value.ThermostatId} state changes.");
            _climateController
                .StateAllChanges()
                .Subscribe(x =>
                {
                    try
                    {
                        eventCounter++;
                        var action = x.New.State;
                        var attributes = x.New?.Attributes;

                        if (attributes.Temperature != null || !String.IsNullOrEmpty(action))
                        {
                            var temp = attributes.Temperature ?? 0;
                            _lastState = action;
                            _logger.LogInformation($"Target Temperature Changed {temp} {action}");
                            
                            
                            //Thread.Sleep(5000);
                            //_climateController.SetTemperature(temp);

                            //TargetTemperatureChanged(temp, action);
                        }



                    }
                    catch (Exception ex)
                    {
                        _logger.Log(LogLevel.Error, $"Error: {ex.ToString()}");
                    }

                });
        }

        private void SensorTemperatureChanged(decimal temp)
        {
            _logger.LogInformation($"New Temperature detected " + temp);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="mode">off cool heat</param>
        private void TargetTemperatureChanged(double temp, string mode)
        {
            //_logger.LogInformation($"Target Temperature Changed {temp} {mode}");

            //var delta = 0;
            //if (_lastState == "cool")
            //    delta = -3;
            //else if (_lastState == "heat")
            //    delta = 3;
            //else return;

            //_climateController.SetTemperature(temp);
            //TurnOnAc(temp);

        }

        private string _lastState = "off";
        private void TurnOnAc(double temp)
        {
            if (temp <= 0)
                return;


            _logger.LogInformation($"Setting AC to {temp} {_lastState}");
            // _climateController.SetTemperature(temp);

        }

        private void TurnOnHeat()
        {

        }



        private void TurnOff()
        {
            _climateController.TurnOff();
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


            // TurnOff();
            //_entities.Climate.Ac.SetTemperature(78);
            _logger.Log(LogLevel.Information, $"InitializeAsync completed");


            return Task.CompletedTask;
        }
    }
}
