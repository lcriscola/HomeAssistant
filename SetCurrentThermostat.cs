using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using NetDaemon.AppModel;
using NetDaemon.HassModel;

using NetDaemon.Extensions.MqttEntityManager;
using NetDaemon.Extensions.MqttEntityManager.Models;
using NetDaemon.HassModel.Entities;
using System.Timers;
using System.Linq;

namespace NetDaemon3Apps
{


    [NetDaemonApp]
    public class SetCurrentThermostat : IAsyncInitializable
    {
        private readonly IHaContext _ha;
        private readonly ILogger<SetCurrentThermostat> _logger;
        private readonly IAppConfig<SetCurrentThermostatConfig> _config;
        private readonly IMqttEntityManager _entityManager;
        Timer timer = new Timer();

        public SetCurrentThermostat(IHaContext ha, ILogger<SetCurrentThermostat> logger, IAppConfig<SetCurrentThermostatConfig> config, IMqttEntityManager entityManager)
        {
            _ha = ha;
            _logger = logger;
            _config = config;
            _entityManager = entityManager;
            _logger.Log(LogLevel.Information, $"{nameof(SetCurrentThermostat)} started.");

            timer.Interval = _config.Value.IntervalCheck * 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();


            //foreach (var sensor in _config.Value.TempSensors)
            //{
            //    _logger.Log(LogLevel.Information, $"Subscribing  to  {sensor.Alias} {sensor.SensorId}");

            //    ha.Entity(sensor.SensorId)
            //        .StateChanges()
            //        .Subscribe(async x =>
            //        {
            //            eventCounter++;
            //            var temp = Convert.ToDecimal(x.New.State);
            //            temperatures[sensor.SensorId]= temp;


            //            await SetState(temp, sensor.Alias, sensor.SensorId);

            //            _logger.Log(LogLevel.Information, $"#{eventCounter} {sensor.Alias} = {temp} .");
            //        });

            //}


        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {

            try
            {
                timer.Stop();
                var sensors = GetEnabledSensors();
                Dictionary<SetCurrentThermostatConfig_Sensor, Decimal> temperatures = new Dictionary<SetCurrentThermostatConfig_Sensor, decimal>();
                foreach (var sensor in sensors)
                {
                    try
                    {
                        var haSensor = _ha.Entity(sensor.SensorId);
                        //  DumpObject(haSensor);
                        if (!String.IsNullOrEmpty(haSensor.State))
                        {
                            var temp = Convert.ToDecimal(haSensor.State);
                            temperatures[sensor] = temp;
                        }

                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(ex, $"Error while reading {sensor.Alias}");
                    }
                }

                if (temperatures.Count == 0)
                {
                    var fallBackSensor = _config.Value.TempSensors.FirstOrDefault(x => x.Alias == _config.Value.FallbackSensor);

                    var haSensor = _ha.Entity(fallBackSensor.SensorId);
                    temperatures[fallBackSensor] = Convert.ToDecimal(haSensor.State);
                }
                var average = temperatures.Average(x => x.Value);
                var min = temperatures.Min(x => x.Value);
                var max = temperatures.Max(x => x.Value);

                var dic = new Dictionary<string, object>();
                dic["measuredOn"] = DateTime.Now;
                dic["sensorAlias"] = String.Join(",", temperatures.Keys.Select(x => x.Alias));
                dic["sensorId"] = String.Join(",", temperatures.Keys.Select(x => x.SensorId));
                dic["max"] = max.ToString("N2");
                dic["min"] = min.ToString("N2");
                _entityManager.SetAttributesAsync(SensorId, dic).Wait();
                _entityManager.SetStateAsync(SensorId, average.ToString("N2")).Wait();

                _logger.LogInformation($"Setting Temperature to {average.ToString("N2")} from { dic["sensorAlias"]}");


            }
            finally
            {
                timer.Start();

            }
        }

        private SetCurrentThermostatConfig_Sensor[] GetEnabledSensors()
        {

            List<SetCurrentThermostatConfig_Sensor> ret = new List<SetCurrentThermostatConfig_Sensor>();

            foreach (var sensor in _config.Value.TempSensors.Where(x => x.Alias != _config.Value.FallbackSensor))
            {
                if (String.IsNullOrWhiteSpace(sensor.Period))
                {
                    ret.Add(sensor);
                    continue;
                }

                var p = _config.Value.Periods.FirstOrDefault(x => x.Name == sensor.Period);
                if (p == null)
                {
                    _logger.LogWarning($"Perido {sensor.Period} not found");
                    ret.Add(sensor);
                    continue;
                }

                var interval = p.Interval.Split('-');

                var from = interval[0];
                var to = interval[1];

                if (IsInPeriod(DateTime.Now, from, to))
                {
                    ret.Add(sensor);
                }

            }


            return ret.ToArray();
        }


        public static bool IsInPeriod(DateTime date, string from, string to)
        {
            date = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);

            var parts = from.Split(':');
            var fromDate = new DateTime(date.Year, date.Month, date.Day, int.Parse(parts[0]), int.Parse(parts[1]), 0);

            parts = to.Split(':');
            var toDate = new DateTime(date.Year, date.Month, date.Day, int.Parse(parts[0]), int.Parse(parts[1]), 0);


            double delta = 0;
            if (fromDate <= toDate)
                return date >= fromDate && date <= toDate;

            var endOfToDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 0, 0, 0);

            delta = (toDate - endOfToDate).TotalSeconds + 1;

            fromDate = fromDate.AddSeconds(-delta);
            fromDate = new DateTime(1, 1, 1, fromDate.Hour, fromDate.Minute, fromDate.Second);

            toDate = toDate.AddSeconds(-delta).AddDays(1);
            toDate = new DateTime(1, 1, 1, toDate.Hour, toDate.Minute, toDate.Second);

            var newDate = date.AddSeconds(-delta);
            newDate = new DateTime(1, 1, 1, newDate.Hour, newDate.Minute, newDate.Second);

            return newDate >= fromDate && newDate <= toDate;

        }
        int eventCounter = 0;
        Dictionary<string, decimal> temperatures = new Dictionary<string, decimal>();

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

        const string SensorId = "sensor.temperature_sensor_current";

        public async Task InitializeAsync(System.Threading.CancellationToken cancellationToken)
        {

            await _entityManager.CreateAsync(SensorId, new EntityCreationOptions()
            {
                DeviceClass = DEVICE_CLASS_TEMPERATURE,
                Name = "Temperature Sensor Current",
                Persist = true
            });



            LogConfig(_config);
            return;
        }

        private void LogConfig(IAppConfig<SetCurrentThermostatConfig> config)
        {
            _logger.LogInformation("Configuration:" + config.Value.GetText());
        }

       
        const string DEVICE_CLASS_TEMPERATURE = "temperature";
    }
}
