using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetDaemon3Apps
{
    public class SetCurrentThermostatConfig
    {
        public int IntervalCheck { get; set; }
        public SetCurrentThermostatConfig_Sensor[] TempSensors { get; set; }
        public SetCurrentThermostatConfig_Period[] Periods { get; set; }
        public string FallbackSensor { get; set; }

        public string GetText()
        {
            var text = System.Text.Json.JsonSerializer.Serialize(this, new JsonSerializerOptions() { WriteIndented = true });
            return text;
        }
    }

    public class SetCurrentThermostatConfig_Period
    {
        public string Name { get; set; }
        public string Interval { get; set; }
    }
    public class SetCurrentThermostatConfig_Sensor
    {
        public string SensorId { get; set; }
        public string Alias { get; set; }
        public string Period { get; set; }
        public string[] Presence_Entities { get; set; } = { };

    }
}
