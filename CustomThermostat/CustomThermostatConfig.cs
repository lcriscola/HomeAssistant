using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemon3Apps
{
    public class CustomThermostatConfig
    {
        public string? ThermostatId { get; set; }
        public string SensorId { get; set; }
        public int CoolMinTemp { get; set; }
        public int HeatMaxTemp { get; set; }
        public string ThermostatTemperatureId { get; set; }
    }

   
}
