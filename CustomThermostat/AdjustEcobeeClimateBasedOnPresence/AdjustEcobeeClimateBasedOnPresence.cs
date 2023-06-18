using NetDaemon.Extensions.Scheduler;

using System.Collections;
using System.Linq;
using System.Reactive.Concurrency;
using System.Threading;
using System.Threading.Tasks;

namespace NetDaemon3Apps.AdjustEcobeeClimateBasedOnPresence
{
    [NetDaemonApp]
    public class AdjustEcobeeClimateBasedOnPresence : IAsyncInitializable
    {
        private readonly IHaContext _ha;
        private readonly ILogger<AdjustEcobeeClimateBasedOnPresence> _logger;
        private readonly IScheduler _scheduler;
        private readonly AdjustEcobeeClimateBasedOnPresenceConfig _config;

        public AdjustEcobeeClimateBasedOnPresence(IHaContext ha, ILogger<AdjustEcobeeClimateBasedOnPresence> logger, IAppConfig<AdjustEcobeeClimateBasedOnPresenceConfig> config, IScheduler scheduler)
        {
            _ha = ha;
            _logger = logger;
            _scheduler = scheduler;
            _config = config.Value;
            

        }

        string SettingsFile = "/data/settings.json";
        private EcobeeManager _ecobee;

        public async Task InitializeAsync(CancellationToken cancellationToken)
        {

            _ecobee = new EcobeeManager(this._ha, _logger, _config.EcobeeApiKey);
            await _ecobee.Authenticate();

            _scheduler.Schedule(TimeSpan.FromSeconds(5), async () => await this.ProcessChanges());
            _scheduler.ScheduleCron("*/5  * * * *", async () => await this.ProcessChanges());

            

            foreach (var person in _config.People)
            {

                _ha.Entity(person.EntityId).StateChanges().SubscribeAsync(async x =>
                {
                    _logger.LogInformation($"{person.EntityId} changed from {x.Old?.State} to {x.New?.State}");
                    await ProcessChanges();
                });

            }

        }

        private async Task ProcessChanges()
        {
            _logger.LogInformation($"PROCESS STARTED");
            await _ecobee.Authenticate();
            var t = await _ecobee.GetThermostat();
            var nightMode = t.program.currentClimateRef.ToUpper() == "SLEEP" || t.program.currentClimateRef.ToUpper() == "SLEEPING";
            _ecobee.ClearAllSensors(t);
            System.Collections.Generic.IEnumerable<Climate> climates = t.program.climates.Where(x => x.name.ToUpper() != "AWAY");
        
            _logger.LogInformation($"Thermostat Climate: {t.program.currentClimateRef}");

            foreach (var person in _config.People)
            {
                var entity = _ha.Entity(person.EntityId);
                _logger.LogInformation($"{person.EntityId} is {entity.EntityState?.State}");
                if (entity.EntityState?.State.ToUpper() == "HOME")
                {
                    System.Collections.Generic.IEnumerable<string> sensors = person.ActivateSensors;
                    if (nightMode)
                        sensors = sensors.Where(x => !_config.NightModeIgnoreSensors.Contains(x));
                    else
                        sensors = sensors.Where(x => !_config.DayModeIgnoreSensors.Contains(x));

                    foreach (string sensor in sensors)
                    {
                        _logger.LogInformation($"  - Sensor {sensor} for Climates:{String.Join(",", climates.Select(x=> x.name))}");
                        _ecobee.UpdateSensor(t, sensor, climates.Select(x=>x.name).ToArray());

                    }
                }
            }
            await _ecobee.SendUpdates(t);

            var allSensors = t.program.climates.SelectMany(x => x.sensors);
            if (allSensors.Count() == 0)
            {
                _logger.LogInformation($"Setting Climate to AWAY");
                await _ecobee.SetPreset("away");
            }
            else
            {
                if (t.events.LastOrDefault()?.holdClimateRef.ToUpper() == "AWAY")
                {
                    _logger.LogInformation($"Setting Climate to RESUME");
                    await _ecobee.ClearPreset();
                }
            }

            _logger.LogInformation($"PROCESS COMPLETED");

        }
    }
}
