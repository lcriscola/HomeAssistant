using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EcobeeTest
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Capability
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("value")]
        public string value { get; set; }
    }

    public class Climate
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("climateRef")]
        public string climateRef { get; set; }

        [JsonPropertyName("isOccupied")]
        public bool isOccupied { get; set; }

        [JsonPropertyName("isOptimized")]
        public bool isOptimized { get; set; }

        [JsonPropertyName("coolFan")]
        public string coolFan { get; set; }

        [JsonPropertyName("heatFan")]
        public string heatFan { get; set; }

        [JsonPropertyName("vent")]
        public string vent { get; set; }

        [JsonPropertyName("ventilatorMinOnTime")]
        public int ventilatorMinOnTime { get; set; }

        [JsonPropertyName("owner")]
        public string owner { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("colour")]
        public int colour { get; set; }

        [JsonPropertyName("coolTemp")]
        public int coolTemp { get; set; }

        [JsonPropertyName("heatTemp")]
        public int heatTemp { get; set; }

        [JsonPropertyName("sensors")]
        public List<Sensor> sensors { get; set; }
    }

    public class Page
    {
        [JsonPropertyName("page")]
        public int page { get; set; }

        [JsonPropertyName("totalPages")]
        public int totalPages { get; set; }

        [JsonPropertyName("pageSize")]
        public int pageSize { get; set; }

        [JsonPropertyName("total")]
        public int total { get; set; }
    }

    public class Program
    {
        [JsonPropertyName("schedule")]
        public List<List<string>> schedule { get; set; }

        [JsonPropertyName("climates")]
        public List<Climate> climates { get; set; }

        [JsonPropertyName("currentClimateRef")]
        public string currentClimateRef { get; set; }
    }

    public class RemoteSensor
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("code")]
        public string code { get; set; }

        [JsonPropertyName("inUse")]
        public bool inUse { get; set; }

        [JsonPropertyName("capability")]
        public List<Capability> capability { get; set; }
    }

    public class Thermostat
    {
        [JsonPropertyName("page")]
        public Page page { get; set; }

        [JsonPropertyName("thermostatList")]
        public List<ThermostatList> thermostatList { get; set; }

        [JsonPropertyName("status")]
        public Status status { get; set; }
    }

    public class Runtime
    {
        [JsonPropertyName("runtimeRev")]
        public string runtimeRev { get; set; }

        [JsonPropertyName("connected")]
        public bool connected { get; set; }

        [JsonPropertyName("firstConnected")]
        public string firstConnected { get; set; }

        [JsonPropertyName("connectDateTime")]
        public string connectDateTime { get; set; }

        [JsonPropertyName("disconnectDateTime")]
        public string disconnectDateTime { get; set; }

        [JsonPropertyName("lastModified")]
        public string lastModified { get; set; }

        [JsonPropertyName("lastStatusModified")]
        public string lastStatusModified { get; set; }

        [JsonPropertyName("runtimeDate")]
        public string runtimeDate { get; set; }

        [JsonPropertyName("runtimeInterval")]
        public int runtimeInterval { get; set; }

        [JsonPropertyName("actualTemperature")]
        public int actualTemperature { get; set; }

        [JsonPropertyName("actualHumidity")]
        public int actualHumidity { get; set; }

        [JsonPropertyName("rawTemperature")]
        public int rawTemperature { get; set; }

        [JsonPropertyName("showIconMode")]
        public int showIconMode { get; set; }

        [JsonPropertyName("desiredHeat")]
        public int desiredHeat { get; set; }

        [JsonPropertyName("desiredCool")]
        public int desiredCool { get; set; }

        [JsonPropertyName("desiredHumidity")]
        public int desiredHumidity { get; set; }

        [JsonPropertyName("desiredDehumidity")]
        public int desiredDehumidity { get; set; }

        [JsonPropertyName("desiredFanMode")]
        public string desiredFanMode { get; set; }

        [JsonPropertyName("actualVOC")]
        public int actualVOC { get; set; }

        [JsonPropertyName("actualCO2")]
        public int actualCO2 { get; set; }

        [JsonPropertyName("actualAQAccuracy")]
        public int actualAQAccuracy { get; set; }

        [JsonPropertyName("actualAQScore")]
        public int actualAQScore { get; set; }

        [JsonPropertyName("desiredHeatRange")]
        public List<int> desiredHeatRange { get; set; }

        [JsonPropertyName("desiredCoolRange")]
        public List<int> desiredCoolRange { get; set; }
    }

    public class Sensor
    {
        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }
    }

    public class Settings
    {
        [JsonPropertyName("hvacMode")]
        public string hvacMode { get; set; }

        [JsonPropertyName("lastServiceDate")]
        public string lastServiceDate { get; set; }

        [JsonPropertyName("serviceRemindMe")]
        public bool serviceRemindMe { get; set; }

        [JsonPropertyName("monthsBetweenService")]
        public int monthsBetweenService { get; set; }

        [JsonPropertyName("remindMeDate")]
        public string remindMeDate { get; set; }

        [JsonPropertyName("vent")]
        public string vent { get; set; }

        [JsonPropertyName("ventilatorMinOnTime")]
        public int ventilatorMinOnTime { get; set; }

        [JsonPropertyName("serviceRemindTechnician")]
        public bool serviceRemindTechnician { get; set; }

        [JsonPropertyName("eiLocation")]
        public string eiLocation { get; set; }

        [JsonPropertyName("coldTempAlert")]
        public int coldTempAlert { get; set; }

        [JsonPropertyName("coldTempAlertEnabled")]
        public bool coldTempAlertEnabled { get; set; }

        [JsonPropertyName("hotTempAlert")]
        public int hotTempAlert { get; set; }

        [JsonPropertyName("hotTempAlertEnabled")]
        public bool hotTempAlertEnabled { get; set; }

        [JsonPropertyName("coolStages")]
        public int coolStages { get; set; }

        [JsonPropertyName("heatStages")]
        public int heatStages { get; set; }

        [JsonPropertyName("maxSetBack")]
        public int maxSetBack { get; set; }

        [JsonPropertyName("maxSetForward")]
        public int maxSetForward { get; set; }

        [JsonPropertyName("quickSaveSetBack")]
        public int quickSaveSetBack { get; set; }

        [JsonPropertyName("quickSaveSetForward")]
        public int quickSaveSetForward { get; set; }

        [JsonPropertyName("hasHeatPump")]
        public bool hasHeatPump { get; set; }

        [JsonPropertyName("hasForcedAir")]
        public bool hasForcedAir { get; set; }

        [JsonPropertyName("hasBoiler")]
        public bool hasBoiler { get; set; }

        [JsonPropertyName("hasHumidifier")]
        public bool hasHumidifier { get; set; }

        [JsonPropertyName("hasErv")]
        public bool hasErv { get; set; }

        [JsonPropertyName("hasHrv")]
        public bool hasHrv { get; set; }

        [JsonPropertyName("condensationAvoid")]
        public bool condensationAvoid { get; set; }

        [JsonPropertyName("useCelsius")]
        public bool useCelsius { get; set; }

        [JsonPropertyName("useTimeFormat12")]
        public bool useTimeFormat12 { get; set; }

        [JsonPropertyName("locale")]
        public string locale { get; set; }

        [JsonPropertyName("humidity")]
        public string humidity { get; set; }

        [JsonPropertyName("humidifierMode")]
        public string humidifierMode { get; set; }

        [JsonPropertyName("backlightOnIntensity")]
        public int backlightOnIntensity { get; set; }

        [JsonPropertyName("backlightSleepIntensity")]
        public int backlightSleepIntensity { get; set; }

        [JsonPropertyName("backlightOffTime")]
        public int backlightOffTime { get; set; }

        [JsonPropertyName("soundTickVolume")]
        public int soundTickVolume { get; set; }

        [JsonPropertyName("soundAlertVolume")]
        public int soundAlertVolume { get; set; }

        [JsonPropertyName("compressorProtectionMinTime")]
        public int compressorProtectionMinTime { get; set; }

        [JsonPropertyName("compressorProtectionMinTemp")]
        public int compressorProtectionMinTemp { get; set; }

        [JsonPropertyName("stage1HeatingDifferentialTemp")]
        public int stage1HeatingDifferentialTemp { get; set; }

        [JsonPropertyName("stage1CoolingDifferentialTemp")]
        public int stage1CoolingDifferentialTemp { get; set; }

        [JsonPropertyName("stage1HeatingDissipationTime")]
        public int stage1HeatingDissipationTime { get; set; }

        [JsonPropertyName("stage1CoolingDissipationTime")]
        public int stage1CoolingDissipationTime { get; set; }

        [JsonPropertyName("heatPumpReversalOnCool")]
        public bool heatPumpReversalOnCool { get; set; }

        [JsonPropertyName("fanControlRequired")]
        public bool fanControlRequired { get; set; }

        [JsonPropertyName("fanMinOnTime")]
        public int fanMinOnTime { get; set; }

        [JsonPropertyName("heatCoolMinDelta")]
        public int heatCoolMinDelta { get; set; }

        [JsonPropertyName("tempCorrection")]
        public int tempCorrection { get; set; }

        [JsonPropertyName("holdAction")]
        public string holdAction { get; set; }

        [JsonPropertyName("heatPumpGroundWater")]
        public bool heatPumpGroundWater { get; set; }

        [JsonPropertyName("hasElectric")]
        public bool hasElectric { get; set; }

        [JsonPropertyName("hasDehumidifier")]
        public bool hasDehumidifier { get; set; }

        [JsonPropertyName("dehumidifierMode")]
        public string dehumidifierMode { get; set; }

        [JsonPropertyName("dehumidifierLevel")]
        public int dehumidifierLevel { get; set; }

        [JsonPropertyName("dehumidifyWithAC")]
        public bool dehumidifyWithAC { get; set; }

        [JsonPropertyName("dehumidifyOvercoolOffset")]
        public int dehumidifyOvercoolOffset { get; set; }

        [JsonPropertyName("autoHeatCoolFeatureEnabled")]
        public bool autoHeatCoolFeatureEnabled { get; set; }

        [JsonPropertyName("wifiOfflineAlert")]
        public bool wifiOfflineAlert { get; set; }

        [JsonPropertyName("heatMinTemp")]
        public int heatMinTemp { get; set; }

        [JsonPropertyName("heatMaxTemp")]
        public int heatMaxTemp { get; set; }

        [JsonPropertyName("coolMinTemp")]
        public int coolMinTemp { get; set; }

        [JsonPropertyName("coolMaxTemp")]
        public int coolMaxTemp { get; set; }

        [JsonPropertyName("heatRangeHigh")]
        public int heatRangeHigh { get; set; }

        [JsonPropertyName("heatRangeLow")]
        public int heatRangeLow { get; set; }

        [JsonPropertyName("coolRangeHigh")]
        public int coolRangeHigh { get; set; }

        [JsonPropertyName("coolRangeLow")]
        public int coolRangeLow { get; set; }

        [JsonPropertyName("userAccessCode")]
        public string userAccessCode { get; set; }

        [JsonPropertyName("userAccessSetting")]
        public int userAccessSetting { get; set; }

        [JsonPropertyName("auxRuntimeAlert")]
        public int auxRuntimeAlert { get; set; }

        [JsonPropertyName("auxOutdoorTempAlert")]
        public int auxOutdoorTempAlert { get; set; }

        [JsonPropertyName("auxMaxOutdoorTemp")]
        public int auxMaxOutdoorTemp { get; set; }

        [JsonPropertyName("auxRuntimeAlertNotify")]
        public bool auxRuntimeAlertNotify { get; set; }

        [JsonPropertyName("auxOutdoorTempAlertNotify")]
        public bool auxOutdoorTempAlertNotify { get; set; }

        [JsonPropertyName("auxRuntimeAlertNotifyTechnician")]
        public bool auxRuntimeAlertNotifyTechnician { get; set; }

        [JsonPropertyName("auxOutdoorTempAlertNotifyTechnician")]
        public bool auxOutdoorTempAlertNotifyTechnician { get; set; }

        [JsonPropertyName("disablePreHeating")]
        public bool disablePreHeating { get; set; }

        [JsonPropertyName("disablePreCooling")]
        public bool disablePreCooling { get; set; }

        [JsonPropertyName("installerCodeRequired")]
        public bool installerCodeRequired { get; set; }

        [JsonPropertyName("drAccept")]
        public string drAccept { get; set; }

        [JsonPropertyName("isRentalProperty")]
        public bool isRentalProperty { get; set; }

        [JsonPropertyName("useZoneController")]
        public bool useZoneController { get; set; }

        [JsonPropertyName("randomStartDelayCool")]
        public int randomStartDelayCool { get; set; }

        [JsonPropertyName("randomStartDelayHeat")]
        public int randomStartDelayHeat { get; set; }

        [JsonPropertyName("humidityHighAlert")]
        public int humidityHighAlert { get; set; }

        [JsonPropertyName("humidityLowAlert")]
        public int humidityLowAlert { get; set; }

        [JsonPropertyName("disableHeatPumpAlerts")]
        public bool disableHeatPumpAlerts { get; set; }

        [JsonPropertyName("disableAlertsOnIdt")]
        public bool disableAlertsOnIdt { get; set; }

        [JsonPropertyName("humidityAlertNotify")]
        public bool humidityAlertNotify { get; set; }

        [JsonPropertyName("humidityAlertNotifyTechnician")]
        public bool humidityAlertNotifyTechnician { get; set; }

        [JsonPropertyName("tempAlertNotify")]
        public bool tempAlertNotify { get; set; }

        [JsonPropertyName("tempAlertNotifyTechnician")]
        public bool tempAlertNotifyTechnician { get; set; }

        [JsonPropertyName("monthlyElectricityBillLimit")]
        public int monthlyElectricityBillLimit { get; set; }

        [JsonPropertyName("enableElectricityBillAlert")]
        public bool enableElectricityBillAlert { get; set; }

        [JsonPropertyName("enableProjectedElectricityBillAlert")]
        public bool enableProjectedElectricityBillAlert { get; set; }

        [JsonPropertyName("electricityBillingDayOfMonth")]
        public int electricityBillingDayOfMonth { get; set; }

        [JsonPropertyName("electricityBillCycleMonths")]
        public int electricityBillCycleMonths { get; set; }

        [JsonPropertyName("electricityBillStartMonth")]
        public int electricityBillStartMonth { get; set; }

        [JsonPropertyName("ventilatorMinOnTimeHome")]
        public int ventilatorMinOnTimeHome { get; set; }

        [JsonPropertyName("ventilatorMinOnTimeAway")]
        public int ventilatorMinOnTimeAway { get; set; }

        [JsonPropertyName("backlightOffDuringSleep")]
        public bool backlightOffDuringSleep { get; set; }

        [JsonPropertyName("autoAway")]
        public bool autoAway { get; set; }

        [JsonPropertyName("smartCirculation")]
        public bool smartCirculation { get; set; }

        [JsonPropertyName("followMeComfort")]
        public bool followMeComfort { get; set; }

        [JsonPropertyName("ventilatorType")]
        public string ventilatorType { get; set; }

        [JsonPropertyName("isVentilatorTimerOn")]
        public bool isVentilatorTimerOn { get; set; }

        [JsonPropertyName("ventilatorOffDateTime")]
        public string ventilatorOffDateTime { get; set; }

        [JsonPropertyName("hasUVFilter")]
        public bool hasUVFilter { get; set; }

        [JsonPropertyName("coolingLockout")]
        public bool coolingLockout { get; set; }

        [JsonPropertyName("ventilatorFreeCooling")]
        public bool ventilatorFreeCooling { get; set; }

        [JsonPropertyName("dehumidifyWhenHeating")]
        public bool dehumidifyWhenHeating { get; set; }

        [JsonPropertyName("ventilatorDehumidify")]
        public bool ventilatorDehumidify { get; set; }

        [JsonPropertyName("groupRef")]
        public string groupRef { get; set; }

        [JsonPropertyName("groupName")]
        public string groupName { get; set; }

        [JsonPropertyName("groupSetting")]
        public int groupSetting { get; set; }

        [JsonPropertyName("fanSpeed")]
        public string fanSpeed { get; set; }

        [JsonPropertyName("displayAirQuality")]
        public bool displayAirQuality { get; set; }
    }

    public class Status
    {
        [JsonPropertyName("code")]
        public int code { get; set; }

        [JsonPropertyName("message")]
        public string message { get; set; }
    }

    public class ThermostatList
    {
        [JsonPropertyName("identifier")]
        public string identifier { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("thermostatRev")]
        public string thermostatRev { get; set; }

        [JsonPropertyName("isRegistered")]
        public bool isRegistered { get; set; }

        [JsonPropertyName("modelNumber")]
        public string modelNumber { get; set; }

        [JsonPropertyName("brand")]
        public string brand { get; set; }

        [JsonPropertyName("features")]
        public string features { get; set; }

        [JsonPropertyName("lastModified")]
        public string lastModified { get; set; }

        [JsonPropertyName("thermostatTime")]
        public string thermostatTime { get; set; }

        [JsonPropertyName("utcTime")]
        public string utcTime { get; set; }

        [JsonPropertyName("alerts")]
        public List<object> alerts { get; set; }

        [JsonPropertyName("settings")]
        public Settings settings { get; set; }

        [JsonPropertyName("runtime")]
        public Runtime runtime { get; set; }

        [JsonPropertyName("events")]
        public List<object> events { get; set; }

        [JsonPropertyName("program")]
        public Program program { get; set; }

        [JsonPropertyName("remoteSensors")]
        public List<RemoteSensor> remoteSensors { get; set; }
    }


}
