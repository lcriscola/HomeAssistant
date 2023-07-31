using Microsoft.Extensions.ObjectPool;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemon3Apps.AdjustEcobeeClimateBasedOnPresence
{
    public class AdjustEcobeeClimateBasedOnPresenceConfig
    {
        public AdjustEcobeeClimateBasedOnPresenceConfig_Person[] People { get; set; }
        public string ForceHomeEntityId { get; set; }
        public string EcobeeApiKey { get; set; }

        public string[] NightModeIgnoreSensors { get; set; }
        public string[] DayModeIgnoreSensors { get; set; }
    }

    public class AdjustEcobeeClimateBasedOnPresenceConfig_Person
    {
        public string EntityId { get; set; }
        public string[] ActivateSensors { get; set; }
    }
}
