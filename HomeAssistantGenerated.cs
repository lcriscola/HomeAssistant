using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using System.Text.Json.Serialization;

namespace HomeAssistantGenerated
{
	public interface IEntities
	{
		AlarmControlPanelEntities AlarmControlPanel { get; }

		AutomationEntities Automation { get; }

		BinarySensorEntities BinarySensor { get; }

		ButtonEntities Button { get; }

		CameraEntities Camera { get; }

		ClimateEntities Climate { get; }

		CoverEntities Cover { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		FanEntities Fan { get; }

		InputBooleanEntities InputBoolean { get; }

		InputDatetimeEntities InputDatetime { get; }

		InputNumberEntities InputNumber { get; }

		InputTextEntities InputText { get; }

		LightEntities Light { get; }

		LockEntities Lock { get; }

		MediaPlayerEntities MediaPlayer { get; }

		PersonEntities Person { get; }

		RemoteEntities Remote { get; }

		SceneEntities Scene { get; }

		ScriptEntities Script { get; }

		SelectEntities Select { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		TimerEntities Timer { get; }

		VacuumEntities Vacuum { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public class Entities : IEntities
	{
		private readonly IHaContext _haContext;
		public Entities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelEntities AlarmControlPanel => new(_haContext);
		public AutomationEntities Automation => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public ButtonEntities Button => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public CoverEntities Cover => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public FanEntities Fan => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputDatetimeEntities InputDatetime => new(_haContext);
		public InputNumberEntities InputNumber => new(_haContext);
		public InputTextEntities InputText => new(_haContext);
		public LightEntities Light => new(_haContext);
		public LockEntities Lock => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public RemoteEntities Remote => new(_haContext);
		public SceneEntities Scene => new(_haContext);
		public ScriptEntities Script => new(_haContext);
		public SelectEntities Select => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public TimerEntities Timer => new(_haContext);
		public VacuumEntities Vacuum => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public class AlarmControlPanelEntities
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Home Alarm</summary>
		public AlarmControlPanelEntity HomeAlarm => new(_haContext, "alarm_control_panel.home_alarm");
	}

	public class AutomationEntities
	{
		private readonly IHaContext _haContext;
		public AutomationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Alarm Disarm On</summary>
		public AutomationEntity AlarmDisarm => new(_haContext, "automation.alarm_disarm");
		///<summary>Alarm Disarm Set</summary>
		public AutomationEntity AlarmDisarmSet => new(_haContext, "automation.alarm_disarm_set");
		///<summary>Alarm Home Set</summary>
		public AutomationEntity AlarmHomeSet => new(_haContext, "automation.alarm_home_set");
		///<summary>Amcrest ReDiscover</summary>
		public AutomationEntity AmcrestRediscover => new(_haContext, "automation.amcrest_rediscover");
		///<summary>Auto Lock Door</summary>
		public AutomationEntity AutoLockDoor => new(_haContext, "automation.auto_lock_door");
		///<summary>Break In Notification</summary>
		public AutomationEntity BreakInNotification => new(_haContext, "automation.break_in_notification");
		///<summary>Clear Old Recordings</summary>
		public AutomationEntity ClearOldRecordings => new(_haContext, "automation.clear_old_recordings");
		///<summary>Close Blinds at Night</summary>
		public AutomationEntity CloseBlindsAtNight => new(_haContext, "automation.close_blinds_at_night");
		///<summary>Cockpit Plug ON MQTT</summary>
		public AutomationEntity CockpitPlug => new(_haContext, "automation.cockpit_plug");
		///<summary>Doorbell Motion Detected</summary>
		public AutomationEntity DoorbellMotionDetectedDuplicate => new(_haContext, "automation.doorbell_motion_detected_duplicate");
		///<summary>Flight Night</summary>
		public AutomationEntity FlightNight => new(_haContext, "automation.flight_night");
		///<summary>Cockpit Plug Off MQTT</summary>
		public AutomationEntity FlioghtOff => new(_haContext, "automation.flioght_off");
		///<summary>Garage Motion Detected</summary>
		public AutomationEntity GarageMotionDetected => new(_haContext, "automation.garage_motion_detected");
		///<summary>keymaster_frontdoor Changed Code</summary>
		public AutomationEntity KeymasterFrontdoorChangedCode => new(_haContext, "automation.keymaster_frontdoor_changed_code");
		///<summary>keymaster_frontdoor Decrement Access Count</summary>
		public AutomationEntity KeymasterFrontdoorDecrementAccessCount => new(_haContext, "automation.keymaster_frontdoor_decrement_access_count");
		///<summary>keymaster_frontdoor_disable_auto_lock</summary>
		public AutomationEntity KeymasterFrontdoorDisableAutoLock => new(_haContext, "automation.keymaster_frontdoor_disable_auto_lock");
		///<summary>keymaster_frontdoor Door Open and Close</summary>
		public AutomationEntity KeymasterFrontdoorDoorOpenAndClose => new(_haContext, "automation.keymaster_frontdoor_door_open_and_close");
		///<summary>keymaster_frontdoor_enable_auto_lock</summary>
		public AutomationEntity KeymasterFrontdoorEnableAutoLock => new(_haContext, "automation.keymaster_frontdoor_enable_auto_lock");
		///<summary>keymaster_frontdoor Lock Notifications</summary>
		public AutomationEntity KeymasterFrontdoorLockNotifications => new(_haContext, "automation.keymaster_frontdoor_lock_notifications");
		///<summary>keymaster_frontdoor_locked</summary>
		public AutomationEntity KeymasterFrontdoorLocked => new(_haContext, "automation.keymaster_frontdoor_locked");
		///<summary>keymaster_frontdoor_opened</summary>
		public AutomationEntity KeymasterFrontdoorOpened => new(_haContext, "automation.keymaster_frontdoor_opened");
		///<summary>keymaster_frontdoor Reset</summary>
		public AutomationEntity KeymasterFrontdoorReset => new(_haContext, "automation.keymaster_frontdoor_reset");
		///<summary>keymaster_frontdoor Reset Code Slot</summary>
		public AutomationEntity KeymasterFrontdoorResetCodeSlot => new(_haContext, "automation.keymaster_frontdoor_reset_code_slot");
		///<summary>keymaster_frontdoor_timer_canceled</summary>
		public AutomationEntity KeymasterFrontdoorTimerCanceled => new(_haContext, "automation.keymaster_frontdoor_timer_canceled");
		///<summary>keymaster_frontdoor_timer_finished</summary>
		public AutomationEntity KeymasterFrontdoorTimerFinished => new(_haContext, "automation.keymaster_frontdoor_timer_finished");
		///<summary>keymaster_frontdoor_unlocked_start_autolock</summary>
		public AutomationEntity KeymasterFrontdoorUnlockedStartAutolock => new(_haContext, "automation.keymaster_frontdoor_unlocked_start_autolock");
		///<summary>keymaster_frontdoor User Notifications</summary>
		public AutomationEntity KeymasterFrontdoorUserNotifications => new(_haContext, "automation.keymaster_frontdoor_user_notifications");
		///<summary>keymaster_retry_bolt_closed_frontdoor</summary>
		public AutomationEntity KeymasterRetryBoltClosedFrontdoor => new(_haContext, "automation.keymaster_retry_bolt_closed_frontdoor");
		///<summary>keymaster_turn_off_retry_frontdoor</summary>
		public AutomationEntity KeymasterTurnOffRetryFrontdoor => new(_haContext, "automation.keymaster_turn_off_retry_frontdoor");
		///<summary>Secure House</summary>
		public AutomationEntity LightsOffAtNight => new(_haContext, "automation.lights_off_at_night");
		///<summary>Low Battery Notification</summary>
		public AutomationEntity LowBatteryNotification => new(_haContext, "automation.low_battery_notification");
		///<summary>Auto Close Garage Door</summary>
		public AutomationEntity NewAutomation => new(_haContext, "automation.new_automation");
		///<summary>Alarm Away On</summary>
		public AutomationEntity NewAutomation2 => new(_haContext, "automation.new_automation_2");
		///<summary>NFC Open Garage Door</summary>
		public AutomationEntity NfcOpenGarageDoor => new(_haContext, "automation.nfc_open_garage_door");
		///<summary>NFC Unlock Front Door</summary>
		public AutomationEntity NfcUnlockFrontDoor => new(_haContext, "automation.nfc_unlock_front_door");
		///<summary>Octoprint Completed</summary>
		public AutomationEntity OctoprintCompleted => new(_haContext, "automation.octoprint_completed");
		///<summary>Octoprint Error</summary>
		public AutomationEntity OctoprintError => new(_haContext, "automation.octoprint_error");
		///<summary>Open Blinds at Morning</summary>
		public AutomationEntity OpenBlindsAtMorning => new(_haContext, "automation.open_blinds_at_morning");
		///<summary>Projector Screen Down</summary>
		public AutomationEntity ProjectorScreenDown => new(_haContext, "automation.projector_screen_down");
		///<summary>Projector Screen Up</summary>
		public AutomationEntity ProjectorScreenUp => new(_haContext, "automation.projector_screen_up");
		///<summary>Restart Amcrest-MQQT Addon</summary>
		public AutomationEntity RestartAmcrestMqqtAddon => new(_haContext, "automation.restart_amcrest_mqqt_addon");
		///<summary>RFID Open Door</summary>
		public AutomationEntity RfidOpenDoor2 => new(_haContext, "automation.rfid_open_door_2");
		///<summary>Set Temperature </summary>
		public AutomationEntity SetTemperature => new(_haContext, "automation.set_temperature");
		///<summary>Set Temperature at Night</summary>
		public AutomationEntity SetTemperatureAtNight => new(_haContext, "automation.set_temperature_at_night");
		///<summary>Set Temperature at Night Off</summary>
		public AutomationEntity SetTemperatureAtNightOff => new(_haContext, "automation.set_temperature_at_night_off");
		///<summary>synchronize_codeslot_frontdoor_1</summary>
		public AutomationEntity SynchronizeCodeslotFrontdoor1 => new(_haContext, "automation.synchronize_codeslot_frontdoor_1");
		///<summary>synchronize_codeslot_frontdoor_10</summary>
		public AutomationEntity SynchronizeCodeslotFrontdoor10 => new(_haContext, "automation.synchronize_codeslot_frontdoor_10");
		///<summary>synchronize_codeslot_frontdoor_2</summary>
		public AutomationEntity SynchronizeCodeslotFrontdoor2 => new(_haContext, "automation.synchronize_codeslot_frontdoor_2");
		///<summary>synchronize_codeslot_frontdoor_3</summary>
		public AutomationEntity SynchronizeCodeslotFrontdoor3 => new(_haContext, "automation.synchronize_codeslot_frontdoor_3");
		///<summary>synchronize_codeslot_frontdoor_4</summary>
		public AutomationEntity SynchronizeCodeslotFrontdoor4 => new(_haContext, "automation.synchronize_codeslot_frontdoor_4");
		///<summary>synchronize_codeslot_frontdoor_5</summary>
		public AutomationEntity SynchronizeCodeslotFrontdoor5 => new(_haContext, "automation.synchronize_codeslot_frontdoor_5");
		///<summary>synchronize_codeslot_frontdoor_6</summary>
		public AutomationEntity SynchronizeCodeslotFrontdoor6 => new(_haContext, "automation.synchronize_codeslot_frontdoor_6");
		///<summary>synchronize_codeslot_frontdoor_7</summary>
		public AutomationEntity SynchronizeCodeslotFrontdoor7 => new(_haContext, "automation.synchronize_codeslot_frontdoor_7");
		///<summary>synchronize_codeslot_frontdoor_8</summary>
		public AutomationEntity SynchronizeCodeslotFrontdoor8 => new(_haContext, "automation.synchronize_codeslot_frontdoor_8");
		///<summary>synchronize_codeslot_frontdoor_9</summary>
		public AutomationEntity SynchronizeCodeslotFrontdoor9 => new(_haContext, "automation.synchronize_codeslot_frontdoor_9");
		///<summary>NFC  Toggle Cockpit Plug</summary>
		public AutomationEntity TagCockpitPlugToggleIsScanned => new(_haContext, "automation.tag_cockpit_plug_toggle_is_scanned");
		///<summary>Telemundo</summary>
		public AutomationEntity Telemundo => new(_haContext, "automation.telemundo");
		///<summary>Turn off all Lights</summary>
		public AutomationEntity TurnOffAllLights => new(_haContext, "automation.turn_off_all_lights");
		///<summary>Turn Off Patio Light</summary>
		public AutomationEntity TurnOffPatioLight => new(_haContext, "automation.turn_off_patio_light");
		///<summary>turn_on_access_limit_frontdoor_1</summary>
		public AutomationEntity TurnOnAccessLimitFrontdoor1 => new(_haContext, "automation.turn_on_access_limit_frontdoor_1");
		///<summary>turn_on_access_limit_frontdoor_10</summary>
		public AutomationEntity TurnOnAccessLimitFrontdoor10 => new(_haContext, "automation.turn_on_access_limit_frontdoor_10");
		///<summary>turn_on_access_limit_frontdoor_2</summary>
		public AutomationEntity TurnOnAccessLimitFrontdoor2 => new(_haContext, "automation.turn_on_access_limit_frontdoor_2");
		///<summary>turn_on_access_limit_frontdoor_3</summary>
		public AutomationEntity TurnOnAccessLimitFrontdoor3 => new(_haContext, "automation.turn_on_access_limit_frontdoor_3");
		///<summary>turn_on_access_limit_frontdoor_4</summary>
		public AutomationEntity TurnOnAccessLimitFrontdoor4 => new(_haContext, "automation.turn_on_access_limit_frontdoor_4");
		///<summary>turn_on_access_limit_frontdoor_5</summary>
		public AutomationEntity TurnOnAccessLimitFrontdoor5 => new(_haContext, "automation.turn_on_access_limit_frontdoor_5");
		///<summary>turn_on_access_limit_frontdoor_6</summary>
		public AutomationEntity TurnOnAccessLimitFrontdoor6 => new(_haContext, "automation.turn_on_access_limit_frontdoor_6");
		///<summary>turn_on_access_limit_frontdoor_7</summary>
		public AutomationEntity TurnOnAccessLimitFrontdoor7 => new(_haContext, "automation.turn_on_access_limit_frontdoor_7");
		///<summary>turn_on_access_limit_frontdoor_8</summary>
		public AutomationEntity TurnOnAccessLimitFrontdoor8 => new(_haContext, "automation.turn_on_access_limit_frontdoor_8");
		///<summary>turn_on_access_limit_frontdoor_9</summary>
		public AutomationEntity TurnOnAccessLimitFrontdoor9 => new(_haContext, "automation.turn_on_access_limit_frontdoor_9");
		///<summary>Turn On Patio Light</summary>
		public AutomationEntity TurnOnPatioLight => new(_haContext, "automation.turn_on_patio_light");
		///<summary>Turnoff 3d printer after job completes</summary>
		public AutomationEntity Turnoff3dPrinterAfterJobCompletes => new(_haContext, "automation.turnoff_3d_printer_after_job_completes");
	}

	public class BinarySensorEntities
	{
		private readonly IHaContext _haContext;
		public BinarySensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Desired PIN State</summary>
		public BinarySensorEntity ActiveFrontdoor1 => new(_haContext, "binary_sensor.active_frontdoor_1");
		///<summary>Desired PIN State</summary>
		public BinarySensorEntity ActiveFrontdoor10 => new(_haContext, "binary_sensor.active_frontdoor_10");
		///<summary>Desired PIN State</summary>
		public BinarySensorEntity ActiveFrontdoor2 => new(_haContext, "binary_sensor.active_frontdoor_2");
		///<summary>Desired PIN State</summary>
		public BinarySensorEntity ActiveFrontdoor3 => new(_haContext, "binary_sensor.active_frontdoor_3");
		///<summary>Desired PIN State</summary>
		public BinarySensorEntity ActiveFrontdoor4 => new(_haContext, "binary_sensor.active_frontdoor_4");
		///<summary>Desired PIN State</summary>
		public BinarySensorEntity ActiveFrontdoor5 => new(_haContext, "binary_sensor.active_frontdoor_5");
		///<summary>Desired PIN State</summary>
		public BinarySensorEntity ActiveFrontdoor6 => new(_haContext, "binary_sensor.active_frontdoor_6");
		///<summary>Desired PIN State</summary>
		public BinarySensorEntity ActiveFrontdoor7 => new(_haContext, "binary_sensor.active_frontdoor_7");
		///<summary>Desired PIN State</summary>
		public BinarySensorEntity ActiveFrontdoor8 => new(_haContext, "binary_sensor.active_frontdoor_8");
		///<summary>Desired PIN State</summary>
		public BinarySensorEntity ActiveFrontdoor9 => new(_haContext, "binary_sensor.active_frontdoor_9");
		///<summary>Front Door Doorbell Pressed</summary>
		public BinarySensorEntity FrontDoorDoorbellPressed => new(_haContext, "binary_sensor.front_door_doorbell_pressed");
		///<summary>Front Door  Sensor</summary>
		public BinarySensorEntity FrontDoorEntranceIasZone => new(_haContext, "binary_sensor.front_door_entrance_ias_zone");
		///<summary>Front Door Human Motion Detected</summary>
		public BinarySensorEntity FrontDoorHumanMotionDetected => new(_haContext, "binary_sensor.front_door_human_motion_detected");
		///<summary>Front Door Lock: Low battery level</summary>
		public BinarySensorEntity FrontDoorLockLowBatteryLevel => new(_haContext, "binary_sensor.front_door_lock_low_battery_level");
		///<summary>Front Door Lock: The current status of the door</summary>
		public BinarySensorEntity FrontDoorLockTheCurrentStatusOfTheDoor => new(_haContext, "binary_sensor.front_door_lock_the_current_status_of_the_door");
		///<summary>Front Door Motion Detected</summary>
		public BinarySensorEntity FrontDoorMotionDetected => new(_haContext, "binary_sensor.front_door_motion_detected");
		///<summary>frontdoor: Network</summary>
		public BinarySensorEntity FrontdoorNetwork => new(_haContext, "binary_sensor.frontdoor_network");
		///<summary>Garage Camera Doorbell Pressed</summary>
		public BinarySensorEntity GarageCameraDoorbellPressed => new(_haContext, "binary_sensor.garage_camera_doorbell_pressed");
		///<summary>Garage Camera Human Motion Detected</summary>
		public BinarySensorEntity GarageCameraHumanMotionDetected => new(_haContext, "binary_sensor.garage_camera_human_motion_detected");
		///<summary>Garage Camera Motion Detected</summary>
		public BinarySensorEntity GarageCameraMotionDetected => new(_haContext, "binary_sensor.garage_camera_motion_detected");
		///<summary>Garage Door Opened</summary>
		public BinarySensorEntity GarageDoorOpenSenorAny => new(_haContext, "binary_sensor.garage_door_open_senor_any");
		///<summary>Garage Door Open Senor: Home Security - Tampering, product cover removed</summary>
		public BinarySensorEntity GarageDoorOpenSenorHomeSecurityTamperingProductCoverRemoved => new(_haContext, "binary_sensor.garage_door_open_senor_home_security_tampering_product_cover_removed");
		///<summary>Garage Door Open Senor: Low battery level</summary>
		public BinarySensorEntity GarageDoorOpenSenorLowBatteryLevel => new(_haContext, "binary_sensor.garage_door_open_senor_low_battery_level");
		///<summary>Kitchen Blind: Low battery level</summary>
		public BinarySensorEntity KitchenBlindLowBatteryLevel => new(_haContext, "binary_sensor.kitchen_blind_low_battery_level");
		///<summary>Living Blind: Low battery level</summary>
		public BinarySensorEntity LivingBlindLowBatteryLevel => new(_haContext, "binary_sensor.living_blind_low_battery_level");
		///<summary>Luciano's Office Tablet Is Charging</summary>
		public BinarySensorEntity LucianoSOfficeTabletIsCharging => new(_haContext, "binary_sensor.luciano_s_office_tablet_is_charging");
		///<summary>Luciano's  S21 Phone Is Charging</summary>
		public BinarySensorEntity LucianoSS21PhoneIsCharging => new(_haContext, "binary_sensor.luciano_s_s21_phone_is_charging");
		///<summary>None Headphones Connected</summary>
		public BinarySensorEntity NoneHeadphonesConnected => new(_haContext, "binary_sensor.none_headphones_connected");
		///<summary>None Supports AirPlay</summary>
		public BinarySensorEntity NoneSupportsAirplay => new(_haContext, "binary_sensor.none_supports_airplay");
		///<summary>None Supports Ethernet</summary>
		public BinarySensorEntity NoneSupportsEthernet => new(_haContext, "binary_sensor.none_supports_ethernet");
		///<summary>None Supports Find Remote</summary>
		public BinarySensorEntity NoneSupportsFindRemote => new(_haContext, "binary_sensor.none_supports_find_remote");
		///<summary>OctoPrint Printing</summary>
		public BinarySensorEntity OctoprintPrinting => new(_haContext, "binary_sensor.octoprint_printing");
		///<summary>OctoPrint Printing Error</summary>
		public BinarySensorEntity OctoprintPrintingError => new(_haContext, "binary_sensor.octoprint_printing_error");
		///<summary>Office Blind: Low battery level</summary>
		public BinarySensorEntity OfficeBlindLowBatteryLevel => new(_haContext, "binary_sensor.office_blind_low_battery_level");
		///<summary>Patio Door Sensor</summary>
		public BinarySensorEntity PatioDoorSensorZone => new(_haContext, "binary_sensor.patio_door_sensor_zone");
		///<summary>PIN synchronized with lock</summary>
		public BinarySensorEntity PinSynchedFrontdoor1 => new(_haContext, "binary_sensor.pin_synched_frontdoor_1");
		///<summary>PIN synchronized with lock</summary>
		public BinarySensorEntity PinSynchedFrontdoor10 => new(_haContext, "binary_sensor.pin_synched_frontdoor_10");
		///<summary>PIN synchronized with lock</summary>
		public BinarySensorEntity PinSynchedFrontdoor2 => new(_haContext, "binary_sensor.pin_synched_frontdoor_2");
		///<summary>PIN synchronized with lock</summary>
		public BinarySensorEntity PinSynchedFrontdoor3 => new(_haContext, "binary_sensor.pin_synched_frontdoor_3");
		///<summary>PIN synchronized with lock</summary>
		public BinarySensorEntity PinSynchedFrontdoor4 => new(_haContext, "binary_sensor.pin_synched_frontdoor_4");
		///<summary>PIN synchronized with lock</summary>
		public BinarySensorEntity PinSynchedFrontdoor5 => new(_haContext, "binary_sensor.pin_synched_frontdoor_5");
		///<summary>PIN synchronized with lock</summary>
		public BinarySensorEntity PinSynchedFrontdoor6 => new(_haContext, "binary_sensor.pin_synched_frontdoor_6");
		///<summary>PIN synchronized with lock</summary>
		public BinarySensorEntity PinSynchedFrontdoor7 => new(_haContext, "binary_sensor.pin_synched_frontdoor_7");
		///<summary>PIN synchronized with lock</summary>
		public BinarySensorEntity PinSynchedFrontdoor8 => new(_haContext, "binary_sensor.pin_synched_frontdoor_8");
		///<summary>PIN synchronized with lock</summary>
		public BinarySensorEntity PinSynchedFrontdoor9 => new(_haContext, "binary_sensor.pin_synched_frontdoor_9");
		///<summary>Real Living Touchscreen Deadbolt: Access Control - Lock jammed</summary>
		public BinarySensorEntity RealLivingTouchscreenDeadboltAccessControlLockJammed => new(_haContext, "binary_sensor.real_living_touchscreen_deadbolt_access_control_lock_jammed");
		///<summary>Remote UI</summary>
		public BinarySensorEntity RemoteUi => new(_haContext, "binary_sensor.remote_ui");
		///<summary>Robot vacuum Mop Attached</summary>
		public BinarySensorEntity RobotVacuumMopAttached => new(_haContext, "binary_sensor.robot_vacuum_mop_attached");
		///<summary>Robot vacuum Water Box Attached</summary>
		public BinarySensorEntity RobotVacuumWaterBoxAttached => new(_haContext, "binary_sensor.robot_vacuum_water_box_attached");
		///<summary>Roku Ultra Headphones Connected</summary>
		public BinarySensorEntity RokuUltraHeadphonesConnected => new(_haContext, "binary_sensor.roku_ultra_headphones_connected");
		///<summary>Roku Ultra Supports AirPlay</summary>
		public BinarySensorEntity RokuUltraSupportsAirplay => new(_haContext, "binary_sensor.roku_ultra_supports_airplay");
		///<summary>Roku Ultra Supports Ethernet</summary>
		public BinarySensorEntity RokuUltraSupportsEthernet => new(_haContext, "binary_sensor.roku_ultra_supports_ethernet");
		///<summary>Roku Ultra Supports Find Remote</summary>
		public BinarySensorEntity RokuUltraSupportsFindRemote => new(_haContext, "binary_sensor.roku_ultra_supports_find_remote");
		///<summary>RPi Power status</summary>
		public BinarySensorEntity RpiPowerStatus => new(_haContext, "binary_sensor.rpi_power_status");
		///<summary>RT-AC5300-A600 wan status</summary>
		public BinarySensorEntity RtAc5300A600WanStatus => new(_haContext, "binary_sensor.rt_ac5300_a600_wan_status");
		///<summary>Sprinklers Extra Water on Hot Days</summary>
		public BinarySensorEntity SprinklersExtraWaterOnHotDays => new(_haContext, "binary_sensor.sprinklers_extra_water_on_hot_days");
		///<summary>Sprinklers Flow Sensor</summary>
		public BinarySensorEntity SprinklersFlowSensor => new(_haContext, "binary_sensor.sprinklers_flow_sensor");
		///<summary>Sprinklers Freeze Protection</summary>
		public BinarySensorEntity SprinklersFreezeProtection => new(_haContext, "binary_sensor.sprinklers_freeze_protection");
		///<summary>Sprinklers Freeze Restrictions</summary>
		public BinarySensorEntity SprinklersFreezeRestrictions => new(_haContext, "binary_sensor.sprinklers_freeze_restrictions");
		///<summary>Updater</summary>
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
	}

	public class ButtonEntities
	{
		private readonly IHaContext _haContext;
		public ButtonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>innr SP 234 580698fe identify</summary>
		public ButtonEntity InnrSp234580698feIdentify => new(_haContext, "button.innr_sp_234_580698fe_identify");
		///<summary>innr SP 234 930698fe identify</summary>
		public ButtonEntity InnrSp234930698feIdentify => new(_haContext, "button.innr_sp_234_930698fe_identify");
		///<summary>Jasco Products 43076 0801cefe identify</summary>
		public ButtonEntity JascoProducts430760801cefeIdentify => new(_haContext, "button.jasco_products_43076_0801cefe_identify");
		///<summary>LG webOS TV 6478 Identify</summary>
		public ButtonEntity LgWebosTv6478Identify => new(_haContext, "button.lg_webos_tv_6478_identify");
		///<summary>LUMI lumi.weather 068ee007 identify</summary>
		public ButtonEntity LumiLumiWeather068ee007Identify => new(_haContext, "button.lumi_lumi_weather_068ee007_identify");
		///<summary>LUMI lumi.weather 1cd2d307 identify</summary>
		public ButtonEntity LumiLumiWeather1cd2d307Identify => new(_haContext, "button.lumi_lumi_weather_1cd2d307_identify");
		///<summary>LUMI lumi.weather 278ee007 identify</summary>
		public ButtonEntity LumiLumiWeather278ee007Identify => new(_haContext, "button.lumi_lumi_weather_278ee007_identify");
		///<summary>LUMI lumi.weather d5a6d307 identify</summary>
		public ButtonEntity LumiLumiWeatherD5a6d307Identify => new(_haContext, "button.lumi_lumi_weather_d5a6d307_identify");
		///<summary>unk_manufacturer lumi.weather 8a7c6507 identify</summary>
		public ButtonEntity UnkManufacturerUnkModel8a7c6507Identify => new(_haContext, "button.unk_manufacturer_unk_model_8a7c6507_identify");
	}

	public class CameraEntities
	{
		private readonly IHaContext _haContext;
		public CameraEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Front Door Camera</summary>
		public CameraEntity AmcrestCamera => new(_haContext, "camera.amcrest_camera");
		///<summary>Garage Camera</summary>
		public CameraEntity GarageCamera => new(_haContext, "camera.garage_camera");
		///<summary>Octoprint Camera</summary>
		public CameraEntity OctoprintCamera => new(_haContext, "camera.octoprint_camera");
	}

	public class ClimateEntities
	{
		private readonly IHaContext _haContext;
		public ClimateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>AC</summary>
		public ClimateEntity Ac => new(_haContext, "climate.ac");
	}

	public class CoverEntities
	{
		private readonly IHaContext _haContext;
		public CoverEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Kitchen Blind</summary>
		public CoverEntity KitchenBlind => new(_haContext, "cover.kitchen_blind");
		///<summary>Living Blind</summary>
		public CoverEntity LivingBlind => new(_haContext, "cover.living_blind");
		///<summary>Office Blind</summary>
		public CoverEntity OfficeBlind => new(_haContext, "cover.office_blind");
	}

	public class DeviceTrackerEntities
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Luciano's Office Tablet</summary>
		public DeviceTrackerEntity LucianoSOfficeTablet => new(_haContext, "device_tracker.luciano_s_office_tablet");
		///<summary>Luciano's  S21 Phone</summary>
		public DeviceTrackerEntity LucianoSS21Phone => new(_haContext, "device_tracker.luciano_s_s21_phone");
	}

	public class FanEntities
	{
		private readonly IHaContext _haContext;
		public FanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>TV Fan</summary>
		public FanEntity TvFan => new(_haContext, "fan.tv_fan");
	}

	public class InputBooleanEntities
	{
		private readonly IHaContext _haContext;
		public InputBooleanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Enforce PIN limit</summary>
		public InputBooleanEntity AccesslimitFrontdoor1 => new(_haContext, "input_boolean.accesslimit_frontdoor_1");
		///<summary>Enforce PIN limit</summary>
		public InputBooleanEntity AccesslimitFrontdoor10 => new(_haContext, "input_boolean.accesslimit_frontdoor_10");
		///<summary>Enforce PIN limit</summary>
		public InputBooleanEntity AccesslimitFrontdoor2 => new(_haContext, "input_boolean.accesslimit_frontdoor_2");
		///<summary>Enforce PIN limit</summary>
		public InputBooleanEntity AccesslimitFrontdoor3 => new(_haContext, "input_boolean.accesslimit_frontdoor_3");
		///<summary>Enforce PIN limit</summary>
		public InputBooleanEntity AccesslimitFrontdoor4 => new(_haContext, "input_boolean.accesslimit_frontdoor_4");
		///<summary>Enforce PIN limit</summary>
		public InputBooleanEntity AccesslimitFrontdoor5 => new(_haContext, "input_boolean.accesslimit_frontdoor_5");
		///<summary>Enforce PIN limit</summary>
		public InputBooleanEntity AccesslimitFrontdoor6 => new(_haContext, "input_boolean.accesslimit_frontdoor_6");
		///<summary>Enforce PIN limit</summary>
		public InputBooleanEntity AccesslimitFrontdoor7 => new(_haContext, "input_boolean.accesslimit_frontdoor_7");
		///<summary>Enforce PIN limit</summary>
		public InputBooleanEntity AccesslimitFrontdoor8 => new(_haContext, "input_boolean.accesslimit_frontdoor_8");
		///<summary>Enforce PIN limit</summary>
		public InputBooleanEntity AccesslimitFrontdoor9 => new(_haContext, "input_boolean.accesslimit_frontdoor_9");
		///<summary>Use Date Range</summary>
		public InputBooleanEntity DaterangeFrontdoor1 => new(_haContext, "input_boolean.daterange_frontdoor_1");
		///<summary>Use Date Range</summary>
		public InputBooleanEntity DaterangeFrontdoor10 => new(_haContext, "input_boolean.daterange_frontdoor_10");
		///<summary>Use Date Range</summary>
		public InputBooleanEntity DaterangeFrontdoor2 => new(_haContext, "input_boolean.daterange_frontdoor_2");
		///<summary>Use Date Range</summary>
		public InputBooleanEntity DaterangeFrontdoor3 => new(_haContext, "input_boolean.daterange_frontdoor_3");
		///<summary>Use Date Range</summary>
		public InputBooleanEntity DaterangeFrontdoor4 => new(_haContext, "input_boolean.daterange_frontdoor_4");
		///<summary>Use Date Range</summary>
		public InputBooleanEntity DaterangeFrontdoor5 => new(_haContext, "input_boolean.daterange_frontdoor_5");
		///<summary>Use Date Range</summary>
		public InputBooleanEntity DaterangeFrontdoor6 => new(_haContext, "input_boolean.daterange_frontdoor_6");
		///<summary>Use Date Range</summary>
		public InputBooleanEntity DaterangeFrontdoor7 => new(_haContext, "input_boolean.daterange_frontdoor_7");
		///<summary>Use Date Range</summary>
		public InputBooleanEntity DaterangeFrontdoor8 => new(_haContext, "input_boolean.daterange_frontdoor_8");
		///<summary>Use Date Range</summary>
		public InputBooleanEntity DaterangeFrontdoor9 => new(_haContext, "input_boolean.daterange_frontdoor_9");
		///<summary>Enabled</summary>
		public InputBooleanEntity EnabledFrontdoor1 => new(_haContext, "input_boolean.enabled_frontdoor_1");
		///<summary>Enabled</summary>
		public InputBooleanEntity EnabledFrontdoor10 => new(_haContext, "input_boolean.enabled_frontdoor_10");
		///<summary>Enabled</summary>
		public InputBooleanEntity EnabledFrontdoor2 => new(_haContext, "input_boolean.enabled_frontdoor_2");
		///<summary>Enabled</summary>
		public InputBooleanEntity EnabledFrontdoor3 => new(_haContext, "input_boolean.enabled_frontdoor_3");
		///<summary>Enabled</summary>
		public InputBooleanEntity EnabledFrontdoor4 => new(_haContext, "input_boolean.enabled_frontdoor_4");
		///<summary>Enabled</summary>
		public InputBooleanEntity EnabledFrontdoor5 => new(_haContext, "input_boolean.enabled_frontdoor_5");
		///<summary>Enabled</summary>
		public InputBooleanEntity EnabledFrontdoor6 => new(_haContext, "input_boolean.enabled_frontdoor_6");
		///<summary>Enabled</summary>
		public InputBooleanEntity EnabledFrontdoor7 => new(_haContext, "input_boolean.enabled_frontdoor_7");
		///<summary>Enabled</summary>
		public InputBooleanEntity EnabledFrontdoor8 => new(_haContext, "input_boolean.enabled_frontdoor_8");
		///<summary>Enabled</summary>
		public InputBooleanEntity EnabledFrontdoor9 => new(_haContext, "input_boolean.enabled_frontdoor_9");
		///<summary>Friday</summary>
		public InputBooleanEntity FriFrontdoor1 => new(_haContext, "input_boolean.fri_frontdoor_1");
		///<summary>Friday</summary>
		public InputBooleanEntity FriFrontdoor10 => new(_haContext, "input_boolean.fri_frontdoor_10");
		///<summary>Friday</summary>
		public InputBooleanEntity FriFrontdoor2 => new(_haContext, "input_boolean.fri_frontdoor_2");
		///<summary>Friday</summary>
		public InputBooleanEntity FriFrontdoor3 => new(_haContext, "input_boolean.fri_frontdoor_3");
		///<summary>Friday</summary>
		public InputBooleanEntity FriFrontdoor4 => new(_haContext, "input_boolean.fri_frontdoor_4");
		///<summary>Friday</summary>
		public InputBooleanEntity FriFrontdoor5 => new(_haContext, "input_boolean.fri_frontdoor_5");
		///<summary>Friday</summary>
		public InputBooleanEntity FriFrontdoor6 => new(_haContext, "input_boolean.fri_frontdoor_6");
		///<summary>Friday</summary>
		public InputBooleanEntity FriFrontdoor7 => new(_haContext, "input_boolean.fri_frontdoor_7");
		///<summary>Friday</summary>
		public InputBooleanEntity FriFrontdoor8 => new(_haContext, "input_boolean.fri_frontdoor_8");
		///<summary>Friday</summary>
		public InputBooleanEntity FriFrontdoor9 => new(_haContext, "input_boolean.fri_frontdoor_9");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity FriIncFrontdoor1 => new(_haContext, "input_boolean.fri_inc_frontdoor_1");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity FriIncFrontdoor10 => new(_haContext, "input_boolean.fri_inc_frontdoor_10");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity FriIncFrontdoor2 => new(_haContext, "input_boolean.fri_inc_frontdoor_2");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity FriIncFrontdoor3 => new(_haContext, "input_boolean.fri_inc_frontdoor_3");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity FriIncFrontdoor4 => new(_haContext, "input_boolean.fri_inc_frontdoor_4");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity FriIncFrontdoor5 => new(_haContext, "input_boolean.fri_inc_frontdoor_5");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity FriIncFrontdoor6 => new(_haContext, "input_boolean.fri_inc_frontdoor_6");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity FriIncFrontdoor7 => new(_haContext, "input_boolean.fri_inc_frontdoor_7");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity FriIncFrontdoor8 => new(_haContext, "input_boolean.fri_inc_frontdoor_8");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity FriIncFrontdoor9 => new(_haContext, "input_boolean.fri_inc_frontdoor_9");
		///<summary>frontdoor Door Notifications</summary>
		public InputBooleanEntity FrontdoorDooraccessNotifications => new(_haContext, "input_boolean.frontdoor_dooraccess_notifications");
		///<summary>frontdoor Garage Notifications</summary>
		public InputBooleanEntity FrontdoorGarageacessNotifications => new(_haContext, "input_boolean.frontdoor_garageacess_notifications");
		///<summary>frontdoor Lock Notifications</summary>
		public InputBooleanEntity FrontdoorLockNotifications => new(_haContext, "input_boolean.frontdoor_lock_notifications");
		///<summary>frontdoor reset lock</summary>
		public InputBooleanEntity FrontdoorResetLock => new(_haContext, "input_boolean.frontdoor_reset_lock");
		///<summary>Auto Lock Enabled</summary>
		public InputBooleanEntity KeymasterFrontdoorAutolock => new(_haContext, "input_boolean.keymaster_frontdoor_autolock");
		///<summary>Auto Lock Enabled</summary>
		public InputBooleanEntity KeymasterFrontdoorRetry => new(_haContext, "input_boolean.keymaster_frontdoor_retry");
		///<summary>Monday</summary>
		public InputBooleanEntity MonFrontdoor1 => new(_haContext, "input_boolean.mon_frontdoor_1");
		///<summary>Monday</summary>
		public InputBooleanEntity MonFrontdoor10 => new(_haContext, "input_boolean.mon_frontdoor_10");
		///<summary>Monday</summary>
		public InputBooleanEntity MonFrontdoor2 => new(_haContext, "input_boolean.mon_frontdoor_2");
		///<summary>Monday</summary>
		public InputBooleanEntity MonFrontdoor3 => new(_haContext, "input_boolean.mon_frontdoor_3");
		///<summary>Monday</summary>
		public InputBooleanEntity MonFrontdoor4 => new(_haContext, "input_boolean.mon_frontdoor_4");
		///<summary>Monday</summary>
		public InputBooleanEntity MonFrontdoor5 => new(_haContext, "input_boolean.mon_frontdoor_5");
		///<summary>Monday</summary>
		public InputBooleanEntity MonFrontdoor6 => new(_haContext, "input_boolean.mon_frontdoor_6");
		///<summary>Monday</summary>
		public InputBooleanEntity MonFrontdoor7 => new(_haContext, "input_boolean.mon_frontdoor_7");
		///<summary>Monday</summary>
		public InputBooleanEntity MonFrontdoor8 => new(_haContext, "input_boolean.mon_frontdoor_8");
		///<summary>Monday</summary>
		public InputBooleanEntity MonFrontdoor9 => new(_haContext, "input_boolean.mon_frontdoor_9");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity MonIncFrontdoor1 => new(_haContext, "input_boolean.mon_inc_frontdoor_1");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity MonIncFrontdoor10 => new(_haContext, "input_boolean.mon_inc_frontdoor_10");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity MonIncFrontdoor2 => new(_haContext, "input_boolean.mon_inc_frontdoor_2");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity MonIncFrontdoor3 => new(_haContext, "input_boolean.mon_inc_frontdoor_3");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity MonIncFrontdoor4 => new(_haContext, "input_boolean.mon_inc_frontdoor_4");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity MonIncFrontdoor5 => new(_haContext, "input_boolean.mon_inc_frontdoor_5");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity MonIncFrontdoor6 => new(_haContext, "input_boolean.mon_inc_frontdoor_6");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity MonIncFrontdoor7 => new(_haContext, "input_boolean.mon_inc_frontdoor_7");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity MonIncFrontdoor8 => new(_haContext, "input_boolean.mon_inc_frontdoor_8");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity MonIncFrontdoor9 => new(_haContext, "input_boolean.mon_inc_frontdoor_9");
		///<summary>netdaemon_appmodelhelloyamlapp</summary>
		public InputBooleanEntity NetdaemonAppmodelhelloyamlapp => new(_haContext, "input_boolean.netdaemon_appmodelhelloyamlapp");
		///<summary>netdaemon_customthermostatcustomthermostat</summary>
		public InputBooleanEntity NetdaemonCustomthermostatcustomthermostat => new(_haContext, "input_boolean.netdaemon_customthermostatcustomthermostat");
		///<summary>netdaemon_extensionsschedulingschedulingapp</summary>
		public InputBooleanEntity NetdaemonExtensionsschedulingschedulingapp => new(_haContext, "input_boolean.netdaemon_extensionsschedulingschedulingapp");
		///<summary>netdaemon_hassmodelhelloworldapp</summary>
		public InputBooleanEntity NetdaemonHassmodelhelloworldapp => new(_haContext, "input_boolean.netdaemon_hassmodelhelloworldapp");
		///<summary>netdaemon_hassmodellightonmovement</summary>
		public InputBooleanEntity NetdaemonHassmodellightonmovement => new(_haContext, "input_boolean.netdaemon_hassmodellightonmovement");
		///<summary>netdaemon_netdaemon3appscustomthermostat</summary>
		public InputBooleanEntity NetdaemonNetdaemon3appscustomthermostat => new(_haContext, "input_boolean.netdaemon_netdaemon3appscustomthermostat");
		///<summary>netdaemon_netdaemon3appssetcurrentthermostat</summary>
		public InputBooleanEntity NetdaemonNetdaemon3appssetcurrentthermostat => new(_haContext, "input_boolean.netdaemon_netdaemon3appssetcurrentthermostat");
		///<summary>Notifications</summary>
		public InputBooleanEntity NotifyFrontdoor1 => new(_haContext, "input_boolean.notify_frontdoor_1");
		///<summary>Notifications</summary>
		public InputBooleanEntity NotifyFrontdoor10 => new(_haContext, "input_boolean.notify_frontdoor_10");
		///<summary>Notifications</summary>
		public InputBooleanEntity NotifyFrontdoor2 => new(_haContext, "input_boolean.notify_frontdoor_2");
		///<summary>Notifications</summary>
		public InputBooleanEntity NotifyFrontdoor3 => new(_haContext, "input_boolean.notify_frontdoor_3");
		///<summary>Notifications</summary>
		public InputBooleanEntity NotifyFrontdoor4 => new(_haContext, "input_boolean.notify_frontdoor_4");
		///<summary>Notifications</summary>
		public InputBooleanEntity NotifyFrontdoor5 => new(_haContext, "input_boolean.notify_frontdoor_5");
		///<summary>Notifications</summary>
		public InputBooleanEntity NotifyFrontdoor6 => new(_haContext, "input_boolean.notify_frontdoor_6");
		///<summary>Notifications</summary>
		public InputBooleanEntity NotifyFrontdoor7 => new(_haContext, "input_boolean.notify_frontdoor_7");
		///<summary>Notifications</summary>
		public InputBooleanEntity NotifyFrontdoor8 => new(_haContext, "input_boolean.notify_frontdoor_8");
		///<summary>Notifications</summary>
		public InputBooleanEntity NotifyFrontdoor9 => new(_haContext, "input_boolean.notify_frontdoor_9");
		///<summary>Reset Code Slot</summary>
		public InputBooleanEntity ResetCodeslotFrontdoor1 => new(_haContext, "input_boolean.reset_codeslot_frontdoor_1");
		///<summary>Reset Code Slot</summary>
		public InputBooleanEntity ResetCodeslotFrontdoor10 => new(_haContext, "input_boolean.reset_codeslot_frontdoor_10");
		///<summary>Reset Code Slot</summary>
		public InputBooleanEntity ResetCodeslotFrontdoor2 => new(_haContext, "input_boolean.reset_codeslot_frontdoor_2");
		///<summary>Reset Code Slot</summary>
		public InputBooleanEntity ResetCodeslotFrontdoor3 => new(_haContext, "input_boolean.reset_codeslot_frontdoor_3");
		///<summary>Reset Code Slot</summary>
		public InputBooleanEntity ResetCodeslotFrontdoor4 => new(_haContext, "input_boolean.reset_codeslot_frontdoor_4");
		///<summary>Reset Code Slot</summary>
		public InputBooleanEntity ResetCodeslotFrontdoor5 => new(_haContext, "input_boolean.reset_codeslot_frontdoor_5");
		///<summary>Reset Code Slot</summary>
		public InputBooleanEntity ResetCodeslotFrontdoor6 => new(_haContext, "input_boolean.reset_codeslot_frontdoor_6");
		///<summary>Reset Code Slot</summary>
		public InputBooleanEntity ResetCodeslotFrontdoor7 => new(_haContext, "input_boolean.reset_codeslot_frontdoor_7");
		///<summary>Reset Code Slot</summary>
		public InputBooleanEntity ResetCodeslotFrontdoor8 => new(_haContext, "input_boolean.reset_codeslot_frontdoor_8");
		///<summary>Reset Code Slot</summary>
		public InputBooleanEntity ResetCodeslotFrontdoor9 => new(_haContext, "input_boolean.reset_codeslot_frontdoor_9");
		///<summary>Saturday</summary>
		public InputBooleanEntity SatFrontdoor1 => new(_haContext, "input_boolean.sat_frontdoor_1");
		///<summary>Saturday</summary>
		public InputBooleanEntity SatFrontdoor10 => new(_haContext, "input_boolean.sat_frontdoor_10");
		///<summary>Saturday</summary>
		public InputBooleanEntity SatFrontdoor2 => new(_haContext, "input_boolean.sat_frontdoor_2");
		///<summary>Saturday</summary>
		public InputBooleanEntity SatFrontdoor3 => new(_haContext, "input_boolean.sat_frontdoor_3");
		///<summary>Saturday</summary>
		public InputBooleanEntity SatFrontdoor4 => new(_haContext, "input_boolean.sat_frontdoor_4");
		///<summary>Saturday</summary>
		public InputBooleanEntity SatFrontdoor5 => new(_haContext, "input_boolean.sat_frontdoor_5");
		///<summary>Saturday</summary>
		public InputBooleanEntity SatFrontdoor6 => new(_haContext, "input_boolean.sat_frontdoor_6");
		///<summary>Saturday</summary>
		public InputBooleanEntity SatFrontdoor7 => new(_haContext, "input_boolean.sat_frontdoor_7");
		///<summary>Saturday</summary>
		public InputBooleanEntity SatFrontdoor8 => new(_haContext, "input_boolean.sat_frontdoor_8");
		///<summary>Saturday</summary>
		public InputBooleanEntity SatFrontdoor9 => new(_haContext, "input_boolean.sat_frontdoor_9");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SatIncFrontdoor1 => new(_haContext, "input_boolean.sat_inc_frontdoor_1");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SatIncFrontdoor10 => new(_haContext, "input_boolean.sat_inc_frontdoor_10");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SatIncFrontdoor2 => new(_haContext, "input_boolean.sat_inc_frontdoor_2");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SatIncFrontdoor3 => new(_haContext, "input_boolean.sat_inc_frontdoor_3");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SatIncFrontdoor4 => new(_haContext, "input_boolean.sat_inc_frontdoor_4");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SatIncFrontdoor5 => new(_haContext, "input_boolean.sat_inc_frontdoor_5");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SatIncFrontdoor6 => new(_haContext, "input_boolean.sat_inc_frontdoor_6");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SatIncFrontdoor7 => new(_haContext, "input_boolean.sat_inc_frontdoor_7");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SatIncFrontdoor8 => new(_haContext, "input_boolean.sat_inc_frontdoor_8");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SatIncFrontdoor9 => new(_haContext, "input_boolean.sat_inc_frontdoor_9");
		///<summary>Sunday</summary>
		public InputBooleanEntity SunFrontdoor1 => new(_haContext, "input_boolean.sun_frontdoor_1");
		///<summary>Sunday</summary>
		public InputBooleanEntity SunFrontdoor10 => new(_haContext, "input_boolean.sun_frontdoor_10");
		///<summary>Sunday</summary>
		public InputBooleanEntity SunFrontdoor2 => new(_haContext, "input_boolean.sun_frontdoor_2");
		///<summary>Sunday</summary>
		public InputBooleanEntity SunFrontdoor3 => new(_haContext, "input_boolean.sun_frontdoor_3");
		///<summary>Sunday</summary>
		public InputBooleanEntity SunFrontdoor4 => new(_haContext, "input_boolean.sun_frontdoor_4");
		///<summary>Sunday</summary>
		public InputBooleanEntity SunFrontdoor5 => new(_haContext, "input_boolean.sun_frontdoor_5");
		///<summary>Sunday</summary>
		public InputBooleanEntity SunFrontdoor6 => new(_haContext, "input_boolean.sun_frontdoor_6");
		///<summary>Sunday</summary>
		public InputBooleanEntity SunFrontdoor7 => new(_haContext, "input_boolean.sun_frontdoor_7");
		///<summary>Sunday</summary>
		public InputBooleanEntity SunFrontdoor8 => new(_haContext, "input_boolean.sun_frontdoor_8");
		///<summary>Sunday</summary>
		public InputBooleanEntity SunFrontdoor9 => new(_haContext, "input_boolean.sun_frontdoor_9");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SunIncFrontdoor1 => new(_haContext, "input_boolean.sun_inc_frontdoor_1");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SunIncFrontdoor10 => new(_haContext, "input_boolean.sun_inc_frontdoor_10");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SunIncFrontdoor2 => new(_haContext, "input_boolean.sun_inc_frontdoor_2");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SunIncFrontdoor3 => new(_haContext, "input_boolean.sun_inc_frontdoor_3");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SunIncFrontdoor4 => new(_haContext, "input_boolean.sun_inc_frontdoor_4");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SunIncFrontdoor5 => new(_haContext, "input_boolean.sun_inc_frontdoor_5");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SunIncFrontdoor6 => new(_haContext, "input_boolean.sun_inc_frontdoor_6");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SunIncFrontdoor7 => new(_haContext, "input_boolean.sun_inc_frontdoor_7");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SunIncFrontdoor8 => new(_haContext, "input_boolean.sun_inc_frontdoor_8");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity SunIncFrontdoor9 => new(_haContext, "input_boolean.sun_inc_frontdoor_9");
		///<summary>Thursday</summary>
		public InputBooleanEntity ThuFrontdoor1 => new(_haContext, "input_boolean.thu_frontdoor_1");
		///<summary>Thursday</summary>
		public InputBooleanEntity ThuFrontdoor10 => new(_haContext, "input_boolean.thu_frontdoor_10");
		///<summary>Thursday</summary>
		public InputBooleanEntity ThuFrontdoor2 => new(_haContext, "input_boolean.thu_frontdoor_2");
		///<summary>Thursday</summary>
		public InputBooleanEntity ThuFrontdoor3 => new(_haContext, "input_boolean.thu_frontdoor_3");
		///<summary>Thursday</summary>
		public InputBooleanEntity ThuFrontdoor4 => new(_haContext, "input_boolean.thu_frontdoor_4");
		///<summary>Thursday</summary>
		public InputBooleanEntity ThuFrontdoor5 => new(_haContext, "input_boolean.thu_frontdoor_5");
		///<summary>Thursday</summary>
		public InputBooleanEntity ThuFrontdoor6 => new(_haContext, "input_boolean.thu_frontdoor_6");
		///<summary>Thursday</summary>
		public InputBooleanEntity ThuFrontdoor7 => new(_haContext, "input_boolean.thu_frontdoor_7");
		///<summary>Thursday</summary>
		public InputBooleanEntity ThuFrontdoor8 => new(_haContext, "input_boolean.thu_frontdoor_8");
		///<summary>Thursday</summary>
		public InputBooleanEntity ThuFrontdoor9 => new(_haContext, "input_boolean.thu_frontdoor_9");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity ThuIncFrontdoor1 => new(_haContext, "input_boolean.thu_inc_frontdoor_1");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity ThuIncFrontdoor10 => new(_haContext, "input_boolean.thu_inc_frontdoor_10");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity ThuIncFrontdoor2 => new(_haContext, "input_boolean.thu_inc_frontdoor_2");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity ThuIncFrontdoor3 => new(_haContext, "input_boolean.thu_inc_frontdoor_3");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity ThuIncFrontdoor4 => new(_haContext, "input_boolean.thu_inc_frontdoor_4");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity ThuIncFrontdoor5 => new(_haContext, "input_boolean.thu_inc_frontdoor_5");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity ThuIncFrontdoor6 => new(_haContext, "input_boolean.thu_inc_frontdoor_6");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity ThuIncFrontdoor7 => new(_haContext, "input_boolean.thu_inc_frontdoor_7");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity ThuIncFrontdoor8 => new(_haContext, "input_boolean.thu_inc_frontdoor_8");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity ThuIncFrontdoor9 => new(_haContext, "input_boolean.thu_inc_frontdoor_9");
		///<summary>Tuesday</summary>
		public InputBooleanEntity TueFrontdoor1 => new(_haContext, "input_boolean.tue_frontdoor_1");
		///<summary>Tuesday</summary>
		public InputBooleanEntity TueFrontdoor10 => new(_haContext, "input_boolean.tue_frontdoor_10");
		///<summary>Tuesday</summary>
		public InputBooleanEntity TueFrontdoor2 => new(_haContext, "input_boolean.tue_frontdoor_2");
		///<summary>Tuesday</summary>
		public InputBooleanEntity TueFrontdoor3 => new(_haContext, "input_boolean.tue_frontdoor_3");
		///<summary>Tuesday</summary>
		public InputBooleanEntity TueFrontdoor4 => new(_haContext, "input_boolean.tue_frontdoor_4");
		///<summary>Tuesday</summary>
		public InputBooleanEntity TueFrontdoor5 => new(_haContext, "input_boolean.tue_frontdoor_5");
		///<summary>Tuesday</summary>
		public InputBooleanEntity TueFrontdoor6 => new(_haContext, "input_boolean.tue_frontdoor_6");
		///<summary>Tuesday</summary>
		public InputBooleanEntity TueFrontdoor7 => new(_haContext, "input_boolean.tue_frontdoor_7");
		///<summary>Tuesday</summary>
		public InputBooleanEntity TueFrontdoor8 => new(_haContext, "input_boolean.tue_frontdoor_8");
		///<summary>Tuesday</summary>
		public InputBooleanEntity TueFrontdoor9 => new(_haContext, "input_boolean.tue_frontdoor_9");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity TueIncFrontdoor1 => new(_haContext, "input_boolean.tue_inc_frontdoor_1");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity TueIncFrontdoor10 => new(_haContext, "input_boolean.tue_inc_frontdoor_10");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity TueIncFrontdoor2 => new(_haContext, "input_boolean.tue_inc_frontdoor_2");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity TueIncFrontdoor3 => new(_haContext, "input_boolean.tue_inc_frontdoor_3");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity TueIncFrontdoor4 => new(_haContext, "input_boolean.tue_inc_frontdoor_4");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity TueIncFrontdoor5 => new(_haContext, "input_boolean.tue_inc_frontdoor_5");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity TueIncFrontdoor6 => new(_haContext, "input_boolean.tue_inc_frontdoor_6");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity TueIncFrontdoor7 => new(_haContext, "input_boolean.tue_inc_frontdoor_7");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity TueIncFrontdoor8 => new(_haContext, "input_boolean.tue_inc_frontdoor_8");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity TueIncFrontdoor9 => new(_haContext, "input_boolean.tue_inc_frontdoor_9");
		///<summary>Wednesday</summary>
		public InputBooleanEntity WedFrontdoor1 => new(_haContext, "input_boolean.wed_frontdoor_1");
		///<summary>Wednesday</summary>
		public InputBooleanEntity WedFrontdoor10 => new(_haContext, "input_boolean.wed_frontdoor_10");
		///<summary>Wednesday</summary>
		public InputBooleanEntity WedFrontdoor2 => new(_haContext, "input_boolean.wed_frontdoor_2");
		///<summary>Wednesday</summary>
		public InputBooleanEntity WedFrontdoor3 => new(_haContext, "input_boolean.wed_frontdoor_3");
		///<summary>Wednesday</summary>
		public InputBooleanEntity WedFrontdoor4 => new(_haContext, "input_boolean.wed_frontdoor_4");
		///<summary>Wednesday</summary>
		public InputBooleanEntity WedFrontdoor5 => new(_haContext, "input_boolean.wed_frontdoor_5");
		///<summary>Wednesday</summary>
		public InputBooleanEntity WedFrontdoor6 => new(_haContext, "input_boolean.wed_frontdoor_6");
		///<summary>Wednesday</summary>
		public InputBooleanEntity WedFrontdoor7 => new(_haContext, "input_boolean.wed_frontdoor_7");
		///<summary>Wednesday</summary>
		public InputBooleanEntity WedFrontdoor8 => new(_haContext, "input_boolean.wed_frontdoor_8");
		///<summary>Wednesday</summary>
		public InputBooleanEntity WedFrontdoor9 => new(_haContext, "input_boolean.wed_frontdoor_9");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity WedIncFrontdoor1 => new(_haContext, "input_boolean.wed_inc_frontdoor_1");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity WedIncFrontdoor10 => new(_haContext, "input_boolean.wed_inc_frontdoor_10");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity WedIncFrontdoor2 => new(_haContext, "input_boolean.wed_inc_frontdoor_2");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity WedIncFrontdoor3 => new(_haContext, "input_boolean.wed_inc_frontdoor_3");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity WedIncFrontdoor4 => new(_haContext, "input_boolean.wed_inc_frontdoor_4");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity WedIncFrontdoor5 => new(_haContext, "input_boolean.wed_inc_frontdoor_5");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity WedIncFrontdoor6 => new(_haContext, "input_boolean.wed_inc_frontdoor_6");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity WedIncFrontdoor7 => new(_haContext, "input_boolean.wed_inc_frontdoor_7");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity WedIncFrontdoor8 => new(_haContext, "input_boolean.wed_inc_frontdoor_8");
		///<summary>include (on)/exclude (off)</summary>
		public InputBooleanEntity WedIncFrontdoor9 => new(_haContext, "input_boolean.wed_inc_frontdoor_9");
	}

	public class InputDatetimeEntities
	{
		private readonly IHaContext _haContext;
		public InputDatetimeEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>End</summary>
		public InputDatetimeEntity EndDateFrontdoor1 => new(_haContext, "input_datetime.end_date_frontdoor_1");
		///<summary>End</summary>
		public InputDatetimeEntity EndDateFrontdoor10 => new(_haContext, "input_datetime.end_date_frontdoor_10");
		///<summary>End</summary>
		public InputDatetimeEntity EndDateFrontdoor2 => new(_haContext, "input_datetime.end_date_frontdoor_2");
		///<summary>End</summary>
		public InputDatetimeEntity EndDateFrontdoor3 => new(_haContext, "input_datetime.end_date_frontdoor_3");
		///<summary>End</summary>
		public InputDatetimeEntity EndDateFrontdoor4 => new(_haContext, "input_datetime.end_date_frontdoor_4");
		///<summary>End</summary>
		public InputDatetimeEntity EndDateFrontdoor5 => new(_haContext, "input_datetime.end_date_frontdoor_5");
		///<summary>End</summary>
		public InputDatetimeEntity EndDateFrontdoor6 => new(_haContext, "input_datetime.end_date_frontdoor_6");
		///<summary>End</summary>
		public InputDatetimeEntity EndDateFrontdoor7 => new(_haContext, "input_datetime.end_date_frontdoor_7");
		///<summary>End</summary>
		public InputDatetimeEntity EndDateFrontdoor8 => new(_haContext, "input_datetime.end_date_frontdoor_8");
		///<summary>End</summary>
		public InputDatetimeEntity EndDateFrontdoor9 => new(_haContext, "input_datetime.end_date_frontdoor_9");
		///<summary>End</summary>
		public InputDatetimeEntity FriEndDateFrontdoor1 => new(_haContext, "input_datetime.fri_end_date_frontdoor_1");
		///<summary>End</summary>
		public InputDatetimeEntity FriEndDateFrontdoor10 => new(_haContext, "input_datetime.fri_end_date_frontdoor_10");
		///<summary>End</summary>
		public InputDatetimeEntity FriEndDateFrontdoor2 => new(_haContext, "input_datetime.fri_end_date_frontdoor_2");
		///<summary>End</summary>
		public InputDatetimeEntity FriEndDateFrontdoor3 => new(_haContext, "input_datetime.fri_end_date_frontdoor_3");
		///<summary>End</summary>
		public InputDatetimeEntity FriEndDateFrontdoor4 => new(_haContext, "input_datetime.fri_end_date_frontdoor_4");
		///<summary>End</summary>
		public InputDatetimeEntity FriEndDateFrontdoor5 => new(_haContext, "input_datetime.fri_end_date_frontdoor_5");
		///<summary>End</summary>
		public InputDatetimeEntity FriEndDateFrontdoor6 => new(_haContext, "input_datetime.fri_end_date_frontdoor_6");
		///<summary>End</summary>
		public InputDatetimeEntity FriEndDateFrontdoor7 => new(_haContext, "input_datetime.fri_end_date_frontdoor_7");
		///<summary>End</summary>
		public InputDatetimeEntity FriEndDateFrontdoor8 => new(_haContext, "input_datetime.fri_end_date_frontdoor_8");
		///<summary>End</summary>
		public InputDatetimeEntity FriEndDateFrontdoor9 => new(_haContext, "input_datetime.fri_end_date_frontdoor_9");
		///<summary>Start</summary>
		public InputDatetimeEntity FriStartDateFrontdoor1 => new(_haContext, "input_datetime.fri_start_date_frontdoor_1");
		///<summary>Start</summary>
		public InputDatetimeEntity FriStartDateFrontdoor10 => new(_haContext, "input_datetime.fri_start_date_frontdoor_10");
		///<summary>Start</summary>
		public InputDatetimeEntity FriStartDateFrontdoor2 => new(_haContext, "input_datetime.fri_start_date_frontdoor_2");
		///<summary>Start</summary>
		public InputDatetimeEntity FriStartDateFrontdoor3 => new(_haContext, "input_datetime.fri_start_date_frontdoor_3");
		///<summary>Start</summary>
		public InputDatetimeEntity FriStartDateFrontdoor4 => new(_haContext, "input_datetime.fri_start_date_frontdoor_4");
		///<summary>Start</summary>
		public InputDatetimeEntity FriStartDateFrontdoor5 => new(_haContext, "input_datetime.fri_start_date_frontdoor_5");
		///<summary>Start</summary>
		public InputDatetimeEntity FriStartDateFrontdoor6 => new(_haContext, "input_datetime.fri_start_date_frontdoor_6");
		///<summary>Start</summary>
		public InputDatetimeEntity FriStartDateFrontdoor7 => new(_haContext, "input_datetime.fri_start_date_frontdoor_7");
		///<summary>Start</summary>
		public InputDatetimeEntity FriStartDateFrontdoor8 => new(_haContext, "input_datetime.fri_start_date_frontdoor_8");
		///<summary>Start</summary>
		public InputDatetimeEntity FriStartDateFrontdoor9 => new(_haContext, "input_datetime.fri_start_date_frontdoor_9");
		///<summary>End</summary>
		public InputDatetimeEntity MonEndDateFrontdoor1 => new(_haContext, "input_datetime.mon_end_date_frontdoor_1");
		///<summary>End</summary>
		public InputDatetimeEntity MonEndDateFrontdoor10 => new(_haContext, "input_datetime.mon_end_date_frontdoor_10");
		///<summary>End</summary>
		public InputDatetimeEntity MonEndDateFrontdoor2 => new(_haContext, "input_datetime.mon_end_date_frontdoor_2");
		///<summary>End</summary>
		public InputDatetimeEntity MonEndDateFrontdoor3 => new(_haContext, "input_datetime.mon_end_date_frontdoor_3");
		///<summary>End</summary>
		public InputDatetimeEntity MonEndDateFrontdoor4 => new(_haContext, "input_datetime.mon_end_date_frontdoor_4");
		///<summary>End</summary>
		public InputDatetimeEntity MonEndDateFrontdoor5 => new(_haContext, "input_datetime.mon_end_date_frontdoor_5");
		///<summary>End</summary>
		public InputDatetimeEntity MonEndDateFrontdoor6 => new(_haContext, "input_datetime.mon_end_date_frontdoor_6");
		///<summary>End</summary>
		public InputDatetimeEntity MonEndDateFrontdoor7 => new(_haContext, "input_datetime.mon_end_date_frontdoor_7");
		///<summary>End</summary>
		public InputDatetimeEntity MonEndDateFrontdoor8 => new(_haContext, "input_datetime.mon_end_date_frontdoor_8");
		///<summary>End</summary>
		public InputDatetimeEntity MonEndDateFrontdoor9 => new(_haContext, "input_datetime.mon_end_date_frontdoor_9");
		///<summary>Start</summary>
		public InputDatetimeEntity MonStartDateFrontdoor1 => new(_haContext, "input_datetime.mon_start_date_frontdoor_1");
		///<summary>Start</summary>
		public InputDatetimeEntity MonStartDateFrontdoor10 => new(_haContext, "input_datetime.mon_start_date_frontdoor_10");
		///<summary>Start</summary>
		public InputDatetimeEntity MonStartDateFrontdoor2 => new(_haContext, "input_datetime.mon_start_date_frontdoor_2");
		///<summary>Start</summary>
		public InputDatetimeEntity MonStartDateFrontdoor3 => new(_haContext, "input_datetime.mon_start_date_frontdoor_3");
		///<summary>Start</summary>
		public InputDatetimeEntity MonStartDateFrontdoor4 => new(_haContext, "input_datetime.mon_start_date_frontdoor_4");
		///<summary>Start</summary>
		public InputDatetimeEntity MonStartDateFrontdoor5 => new(_haContext, "input_datetime.mon_start_date_frontdoor_5");
		///<summary>Start</summary>
		public InputDatetimeEntity MonStartDateFrontdoor6 => new(_haContext, "input_datetime.mon_start_date_frontdoor_6");
		///<summary>Start</summary>
		public InputDatetimeEntity MonStartDateFrontdoor7 => new(_haContext, "input_datetime.mon_start_date_frontdoor_7");
		///<summary>Start</summary>
		public InputDatetimeEntity MonStartDateFrontdoor8 => new(_haContext, "input_datetime.mon_start_date_frontdoor_8");
		///<summary>Start</summary>
		public InputDatetimeEntity MonStartDateFrontdoor9 => new(_haContext, "input_datetime.mon_start_date_frontdoor_9");
		///<summary>End</summary>
		public InputDatetimeEntity SatEndDateFrontdoor1 => new(_haContext, "input_datetime.sat_end_date_frontdoor_1");
		///<summary>End</summary>
		public InputDatetimeEntity SatEndDateFrontdoor10 => new(_haContext, "input_datetime.sat_end_date_frontdoor_10");
		///<summary>End</summary>
		public InputDatetimeEntity SatEndDateFrontdoor2 => new(_haContext, "input_datetime.sat_end_date_frontdoor_2");
		///<summary>End</summary>
		public InputDatetimeEntity SatEndDateFrontdoor3 => new(_haContext, "input_datetime.sat_end_date_frontdoor_3");
		///<summary>End</summary>
		public InputDatetimeEntity SatEndDateFrontdoor4 => new(_haContext, "input_datetime.sat_end_date_frontdoor_4");
		///<summary>End</summary>
		public InputDatetimeEntity SatEndDateFrontdoor5 => new(_haContext, "input_datetime.sat_end_date_frontdoor_5");
		///<summary>End</summary>
		public InputDatetimeEntity SatEndDateFrontdoor6 => new(_haContext, "input_datetime.sat_end_date_frontdoor_6");
		///<summary>End</summary>
		public InputDatetimeEntity SatEndDateFrontdoor7 => new(_haContext, "input_datetime.sat_end_date_frontdoor_7");
		///<summary>End</summary>
		public InputDatetimeEntity SatEndDateFrontdoor8 => new(_haContext, "input_datetime.sat_end_date_frontdoor_8");
		///<summary>End</summary>
		public InputDatetimeEntity SatEndDateFrontdoor9 => new(_haContext, "input_datetime.sat_end_date_frontdoor_9");
		///<summary>Start</summary>
		public InputDatetimeEntity SatStartDateFrontdoor1 => new(_haContext, "input_datetime.sat_start_date_frontdoor_1");
		///<summary>Start</summary>
		public InputDatetimeEntity SatStartDateFrontdoor10 => new(_haContext, "input_datetime.sat_start_date_frontdoor_10");
		///<summary>Start</summary>
		public InputDatetimeEntity SatStartDateFrontdoor2 => new(_haContext, "input_datetime.sat_start_date_frontdoor_2");
		///<summary>Start</summary>
		public InputDatetimeEntity SatStartDateFrontdoor3 => new(_haContext, "input_datetime.sat_start_date_frontdoor_3");
		///<summary>Start</summary>
		public InputDatetimeEntity SatStartDateFrontdoor4 => new(_haContext, "input_datetime.sat_start_date_frontdoor_4");
		///<summary>Start</summary>
		public InputDatetimeEntity SatStartDateFrontdoor5 => new(_haContext, "input_datetime.sat_start_date_frontdoor_5");
		///<summary>Start</summary>
		public InputDatetimeEntity SatStartDateFrontdoor6 => new(_haContext, "input_datetime.sat_start_date_frontdoor_6");
		///<summary>Start</summary>
		public InputDatetimeEntity SatStartDateFrontdoor7 => new(_haContext, "input_datetime.sat_start_date_frontdoor_7");
		///<summary>Start</summary>
		public InputDatetimeEntity SatStartDateFrontdoor8 => new(_haContext, "input_datetime.sat_start_date_frontdoor_8");
		///<summary>Start</summary>
		public InputDatetimeEntity SatStartDateFrontdoor9 => new(_haContext, "input_datetime.sat_start_date_frontdoor_9");
		///<summary>Start</summary>
		public InputDatetimeEntity StartDateFrontdoor1 => new(_haContext, "input_datetime.start_date_frontdoor_1");
		///<summary>Start</summary>
		public InputDatetimeEntity StartDateFrontdoor10 => new(_haContext, "input_datetime.start_date_frontdoor_10");
		///<summary>Start</summary>
		public InputDatetimeEntity StartDateFrontdoor2 => new(_haContext, "input_datetime.start_date_frontdoor_2");
		///<summary>Start</summary>
		public InputDatetimeEntity StartDateFrontdoor3 => new(_haContext, "input_datetime.start_date_frontdoor_3");
		///<summary>Start</summary>
		public InputDatetimeEntity StartDateFrontdoor4 => new(_haContext, "input_datetime.start_date_frontdoor_4");
		///<summary>Start</summary>
		public InputDatetimeEntity StartDateFrontdoor5 => new(_haContext, "input_datetime.start_date_frontdoor_5");
		///<summary>Start</summary>
		public InputDatetimeEntity StartDateFrontdoor6 => new(_haContext, "input_datetime.start_date_frontdoor_6");
		///<summary>Start</summary>
		public InputDatetimeEntity StartDateFrontdoor7 => new(_haContext, "input_datetime.start_date_frontdoor_7");
		///<summary>Start</summary>
		public InputDatetimeEntity StartDateFrontdoor8 => new(_haContext, "input_datetime.start_date_frontdoor_8");
		///<summary>Start</summary>
		public InputDatetimeEntity StartDateFrontdoor9 => new(_haContext, "input_datetime.start_date_frontdoor_9");
		///<summary>End</summary>
		public InputDatetimeEntity SunEndDateFrontdoor1 => new(_haContext, "input_datetime.sun_end_date_frontdoor_1");
		///<summary>End</summary>
		public InputDatetimeEntity SunEndDateFrontdoor10 => new(_haContext, "input_datetime.sun_end_date_frontdoor_10");
		///<summary>End</summary>
		public InputDatetimeEntity SunEndDateFrontdoor2 => new(_haContext, "input_datetime.sun_end_date_frontdoor_2");
		///<summary>End</summary>
		public InputDatetimeEntity SunEndDateFrontdoor3 => new(_haContext, "input_datetime.sun_end_date_frontdoor_3");
		///<summary>End</summary>
		public InputDatetimeEntity SunEndDateFrontdoor4 => new(_haContext, "input_datetime.sun_end_date_frontdoor_4");
		///<summary>End</summary>
		public InputDatetimeEntity SunEndDateFrontdoor5 => new(_haContext, "input_datetime.sun_end_date_frontdoor_5");
		///<summary>End</summary>
		public InputDatetimeEntity SunEndDateFrontdoor6 => new(_haContext, "input_datetime.sun_end_date_frontdoor_6");
		///<summary>End</summary>
		public InputDatetimeEntity SunEndDateFrontdoor7 => new(_haContext, "input_datetime.sun_end_date_frontdoor_7");
		///<summary>End</summary>
		public InputDatetimeEntity SunEndDateFrontdoor8 => new(_haContext, "input_datetime.sun_end_date_frontdoor_8");
		///<summary>End</summary>
		public InputDatetimeEntity SunEndDateFrontdoor9 => new(_haContext, "input_datetime.sun_end_date_frontdoor_9");
		///<summary>Start</summary>
		public InputDatetimeEntity SunStartDateFrontdoor1 => new(_haContext, "input_datetime.sun_start_date_frontdoor_1");
		///<summary>Start</summary>
		public InputDatetimeEntity SunStartDateFrontdoor10 => new(_haContext, "input_datetime.sun_start_date_frontdoor_10");
		///<summary>Start</summary>
		public InputDatetimeEntity SunStartDateFrontdoor2 => new(_haContext, "input_datetime.sun_start_date_frontdoor_2");
		///<summary>Start</summary>
		public InputDatetimeEntity SunStartDateFrontdoor3 => new(_haContext, "input_datetime.sun_start_date_frontdoor_3");
		///<summary>Start</summary>
		public InputDatetimeEntity SunStartDateFrontdoor4 => new(_haContext, "input_datetime.sun_start_date_frontdoor_4");
		///<summary>Start</summary>
		public InputDatetimeEntity SunStartDateFrontdoor5 => new(_haContext, "input_datetime.sun_start_date_frontdoor_5");
		///<summary>Start</summary>
		public InputDatetimeEntity SunStartDateFrontdoor6 => new(_haContext, "input_datetime.sun_start_date_frontdoor_6");
		///<summary>Start</summary>
		public InputDatetimeEntity SunStartDateFrontdoor7 => new(_haContext, "input_datetime.sun_start_date_frontdoor_7");
		///<summary>Start</summary>
		public InputDatetimeEntity SunStartDateFrontdoor8 => new(_haContext, "input_datetime.sun_start_date_frontdoor_8");
		///<summary>Start</summary>
		public InputDatetimeEntity SunStartDateFrontdoor9 => new(_haContext, "input_datetime.sun_start_date_frontdoor_9");
		///<summary>End</summary>
		public InputDatetimeEntity ThuEndDateFrontdoor1 => new(_haContext, "input_datetime.thu_end_date_frontdoor_1");
		///<summary>End</summary>
		public InputDatetimeEntity ThuEndDateFrontdoor10 => new(_haContext, "input_datetime.thu_end_date_frontdoor_10");
		///<summary>End</summary>
		public InputDatetimeEntity ThuEndDateFrontdoor2 => new(_haContext, "input_datetime.thu_end_date_frontdoor_2");
		///<summary>End</summary>
		public InputDatetimeEntity ThuEndDateFrontdoor3 => new(_haContext, "input_datetime.thu_end_date_frontdoor_3");
		///<summary>End</summary>
		public InputDatetimeEntity ThuEndDateFrontdoor4 => new(_haContext, "input_datetime.thu_end_date_frontdoor_4");
		///<summary>End</summary>
		public InputDatetimeEntity ThuEndDateFrontdoor5 => new(_haContext, "input_datetime.thu_end_date_frontdoor_5");
		///<summary>End</summary>
		public InputDatetimeEntity ThuEndDateFrontdoor6 => new(_haContext, "input_datetime.thu_end_date_frontdoor_6");
		///<summary>End</summary>
		public InputDatetimeEntity ThuEndDateFrontdoor7 => new(_haContext, "input_datetime.thu_end_date_frontdoor_7");
		///<summary>End</summary>
		public InputDatetimeEntity ThuEndDateFrontdoor8 => new(_haContext, "input_datetime.thu_end_date_frontdoor_8");
		///<summary>End</summary>
		public InputDatetimeEntity ThuEndDateFrontdoor9 => new(_haContext, "input_datetime.thu_end_date_frontdoor_9");
		///<summary>Start</summary>
		public InputDatetimeEntity ThuStartDateFrontdoor1 => new(_haContext, "input_datetime.thu_start_date_frontdoor_1");
		///<summary>Start</summary>
		public InputDatetimeEntity ThuStartDateFrontdoor10 => new(_haContext, "input_datetime.thu_start_date_frontdoor_10");
		///<summary>Start</summary>
		public InputDatetimeEntity ThuStartDateFrontdoor2 => new(_haContext, "input_datetime.thu_start_date_frontdoor_2");
		///<summary>Start</summary>
		public InputDatetimeEntity ThuStartDateFrontdoor3 => new(_haContext, "input_datetime.thu_start_date_frontdoor_3");
		///<summary>Start</summary>
		public InputDatetimeEntity ThuStartDateFrontdoor4 => new(_haContext, "input_datetime.thu_start_date_frontdoor_4");
		///<summary>Start</summary>
		public InputDatetimeEntity ThuStartDateFrontdoor5 => new(_haContext, "input_datetime.thu_start_date_frontdoor_5");
		///<summary>Start</summary>
		public InputDatetimeEntity ThuStartDateFrontdoor6 => new(_haContext, "input_datetime.thu_start_date_frontdoor_6");
		///<summary>Start</summary>
		public InputDatetimeEntity ThuStartDateFrontdoor7 => new(_haContext, "input_datetime.thu_start_date_frontdoor_7");
		///<summary>Start</summary>
		public InputDatetimeEntity ThuStartDateFrontdoor8 => new(_haContext, "input_datetime.thu_start_date_frontdoor_8");
		///<summary>Start</summary>
		public InputDatetimeEntity ThuStartDateFrontdoor9 => new(_haContext, "input_datetime.thu_start_date_frontdoor_9");
		///<summary>End</summary>
		public InputDatetimeEntity TueEndDateFrontdoor1 => new(_haContext, "input_datetime.tue_end_date_frontdoor_1");
		///<summary>End</summary>
		public InputDatetimeEntity TueEndDateFrontdoor10 => new(_haContext, "input_datetime.tue_end_date_frontdoor_10");
		///<summary>End</summary>
		public InputDatetimeEntity TueEndDateFrontdoor2 => new(_haContext, "input_datetime.tue_end_date_frontdoor_2");
		///<summary>End</summary>
		public InputDatetimeEntity TueEndDateFrontdoor3 => new(_haContext, "input_datetime.tue_end_date_frontdoor_3");
		///<summary>End</summary>
		public InputDatetimeEntity TueEndDateFrontdoor4 => new(_haContext, "input_datetime.tue_end_date_frontdoor_4");
		///<summary>End</summary>
		public InputDatetimeEntity TueEndDateFrontdoor5 => new(_haContext, "input_datetime.tue_end_date_frontdoor_5");
		///<summary>End</summary>
		public InputDatetimeEntity TueEndDateFrontdoor6 => new(_haContext, "input_datetime.tue_end_date_frontdoor_6");
		///<summary>End</summary>
		public InputDatetimeEntity TueEndDateFrontdoor7 => new(_haContext, "input_datetime.tue_end_date_frontdoor_7");
		///<summary>End</summary>
		public InputDatetimeEntity TueEndDateFrontdoor8 => new(_haContext, "input_datetime.tue_end_date_frontdoor_8");
		///<summary>End</summary>
		public InputDatetimeEntity TueEndDateFrontdoor9 => new(_haContext, "input_datetime.tue_end_date_frontdoor_9");
		///<summary>Start</summary>
		public InputDatetimeEntity TueStartDateFrontdoor1 => new(_haContext, "input_datetime.tue_start_date_frontdoor_1");
		///<summary>Start</summary>
		public InputDatetimeEntity TueStartDateFrontdoor10 => new(_haContext, "input_datetime.tue_start_date_frontdoor_10");
		///<summary>Start</summary>
		public InputDatetimeEntity TueStartDateFrontdoor2 => new(_haContext, "input_datetime.tue_start_date_frontdoor_2");
		///<summary>Start</summary>
		public InputDatetimeEntity TueStartDateFrontdoor3 => new(_haContext, "input_datetime.tue_start_date_frontdoor_3");
		///<summary>Start</summary>
		public InputDatetimeEntity TueStartDateFrontdoor4 => new(_haContext, "input_datetime.tue_start_date_frontdoor_4");
		///<summary>Start</summary>
		public InputDatetimeEntity TueStartDateFrontdoor5 => new(_haContext, "input_datetime.tue_start_date_frontdoor_5");
		///<summary>Start</summary>
		public InputDatetimeEntity TueStartDateFrontdoor6 => new(_haContext, "input_datetime.tue_start_date_frontdoor_6");
		///<summary>Start</summary>
		public InputDatetimeEntity TueStartDateFrontdoor7 => new(_haContext, "input_datetime.tue_start_date_frontdoor_7");
		///<summary>Start</summary>
		public InputDatetimeEntity TueStartDateFrontdoor8 => new(_haContext, "input_datetime.tue_start_date_frontdoor_8");
		///<summary>Start</summary>
		public InputDatetimeEntity TueStartDateFrontdoor9 => new(_haContext, "input_datetime.tue_start_date_frontdoor_9");
		///<summary>End</summary>
		public InputDatetimeEntity WedEndDateFrontdoor1 => new(_haContext, "input_datetime.wed_end_date_frontdoor_1");
		///<summary>End</summary>
		public InputDatetimeEntity WedEndDateFrontdoor10 => new(_haContext, "input_datetime.wed_end_date_frontdoor_10");
		///<summary>End</summary>
		public InputDatetimeEntity WedEndDateFrontdoor2 => new(_haContext, "input_datetime.wed_end_date_frontdoor_2");
		///<summary>End</summary>
		public InputDatetimeEntity WedEndDateFrontdoor3 => new(_haContext, "input_datetime.wed_end_date_frontdoor_3");
		///<summary>End</summary>
		public InputDatetimeEntity WedEndDateFrontdoor4 => new(_haContext, "input_datetime.wed_end_date_frontdoor_4");
		///<summary>End</summary>
		public InputDatetimeEntity WedEndDateFrontdoor5 => new(_haContext, "input_datetime.wed_end_date_frontdoor_5");
		///<summary>End</summary>
		public InputDatetimeEntity WedEndDateFrontdoor6 => new(_haContext, "input_datetime.wed_end_date_frontdoor_6");
		///<summary>End</summary>
		public InputDatetimeEntity WedEndDateFrontdoor7 => new(_haContext, "input_datetime.wed_end_date_frontdoor_7");
		///<summary>End</summary>
		public InputDatetimeEntity WedEndDateFrontdoor8 => new(_haContext, "input_datetime.wed_end_date_frontdoor_8");
		///<summary>End</summary>
		public InputDatetimeEntity WedEndDateFrontdoor9 => new(_haContext, "input_datetime.wed_end_date_frontdoor_9");
		///<summary>Start</summary>
		public InputDatetimeEntity WedStartDateFrontdoor1 => new(_haContext, "input_datetime.wed_start_date_frontdoor_1");
		///<summary>Start</summary>
		public InputDatetimeEntity WedStartDateFrontdoor10 => new(_haContext, "input_datetime.wed_start_date_frontdoor_10");
		///<summary>Start</summary>
		public InputDatetimeEntity WedStartDateFrontdoor2 => new(_haContext, "input_datetime.wed_start_date_frontdoor_2");
		///<summary>Start</summary>
		public InputDatetimeEntity WedStartDateFrontdoor3 => new(_haContext, "input_datetime.wed_start_date_frontdoor_3");
		///<summary>Start</summary>
		public InputDatetimeEntity WedStartDateFrontdoor4 => new(_haContext, "input_datetime.wed_start_date_frontdoor_4");
		///<summary>Start</summary>
		public InputDatetimeEntity WedStartDateFrontdoor5 => new(_haContext, "input_datetime.wed_start_date_frontdoor_5");
		///<summary>Start</summary>
		public InputDatetimeEntity WedStartDateFrontdoor6 => new(_haContext, "input_datetime.wed_start_date_frontdoor_6");
		///<summary>Start</summary>
		public InputDatetimeEntity WedStartDateFrontdoor7 => new(_haContext, "input_datetime.wed_start_date_frontdoor_7");
		///<summary>Start</summary>
		public InputDatetimeEntity WedStartDateFrontdoor8 => new(_haContext, "input_datetime.wed_start_date_frontdoor_8");
		///<summary>Start</summary>
		public InputDatetimeEntity WedStartDateFrontdoor9 => new(_haContext, "input_datetime.wed_start_date_frontdoor_9");
	}

	public class InputNumberEntities
	{
		private readonly IHaContext _haContext;
		public InputNumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Unlock events</summary>
		public InputNumberEntity AccesscountFrontdoor1 => new(_haContext, "input_number.accesscount_frontdoor_1");
		///<summary>Unlock events</summary>
		public InputNumberEntity AccesscountFrontdoor10 => new(_haContext, "input_number.accesscount_frontdoor_10");
		///<summary>Unlock events</summary>
		public InputNumberEntity AccesscountFrontdoor2 => new(_haContext, "input_number.accesscount_frontdoor_2");
		///<summary>Unlock events</summary>
		public InputNumberEntity AccesscountFrontdoor3 => new(_haContext, "input_number.accesscount_frontdoor_3");
		///<summary>Unlock events</summary>
		public InputNumberEntity AccesscountFrontdoor4 => new(_haContext, "input_number.accesscount_frontdoor_4");
		///<summary>Unlock events</summary>
		public InputNumberEntity AccesscountFrontdoor5 => new(_haContext, "input_number.accesscount_frontdoor_5");
		///<summary>Unlock events</summary>
		public InputNumberEntity AccesscountFrontdoor6 => new(_haContext, "input_number.accesscount_frontdoor_6");
		///<summary>Unlock events</summary>
		public InputNumberEntity AccesscountFrontdoor7 => new(_haContext, "input_number.accesscount_frontdoor_7");
		///<summary>Unlock events</summary>
		public InputNumberEntity AccesscountFrontdoor8 => new(_haContext, "input_number.accesscount_frontdoor_8");
		///<summary>Unlock events</summary>
		public InputNumberEntity AccesscountFrontdoor9 => new(_haContext, "input_number.accesscount_frontdoor_9");
	}

	public class InputTextEntities
	{
		private readonly IHaContext _haContext;
		public InputTextEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lock Name</summary>
		public InputTextEntity FrontdoorLockname => new(_haContext, "input_text.frontdoor_lockname");
		///<summary>Name</summary>
		public InputTextEntity FrontdoorName1 => new(_haContext, "input_text.frontdoor_name_1");
		///<summary>Name</summary>
		public InputTextEntity FrontdoorName10 => new(_haContext, "input_text.frontdoor_name_10");
		///<summary>Name</summary>
		public InputTextEntity FrontdoorName2 => new(_haContext, "input_text.frontdoor_name_2");
		///<summary>Name</summary>
		public InputTextEntity FrontdoorName3 => new(_haContext, "input_text.frontdoor_name_3");
		///<summary>Name</summary>
		public InputTextEntity FrontdoorName4 => new(_haContext, "input_text.frontdoor_name_4");
		///<summary>Name</summary>
		public InputTextEntity FrontdoorName5 => new(_haContext, "input_text.frontdoor_name_5");
		///<summary>Name</summary>
		public InputTextEntity FrontdoorName6 => new(_haContext, "input_text.frontdoor_name_6");
		///<summary>Name</summary>
		public InputTextEntity FrontdoorName7 => new(_haContext, "input_text.frontdoor_name_7");
		///<summary>Name</summary>
		public InputTextEntity FrontdoorName8 => new(_haContext, "input_text.frontdoor_name_8");
		///<summary>Name</summary>
		public InputTextEntity FrontdoorName9 => new(_haContext, "input_text.frontdoor_name_9");
		///<summary>PIN</summary>
		public InputTextEntity FrontdoorPin1 => new(_haContext, "input_text.frontdoor_pin_1");
		///<summary>PIN</summary>
		public InputTextEntity FrontdoorPin10 => new(_haContext, "input_text.frontdoor_pin_10");
		///<summary>PIN</summary>
		public InputTextEntity FrontdoorPin2 => new(_haContext, "input_text.frontdoor_pin_2");
		///<summary>PIN</summary>
		public InputTextEntity FrontdoorPin3 => new(_haContext, "input_text.frontdoor_pin_3");
		///<summary>PIN</summary>
		public InputTextEntity FrontdoorPin4 => new(_haContext, "input_text.frontdoor_pin_4");
		///<summary>PIN</summary>
		public InputTextEntity FrontdoorPin5 => new(_haContext, "input_text.frontdoor_pin_5");
		///<summary>PIN</summary>
		public InputTextEntity FrontdoorPin6 => new(_haContext, "input_text.frontdoor_pin_6");
		///<summary>PIN</summary>
		public InputTextEntity FrontdoorPin7 => new(_haContext, "input_text.frontdoor_pin_7");
		///<summary>PIN</summary>
		public InputTextEntity FrontdoorPin8 => new(_haContext, "input_text.frontdoor_pin_8");
		///<summary>PIN</summary>
		public InputTextEntity FrontdoorPin9 => new(_haContext, "input_text.frontdoor_pin_9");
		///<summary>Day Auto Lock HH:MM:SS</summary>
		public InputTextEntity KeymasterFrontdoorAutolockDoorTimeDay => new(_haContext, "input_text.keymaster_frontdoor_autolock_door_time_day");
		///<summary>Night Auto Lock HH:MM:SS</summary>
		public InputTextEntity KeymasterFrontdoorAutolockDoorTimeNight => new(_haContext, "input_text.keymaster_frontdoor_autolock_door_time_night");
	}

	public class LightEntities
	{
		private readonly IHaContext _haContext;
		public LightEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Franco Bathroom on_off</summary>
		public LightEntity FrancoBathroomOnOff => new(_haContext, "light.franco_bathroom_on_off");
	}

	public class LockEntities
	{
		private readonly IHaContext _haContext;
		public LockEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>boltchecked_frontdoor</summary>
		public LockEntity BoltcheckedFrontdoor => new(_haContext, "lock.boltchecked_frontdoor");
		///<summary>Front Door Lock</summary>
		public LockEntity FrontDoorLock => new(_haContext, "lock.front_door_lock");
	}

	public class MediaPlayerEntities
	{
		private readonly IHaContext _haContext;
		public MediaPlayerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Antonella</summary>
		public MediaPlayerEntity Antonella => new(_haContext, "media_player.antonella");
		///<summary>Camila</summary>
		public MediaPlayerEntity Camila => new(_haContext, "media_player.camila");
		///<summary>El Fire de Mariela</summary>
		public MediaPlayerEntity ElFireDeMariela => new(_haContext, "media_player.el_fire_de_mariela");
		///<summary>Everywhere</summary>
		public MediaPlayerEntity Everywhere => new(_haContext, "media_player.everywhere");
		///<summary>Kitchen</summary>
		public MediaPlayerEntity Kitchen => new(_haContext, "media_player.kitchen");
		///<summary>LG 65</summary>
		public MediaPlayerEntity Lg65 => new(_haContext, "media_player.lg_65");
		///<summary>Luciano's 3rd Echo Dot</summary>
		public MediaPlayerEntity LucianoS3rdEchoDot => new(_haContext, "media_player.luciano_s_3rd_echo_dot");
		///<summary>Luciano's Alexa Listens</summary>
		public MediaPlayerEntity LucianoSAlexaListens => new(_haContext, "media_player.luciano_s_alexa_listens");
		///<summary>Luciano's Fire</summary>
		public MediaPlayerEntity LucianoSFire => new(_haContext, "media_player.luciano_s_fire");
		///<summary>Luciano's FireTVStick</summary>
		public MediaPlayerEntity LucianoSFiretvstick => new(_haContext, "media_player.luciano_s_firetvstick");
		///<summary>Luciano's Ford/Lincoln+Alexa App</summary>
		public MediaPlayerEntity LucianoSFordLincolnAlexaApp => new(_haContext, "media_player.luciano_s_ford_lincoln_alexa_app");
		///<summary>Luciano's TV</summary>
		public MediaPlayerEntity LucianoSTv => new(_haContext, "media_player.luciano_s_tv");
		///<summary>MOVIES</summary>
		public MediaPlayerEntity Movies => new(_haContext, "media_player.movies");
		public MediaPlayerEntity Roku63264m060806 => new(_haContext, "media_player.roku_63264m060806");
		///<summary>Roku Ultra</summary>
		public MediaPlayerEntity RokuUltra => new(_haContext, "media_player.roku_ultra");
		///<summary>This Device</summary>
		public MediaPlayerEntity ThisDevice => new(_haContext, "media_player.this_device");
		///<summary>This Device</summary>
		public MediaPlayerEntity ThisDevice2 => new(_haContext, "media_player.this_device_2");
		///<summary>XBOXONEX</summary>
		public MediaPlayerEntity Xboxonex => new(_haContext, "media_player.xboxonex");
	}

	public class PersonEntities
	{
		private readonly IHaContext _haContext;
		public PersonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Luciano</summary>
		public PersonEntity Administrator => new(_haContext, "person.administrator");
		///<summary>Antonella</summary>
		public PersonEntity Antonella => new(_haContext, "person.antonella");
		///<summary>Camila</summary>
		public PersonEntity Camila => new(_haContext, "person.camila");
		///<summary>Franco</summary>
		public PersonEntity Franco => new(_haContext, "person.franco");
		///<summary>Mariela</summary>
		public PersonEntity Mariela => new(_haContext, "person.mariela");
	}

	public class RemoteEntities
	{
		private readonly IHaContext _haContext;
		public RemoteEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Hub</summary>
		public RemoteEntity Hub => new(_haContext, "remote.hub");
		public RemoteEntity Roku63264m060806 => new(_haContext, "remote.roku_63264m060806");
		///<summary>Roku Ultra</summary>
		public RemoteEntity RokuUltra => new(_haContext, "remote.roku_ultra");
	}

	public class SceneEntities
	{
		private readonly IHaContext _haContext;
		public SceneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close Blinds</summary>
		public SceneEntity CloseBlinds => new(_haContext, "scene.close_blinds");
		///<summary>Open Blinds</summary>
		public SceneEntity OpenBlinds => new(_haContext, "scene.open_blinds");
		///<summary>Lights Off</summary>
		public SceneEntity TurnOffAllLights => new(_haContext, "scene.turn_off_all_lights");
	}

	public class ScriptEntities
	{
		private readonly IHaContext _haContext;
		public ScriptEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>boltchecked_lock_frontdoor</summary>
		public ScriptEntity BoltcheckedLockFrontdoor => new(_haContext, "script.boltchecked_lock_frontdoor");
		///<summary>boltchecked_retry_frontdoor</summary>
		public ScriptEntity BoltcheckedRetryFrontdoor => new(_haContext, "script.boltchecked_retry_frontdoor");
		///<summary>dummy</summary>
		public ScriptEntity Dummy => new(_haContext, "script.dummy");
		///<summary>keymaster_frontdoor_reset_codeslot</summary>
		public ScriptEntity KeymasterFrontdoorResetCodeslot => new(_haContext, "script.keymaster_frontdoor_reset_codeslot");
		///<summary>keymaster_frontdoor_reset_lock</summary>
		public ScriptEntity KeymasterFrontdoorResetLock => new(_haContext, "script.keymaster_frontdoor_reset_lock");
		///<summary>keymaster_frontdoor_start_timer</summary>
		public ScriptEntity KeymasterFrontdoorStartTimer => new(_haContext, "script.keymaster_frontdoor_start_timer");
		///<summary>Projector Screen Down</summary>
		public ScriptEntity ProjectorScreenDown => new(_haContext, "script.projector_screen_down");
		///<summary>Secure House</summary>
		public ScriptEntity SecureHouse => new(_haContext, "script.secure_house");
		///<summary>Flight</summary>
		public ScriptEntity StarCockpit => new(_haContext, "script.star_cockpit");
		///<summary>Telemundo</summary>
		public ScriptEntity Telemundo => new(_haContext, "script.telemundo");
		///<summary>Toggle Garage Door</summary>
		public ScriptEntity ToggleGarageDoor => new(_haContext, "script.toggle_garage_door");
	}

	public class SelectEntities
	{
		private readonly IHaContext _haContext;
		public SelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Front Door Lock: Local protection state</summary>
		public SelectEntity FrontDoorLockLocalProtectionState => new(_haContext, "select.front_door_lock_local_protection_state");
		///<summary>Front Door Lock: RF protection state</summary>
		public SelectEntity FrontDoorLockRfProtectionState => new(_haContext, "select.front_door_lock_rf_protection_state");
		///<summary>Hub Activities</summary>
		public SelectEntity HubActivities => new(_haContext, "select.hub_activities");
	}

	public class SensorEntities
	{
		private readonly IHaContext _haContext;
		public SensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>3D Printer Plug electrical_measurement</summary>
		public NumericSensorEntity E3dPrinterPlugElectricalMeasurement => new(_haContext, "sensor.3d_printer_plug_electrical_measurement");
		///<summary>3D Printer Plug electrical_measurement rms_current</summary>
		public NumericSensorEntity E3dPrinterPlugElectricalMeasurementRmsCurrent => new(_haContext, "sensor.3d_printer_plug_electrical_measurement_rms_current");
		///<summary>3D Printer Plug electrical_measurement rms_voltage</summary>
		public NumericSensorEntity E3dPrinterPlugElectricalMeasurementRmsVoltage => new(_haContext, "sensor.3d_printer_plug_electrical_measurement_rms_voltage");
		///<summary>3D Printer Plug smartenergy_metering summation_delivered</summary>
		public NumericSensorEntity E3dPrinterPlugSmartenergyMeteringSummationDelivered => new(_haContext, "sensor.3d_printer_plug_smartenergy_metering_summation_delivered");
		///<summary>AC: Air temperature</summary>
		public NumericSensorEntity AcAirTemperature => new(_haContext, "sensor.ac_air_temperature");
		///<summary>Canon MX920 series Black(BK)</summary>
		public NumericSensorEntity CanonMx920SeriesBlackBk => new(_haContext, "sensor.canon_mx920_series_black_bk");
		///<summary>Canon MX920 series Black(PGBK)</summary>
		public NumericSensorEntity CanonMx920SeriesBlackPgbk => new(_haContext, "sensor.canon_mx920_series_black_pgbk");
		///<summary>Canon MX920 series Cyan</summary>
		public NumericSensorEntity CanonMx920SeriesCyan => new(_haContext, "sensor.canon_mx920_series_cyan");
		///<summary>Canon MX920 series Magenta</summary>
		public NumericSensorEntity CanonMx920SeriesMagenta => new(_haContext, "sensor.canon_mx920_series_magenta");
		///<summary>Canon MX920 series Yellow</summary>
		public NumericSensorEntity CanonMx920SeriesYellow => new(_haContext, "sensor.canon_mx920_series_yellow");
		///<summary>Cockpit Plug electrical_measurement</summary>
		public NumericSensorEntity CockpitPlugElectricalMeasurement => new(_haContext, "sensor.cockpit_plug_electrical_measurement");
		///<summary>Cockpit Plug electrical_measurement rms_current</summary>
		public NumericSensorEntity CockpitPlugElectricalMeasurementRmsCurrent => new(_haContext, "sensor.cockpit_plug_electrical_measurement_rms_current");
		///<summary>Cockpit Plug electrical_measurement rms_voltage</summary>
		public NumericSensorEntity CockpitPlugElectricalMeasurementRmsVoltage => new(_haContext, "sensor.cockpit_plug_electrical_measurement_rms_voltage");
		///<summary>Cockpit Plug smartenergy_metering summation_delivered</summary>
		public NumericSensorEntity CockpitPlugSmartenergyMeteringSummationDelivered => new(_haContext, "sensor.cockpit_plug_smartenergy_metering_summation_delivered");
		///<summary>Digital or Analog Voltage input and/or Dry Contact Relay: Target temperature</summary>
		public NumericSensorEntity DigitalOrAnalogVoltageInputAndOrDryContactRelayTargetTemperature => new(_haContext, "sensor.digital_or_analog_voltage_input_and_or_dry_contact_relay_target_temperature");
		///<summary>Digital or Analog Voltage input and/or Dry Contact Relay: Velocity</summary>
		public NumericSensorEntity DigitalOrAnalogVoltageInputAndOrDryContactRelayVelocity => new(_haContext, "sensor.digital_or_analog_voltage_input_and_or_dry_contact_relay_velocity");
		///<summary>Front Door Lock: Battery level</summary>
		public NumericSensorEntity FrontDoorLockBatteryLevel => new(_haContext, "sensor.front_door_lock_battery_level");
		///<summary>Front Door Sensor Battery Level</summary>
		public NumericSensorEntity FrontDoorSensorBatteryLevel => new(_haContext, "sensor.front_door_sensor_battery_level");
		///<summary>Garage Door Open Senor: Battery level</summary>
		public NumericSensorEntity GarageDoorOpenSenorBatteryLevel => new(_haContext, "sensor.garage_door_open_senor_battery_level");
		///<summary>hacs</summary>
		public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>Kitchen Blind: Battery level</summary>
		public NumericSensorEntity KitchenBlindBatteryLevel => new(_haContext, "sensor.kitchen_blind_battery_level");
		///<summary>Living Blind: Battery level</summary>
		public NumericSensorEntity LivingBlindBatteryLevel => new(_haContext, "sensor.living_blind_battery_level");
		///<summary>Luciano's Office Tablet Battery Level</summary>
		public NumericSensorEntity LucianoSOfficeTabletBatteryLevel => new(_haContext, "sensor.luciano_s_office_tablet_battery_level");
		///<summary>Luciano's Office Tablet Battery Temperature</summary>
		public NumericSensorEntity LucianoSOfficeTabletBatteryTemperature => new(_haContext, "sensor.luciano_s_office_tablet_battery_temperature");
		///<summary>Luciano's  S21 Phone Battery Level</summary>
		public NumericSensorEntity LucianoSS21PhoneBatteryLevel => new(_haContext, "sensor.luciano_s_s21_phone_battery_level");
		///<summary>Luciano's  S21 Phone Battery Temperature</summary>
		public NumericSensorEntity LucianoSS21PhoneBatteryTemperature => new(_haContext, "sensor.luciano_s_s21_phone_battery_temperature");
		///<summary>Camila Temperature Sensor Humidity</summary>
		public NumericSensorEntity LumiLumiWeather068ee007Humidity => new(_haContext, "sensor.lumi_lumi_weather_068ee007_humidity");
		///<summary>Camila Temperature Sensor Power</summary>
		public NumericSensorEntity LumiLumiWeather068ee007Power => new(_haContext, "sensor.lumi_lumi_weather_068ee007_power");
		///<summary>Camila Temperature Sensor Pressure</summary>
		public NumericSensorEntity LumiLumiWeather068ee007Pressure => new(_haContext, "sensor.lumi_lumi_weather_068ee007_pressure");
		///<summary>Camila Temperature Sensor Temperature</summary>
		public NumericSensorEntity LumiLumiWeather068ee007Temperature => new(_haContext, "sensor.lumi_lumi_weather_068ee007_temperature");
		///<summary>Master Bed Temperature Sensor Humidity</summary>
		public NumericSensorEntity LumiLumiWeather1cd2d307Humidity => new(_haContext, "sensor.lumi_lumi_weather_1cd2d307_humidity");
		///<summary>Master Bed Temperature Sensor Power</summary>
		public NumericSensorEntity LumiLumiWeather1cd2d307Power => new(_haContext, "sensor.lumi_lumi_weather_1cd2d307_power");
		///<summary>Master Bed Temperature Sensor Preassure</summary>
		public NumericSensorEntity LumiLumiWeather1cd2d307Pressure => new(_haContext, "sensor.lumi_lumi_weather_1cd2d307_pressure");
		///<summary>Master Bed Temperature Sensor Temperature</summary>
		public NumericSensorEntity LumiLumiWeather1cd2d307Temperature => new(_haContext, "sensor.lumi_lumi_weather_1cd2d307_temperature");
		///<summary>Franco Temperature Sensor Humidity</summary>
		public NumericSensorEntity LumiLumiWeatherD5a6d307Humidity => new(_haContext, "sensor.lumi_lumi_weather_d5a6d307_humidity");
		///<summary>Franco Temperature Sensor  Power</summary>
		public NumericSensorEntity LumiLumiWeatherD5a6d307Power => new(_haContext, "sensor.lumi_lumi_weather_d5a6d307_power");
		///<summary>Franco Temperature Sensor  Preassure</summary>
		public NumericSensorEntity LumiLumiWeatherD5a6d307Pressure => new(_haContext, "sensor.lumi_lumi_weather_d5a6d307_pressure");
		///<summary>Franco Temperature Sensor Temperature</summary>
		public NumericSensorEntity LumiLumiWeatherD5a6d307Temperature => new(_haContext, "sensor.lumi_lumi_weather_d5a6d307_temperature");
		///<summary>Living Temperature Sensor Humidity</summary>
		public NumericSensorEntity LumiLumiWeatherHumidity => new(_haContext, "sensor.lumi_lumi_weather_humidity");
		///<summary>Living Temperature Sensor power</summary>
		public NumericSensorEntity LumiLumiWeatherPower => new(_haContext, "sensor.lumi_lumi_weather_power");
		///<summary>Living Temperature Sensor Pressure</summary>
		public NumericSensorEntity LumiLumiWeatherPressure => new(_haContext, "sensor.lumi_lumi_weather_pressure");
		///<summary>Living Temperature Sensor Temperature</summary>
		public NumericSensorEntity LumiLumiWeatherTemperature => new(_haContext, "sensor.lumi_lumi_weather_temperature");
		///<summary>OctoPrint actual bed temp</summary>
		public NumericSensorEntity OctoprintActualBedTemp => new(_haContext, "sensor.octoprint_actual_bed_temp");
		///<summary>OctoPrint actual tool0 temp</summary>
		public NumericSensorEntity OctoprintActualTool0Temp => new(_haContext, "sensor.octoprint_actual_tool0_temp");
		///<summary>OctoPrint Job Percentage</summary>
		public NumericSensorEntity OctoprintJobPercentage => new(_haContext, "sensor.octoprint_job_percentage");
		///<summary>OctoPrint target bed temp</summary>
		public NumericSensorEntity OctoprintTargetBedTemp => new(_haContext, "sensor.octoprint_target_bed_temp");
		///<summary>OctoPrint target tool0 temp</summary>
		public NumericSensorEntity OctoprintTargetTool0Temp => new(_haContext, "sensor.octoprint_target_tool0_temp");
		///<summary>Office Blind: Battery level</summary>
		public NumericSensorEntity OfficeBlindBatteryLevel => new(_haContext, "sensor.office_blind_battery_level");
		///<summary>Patio Door Sensor power</summary>
		public NumericSensorEntity PatioDoorSensorPower => new(_haContext, "sensor.patio_door_sensor_power");
		///<summary>Robot vacuum Current Clean Area</summary>
		public NumericSensorEntity RobotVacuumCurrentCleanArea => new(_haContext, "sensor.robot_vacuum_current_clean_area");
		///<summary>Robot vacuum Current Clean Duration</summary>
		public NumericSensorEntity RobotVacuumCurrentCleanDuration => new(_haContext, "sensor.robot_vacuum_current_clean_duration");
		///<summary>Robot vacuum Last Clean Area</summary>
		public NumericSensorEntity RobotVacuumLastCleanArea => new(_haContext, "sensor.robot_vacuum_last_clean_area");
		///<summary>Robot vacuum Last Clean Duration</summary>
		public NumericSensorEntity RobotVacuumLastCleanDuration => new(_haContext, "sensor.robot_vacuum_last_clean_duration");
		///<summary>RT-AC5300-A600 B received</summary>
		public NumericSensorEntity RtAc5300A600BReceived => new(_haContext, "sensor.rt_ac5300_a600_b_received");
		///<summary>RT-AC5300-A600 B sent</summary>
		public NumericSensorEntity RtAc5300A600BSent => new(_haContext, "sensor.rt_ac5300_a600_b_sent");
		///<summary>RT-AC5300-A600 KiB/s received</summary>
		public NumericSensorEntity RtAc5300A600KibSReceived => new(_haContext, "sensor.rt_ac5300_a600_kib_s_received");
		///<summary>RT-AC5300-A600 KiB/s sent</summary>
		public NumericSensorEntity RtAc5300A600KibSSent => new(_haContext, "sensor.rt_ac5300_a600_kib_s_sent");
		///<summary>RT-AC5300-A600 packets received</summary>
		public NumericSensorEntity RtAc5300A600PacketsReceived => new(_haContext, "sensor.rt_ac5300_a600_packets_received");
		///<summary>RT-AC5300-A600 packets/s received</summary>
		public NumericSensorEntity RtAc5300A600PacketsSReceived => new(_haContext, "sensor.rt_ac5300_a600_packets_s_received");
		///<summary>RT-AC5300-A600 packets/s sent</summary>
		public NumericSensorEntity RtAc5300A600PacketsSSent => new(_haContext, "sensor.rt_ac5300_a600_packets_s_sent");
		///<summary>RT-AC5300-A600 packets sent</summary>
		public NumericSensorEntity RtAc5300A600PacketsSent => new(_haContext, "sensor.rt_ac5300_a600_packets_sent");
		///<summary>Sprinklers Freeze Protect Temperature</summary>
		public NumericSensorEntity SprinklersFreezeProtectTemperature => new(_haContext, "sensor.sprinklers_freeze_protect_temperature");
		///<summary>Touchscreen Programmable Thermostat: General purpose</summary>
		public NumericSensorEntity TouchscreenProgrammableThermostatGeneralPurpose => new(_haContext, "sensor.touchscreen_programmable_thermostat_general_purpose");
		///<summary>unk_manufacturer lumi.weather 8a7c6507 humidity</summary>
		public NumericSensorEntity UnkManufacturerUnkModel8a7c6507Humidity => new(_haContext, "sensor.unk_manufacturer_unk_model_8a7c6507_humidity");
		///<summary>unk_manufacturer lumi.weather 8a7c6507 pressure</summary>
		public NumericSensorEntity UnkManufacturerUnkModel8a7c6507Pressure => new(_haContext, "sensor.unk_manufacturer_unk_model_8a7c6507_pressure");
		///<summary>unk_manufacturer lumi.weather 8a7c6507 temperature</summary>
		public NumericSensorEntity UnkManufacturerUnkModel8a7c6507Temperature => new(_haContext, "sensor.unk_manufacturer_unk_model_8a7c6507_temperature");
		///<summary>Antonella next Alarm</summary>
		public SensorEntity AntonellaNextAlarm => new(_haContext, "sensor.antonella_next_alarm");
		///<summary>Antonella next Reminder</summary>
		public SensorEntity AntonellaNextReminder => new(_haContext, "sensor.antonella_next_reminder");
		///<summary>Antonella next Timer</summary>
		public SensorEntity AntonellaNextTimer => new(_haContext, "sensor.antonella_next_timer");
		///<summary>Camila next Alarm</summary>
		public SensorEntity CamilaNextAlarm => new(_haContext, "sensor.camila_next_alarm");
		///<summary>Camila next Reminder</summary>
		public SensorEntity CamilaNextReminder => new(_haContext, "sensor.camila_next_reminder");
		///<summary>Camila next Timer</summary>
		public SensorEntity CamilaNextTimer => new(_haContext, "sensor.camila_next_timer");
		///<summary>Canon MX920 series</summary>
		public SensorEntity CanonMx920Series => new(_haContext, "sensor.canon_mx920_series");
		///<summary>PIN Status</summary>
		public SensorEntity ConnectedFrontdoor1 => new(_haContext, "sensor.connected_frontdoor_1");
		///<summary>PIN Status</summary>
		public SensorEntity ConnectedFrontdoor10 => new(_haContext, "sensor.connected_frontdoor_10");
		///<summary>PIN Status</summary>
		public SensorEntity ConnectedFrontdoor2 => new(_haContext, "sensor.connected_frontdoor_2");
		///<summary>PIN Status</summary>
		public SensorEntity ConnectedFrontdoor3 => new(_haContext, "sensor.connected_frontdoor_3");
		///<summary>PIN Status</summary>
		public SensorEntity ConnectedFrontdoor4 => new(_haContext, "sensor.connected_frontdoor_4");
		///<summary>PIN Status</summary>
		public SensorEntity ConnectedFrontdoor5 => new(_haContext, "sensor.connected_frontdoor_5");
		///<summary>PIN Status</summary>
		public SensorEntity ConnectedFrontdoor6 => new(_haContext, "sensor.connected_frontdoor_6");
		///<summary>PIN Status</summary>
		public SensorEntity ConnectedFrontdoor7 => new(_haContext, "sensor.connected_frontdoor_7");
		///<summary>PIN Status</summary>
		public SensorEntity ConnectedFrontdoor8 => new(_haContext, "sensor.connected_frontdoor_8");
		///<summary>PIN Status</summary>
		public SensorEntity ConnectedFrontdoor9 => new(_haContext, "sensor.connected_frontdoor_9");
		///<summary>El Fire de Mariela next Alarm</summary>
		public SensorEntity ElFireDeMarielaNextAlarm => new(_haContext, "sensor.el_fire_de_mariela_next_alarm");
		///<summary>El Fire de Mariela next Reminder</summary>
		public SensorEntity ElFireDeMarielaNextReminder => new(_haContext, "sensor.el_fire_de_mariela_next_reminder");
		///<summary>El Fire de Mariela next Timer</summary>
		public SensorEntity ElFireDeMarielaNextTimer => new(_haContext, "sensor.el_fire_de_mariela_next_timer");
		///<summary>frontdoor: Code Slot 1</summary>
		public SensorEntity FrontdoorCodeSlot1 => new(_haContext, "sensor.frontdoor_code_slot_1");
		///<summary>frontdoor: Code Slot 10</summary>
		public SensorEntity FrontdoorCodeSlot10 => new(_haContext, "sensor.frontdoor_code_slot_10");
		///<summary>frontdoor: Code Slot 2</summary>
		public SensorEntity FrontdoorCodeSlot2 => new(_haContext, "sensor.frontdoor_code_slot_2");
		///<summary>frontdoor: Code Slot 3</summary>
		public SensorEntity FrontdoorCodeSlot3 => new(_haContext, "sensor.frontdoor_code_slot_3");
		///<summary>frontdoor: Code Slot 4</summary>
		public SensorEntity FrontdoorCodeSlot4 => new(_haContext, "sensor.frontdoor_code_slot_4");
		///<summary>frontdoor: Code Slot 5</summary>
		public SensorEntity FrontdoorCodeSlot5 => new(_haContext, "sensor.frontdoor_code_slot_5");
		///<summary>frontdoor: Code Slot 6</summary>
		public SensorEntity FrontdoorCodeSlot6 => new(_haContext, "sensor.frontdoor_code_slot_6");
		///<summary>frontdoor: Code Slot 7</summary>
		public SensorEntity FrontdoorCodeSlot7 => new(_haContext, "sensor.frontdoor_code_slot_7");
		///<summary>frontdoor: Code Slot 8</summary>
		public SensorEntity FrontdoorCodeSlot8 => new(_haContext, "sensor.frontdoor_code_slot_8");
		///<summary>frontdoor: Code Slot 9</summary>
		public SensorEntity FrontdoorCodeSlot9 => new(_haContext, "sensor.frontdoor_code_slot_9");
		///<summary>Garage Door Opener: General purpose</summary>
		public SensorEntity GarageDoorOpenerGeneralPurpose => new(_haContext, "sensor.garage_door_opener_general_purpose");
		///<summary>Kitchen next Alarm</summary>
		public SensorEntity KitchenNextAlarm => new(_haContext, "sensor.kitchen_next_alarm");
		///<summary>Kitchen next Reminder</summary>
		public SensorEntity KitchenNextReminder => new(_haContext, "sensor.kitchen_next_reminder");
		///<summary>Kitchen next Timer</summary>
		public SensorEntity KitchenNextTimer => new(_haContext, "sensor.kitchen_next_timer");
		///<summary>Luciano's 3rd Echo Dot next Alarm</summary>
		public SensorEntity LucianoS3rdEchoDotNextAlarm => new(_haContext, "sensor.luciano_s_3rd_echo_dot_next_alarm");
		///<summary>Luciano's 3rd Echo Dot next Reminder</summary>
		public SensorEntity LucianoS3rdEchoDotNextReminder => new(_haContext, "sensor.luciano_s_3rd_echo_dot_next_reminder");
		///<summary>Luciano's 3rd Echo Dot next Timer</summary>
		public SensorEntity LucianoS3rdEchoDotNextTimer => new(_haContext, "sensor.luciano_s_3rd_echo_dot_next_timer");
		///<summary>Luciano's Alexa Listens next Alarm</summary>
		public SensorEntity LucianoSAlexaListensNextAlarm => new(_haContext, "sensor.luciano_s_alexa_listens_next_alarm");
		///<summary>Luciano's Alexa Listens next Timer</summary>
		public SensorEntity LucianoSAlexaListensNextTimer => new(_haContext, "sensor.luciano_s_alexa_listens_next_timer");
		///<summary>Luciano's Fire next Alarm</summary>
		public SensorEntity LucianoSFireNextAlarm => new(_haContext, "sensor.luciano_s_fire_next_alarm");
		///<summary>Luciano's Fire next Reminder</summary>
		public SensorEntity LucianoSFireNextReminder => new(_haContext, "sensor.luciano_s_fire_next_reminder");
		///<summary>Luciano's Fire next Timer</summary>
		public SensorEntity LucianoSFireNextTimer => new(_haContext, "sensor.luciano_s_fire_next_timer");
		///<summary>Luciano's FireTVStick next Alarm</summary>
		public SensorEntity LucianoSFiretvstickNextAlarm => new(_haContext, "sensor.luciano_s_firetvstick_next_alarm");
		///<summary>Luciano's FireTVStick next Reminder</summary>
		public SensorEntity LucianoSFiretvstickNextReminder => new(_haContext, "sensor.luciano_s_firetvstick_next_reminder");
		///<summary>Luciano's FireTVStick next Timer</summary>
		public SensorEntity LucianoSFiretvstickNextTimer => new(_haContext, "sensor.luciano_s_firetvstick_next_timer");
		///<summary>Luciano's Ford/Lincoln+Alexa App next Alarm</summary>
		public SensorEntity LucianoSFordLincolnAlexaAppNextAlarm => new(_haContext, "sensor.luciano_s_ford_lincoln_alexa_app_next_alarm");
		///<summary>Luciano's Ford/Lincoln+Alexa App next Timer</summary>
		public SensorEntity LucianoSFordLincolnAlexaAppNextTimer => new(_haContext, "sensor.luciano_s_ford_lincoln_alexa_app_next_timer");
		///<summary>Luciano's Office Tablet Battery Health</summary>
		public SensorEntity LucianoSOfficeTabletBatteryHealth => new(_haContext, "sensor.luciano_s_office_tablet_battery_health");
		///<summary>Luciano's Office Tablet Battery State</summary>
		public SensorEntity LucianoSOfficeTabletBatteryState => new(_haContext, "sensor.luciano_s_office_tablet_battery_state");
		///<summary>Luciano's Office Tablet Charger Type</summary>
		public SensorEntity LucianoSOfficeTabletChargerType => new(_haContext, "sensor.luciano_s_office_tablet_charger_type");
		///<summary>Luciano's  S21 Phone Battery Health</summary>
		public SensorEntity LucianoSS21PhoneBatteryHealth => new(_haContext, "sensor.luciano_s_s21_phone_battery_health");
		///<summary>Luciano's  S21 Phone Battery State</summary>
		public SensorEntity LucianoSS21PhoneBatteryState => new(_haContext, "sensor.luciano_s_s21_phone_battery_state");
		///<summary>Luciano's  S21 Phone Charger Type</summary>
		public SensorEntity LucianoSS21PhoneChargerType => new(_haContext, "sensor.luciano_s_s21_phone_charger_type");
		///<summary>Luciano's TV next Alarm</summary>
		public SensorEntity LucianoSTvNextAlarm => new(_haContext, "sensor.luciano_s_tv_next_alarm");
		///<summary>Luciano's TV next Reminder</summary>
		public SensorEntity LucianoSTvNextReminder => new(_haContext, "sensor.luciano_s_tv_next_reminder");
		///<summary>Luciano's TV next Timer</summary>
		public SensorEntity LucianoSTvNextTimer => new(_haContext, "sensor.luciano_s_tv_next_timer");
		///<summary>None Active App</summary>
		public SensorEntity NoneActiveApp => new(_haContext, "sensor.none_active_app");
		///<summary>None Active App ID</summary>
		public SensorEntity NoneActiveAppId => new(_haContext, "sensor.none_active_app_id");
		///<summary>OctoPrint Current State</summary>
		public SensorEntity OctoprintCurrentState => new(_haContext, "sensor.octoprint_current_state");
		///<summary>OctoPrint Estimated Finish Time</summary>
		public SensorEntity OctoprintEstimatedFinishTime => new(_haContext, "sensor.octoprint_estimated_finish_time");
		///<summary>OctoPrint Start Time</summary>
		public SensorEntity OctoprintStartTime => new(_haContext, "sensor.octoprint_start_time");
		///<summary>On/Off Relay Switch: General purpose</summary>
		public SensorEntity OnOffRelaySwitchGeneralPurpose => new(_haContext, "sensor.on_off_relay_switch_general_purpose");
		///<summary>Robot vacuum Last Clean End</summary>
		public SensorEntity RobotVacuumLastCleanEnd => new(_haContext, "sensor.robot_vacuum_last_clean_end");
		///<summary>Robot vacuum Last Clean Start</summary>
		public SensorEntity RobotVacuumLastCleanStart => new(_haContext, "sensor.robot_vacuum_last_clean_start");
		///<summary>Roku Ultra Active App</summary>
		public SensorEntity RokuUltraActiveApp => new(_haContext, "sensor.roku_ultra_active_app");
		///<summary>Roku Ultra Active App ID</summary>
		public SensorEntity RokuUltraActiveAppId => new(_haContext, "sensor.roku_ultra_active_app_id");
		///<summary>RT-AC5300-A600 External IP</summary>
		public SensorEntity RtAc5300A600ExternalIp => new(_haContext, "sensor.rt_ac5300_a600_external_ip");
		///<summary>RT-AC5300-A600 wan status</summary>
		public SensorEntity RtAc5300A600WanStatus => new(_haContext, "sensor.rt_ac5300_a600_wan_status");
		///<summary>Scene Capable Switch On/Off: Node Status</summary>
		public SensorEntity SceneCapableSwitchOnOffNodeStatus5 => new(_haContext, "sensor.scene_capable_switch_on_off_node_status_5");
		///<summary>Temperature Sensor Current</summary>
		public SensorEntity TemperatureSensorCurrent => new(_haContext, "sensor.temperature_sensor_current");
		///<summary>This Device next Alarm</summary>
		public SensorEntity ThisDeviceNextAlarm => new(_haContext, "sensor.this_device_next_alarm");
		///<summary>This Device next Reminder</summary>
		public SensorEntity ThisDeviceNextReminder => new(_haContext, "sensor.this_device_next_reminder");
		///<summary>This Device next Timer</summary>
		public SensorEntity ThisDeviceNextTimer => new(_haContext, "sensor.this_device_next_timer");
		///<summary>Window Blind Controller: Node Status</summary>
		public SensorEntity WindowBlindControllerNodeStatus => new(_haContext, "sensor.window_blind_controller_node_status");
	}

	public class SunEntities
	{
		private readonly IHaContext _haContext;
		public SunEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public class SwitchEntities
	{
		private readonly IHaContext _haContext;
		public SwitchEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Antonella do not disturb switch</summary>
		public SwitchEntity AntonellaDoNotDisturbSwitch => new(_haContext, "switch.antonella_do_not_disturb_switch");
		///<summary>Antonella repeat switch</summary>
		public SwitchEntity AntonellaRepeatSwitch => new(_haContext, "switch.antonella_repeat_switch");
		///<summary>Antonella shuffle switch</summary>
		public SwitchEntity AntonellaShuffleSwitch => new(_haContext, "switch.antonella_shuffle_switch");
		///<summary>Camila do not disturb switch</summary>
		public SwitchEntity CamilaDoNotDisturbSwitch => new(_haContext, "switch.camila_do_not_disturb_switch");
		///<summary>Camila repeat switch</summary>
		public SwitchEntity CamilaRepeatSwitch => new(_haContext, "switch.camila_repeat_switch");
		///<summary>Camila shuffle switch</summary>
		public SwitchEntity CamilaShuffleSwitch => new(_haContext, "switch.camila_shuffle_switch");
		///<summary>Cockpit Plug on_off</summary>
		public SwitchEntity CockpitPlugOnOff => new(_haContext, "switch.cockpit_plug_on_off");
		///<summary>Dinning Room Light</summary>
		public SwitchEntity DinningRoomLight => new(_haContext, "switch.dinning_room_light");
		///<summary>El Fire de Mariela do not disturb switch</summary>
		public SwitchEntity ElFireDeMarielaDoNotDisturbSwitch => new(_haContext, "switch.el_fire_de_mariela_do_not_disturb_switch");
		///<summary>Entrance Hall Light</summary>
		public SwitchEntity EntranceHallLight => new(_haContext, "switch.entrance_hall_light");
		///<summary>Everywhere do not disturb switch</summary>
		public SwitchEntity EverywhereDoNotDisturbSwitch => new(_haContext, "switch.everywhere_do_not_disturb_switch");
		///<summary>Everywhere repeat switch</summary>
		public SwitchEntity EverywhereRepeatSwitch => new(_haContext, "switch.everywhere_repeat_switch");
		///<summary>Everywhere shuffle switch</summary>
		public SwitchEntity EverywhereShuffleSwitch => new(_haContext, "switch.everywhere_shuffle_switch");
		///<summary>Garage Door Opener</summary>
		public SwitchEntity GarageDoorOpener => new(_haContext, "switch.garage_door_opener");
		///<summary>Garage Hall Light Light</summary>
		public SwitchEntity GarageHallLight => new(_haContext, "switch.garage_hall_light");
		///<summary>Garage Light</summary>
		public SwitchEntity GarageLight => new(_haContext, "switch.garage_light");
		///<summary>Hall Light</summary>
		public SwitchEntity HallLighy => new(_haContext, "switch.hall_lighy");
		///<summary>3D Printer Plug Switch</summary>
		public SwitchEntity InnrSp234580698feOnOff => new(_haContext, "switch.innr_sp_234_580698fe_on_off");
		///<summary>Kitchen Blind</summary>
		public SwitchEntity KitchenBlind => new(_haContext, "switch.kitchen_blind");
		///<summary>Kitchen do not disturb switch</summary>
		public SwitchEntity KitchenDoNotDisturbSwitch => new(_haContext, "switch.kitchen_do_not_disturb_switch");
		///<summary>Kitchen Light</summary>
		public SwitchEntity KitchenLight => new(_haContext, "switch.kitchen_light");
		///<summary>Kitchen Light Sink</summary>
		public SwitchEntity KitchenLightSink => new(_haContext, "switch.kitchen_light_sink");
		///<summary>Kitchen repeat switch</summary>
		public SwitchEntity KitchenRepeatSwitch => new(_haContext, "switch.kitchen_repeat_switch");
		///<summary>Kitchen shuffle switch</summary>
		public SwitchEntity KitchenShuffleSwitch => new(_haContext, "switch.kitchen_shuffle_switch");
		///<summary>Kitchen Table Light</summary>
		public SwitchEntity KitchenTableLight => new(_haContext, "switch.kitchen_table_light");
		///<summary>Living Blind</summary>
		public SwitchEntity LivingBlind => new(_haContext, "switch.living_blind");
		///<summary>Luciano's 3rd Echo Dot do not disturb switch</summary>
		public SwitchEntity LucianoS3rdEchoDotDoNotDisturbSwitch => new(_haContext, "switch.luciano_s_3rd_echo_dot_do_not_disturb_switch");
		///<summary>Luciano's 3rd Echo Dot repeat switch</summary>
		public SwitchEntity LucianoS3rdEchoDotRepeatSwitch => new(_haContext, "switch.luciano_s_3rd_echo_dot_repeat_switch");
		///<summary>Luciano's 3rd Echo Dot shuffle switch</summary>
		public SwitchEntity LucianoS3rdEchoDotShuffleSwitch => new(_haContext, "switch.luciano_s_3rd_echo_dot_shuffle_switch");
		///<summary>Luciano's Alexa Listens do not disturb switch</summary>
		public SwitchEntity LucianoSAlexaListensDoNotDisturbSwitch => new(_haContext, "switch.luciano_s_alexa_listens_do_not_disturb_switch");
		///<summary>Luciano's Alexa Listens repeat switch</summary>
		public SwitchEntity LucianoSAlexaListensRepeatSwitch => new(_haContext, "switch.luciano_s_alexa_listens_repeat_switch");
		///<summary>Luciano's Alexa Listens shuffle switch</summary>
		public SwitchEntity LucianoSAlexaListensShuffleSwitch => new(_haContext, "switch.luciano_s_alexa_listens_shuffle_switch");
		///<summary>Luciano's Fire do not disturb switch</summary>
		public SwitchEntity LucianoSFireDoNotDisturbSwitch => new(_haContext, "switch.luciano_s_fire_do_not_disturb_switch");
		///<summary>Luciano's FireTVStick do not disturb switch</summary>
		public SwitchEntity LucianoSFiretvstickDoNotDisturbSwitch => new(_haContext, "switch.luciano_s_firetvstick_do_not_disturb_switch");
		///<summary>Luciano's Ford/Lincoln+Alexa App do not disturb switch</summary>
		public SwitchEntity LucianoSFordLincolnAlexaAppDoNotDisturbSwitch => new(_haContext, "switch.luciano_s_ford_lincoln_alexa_app_do_not_disturb_switch");
		///<summary>Luciano's Ford/Lincoln+Alexa App repeat switch</summary>
		public SwitchEntity LucianoSFordLincolnAlexaAppRepeatSwitch => new(_haContext, "switch.luciano_s_ford_lincoln_alexa_app_repeat_switch");
		///<summary>Luciano's Ford/Lincoln+Alexa App shuffle switch</summary>
		public SwitchEntity LucianoSFordLincolnAlexaAppShuffleSwitch => new(_haContext, "switch.luciano_s_ford_lincoln_alexa_app_shuffle_switch");
		///<summary>Luciano's TV do not disturb switch</summary>
		public SwitchEntity LucianoSTvDoNotDisturbSwitch => new(_haContext, "switch.luciano_s_tv_do_not_disturb_switch");
		///<summary>Luciano's TV repeat switch</summary>
		public SwitchEntity LucianoSTvRepeatSwitch => new(_haContext, "switch.luciano_s_tv_repeat_switch");
		///<summary>Luciano's TV shuffle switch</summary>
		public SwitchEntity LucianoSTvShuffleSwitch => new(_haContext, "switch.luciano_s_tv_shuffle_switch");
		///<summary>Office Blind</summary>
		public SwitchEntity OfficeBlind => new(_haContext, "switch.office_blind");
		///<summary>Office Light</summary>
		public SwitchEntity OfficeLight => new(_haContext, "switch.office_light");
		///<summary>Patio Light</summary>
		public SwitchEntity PatioLight => new(_haContext, "switch.patio_light");
		///<summary>Sprinklers Back</summary>
		public SwitchEntity SprinklersBack => new(_haContext, "switch.sprinklers_back");
		///<summary>Sprinklers Back Enabled</summary>
		public SwitchEntity SprinklersBackEnabled => new(_haContext, "switch.sprinklers_back_enabled");
		///<summary>Sprinklers Daily</summary>
		public SwitchEntity SprinklersDaily => new(_haContext, "switch.sprinklers_daily");
		///<summary>Sprinklers Daily Afternoon</summary>
		public SwitchEntity SprinklersDailyAfternoon => new(_haContext, "switch.sprinklers_daily_afternoon");
		///<summary>Sprinklers Daily Afternoon</summary>
		public SwitchEntity SprinklersDailyAfternoon2 => new(_haContext, "switch.sprinklers_daily_afternoon_2");
		///<summary>Sprinklers Daily Afternoon Enabled</summary>
		public SwitchEntity SprinklersDailyAfternoonEnabled => new(_haContext, "switch.sprinklers_daily_afternoon_enabled");
		///<summary>Sprinklers Daily Afternoon Enabled</summary>
		public SwitchEntity SprinklersDailyAfternoonEnabled2 => new(_haContext, "switch.sprinklers_daily_afternoon_enabled_2");
		///<summary>Sprinklers Daily Enabled</summary>
		public SwitchEntity SprinklersDailyEnabled => new(_haContext, "switch.sprinklers_daily_enabled");
		///<summary>Sprinklers Daily Front Night</summary>
		public SwitchEntity SprinklersDailyFrontNight => new(_haContext, "switch.sprinklers_daily_front_night");
		///<summary>Sprinklers Daily Front Night Enabled</summary>
		public SwitchEntity SprinklersDailyFrontNightEnabled => new(_haContext, "switch.sprinklers_daily_front_night_enabled");
		///<summary>Sprinklers Front</summary>
		public SwitchEntity SprinklersFront => new(_haContext, "switch.sprinklers_front");
		///<summary>Sprinklers Front Enabled</summary>
		public SwitchEntity SprinklersFrontEnabled => new(_haContext, "switch.sprinklers_front_enabled");
		///<summary>Sprinklers Front2</summary>
		public SwitchEntity SprinklersFront2 => new(_haContext, "switch.sprinklers_front2");
		///<summary>Sprinklers Front2 Enabled</summary>
		public SwitchEntity SprinklersFront2Enabled => new(_haContext, "switch.sprinklers_front2_enabled");
		///<summary>Sprinklers Left</summary>
		public SwitchEntity SprinklersLeft => new(_haContext, "switch.sprinklers_left");
		///<summary>Sprinklers Left Enabled</summary>
		public SwitchEntity SprinklersLeftEnabled => new(_haContext, "switch.sprinklers_left_enabled");
		///<summary>Sprinklers  Summer Afternoon</summary>
		public SwitchEntity SprinklersSummerAfternoon => new(_haContext, "switch.sprinklers_summer_afternoon");
		///<summary>Sprinklers  Summer Afternoon Enabled</summary>
		public SwitchEntity SprinklersSummerAfternoonEnabled => new(_haContext, "switch.sprinklers_summer_afternoon_enabled");
		///<summary>Sprinklers Summer Morning</summary>
		public SwitchEntity SprinklersSummerMorning => new(_haContext, "switch.sprinklers_summer_morning");
		///<summary>Sprinklers Summer Morning Enabled</summary>
		public SwitchEntity SprinklersSummerMorningEnabled => new(_haContext, "switch.sprinklers_summer_morning_enabled");
		///<summary>Sprinklers Zone 5</summary>
		public SwitchEntity SprinklersZone5 => new(_haContext, "switch.sprinklers_zone_5");
		///<summary>Sprinklers Zone 5 Enabled</summary>
		public SwitchEntity SprinklersZone5Enabled => new(_haContext, "switch.sprinklers_zone_5_enabled");
		///<summary>Sprinklers Zone 6</summary>
		public SwitchEntity SprinklersZone6 => new(_haContext, "switch.sprinklers_zone_6");
		///<summary>Sprinklers Zone 6 Enabled</summary>
		public SwitchEntity SprinklersZone6Enabled => new(_haContext, "switch.sprinklers_zone_6_enabled");
		///<summary>Sprinklers Zone 7</summary>
		public SwitchEntity SprinklersZone7 => new(_haContext, "switch.sprinklers_zone_7");
		///<summary>Sprinklers Zone 7 Enabled</summary>
		public SwitchEntity SprinklersZone7Enabled => new(_haContext, "switch.sprinklers_zone_7_enabled");
		///<summary>Sprinklers Zone 8</summary>
		public SwitchEntity SprinklersZone8 => new(_haContext, "switch.sprinklers_zone_8");
		///<summary>Sprinklers Zone 8 Enabled</summary>
		public SwitchEntity SprinklersZone8Enabled => new(_haContext, "switch.sprinklers_zone_8_enabled");
		///<summary>Stairs Light</summary>
		public SwitchEntity StairsLight => new(_haContext, "switch.stairs_light");
		///<summary>This Device do not disturb switch</summary>
		public SwitchEntity ThisDeviceDoNotDisturbSwitch => new(_haContext, "switch.this_device_do_not_disturb_switch");
		///<summary>TV Light</summary>
		public SwitchEntity TvLight => new(_haContext, "switch.tv_light");
	}

	public class TimerEntities
	{
		private readonly IHaContext _haContext;
		public TimerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Auto Lock Timer</summary>
		public TimerEntity KeymasterFrontdoorAutolock => new(_haContext, "timer.keymaster_frontdoor_autolock");
	}

	public class VacuumEntities
	{
		private readonly IHaContext _haContext;
		public VacuumEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Robot vacuum</summary>
		public VacuumEntity RobotVacuum => new(_haContext, "vacuum.robot_vacuum");
	}

	public class WeatherEntities
	{
		private readonly IHaContext _haContext;
		public WeatherEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Home</summary>
		public WeatherEntity Home => new(_haContext, "weather.home");
	}

	public class ZoneEntities
	{
		private readonly IHaContext _haContext;
		public ZoneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Home</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
		///<summary>Olivos</summary>
		public ZoneEntity Olivos => new(_haContext, "zone.olivos");
	}

	public record AlarmControlPanelEntity : Entity<AlarmControlPanelEntity, EntityState<AlarmControlPanelAttributes>, AlarmControlPanelAttributes>
	{
		public AlarmControlPanelEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AlarmControlPanelEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AutomationEntity : Entity<AutomationEntity, EntityState<AutomationAttributes>, AutomationAttributes>
	{
		public AutomationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AutomationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes>
	{
		public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ButtonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CameraEntity : Entity<CameraEntity, EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ClimateEntity : Entity<ClimateEntity, EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CoverEntity : Entity<CoverEntity, EntityState<CoverAttributes>, CoverAttributes>
	{
		public CoverEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CoverEntity(Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record FanEntity : Entity<FanEntity, EntityState<FanAttributes>, FanAttributes>
	{
		public FanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public FanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputDatetimeEntity : Entity<InputDatetimeEntity, EntityState<InputDatetimeAttributes>, InputDatetimeAttributes>
	{
		public InputDatetimeEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputDatetimeEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputNumberEntity : NumericEntity<InputNumberEntity, NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputNumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputTextEntity : Entity<InputTextEntity, EntityState<InputTextAttributes>, InputTextAttributes>
	{
		public InputTextEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputTextEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LockEntity : Entity<LockEntity, EntityState<LockAttributes>, LockAttributes>
	{
		public LockEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LockEntity(Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerEntity : Entity<MediaPlayerEntity, EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record RemoteEntity : Entity<RemoteEntity, EntityState<RemoteAttributes>, RemoteAttributes>
	{
		public RemoteEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public RemoteEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SceneEntity : Entity<SceneEntity, EntityState<SceneAttributes>, SceneAttributes>
	{
		public SceneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SceneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ScriptEntity : Entity<ScriptEntity, EntityState<ScriptAttributes>, ScriptAttributes>
	{
		public ScriptEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ScriptEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SelectEntity : Entity<SelectEntity, EntityState<SelectAttributes>, SelectAttributes>
	{
		public SelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(Entity entity) : base(entity)
		{
		}
	}

	public record TimerEntity : Entity<TimerEntity, EntityState<TimerAttributes>, TimerAttributes>
	{
		public TimerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public TimerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VacuumEntity : Entity<VacuumEntity, EntityState<VacuumAttributes>, VacuumAttributes>
	{
		public VacuumEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VacuumEntity(Entity entity) : base(entity)
		{
		}
	}

	public record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AlarmControlPanelAttributes
	{
		[JsonPropertyName("changed_by")]
		public object? ChangedBy { get; init; }

		[JsonPropertyName("code_arm_required")]
		public bool? CodeArmRequired { get; init; }

		[JsonPropertyName("code_format")]
		public string? CodeFormat { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record AutomationAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public record BinarySensorAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("newest_version")]
		public string? NewestVersion { get; init; }

		[JsonPropertyName("release_notes")]
		public string? ReleaseNotes { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record ButtonAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public record CameraAttributes
	{
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; init; }

		[JsonPropertyName("audio")]
		public string? Audio { get; init; }

		[JsonPropertyName("brand")]
		public string? Brand { get; init; }

		[JsonPropertyName("color_bw")]
		public string? ColorBw { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("frontend_stream_type")]
		public string? FrontendStreamType { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("model_name")]
		public string? ModelName { get; init; }

		[JsonPropertyName("motion_detection")]
		public bool? MotionDetection { get; init; }

		[JsonPropertyName("motion_recording")]
		public string? MotionRecording { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record ClimateAttributes
	{
		[JsonPropertyName("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }

		[JsonPropertyName("fan_modes")]
		public object? FanModes { get; init; }

		[JsonPropertyName("fan_state")]
		public string? FanState { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hvac_action")]
		public string? HvacAction { get; init; }

		[JsonPropertyName("hvac_modes")]
		public object? HvacModes { get; init; }

		[JsonPropertyName("max_temp")]
		public double? MaxTemp { get; init; }

		[JsonPropertyName("min_temp")]
		public double? MinTemp { get; init; }

		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }

		[JsonPropertyName("preset_modes")]
		public object? PresetModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("temperature")]
		public object? Temperature { get; init; }
	}

	public record CoverAttributes
	{
		[JsonPropertyName("current_position")]
		public double? CurrentPosition { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record DeviceTrackerAttributes
	{
		[JsonPropertyName("altitude")]
		public double? Altitude { get; init; }

		[JsonPropertyName("course")]
		public double? Course { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source_type")]
		public string? SourceType { get; init; }

		[JsonPropertyName("speed")]
		public double? Speed { get; init; }

		[JsonPropertyName("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }
	}

	public record FanAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("percentage")]
		public double? Percentage { get; init; }

		[JsonPropertyName("percentage_step")]
		public double? PercentageStep { get; init; }

		[JsonPropertyName("preset_mode")]
		public object? PresetMode { get; init; }

		[JsonPropertyName("preset_modes")]
		public object? PresetModes { get; init; }

		[JsonPropertyName("speed")]
		public string? Speed { get; init; }

		[JsonPropertyName("speed_list")]
		public object? SpeedList { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record InputBooleanAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public record InputDatetimeAttributes
	{
		[JsonPropertyName("day")]
		public double? Day { get; init; }

		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("has_date")]
		public bool? HasDate { get; init; }

		[JsonPropertyName("has_time")]
		public bool? HasTime { get; init; }

		[JsonPropertyName("hour")]
		public double? Hour { get; init; }

		[JsonPropertyName("minute")]
		public double? Minute { get; init; }

		[JsonPropertyName("month")]
		public double? Month { get; init; }

		[JsonPropertyName("second")]
		public double? Second { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }

		[JsonPropertyName("year")]
		public double? Year { get; init; }
	}

	public record InputNumberAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("initial")]
		public object? Initial { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }
	}

	public record InputTextAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("pattern")]
		public object? Pattern { get; init; }
	}

	public record LightAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("off_brightness")]
		public object? OffBrightness { get; init; }

		[JsonPropertyName("supported_color_modes")]
		public object? SupportedColorModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record LockAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public record MediaPlayerAttributes
	{
		[JsonPropertyName("app_name")]
		public string? AppName { get; init; }

		[JsonPropertyName("available")]
		public bool? Available { get; init; }

		[JsonPropertyName("bluetooth_list")]
		public object? BluetoothList { get; init; }

		[JsonPropertyName("connected_bluetooth")]
		public object? ConnectedBluetooth { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }

		[JsonPropertyName("last_called")]
		public bool? LastCalled { get; init; }

		[JsonPropertyName("last_called_summary")]
		public string? LastCalledSummary { get; init; }

		[JsonPropertyName("last_called_timestamp")]
		public double? LastCalledTimestamp { get; init; }

		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		[JsonPropertyName("media_position_updated_at")]
		public string? MediaPositionUpdatedAt { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("source_list")]
		public object? SourceList { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public record PersonAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("user_id")]
		public string? UserId { get; init; }
	}

	public record RemoteAttributes
	{
		[JsonPropertyName("activity_list")]
		public object? ActivityList { get; init; }

		[JsonPropertyName("activity_starting")]
		public object? ActivityStarting { get; init; }

		[JsonPropertyName("current_activity")]
		public string? CurrentActivity { get; init; }

		[JsonPropertyName("devices_list")]
		public object? DevicesList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("last_activity")]
		public string? LastActivity { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record SceneAttributes
	{
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }
	}

	public record ScriptAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public record SelectAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public record NumericSensorAttributes
	{
		[JsonPropertyName("battery_voltage")]
		public double? BatteryVoltage { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_type")]
		public string? DeviceType { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("marker_high_level")]
		public double? MarkerHighLevel { get; init; }

		[JsonPropertyName("marker_low_level")]
		public double? MarkerLowLevel { get; init; }

		[JsonPropertyName("marker_type")]
		public string? MarkerType { get; init; }

		[JsonPropertyName("measurement_type")]
		public string? MeasurementType { get; init; }

		[JsonPropertyName("repositories")]
		public object? Repositories { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public record SensorAttributes
	{
		[JsonPropertyName("code_slot")]
		public double? CodeSlot { get; init; }

		[JsonPropertyName("command_set")]
		public string? CommandSet { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("dismissed")]
		public object? Dismissed { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("info")]
		public string? Info { get; init; }

		[JsonPropertyName("location")]
		public string? Location { get; init; }

		[JsonPropertyName("prior_value")]
		public string? PriorValue { get; init; }

		[JsonPropertyName("process_timestamp")]
		public string? ProcessTimestamp { get; init; }

		[JsonPropertyName("recurrence")]
		public object? Recurrence { get; init; }

		[JsonPropertyName("reminder")]
		public object? Reminder { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("serial")]
		public object? Serial { get; init; }

		[JsonPropertyName("sorted_active")]
		public string? SortedActive { get; init; }

		[JsonPropertyName("sorted_all")]
		public string? SortedAll { get; init; }

		[JsonPropertyName("state_message")]
		public object? StateMessage { get; init; }

		[JsonPropertyName("state_reason")]
		public object? StateReason { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("total_active")]
		public double? TotalActive { get; init; }

		[JsonPropertyName("total_all")]
		public double? TotalAll { get; init; }

		[JsonPropertyName("uri_supported")]
		public string? UriSupported { get; init; }
	}

	public record SunAttributes
	{
		[JsonPropertyName("azimuth")]
		public double? Azimuth { get; init; }

		[JsonPropertyName("elevation")]
		public double? Elevation { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("next_dawn")]
		public string? NextDawn { get; init; }

		[JsonPropertyName("next_dusk")]
		public string? NextDusk { get; init; }

		[JsonPropertyName("next_midnight")]
		public string? NextMidnight { get; init; }

		[JsonPropertyName("next_noon")]
		public string? NextNoon { get; init; }

		[JsonPropertyName("next_rising")]
		public string? NextRising { get; init; }

		[JsonPropertyName("next_setting")]
		public string? NextSetting { get; init; }

		[JsonPropertyName("rising")]
		public bool? Rising { get; init; }
	}

	public record SwitchAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record TimerAttributes
	{
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }

		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public record VacuumAttributes
	{
		[JsonPropertyName("battery_icon")]
		public string? BatteryIcon { get; init; }

		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }

		[JsonPropertyName("fan_speed_list")]
		public object? FanSpeedList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("timers")]
		public object? Timers { get; init; }
	}

	public record WeatherAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("forecast")]
		public object? Forecast { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("pressure")]
		public double? Pressure { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("wind_bearing")]
		public double? WindBearing { get; init; }

		[JsonPropertyName("wind_speed")]
		public double? WindSpeed { get; init; }
	}

	public record ZoneAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("passive")]
		public bool? Passive { get; init; }

		[JsonPropertyName("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AlexaMediaServices AlexaMedia { get; }

		AmcrestServices Amcrest { get; }

		AutomationServices Automation { get; }

		ButtonServices Button { get; }

		CameraServices Camera { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DeviceTrackerServices DeviceTracker { get; }

		FanServices Fan { get; }

		FfmpegServices Ffmpeg { get; }

		FrontendServices Frontend { get; }

		GroupServices Group { get; }

		HarmonyServices Harmony { get; }

		HassioServices Hassio { get; }

		HomeassistantServices Homeassistant { get; }

		InputBooleanServices InputBoolean { get; }

		InputButtonServices InputButton { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		KeymasterServices Keymaster { get; }

		KodiServices Kodi { get; }

		LightServices Light { get; }

		LockServices Lock { get; }

		LogbookServices Logbook { get; }

		LoggerServices Logger { get; }

		MediaPlayerServices MediaPlayer { get; }

		MqttServices Mqtt { get; }

		NotifyServices Notify { get; }

		NumberServices Number { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		RecorderServices Recorder { get; }

		RemoteServices Remote { get; }

		RestCommandServices RestCommand { get; }

		RokuServices Roku { get; }

		SceneServices Scene { get; }

		ScriptServices Script { get; }

		SelectServices Select { get; }

		ShellCommandServices ShellCommand { get; }

		ShoppingListServices ShoppingList { get; }

		SirenServices Siren { get; }

		SwitchServices Switch { get; }

		SystemLogServices SystemLog { get; }

		TemplateServices Template { get; }

		TimerServices Timer { get; }

		TtsServices Tts { get; }

		VacuumServices Vacuum { get; }

		XiaomiMiioServices XiaomiMiio { get; }

		ZhaServices Zha { get; }

		ZoneServices Zone { get; }

		ZwaveJsServices ZwaveJs { get; }
	}

	public class Services : IServices
	{
		private readonly IHaContext _haContext;
		public Services(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
		public AlexaMediaServices AlexaMedia => new(_haContext);
		public AmcrestServices Amcrest => new(_haContext);
		public AutomationServices Automation => new(_haContext);
		public ButtonServices Button => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public FanServices Fan => new(_haContext);
		public FfmpegServices Ffmpeg => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HarmonyServices Harmony => new(_haContext);
		public HassioServices Hassio => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputButtonServices InputButton => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public KeymasterServices Keymaster => new(_haContext);
		public KodiServices Kodi => new(_haContext);
		public LightServices Light => new(_haContext);
		public LockServices Lock => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public LoggerServices Logger => new(_haContext);
		public MediaPlayerServices MediaPlayer => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public NumberServices Number => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public RemoteServices Remote => new(_haContext);
		public RestCommandServices RestCommand => new(_haContext);
		public RokuServices Roku => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SelectServices Select => new(_haContext);
		public ShellCommandServices ShellCommand => new(_haContext);
		public ShoppingListServices ShoppingList => new(_haContext);
		public SirenServices Siren => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TemplateServices Template => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public TtsServices Tts => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public XiaomiMiioServices XiaomiMiio => new(_haContext);
		public ZhaServices Zha => new(_haContext);
		public ZoneServices Zone => new(_haContext);
		public ZwaveJsServices ZwaveJs => new(_haContext);
	}

	public class AlarmControlPanelServices
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public void AlarmArmAway(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public void AlarmArmCustomBypass(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public void AlarmArmHome(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public void AlarmArmNight(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public void AlarmArmVacation(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public void AlarmDisarm(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public void AlarmTrigger(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmVacationParameters
	{
		///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class AlexaMediaServices
	{
		private readonly IHaContext _haContext;
		public AlexaMediaServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear last entries from Alexa history for each Alexa account.</summary>
		public void ClearHistory(AlexaMediaClearHistoryParameters data)
		{
			_haContext.CallService("alexa_media", "clear_history", null, data);
		}

		///<summary>Clear last entries from Alexa history for each Alexa account.</summary>
		///<param name="email">List of Alexa accounts to update. If empty, will delete from all known accounts. eg: my_email@alexa.com</param>
		///<param name="entries">Number of entries to clear from 1 to 50. If empty, clear 50. eg: 50</param>
		public void ClearHistory(object? @email = null, object? @entries = null)
		{
			_haContext.CallService("alexa_media", "clear_history", null, new AlexaMediaClearHistoryParameters{Email = @email, Entries = @entries});
		}

		///<summary>Force logout of Alexa Login account and deletion of .pickle. Intended for debugging use.</summary>
		public void ForceLogout(AlexaMediaForceLogoutParameters data)
		{
			_haContext.CallService("alexa_media", "force_logout", null, data);
		}

		///<summary>Force logout of Alexa Login account and deletion of .pickle. Intended for debugging use.</summary>
		///<param name="email">List of Alexa accounts to log out. If empty, will log out from all known accounts. eg: my_email@alexa.com</param>
		public void ForceLogout(object? @email = null)
		{
			_haContext.CallService("alexa_media", "force_logout", null, new AlexaMediaForceLogoutParameters{Email = @email});
		}

		///<summary>Forces update of last_called echo device for each Alexa account.</summary>
		public void UpdateLastCalled(AlexaMediaUpdateLastCalledParameters data)
		{
			_haContext.CallService("alexa_media", "update_last_called", null, data);
		}

		///<summary>Forces update of last_called echo device for each Alexa account.</summary>
		///<param name="email">List of Alexa accounts to update. If empty, will update all known accounts. eg: my_email@alexa.com</param>
		public void UpdateLastCalled(object? @email = null)
		{
			_haContext.CallService("alexa_media", "update_last_called", null, new AlexaMediaUpdateLastCalledParameters{Email = @email});
		}
	}

	public record AlexaMediaClearHistoryParameters
	{
		///<summary>List of Alexa accounts to update. If empty, will delete from all known accounts. eg: my_email@alexa.com</summary>
		[JsonPropertyName("email")]
		public object? Email { get; init; }

		///<summary>Number of entries to clear from 1 to 50. If empty, clear 50. eg: 50</summary>
		[JsonPropertyName("entries")]
		public object? Entries { get; init; }
	}

	public record AlexaMediaForceLogoutParameters
	{
		///<summary>List of Alexa accounts to log out. If empty, will log out from all known accounts. eg: my_email@alexa.com</summary>
		[JsonPropertyName("email")]
		public object? Email { get; init; }
	}

	public record AlexaMediaUpdateLastCalledParameters
	{
		///<summary>List of Alexa accounts to update. If empty, will update all known accounts. eg: my_email@alexa.com</summary>
		[JsonPropertyName("email")]
		public object? Email { get; init; }
	}

	public class AmcrestServices
	{
		private readonly IHaContext _haContext;
		public AmcrestServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable audio stream.</summary>
		public void DisableAudio(AmcrestDisableAudioParameters data)
		{
			_haContext.CallService("amcrest", "disable_audio", null, data);
		}

		///<summary>Disable audio stream.</summary>
		///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
		public void DisableAudio(string? @entityId = null)
		{
			_haContext.CallService("amcrest", "disable_audio", null, new AmcrestDisableAudioParameters{EntityId = @entityId});
		}

		///<summary>Disable recording a clip to camera storage when motion is detected.</summary>
		public void DisableMotionRecording(AmcrestDisableMotionRecordingParameters data)
		{
			_haContext.CallService("amcrest", "disable_motion_recording", null, data);
		}

		///<summary>Disable recording a clip to camera storage when motion is detected.</summary>
		///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
		public void DisableMotionRecording(string? @entityId = null)
		{
			_haContext.CallService("amcrest", "disable_motion_recording", null, new AmcrestDisableMotionRecordingParameters{EntityId = @entityId});
		}

		///<summary>Disable continuous recording to camera storage.</summary>
		public void DisableRecording(AmcrestDisableRecordingParameters data)
		{
			_haContext.CallService("amcrest", "disable_recording", null, data);
		}

		///<summary>Disable continuous recording to camera storage.</summary>
		///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
		public void DisableRecording(string? @entityId = null)
		{
			_haContext.CallService("amcrest", "disable_recording", null, new AmcrestDisableRecordingParameters{EntityId = @entityId});
		}

		///<summary>Enable audio stream.</summary>
		public void EnableAudio(AmcrestEnableAudioParameters data)
		{
			_haContext.CallService("amcrest", "enable_audio", null, data);
		}

		///<summary>Enable audio stream.</summary>
		///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
		public void EnableAudio(string? @entityId = null)
		{
			_haContext.CallService("amcrest", "enable_audio", null, new AmcrestEnableAudioParameters{EntityId = @entityId});
		}

		///<summary>Enable recording a clip to camera storage when motion is detected.</summary>
		public void EnableMotionRecording(AmcrestEnableMotionRecordingParameters data)
		{
			_haContext.CallService("amcrest", "enable_motion_recording", null, data);
		}

		///<summary>Enable recording a clip to camera storage when motion is detected.</summary>
		///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
		public void EnableMotionRecording(string? @entityId = null)
		{
			_haContext.CallService("amcrest", "enable_motion_recording", null, new AmcrestEnableMotionRecordingParameters{EntityId = @entityId});
		}

		///<summary>Enable continuous recording to camera storage.</summary>
		public void EnableRecording(AmcrestEnableRecordingParameters data)
		{
			_haContext.CallService("amcrest", "enable_recording", null, data);
		}

		///<summary>Enable continuous recording to camera storage.</summary>
		///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
		public void EnableRecording(string? @entityId = null)
		{
			_haContext.CallService("amcrest", "enable_recording", null, new AmcrestEnableRecordingParameters{EntityId = @entityId});
		}

		///<summary>Move camera to PTZ preset.</summary>
		public void GotoPreset(AmcrestGotoPresetParameters data)
		{
			_haContext.CallService("amcrest", "goto_preset", null, data);
		}

		///<summary>Move camera to PTZ preset.</summary>
		///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras.</param>
		///<param name="preset">Preset number.</param>
		public void GotoPreset(long @preset, string? @entityId = null)
		{
			_haContext.CallService("amcrest", "goto_preset", null, new AmcrestGotoPresetParameters{EntityId = @entityId, Preset = @preset});
		}

		///<summary>Move (Pan/Tilt) and/or Zoom a PTZ camera.</summary>
		public void PtzControl(AmcrestPtzControlParameters data)
		{
			_haContext.CallService("amcrest", "ptz_control", null, data);
		}

		///<summary>Move (Pan/Tilt) and/or Zoom a PTZ camera.</summary>
		///<param name="entityId">Name of the camera, or 'all' for all cameras. eg: camera.house_front</param>
		///<param name="movement">Direction to move the camera.</param>
		///<param name="travelTime">Travel time in fractional seconds: from 0 to 1.</param>
		public void PtzControl(string @movement, string? @entityId = null, double? @travelTime = null)
		{
			_haContext.CallService("amcrest", "ptz_control", null, new AmcrestPtzControlParameters{EntityId = @entityId, Movement = @movement, TravelTime = @travelTime});
		}

		///<summary>Set camera color mode.</summary>
		public void SetColorBw(AmcrestSetColorBwParameters data)
		{
			_haContext.CallService("amcrest", "set_color_bw", null, data);
		}

		///<summary>Set camera color mode.</summary>
		///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
		///<param name="colorBw">Color mode.</param>
		public void SetColorBw(string? @entityId = null, string? @colorBw = null)
		{
			_haContext.CallService("amcrest", "set_color_bw", null, new AmcrestSetColorBwParameters{EntityId = @entityId, ColorBw = @colorBw});
		}

		///<summary>Start camera's PTZ tour function.</summary>
		public void StartTour(AmcrestStartTourParameters data)
		{
			_haContext.CallService("amcrest", "start_tour", null, data);
		}

		///<summary>Start camera's PTZ tour function.</summary>
		///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
		public void StartTour(string? @entityId = null)
		{
			_haContext.CallService("amcrest", "start_tour", null, new AmcrestStartTourParameters{EntityId = @entityId});
		}

		///<summary>Stop camera's PTZ tour function.</summary>
		public void StopTour(AmcrestStopTourParameters data)
		{
			_haContext.CallService("amcrest", "stop_tour", null, data);
		}

		///<summary>Stop camera's PTZ tour function.</summary>
		///<param name="entityId">Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</param>
		public void StopTour(string? @entityId = null)
		{
			_haContext.CallService("amcrest", "stop_tour", null, new AmcrestStopTourParameters{EntityId = @entityId});
		}
	}

	public record AmcrestDisableAudioParameters
	{
		///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record AmcrestDisableMotionRecordingParameters
	{
		///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record AmcrestDisableRecordingParameters
	{
		///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record AmcrestEnableAudioParameters
	{
		///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record AmcrestEnableMotionRecordingParameters
	{
		///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record AmcrestEnableRecordingParameters
	{
		///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record AmcrestGotoPresetParameters
	{
		///<summary>Name(s) of the cameras, or 'all' for all cameras.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Preset number.</summary>
		[JsonPropertyName("preset")]
		public long? Preset { get; init; }
	}

	public record AmcrestPtzControlParameters
	{
		///<summary>Name of the camera, or 'all' for all cameras. eg: camera.house_front</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Direction to move the camera.</summary>
		[JsonPropertyName("movement")]
		public string? Movement { get; init; }

		///<summary>Travel time in fractional seconds: from 0 to 1.</summary>
		[JsonPropertyName("travel_time")]
		public double? TravelTime { get; init; }
	}

	public record AmcrestSetColorBwParameters
	{
		///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Color mode.</summary>
		[JsonPropertyName("color_bw")]
		public string? ColorBw { get; init; }
	}

	public record AmcrestStartTourParameters
	{
		///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record AmcrestStopTourParameters
	{
		///<summary>Name(s) of the cameras, or 'all' for all cameras. eg: camera.house_front</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public class AutomationServices
	{
		private readonly IHaContext _haContext;
		public AutomationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the automation configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[JsonPropertyName("skip_condition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
		[JsonPropertyName("stop_actions")]
		public bool? StopActions { get; init; }
	}

	public class ButtonServices
	{
		private readonly IHaContext _haContext;
		public ButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("button", "press", target);
		}
	}

	public class CameraServices
	{
		private readonly IHaContext _haContext;
		public CameraServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(ServiceTarget target, string @mediaPlayer, string? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[JsonPropertyName("media_player")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[JsonPropertyName("format")]
		public string? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class ClimateServices
	{
		private readonly IHaContext _haContext;
		public ClimateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(ServiceTarget target, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[JsonPropertyName("aux_heat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[JsonPropertyName("hvac_mode")]
		public string? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_high")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_low")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
		[JsonPropertyName("hvac_mode")]
		public string? HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly IHaContext _haContext;
		public CloudServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Make instance UI available outside over NabuCasa cloud</summary>
		public void RemoteConnect()
		{
			_haContext.CallService("cloud", "remote_connect", null);
		}

		///<summary>Disconnect UI from NabuCasa cloud</summary>
		public void RemoteDisconnect()
		{
			_haContext.CallService("cloud", "remote_disconnect", null);
		}
	}

	public class CounterServices
	{
		private readonly IHaContext _haContext;
		public CounterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public void Configure(ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
		[JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly IHaContext _haContext;
		public CoverServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
		[JsonPropertyName("tilt_position")]
		public long? TiltPosition { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Control tracked device.</summary>
		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		///<summary>Control tracked device.</summary>
		///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
		///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
		///<param name="hostName">Hostname of device eg: Dave</param>
		///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
		///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
		///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
		///<param name="battery">Battery level of device.</param>
		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters{Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery});
		}
	}

	public record DeviceTrackerSeeParameters
	{
		///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[JsonPropertyName("dev_id")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[JsonPropertyName("location_name")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[JsonPropertyName("gps_accuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
		[JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class FanServices
	{
		private readonly IHaContext _haContext;
		public FanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void DecreaseSpeed(ServiceTarget target, FanDecreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "decrease_speed", target, data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public void DecreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void IncreaseSpeed(ServiceTarget target, FanIncreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "increase_speed", target, data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public void IncreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		public void Oscillate(ServiceTarget target, FanOscillateParameters data)
		{
			_haContext.CallService("fan", "oscillate", target, data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public void Oscillate(ServiceTarget target, bool @oscillating)
		{
			_haContext.CallService("fan", "oscillate", target, new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDirection(ServiceTarget target, FanSetDirectionParameters data)
		{
			_haContext.CallService("fan", "set_direction", target, data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="direction">The direction to rotate.</param>
		public void SetDirection(ServiceTarget target, string @direction)
		{
			_haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPercentage(ServiceTarget target, FanSetPercentageParameters data)
		{
			_haContext.CallService("fan", "set_percentage", target, data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentage">Percentage speed setting.</param>
		public void SetPercentage(ServiceTarget target, long @percentage)
		{
			_haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, FanSetPresetModeParameters data)
		{
			_haContext.CallService("fan", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set fan speed.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSpeed(ServiceTarget target, FanSetSpeedParameters data)
		{
			_haContext.CallService("fan", "set_speed", target, data);
		}

		///<summary>Set fan speed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: low</param>
		public void SetSpeed(ServiceTarget target, string @speed)
		{
			_haContext.CallService("fan", "set_speed", target, new FanSetSpeedParameters{Speed = @speed});
		}

		///<summary>Toggle the fan on/off.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("fan", "toggle", target);
		}

		///<summary>Turn fan off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("fan", "turn_off", target);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, FanTurnOnParameters data)
		{
			_haContext.CallService("fan", "turn_on", target, data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public void TurnOn(ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			_haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public record FanDecreaseSpeedParameters
	{
		///<summary>Decrease speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanIncreaseSpeedParameters
	{
		///<summary>Increase speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanOscillateParameters
	{
		///<summary>Flag to turn on/off oscillation.</summary>
		[JsonPropertyName("oscillating")]
		public bool? Oscillating { get; init; }
	}

	public record FanSetDirectionParameters
	{
		///<summary>The direction to rotate.</summary>
		[JsonPropertyName("direction")]
		public string? Direction { get; init; }
	}

	public record FanSetPercentageParameters
	{
		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }
	}

	public record FanSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record FanSetSpeedParameters
	{
		///<summary>Speed setting. eg: low</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }
	}

	public record FanTurnOnParameters
	{
		///<summary>Speed setting. eg: high</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }

		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }

		///<summary>Preset mode setting. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public class FfmpegServices
	{
		private readonly IHaContext _haContext;
		public FfmpegServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		public void Restart(FfmpegRestartParameters data)
		{
			_haContext.CallService("ffmpeg", "restart", null, data);
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will restart. Platform dependent.</param>
		public void Restart(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "restart", null, new FfmpegRestartParameters{EntityId = @entityId});
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		public void Start(FfmpegStartParameters data)
		{
			_haContext.CallService("ffmpeg", "start", null, data);
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will start. Platform dependent.</param>
		public void Start(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "start", null, new FfmpegStartParameters{EntityId = @entityId});
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		public void Stop(FfmpegStopParameters data)
		{
			_haContext.CallService("ffmpeg", "stop", null, data);
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will stop. Platform dependent.</param>
		public void Stop(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "stop", null, new FfmpegStopParameters{EntityId = @entityId});
		}
	}

	public record FfmpegRestartParameters
	{
		///<summary>Name of entity that will restart. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStartParameters
	{
		///<summary>Name of entity that will start. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStopParameters
	{
		///<summary>Name of entity that will stop. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public class FrontendServices
	{
		private readonly IHaContext _haContext;
		public FrontendServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload themes from YAML configuration.</summary>
		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		///<param name="name">Name of a predefined theme, 'default' or 'none'. eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(string @name, string? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme, 'default' or 'none'. eg: default</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class GroupServices
	{
		private readonly IHaContext _haContext;
		public GroupServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload group configuration, entities, and notify services.</summary>
		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		///<summary>Remove a user group.</summary>
		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		///<summary>Remove a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new GroupRemoveParameters{ObjectId = @objectId});
		}

		///<summary>Create/Update a user group.</summary>
		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		///<summary>Create/Update a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		///<param name="name">Name of group eg: My test group</param>
		///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
		///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, string? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("add_entities")]
		public object? AddEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
		[JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HarmonyServices
	{
		private readonly IHaContext _haContext;
		public HarmonyServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends change channel command to the Harmony HUB</summary>
		///<param name="target">The target for this service call</param>
		public void ChangeChannel(ServiceTarget target, HarmonyChangeChannelParameters data)
		{
			_haContext.CallService("harmony", "change_channel", target, data);
		}

		///<summary>Sends change channel command to the Harmony HUB</summary>
		///<param name="target">The target for this service call</param>
		///<param name="channel">Channel number to change to</param>
		public void ChangeChannel(ServiceTarget target, long @channel)
		{
			_haContext.CallService("harmony", "change_channel", target, new HarmonyChangeChannelParameters{Channel = @channel});
		}

		///<summary>Syncs the remote's configuration.</summary>
		///<param name="target">The target for this service call</param>
		public void Sync(ServiceTarget target)
		{
			_haContext.CallService("harmony", "sync", target);
		}
	}

	public record HarmonyChangeChannelParameters
	{
		///<summary>Channel number to change to</summary>
		[JsonPropertyName("channel")]
		public long? Channel { get; init; }
	}

	public class HassioServices
	{
		private readonly IHaContext _haContext;
		public HassioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Restart add-on.</summary>
		public void AddonRestart(HassioAddonRestartParameters data)
		{
			_haContext.CallService("hassio", "addon_restart", null, data);
		}

		///<summary>Restart add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonRestart(string @addon)
		{
			_haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters{Addon = @addon});
		}

		///<summary>Start add-on.</summary>
		public void AddonStart(HassioAddonStartParameters data)
		{
			_haContext.CallService("hassio", "addon_start", null, data);
		}

		///<summary>Start add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStart(string @addon)
		{
			_haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters{Addon = @addon});
		}

		///<summary>Write data to add-on stdin.</summary>
		public void AddonStdin(HassioAddonStdinParameters data)
		{
			_haContext.CallService("hassio", "addon_stdin", null, data);
		}

		///<summary>Write data to add-on stdin.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStdin(string @addon)
		{
			_haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters{Addon = @addon});
		}

		///<summary>Stop add-on.</summary>
		public void AddonStop(HassioAddonStopParameters data)
		{
			_haContext.CallService("hassio", "addon_stop", null, data);
		}

		///<summary>Stop add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStop(string @addon)
		{
			_haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters{Addon = @addon});
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		public void AddonUpdate(HassioAddonUpdateParameters data)
		{
			_haContext.CallService("hassio", "addon_update", null, data);
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonUpdate(string @addon)
		{
			_haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters{Addon = @addon});
		}

		///<summary>Create a full backup.</summary>
		public void BackupFull(HassioBackupFullParameters data)
		{
			_haContext.CallService("hassio", "backup_full", null, data);
		}

		///<summary>Create a full backup.</summary>
		///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		public void BackupFull(string? @name = null, string? @password = null)
		{
			_haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters{Name = @name, Password = @password});
		}

		///<summary>Create a partial backup.</summary>
		public void BackupPartial(HassioBackupPartialParameters data)
		{
			_haContext.CallService("hassio", "backup_partial", null, data);
		}

		///<summary>Create a partial backup.</summary>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant", "share"]</param>
		///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		public void BackupPartial(object? @addons = null, object? @folders = null, string? @name = null, string? @password = null)
		{
			_haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters{Addons = @addons, Folders = @folders, Name = @name, Password = @password});
		}

		///<summary>Reboot the host system.</summary>
		public void HostReboot()
		{
			_haContext.CallService("hassio", "host_reboot", null);
		}

		///<summary>Poweroff the host system.</summary>
		public void HostShutdown()
		{
			_haContext.CallService("hassio", "host_shutdown", null);
		}

		///<summary>Restore from full backup.</summary>
		public void RestoreFull(HassioRestoreFullParameters data)
		{
			_haContext.CallService("hassio", "restore_full", null, data);
		}

		///<summary>Restore from full backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestoreFull(string @slug, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters{Slug = @slug, Password = @password});
		}

		///<summary>Restore from partial backup.</summary>
		public void RestorePartial(HassioRestorePartialParameters data)
		{
			_haContext.CallService("hassio", "restore_partial", null, data);
		}

		///<summary>Restore from partial backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="homeassistant">Restore Home Assistant</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant", "share"]</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters{Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password});
		}
	}

	public record HassioAddonRestartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStdinParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStopParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonUpdateParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioBackupFullParameters
	{
		///<summary>Optional (default = current date and time). eg: Backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioBackupPartialParameters
	{
		///<summary>Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant", "share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestoreFullParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestorePartialParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Restore Home Assistant</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant", "share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly IHaContext _haContext;
		public HomeassistantServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters{EntryId = @entryId});
		}

		///<summary>Reload the core configuration.</summary>
		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		///<summary>Restart the Home Assistant service.</summary>
		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
		public void SavePersistentStates()
		{
			_haContext.CallService("homeassistant", "save_persistent_states", null);
		}

		///<summary>Update the Home Assistant location.</summary>
		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		///<summary>Update the Home Assistant location.</summary>
		///<param name="latitude">Latitude of your location. eg: 32.87336</param>
		///<param name="longitude">Longitude of your location. eg: 117.22743</param>
		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters{Latitude = @latitude, Longitude = @longitude});
		}

		///<summary>Stop the Home Assistant service.</summary>
		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		///<summary>Generic service to toggle devices on/off under any domain</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[JsonPropertyName("entry_id")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32.87336</summary>
		[JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117.22743</summary>
		[JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly IHaContext _haContext;
		public InputBooleanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_boolean configuration</summary>
		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		///<summary>Toggle an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputButtonServices
	{
		private readonly IHaContext _haContext;
		public InputButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the input button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("input_button", "press", target);
		}

		public void Reload()
		{
			_haContext.CallService("input_button", "reload", null);
		}
	}

	public class InputDatetimeServices
	{
		private readonly IHaContext _haContext;
		public InputDatetimeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_datetime configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly IHaContext _haContext;
		public InputNumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		///<summary>Reload the input_number configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
		[JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly IHaContext _haContext;
		public InputSelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_select configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		///<summary>Select the first option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectFirst(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly IHaContext _haContext;
		public InputTextServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_text configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class KeymasterServices
	{
		private readonly IHaContext _haContext;
		public KeymasterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Supports ozw, zwave, and zwave_js locks.</summary>
		public void AddCode(KeymasterAddCodeParameters data)
		{
			_haContext.CallService("keymaster", "add_code", null, data);
		}

		///<summary>Supports ozw, zwave, and zwave_js locks.</summary>
		///<param name="entityId">Lock to add a code to</param>
		///<param name="codeSlot">The code slot you are attempting to add/replace a code into eg: 2</param>
		///<param name="usercode">The code you are attempting to set eg: 1234</param>
		public void AddCode(string @entityId, string @codeSlot, string @usercode)
		{
			_haContext.CallService("keymaster", "add_code", null, new KeymasterAddCodeParameters{EntityId = @entityId, CodeSlot = @codeSlot, Usercode = @usercode});
		}

		///<summary>Supports ozw, zwave, and zwave_js locks.</summary>
		public void ClearCode(KeymasterClearCodeParameters data)
		{
			_haContext.CallService("keymaster", "clear_code", null, data);
		}

		///<summary>Supports ozw, zwave, and zwave_js locks.</summary>
		///<param name="entityId">Lock to clear a code from</param>
		///<param name="codeSlot">The code slot you are attempting to clear eg: 2</param>
		public void ClearCode(string @entityId, string? @codeSlot = null)
		{
			_haContext.CallService("keymaster", "clear_code", null, new KeymasterClearCodeParameters{EntityId = @entityId, CodeSlot = @codeSlot});
		}

		///<summary>(Re-)Generates the package files that are used to provide the input helpers and automations that make Keymaster work</summary>
		public void GeneratePackage(KeymasterGeneratePackageParameters data)
		{
			_haContext.CallService("keymaster", "generate_package", null, data);
		}

		///<summary>(Re-)Generates the package files that are used to provide the input helpers and automations that make Keymaster work</summary>
		///<param name="lockname">The name that you specified during keymaster configuration. eg: frontdoor</param>
		public void GeneratePackage(string @lockname)
		{
			_haContext.CallService("keymaster", "generate_package", null, new KeymasterGeneratePackageParameters{Lockname = @lockname});
		}

		///<summary>Experimental. Only supports ozw locks for now, and may not be fully functional.</summary>
		public void RefreshCodes(KeymasterRefreshCodesParameters data)
		{
			_haContext.CallService("keymaster", "refresh_codes", null, data);
		}

		///<summary>Experimental. Only supports ozw locks for now, and may not be fully functional.</summary>
		///<param name="entityId">Lock to refresh codes on</param>
		public void RefreshCodes(string @entityId)
		{
			_haContext.CallService("keymaster", "refresh_codes", null, new KeymasterRefreshCodesParameters{EntityId = @entityId});
		}
	}

	public record KeymasterAddCodeParameters
	{
		///<summary>Lock to add a code to</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The code slot you are attempting to add/replace a code into eg: 2</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }

		///<summary>The code you are attempting to set eg: 1234</summary>
		[JsonPropertyName("usercode")]
		public string? Usercode { get; init; }
	}

	public record KeymasterClearCodeParameters
	{
		///<summary>Lock to clear a code from</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The code slot you are attempting to clear eg: 2</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record KeymasterGeneratePackageParameters
	{
		///<summary>The name that you specified during keymaster configuration. eg: frontdoor</summary>
		[JsonPropertyName("lockname")]
		public string? Lockname { get; init; }
	}

	public record KeymasterRefreshCodesParameters
	{
		///<summary>Lock to refresh codes on</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public class KodiServices
	{
		private readonly IHaContext _haContext;
		public KodiServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The target for this service call</param>
		public void AddToPlaylist(ServiceTarget target, KodiAddToPlaylistParameters data)
		{
			_haContext.CallService("kodi", "add_to_playlist", target, data);
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaType">Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</param>
		///<param name="mediaId">Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</param>
		///<param name="mediaName">Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</param>
		///<param name="artistName">Optional artist name for filtering media. eg: AC/DC</param>
		public void AddToPlaylist(ServiceTarget target, string @mediaType, string? @mediaId = null, string? @mediaName = null, string? @artistName = null)
		{
			_haContext.CallService("kodi", "add_to_playlist", target, new KodiAddToPlaylistParameters{MediaType = @mediaType, MediaId = @mediaId, MediaName = @mediaName, ArtistName = @artistName});
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The target for this service call</param>
		public void CallMethod(ServiceTarget target, KodiCallMethodParameters data)
		{
			_haContext.CallService("kodi", "call_method", target, data);
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="method">Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</param>
		public void CallMethod(ServiceTarget target, string @method)
		{
			_haContext.CallService("kodi", "call_method", target, new KodiCallMethodParameters{Method = @method});
		}
	}

	public record KodiAddToPlaylistParameters
	{
		///<summary>Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</summary>
		[JsonPropertyName("media_type")]
		public string? MediaType { get; init; }

		///<summary>Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</summary>
		[JsonPropertyName("media_id")]
		public string? MediaId { get; init; }

		///<summary>Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</summary>
		[JsonPropertyName("media_name")]
		public string? MediaName { get; init; }

		///<summary>Optional artist name for filtering media. eg: AC/DC</summary>
		[JsonPropertyName("artist_name")]
		public string? ArtistName { get; init; }
	}

	public record KodiCallMethodParameters
	{
		///<summary>Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</summary>
		[JsonPropertyName("method")]
		public string? Method { get; init; }
	}

	public class LightServices
	{
		private readonly IHaContext _haContext;
		public LightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target, LightToggleParameters data)
		{
			_haContext.CallService("light", "toggle", target, data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(ServiceTarget target, long? @transition = null, string? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public string? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public long? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating level of white.</summary>
		[JsonPropertyName("white_value")]
		public long? WhiteValue { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public string? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public string? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public string? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public long? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[JsonPropertyName("brightness_step")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[JsonPropertyName("brightness_step_pct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("white")]
		public long? White { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public string? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LockServices
	{
		private readonly IHaContext _haContext;
		public LockServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Lock(ServiceTarget target, LockLockParameters data)
		{
			_haContext.CallService("lock", "lock", target, data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public void Lock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "lock", target, new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Open(ServiceTarget target, LockOpenParameters data)
		{
			_haContext.CallService("lock", "open", target, data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public void Open(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "open", target, new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Unlock(ServiceTarget target, LockUnlockParameters data)
		{
			_haContext.CallService("lock", "unlock", target, data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public void Unlock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "unlock", target, new LockUnlockParameters{Code = @code});
		}
	}

	public record LockLockParameters
	{
		///<summary>An optional code to lock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockOpenParameters
	{
		///<summary>An optional code to open the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockUnlockParameters
	{
		///<summary>An optional code to unlock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class LogbookServices
	{
		private readonly IHaContext _haContext;
		public LogbookServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a custom entry in your logbook.</summary>
		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		///<summary>Create a custom entry in your logbook.</summary>
		///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
		///<param name="message">Message of the custom logbook entry. eg: is being used</param>
		///<param name="entityId">Entity to reference in custom logbook entry.</param>
		///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new LogbookLogParameters{Name = @name, Message = @message, EntityId = @entityId, Domain = @domain});
		}
	}

	public record LogbookLogParameters
	{
		///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
		[JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class LoggerServices
	{
		private readonly IHaContext _haContext;
		public LoggerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the default log level for integrations.</summary>
		public void SetDefaultLevel(LoggerSetDefaultLevelParameters data)
		{
			_haContext.CallService("logger", "set_default_level", null, data);
		}

		///<summary>Set the default log level for integrations.</summary>
		///<param name="level">Default severity level for all integrations.</param>
		public void SetDefaultLevel(string? @level = null)
		{
			_haContext.CallService("logger", "set_default_level", null, new LoggerSetDefaultLevelParameters{Level = @level});
		}

		///<summary>Set log level for integrations.</summary>
		public void SetLevel()
		{
			_haContext.CallService("logger", "set_level", null);
		}
	}

	public record LoggerSetDefaultLevelParameters
	{
		///<summary>Default severity level for all integrations.</summary>
		[JsonPropertyName("level")]
		public string? Level { get; init; }
	}

	public class MediaPlayerServices
	{
		private readonly IHaContext _haContext;
		public MediaPlayerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
		public void Join(ServiceTarget target, object? @groupMembers = null)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public void PlayMedia(ServiceTarget target, string @mediaContentId, string @mediaContentType)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(ServiceTarget target, string @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</summary>
		[JsonPropertyName("group_members")]
		public object? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[JsonPropertyName("seek_position")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[JsonPropertyName("repeat")]
		public string? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public class MqttServices
	{
		private readonly IHaContext _haContext;
		public MqttServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		public void Dump(MqttDumpParameters data)
		{
			_haContext.CallService("mqtt", "dump", null, data);
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		///<param name="topic">topic to listen to eg: OpenZWave/#</param>
		///<param name="duration">how long we should listen for messages in seconds</param>
		public void Dump(string? @topic = null, long? @duration = null)
		{
			_haContext.CallService("mqtt", "dump", null, new MqttDumpParameters{Topic = @topic, Duration = @duration});
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		public void Publish(MqttPublishParameters data)
		{
			_haContext.CallService("mqtt", "publish", null, data);
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		///<param name="topic">Topic to publish payload. eg: /homeassistant/hello</param>
		///<param name="payload">Payload to publish. eg: This is great</param>
		///<param name="payloadTemplate">Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</param>
		///<param name="qos">Quality of Service to use.</param>
		///<param name="retain">If message should have the retain flag set.</param>
		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, string? @qos = null, bool? @retain = null)
		{
			_haContext.CallService("mqtt", "publish", null, new MqttPublishParameters{Topic = @topic, Payload = @payload, PayloadTemplate = @payloadTemplate, Qos = @qos, Retain = @retain});
		}
	}

	public record MqttDumpParameters
	{
		///<summary>topic to listen to eg: OpenZWave/#</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>how long we should listen for messages in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>Payload to publish. eg: This is great</summary>
		[JsonPropertyName("payload")]
		public string? Payload { get; init; }

		///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
		[JsonPropertyName("payload_template")]
		public object? PayloadTemplate { get; init; }

		///<summary>Quality of Service to use.</summary>
		[JsonPropertyName("qos")]
		public string? Qos { get; init; }

		///<summary>If message should have the retain flag set.</summary>
		[JsonPropertyName("retain")]
		public bool? Retain { get; init; }
	}

	public class NotifyServices
	{
		private readonly IHaContext _haContext;
		public NotifyServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a notification message using the alexa_media service.</summary>
		public void AlexaMedia(NotifyAlexaMediaParameters data)
		{
			_haContext.CallService("notify", "alexa_media", null, data);
		}

		///<summary>Sends a notification message using the alexa_media service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMedia(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media", null, new NotifyAlexaMediaParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_antonella integration.</summary>
		public void AlexaMediaAntonella(NotifyAlexaMediaAntonellaParameters data)
		{
			_haContext.CallService("notify", "alexa_media_antonella", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_antonella integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaAntonella(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_antonella", null, new NotifyAlexaMediaAntonellaParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_camila integration.</summary>
		public void AlexaMediaCamila(NotifyAlexaMediaCamilaParameters data)
		{
			_haContext.CallService("notify", "alexa_media_camila", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_camila integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaCamila(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_camila", null, new NotifyAlexaMediaCamilaParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_el_fire_de_mariela integration.</summary>
		public void AlexaMediaElFireDeMariela(NotifyAlexaMediaElFireDeMarielaParameters data)
		{
			_haContext.CallService("notify", "alexa_media_el_fire_de_mariela", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_el_fire_de_mariela integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaElFireDeMariela(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_el_fire_de_mariela", null, new NotifyAlexaMediaElFireDeMarielaParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_everywhere integration.</summary>
		public void AlexaMediaEverywhere(NotifyAlexaMediaEverywhereParameters data)
		{
			_haContext.CallService("notify", "alexa_media_everywhere", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_everywhere integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaEverywhere(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_everywhere", null, new NotifyAlexaMediaEverywhereParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_kitchen integration.</summary>
		public void AlexaMediaKitchen(NotifyAlexaMediaKitchenParameters data)
		{
			_haContext.CallService("notify", "alexa_media_kitchen", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_kitchen integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaKitchen(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_kitchen", null, new NotifyAlexaMediaKitchenParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_last_called integration.</summary>
		public void AlexaMediaLastCalled(NotifyAlexaMediaLastCalledParameters data)
		{
			_haContext.CallService("notify", "alexa_media_last_called", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_last_called integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaLastCalled(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_last_called", null, new NotifyAlexaMediaLastCalledParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_3rd_echo_dot integration.</summary>
		public void AlexaMediaLucianoS3rdEchoDot(NotifyAlexaMediaLucianoS3rdEchoDotParameters data)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_3rd_echo_dot", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_3rd_echo_dot integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaLucianoS3rdEchoDot(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_3rd_echo_dot", null, new NotifyAlexaMediaLucianoS3rdEchoDotParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_alexa_listens integration.</summary>
		public void AlexaMediaLucianoSAlexaListens(NotifyAlexaMediaLucianoSAlexaListensParameters data)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_alexa_listens", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_alexa_listens integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaLucianoSAlexaListens(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_alexa_listens", null, new NotifyAlexaMediaLucianoSAlexaListensParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_fire integration.</summary>
		public void AlexaMediaLucianoSFire(NotifyAlexaMediaLucianoSFireParameters data)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_fire", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_fire integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaLucianoSFire(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_fire", null, new NotifyAlexaMediaLucianoSFireParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_firetvstick integration.</summary>
		public void AlexaMediaLucianoSFiretvstick(NotifyAlexaMediaLucianoSFiretvstickParameters data)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_firetvstick", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_firetvstick integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaLucianoSFiretvstick(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_firetvstick", null, new NotifyAlexaMediaLucianoSFiretvstickParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_ford_lincoln_alexa_app integration.</summary>
		public void AlexaMediaLucianoSFordLincolnAlexaApp(NotifyAlexaMediaLucianoSFordLincolnAlexaAppParameters data)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_ford_lincoln_alexa_app", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_ford_lincoln_alexa_app integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaLucianoSFordLincolnAlexaApp(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_ford_lincoln_alexa_app", null, new NotifyAlexaMediaLucianoSFordLincolnAlexaAppParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_tv integration.</summary>
		public void AlexaMediaLucianoSTv(NotifyAlexaMediaLucianoSTvParameters data)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_tv", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_luciano_s_tv integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaLucianoSTv(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_luciano_s_tv", null, new NotifyAlexaMediaLucianoSTvParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the alexa_media_this_device_2 integration.</summary>
		public void AlexaMediaThisDevice2(NotifyAlexaMediaThisDevice2Parameters data)
		{
			_haContext.CallService("notify", "alexa_media_this_device_2", null, data);
		}

		///<summary>Sends a notification message using the alexa_media_this_device_2 integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void AlexaMediaThisDevice2(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "alexa_media_this_device_2", null, new NotifyAlexaMediaThisDevice2Parameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_luciano_s_office_tablet integration.</summary>
		public void MobileAppLucianoSOfficeTablet(NotifyMobileAppLucianoSOfficeTabletParameters data)
		{
			_haContext.CallService("notify", "mobile_app_luciano_s_office_tablet", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_luciano_s_office_tablet integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppLucianoSOfficeTablet(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_luciano_s_office_tablet", null, new NotifyMobileAppLucianoSOfficeTabletParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_luciano_s_s21_phone integration.</summary>
		public void MobileAppLucianoSS21Phone(NotifyMobileAppLucianoSS21PhoneParameters data)
		{
			_haContext.CallService("notify", "mobile_app_luciano_s_s21_phone", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_luciano_s_s21_phone integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppLucianoSS21Phone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_luciano_s_s21_phone", null, new NotifyMobileAppLucianoSS21PhoneParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the notify service.</summary>
		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		///<summary>Sends a notification message using the notify service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new NotifyNotifyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification to the visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification to the visible in the front-end.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters{Message = @message, Title = @title});
		}
	}

	public record NotifyAlexaMediaParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaAntonellaParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaCamilaParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaElFireDeMarielaParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaEverywhereParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaKitchenParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaLastCalledParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaLucianoS3rdEchoDotParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaLucianoSAlexaListensParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaLucianoSFireParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaLucianoSFiretvstickParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaLucianoSFordLincolnAlexaAppParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaLucianoSTvParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyAlexaMediaThisDevice2Parameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppLucianoSOfficeTabletParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppLucianoSS21PhoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public class NumberServices
	{
		private readonly IHaContext _haContext;
		public NumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, NumberSetValueParameters data)
		{
			_haContext.CallService("number", "set_value", target, data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public void SetValue(ServiceTarget target, string? @value = null)
		{
			_haContext.CallService("number", "set_value", target, new NumberSetValueParameters{Value = @value});
		}
	}

	public record NumberSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: 42</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a notification in the frontend.</summary>
		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		///<summary>Show a notification in the frontend.</summary>
		///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
		///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
		///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters{Message = @message, Title = @title, NotificationId = @notificationId});
		}

		///<summary>Remove a notification from the frontend.</summary>
		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		///<summary>Remove a notification from the frontend.</summary>
		///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters{NotificationId = @notificationId});
		}

		///<summary>Mark a notification read.</summary>
		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		///<summary>Mark a notification read.</summary>
		///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters{NotificationId = @notificationId});
		}
	}

	public record PersistentNotificationCreateParameters
	{
		///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly IHaContext _haContext;
		public PersonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the person configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class RecorderServices
	{
		private readonly IHaContext _haContext;
		public RecorderServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Stop the recording of events and state changes</summary>
		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		///<summary>Start the recording of events and state changes</summary>
		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		///<param name="keepDays">Number of history days to keep in database after purge.</param>
		///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
		///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters{KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter});
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the regular expressions to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[JsonPropertyName("keep_days")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[JsonPropertyName("apply_filter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the regular expressions to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
		[JsonPropertyName("entity_globs")]
		public object? EntityGlobs { get; init; }
	}

	public class RemoteServices
	{
		private readonly IHaContext _haContext;
		public RemoteServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		public void DeleteCommand(ServiceTarget target, RemoteDeleteCommandParameters data)
		{
			_haContext.CallService("remote", "delete_command", target, data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public void DeleteCommand(ServiceTarget target, object @command, string? @device = null)
		{
			_haContext.CallService("remote", "delete_command", target, new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		public void LearnCommand(ServiceTarget target, RemoteLearnCommandParameters data)
		{
			_haContext.CallService("remote", "learn_command", target, data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public void LearnCommand(ServiceTarget target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			_haContext.CallService("remote", "learn_command", target, new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, RemoteSendCommandParameters data)
		{
			_haContext.CallService("remote", "send_command", target, data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public void SendCommand(ServiceTarget target, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			_haContext.CallService("remote", "send_command", target, new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("remote", "toggle", target);
		}

		///<summary>Sends the Power Off Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("remote", "turn_off", target);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, RemoteTurnOnParameters data)
		{
			_haContext.CallService("remote", "turn_on", target, data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public void TurnOn(ServiceTarget target, string? @activity = null)
		{
			_haContext.CallService("remote", "turn_on", target, new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public record RemoteDeleteCommandParameters
	{
		///<summary>Name of the device from which commands will be deleted. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to delete. eg: Mute</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }
	}

	public record RemoteLearnCommandParameters
	{
		///<summary>Device ID to learn command from. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to learn. eg: Turn on</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The type of command to be learned.</summary>
		[JsonPropertyName("command_type")]
		public string? CommandType { get; init; }

		///<summary>If code must be stored as alternative (useful for discrete remotes).</summary>
		[JsonPropertyName("alternative")]
		public bool? Alternative { get; init; }

		///<summary>Timeout for the command to be learned.</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }
	}

	public record RemoteSendCommandParameters
	{
		///<summary>Device ID to send command to. eg: 32756745</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to send. eg: Play</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>The number of times you want to repeat the command(s).</summary>
		[JsonPropertyName("num_repeats")]
		public long? NumRepeats { get; init; }

		///<summary>The time you want to wait in between repeated commands.</summary>
		[JsonPropertyName("delay_secs")]
		public double? DelaySecs { get; init; }

		///<summary>The time you want to have it held before the release is send.</summary>
		[JsonPropertyName("hold_secs")]
		public double? HoldSecs { get; init; }
	}

	public record RemoteTurnOnParameters
	{
		///<summary>Activity ID or Activity Name to start. eg: BedroomTV</summary>
		[JsonPropertyName("activity")]
		public string? Activity { get; init; }
	}

	public class RestCommandServices
	{
		private readonly IHaContext _haContext;
		public RestCommandServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void AmcrestDiscover()
		{
			_haContext.CallService("rest_command", "amcrest_discover", null);
		}
	}

	public class RokuServices
	{
		private readonly IHaContext _haContext;
		public RokuServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Emulates opening the search screen and entering the search keyword.</summary>
		///<param name="target">The target for this service call</param>
		public void Search(ServiceTarget target, RokuSearchParameters data)
		{
			_haContext.CallService("roku", "search", target, data);
		}

		///<summary>Emulates opening the search screen and entering the search keyword.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="keyword">The keyword to search for. eg: Space Jam</param>
		public void Search(ServiceTarget target, string @keyword)
		{
			_haContext.CallService("roku", "search", target, new RokuSearchParameters{Keyword = @keyword});
		}
	}

	public record RokuSearchParameters
	{
		///<summary>The keyword to search for. eg: Space Jam</summary>
		[JsonPropertyName("keyword")]
		public string? Keyword { get; init; }
	}

	public class SceneServices
	{
		private readonly IHaContext _haContext;
		public SceneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen": "on", "light.ceiling": {"state": "on", "brightness": 80}}</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new SceneApplyParameters{Entities = @entities, Transition = @transition});
		}

		///<summary>Creates a new scene.</summary>
		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		///<summary>Creates a new scene.</summary>
		///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light": "on", "light.ceiling": {"state": "on", "brightness": 200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling", "light.kitchen"]</param>
		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new SceneCreateParameters{SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities});
		}

		///<summary>Reload the scene configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen": "on", "light.ceiling": {"state": "on", "brightness": 80}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[JsonPropertyName("scene_id")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light": "on", "light.ceiling": {"state": "on", "brightness": 200}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling", "light.kitchen"]</summary>
		[JsonPropertyName("snapshot_entities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class ScriptServices
	{
		private readonly IHaContext _haContext;
		public ScriptServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void BoltcheckedLockFrontdoor()
		{
			_haContext.CallService("script", "boltchecked_lock_frontdoor", null);
		}

		public void BoltcheckedRetryFrontdoor()
		{
			_haContext.CallService("script", "boltchecked_retry_frontdoor", null);
		}

		public void Dummy()
		{
			_haContext.CallService("script", "dummy", null);
		}

		public void KeymasterFrontdoorResetCodeslot(ScriptKeymasterFrontdoorResetCodeslotParameters data)
		{
			_haContext.CallService("script", "keymaster_frontdoor_reset_codeslot", null, data);
		}

		///<param name="codeSlot">The code slot to reset eg: 1</param>
		public void KeymasterFrontdoorResetCodeslot(object? @codeSlot = null)
		{
			_haContext.CallService("script", "keymaster_frontdoor_reset_codeslot", null, new ScriptKeymasterFrontdoorResetCodeslotParameters{CodeSlot = @codeSlot});
		}

		public void KeymasterFrontdoorResetLock()
		{
			_haContext.CallService("script", "keymaster_frontdoor_reset_lock", null);
		}

		public void KeymasterFrontdoorStartTimer()
		{
			_haContext.CallService("script", "keymaster_frontdoor_start_timer", null);
		}

		public void ProjectorScreenDown()
		{
			_haContext.CallService("script", "projector_screen_down", null);
		}

		///<summary>Reload all the available scripts</summary>
		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		public void SecureHouse()
		{
			_haContext.CallService("script", "secure_house", null);
		}

		public void StarCockpit()
		{
			_haContext.CallService("script", "star_cockpit", null);
		}

		public void Telemundo()
		{
			_haContext.CallService("script", "telemundo", null);
		}

		///<summary>Toggle script</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		public void ToggleGarageDoor()
		{
			_haContext.CallService("script", "toggle_garage_door", null);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}
	}

	public record ScriptKeymasterFrontdoorResetCodeslotParameters
	{
		///<summary>The code slot to reset eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public object? CodeSlot { get; init; }
	}

	public class SelectServices
	{
		private readonly IHaContext _haContext;
		public SelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data)
		{
			_haContext.CallService("select", "select_option", target, data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters{Option = @option});
		}
	}

	public record SelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public class ShellCommandServices
	{
		private readonly IHaContext _haContext;
		public ShellCommandServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void ClearOldRecordings()
		{
			_haContext.CallService("shell_command", "clear_old_recordings", null);
		}
	}

	public class ShoppingListServices
	{
		private readonly IHaContext _haContext;
		public ShoppingListServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Add an item to the shopping list.</summary>
		public void AddItem(ShoppingListAddItemParameters data)
		{
			_haContext.CallService("shopping_list", "add_item", null, data);
		}

		///<summary>Add an item to the shopping list.</summary>
		///<param name="name">The name of the item to add. eg: Beer</param>
		public void AddItem(string @name)
		{
			_haContext.CallService("shopping_list", "add_item", null, new ShoppingListAddItemParameters{Name = @name});
		}

		///<summary>Clear completed items from the shopping list.</summary>
		public void ClearCompletedItems()
		{
			_haContext.CallService("shopping_list", "clear_completed_items", null);
		}

		///<summary>Marks all items as completed in the shopping list. It does not remove the items.</summary>
		public void CompleteAll()
		{
			_haContext.CallService("shopping_list", "complete_all", null);
		}

		///<summary>Mark an item as completed in the shopping list.</summary>
		public void CompleteItem(ShoppingListCompleteItemParameters data)
		{
			_haContext.CallService("shopping_list", "complete_item", null, data);
		}

		///<summary>Mark an item as completed in the shopping list.</summary>
		///<param name="name">The name of the item to mark as completed (without removing). eg: Beer</param>
		public void CompleteItem(string @name)
		{
			_haContext.CallService("shopping_list", "complete_item", null, new ShoppingListCompleteItemParameters{Name = @name});
		}

		///<summary>Marks all items as incomplete in the shopping list.</summary>
		public void IncompleteAll()
		{
			_haContext.CallService("shopping_list", "incomplete_all", null);
		}

		///<summary>Marks an item as incomplete in the shopping list.</summary>
		public void IncompleteItem(ShoppingListIncompleteItemParameters data)
		{
			_haContext.CallService("shopping_list", "incomplete_item", null, data);
		}

		///<summary>Marks an item as incomplete in the shopping list.</summary>
		///<param name="name">The name of the item to mark as incomplete. eg: Beer</param>
		public void IncompleteItem(string @name)
		{
			_haContext.CallService("shopping_list", "incomplete_item", null, new ShoppingListIncompleteItemParameters{Name = @name});
		}
	}

	public record ShoppingListAddItemParameters
	{
		///<summary>The name of the item to add. eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record ShoppingListCompleteItemParameters
	{
		///<summary>The name of the item to mark as completed (without removing). eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record ShoppingListIncompleteItemParameters
	{
		///<summary>The name of the item to mark as incomplete. eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public class SirenServices
	{
		private readonly IHaContext _haContext;
		public SirenServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a siren.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("siren", "toggle", target);
		}

		///<summary>Turn siren off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("siren", "turn_off", target);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
		{
			_haContext.CallService("siren", "turn_on", target, data);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
		///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</param>
		///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
		public void TurnOn(ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
		{
			_haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters{Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration});
		}
	}

	public record SirenTurnOnParameters
	{
		///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
		[JsonPropertyName("tone")]
		public string? Tone { get; init; }

		///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }

		///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class SwitchServices
	{
		private readonly IHaContext _haContext;
		public SwitchServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SystemLogServices
	{
		private readonly IHaContext _haContext;
		public SystemLogServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear all log entries.</summary>
		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		///<summary>Write log entry.</summary>
		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		///<summary>Write log entry.</summary>
		///<param name="message">Message to log. eg: Something went wrong</param>
		///<param name="level">Log level.</param>
		///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
		public void Write(string @message, string? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[JsonPropertyName("level")]
		public string? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
		[JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TemplateServices
	{
		private readonly IHaContext _haContext;
		public TemplateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all template entities.</summary>
		public void Reload()
		{
			_haContext.CallService("template", "reload", null);
		}
	}

	public class TimerServices
	{
		private readonly IHaContext _haContext;
		public TimerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class TtsServices
	{
		private readonly IHaContext _haContext;
		public TtsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
		public void ClearCache()
		{
			_haContext.CallService("tts", "clear_cache", null);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		public void GoogleTranslateSay(TtsGoogleTranslateSayParameters data)
		{
			_haContext.CallService("tts", "google_translate_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void GoogleTranslateSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "google_translate_say", null, new TtsGoogleTranslateSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}
	}

	public record TtsGoogleTranslateSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class VacuumServices
	{
		private readonly IHaContext _haContext;
		public VacuumServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }
	}

	public class XiaomiMiioServices
	{
		private readonly IHaContext _haContext;
		public XiaomiMiioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanSegment(ServiceTarget target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public void VacuumCleanSegment(ServiceTarget target, object? @segments = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanZone(ServiceTarget target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public void VacuumCleanZone(ServiceTarget target, object? @zone = null, long? @repeats = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumGoto(ServiceTarget target, XiaomiMiioVacuumGotoParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public void VacuumGoto(ServiceTarget target, string? @xCoord = null, string? @yCoord = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMove(ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMove(ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMoveStep(ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMoveStep(ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStart(ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_start", target);
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStop(ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_stop", target);
		}
	}

	public record XiaomiMiioVacuumCleanSegmentParameters
	{
		///<summary>Segments. eg: [1,2]</summary>
		[JsonPropertyName("segments")]
		public object? Segments { get; init; }
	}

	public record XiaomiMiioVacuumCleanZoneParameters
	{
		///<summary>Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</summary>
		[JsonPropertyName("zone")]
		public object? Zone { get; init; }

		///<summary>Number of cleaning repeats for each zone.</summary>
		[JsonPropertyName("repeats")]
		public long? Repeats { get; init; }
	}

	public record XiaomiMiioVacuumGotoParameters
	{
		///<summary>x-coordinate. eg: 27500</summary>
		[JsonPropertyName("x_coord")]
		public string? XCoord { get; init; }

		///<summary>y-coordinate. eg: 32000</summary>
		[JsonPropertyName("y_coord")]
		public string? YCoord { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveParameters
	{
		///<summary>Speed.</summary>
		[JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation, between -179 degrees and 179 degrees.</summary>
		[JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveStepParameters
	{
		///<summary>Speed.</summary>
		[JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation.</summary>
		[JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public class ZhaServices
	{
		private readonly IHaContext _haContext;
		public ZhaServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The target for this service call</param>
		public void ClearLockUserCode(ServiceTarget target, ZhaClearLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "clear_lock_user_code", target, data);
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public void ClearLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "clear_lock_user_code", target, new ZhaClearLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void DisableLockUserCode(ServiceTarget target, ZhaDisableLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "disable_lock_user_code", target, data);
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to disable eg: 1</param>
		public void DisableLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "disable_lock_user_code", target, new ZhaDisableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void EnableLockUserCode(ServiceTarget target, ZhaEnableLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "enable_lock_user_code", target, data);
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to enable eg: 1</param>
		public void EnableLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "enable_lock_user_code", target, new ZhaEnableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Issue command on the specified cluster on the specified entity.</summary>
		public void IssueZigbeeClusterCommand(ZhaIssueZigbeeClusterCommandParameters data)
		{
			_haContext.CallService("zha", "issue_zigbee_cluster_command", null, data);
		}

		///<summary>Issue command on the specified cluster on the specified entity.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="endpointId">Endpoint id for the cluster</param>
		///<param name="clusterId">ZCL cluster to retrieve attributes for</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="command">id of the command to execute</param>
		///<param name="commandType">type of the command to execute</param>
		///<param name="args">args to pass to the command eg: [arg1, arg2, argN]</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void IssueZigbeeClusterCommand(string @ieee, long @endpointId, long @clusterId, long @command, string @commandType, string? @clusterType = null, object? @args = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "issue_zigbee_cluster_command", null, new ZhaIssueZigbeeClusterCommandParameters{Ieee = @ieee, EndpointId = @endpointId, ClusterId = @clusterId, ClusterType = @clusterType, Command = @command, CommandType = @commandType, Args = @args, Manufacturer = @manufacturer});
		}

		///<summary>Issue command on the specified cluster on the specified group.</summary>
		public void IssueZigbeeGroupCommand(ZhaIssueZigbeeGroupCommandParameters data)
		{
			_haContext.CallService("zha", "issue_zigbee_group_command", null, data);
		}

		///<summary>Issue command on the specified cluster on the specified group.</summary>
		///<param name="group">Hexadecimal address of the group eg: 546</param>
		///<param name="clusterId">ZCL cluster to send command to</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="command">id of the command to execute</param>
		///<param name="args">args to pass to the command eg: [arg1, arg2, argN]</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void IssueZigbeeGroupCommand(string @group, long @clusterId, long @command, string? @clusterType = null, object? @args = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "issue_zigbee_group_command", null, new ZhaIssueZigbeeGroupCommandParameters{Group = @group, ClusterId = @clusterId, ClusterType = @clusterType, Command = @command, Args = @args, Manufacturer = @manufacturer});
		}

		///<summary>Allow nodes to join the Zigbee network.</summary>
		public void Permit(ZhaPermitParameters data)
		{
			_haContext.CallService("zha", "permit", null, data);
		}

		///<summary>Allow nodes to join the Zigbee network.</summary>
		///<param name="duration">Time to permit joins, in seconds</param>
		///<param name="ieee">IEEE address of the node permitting new joins eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="sourceIeee">IEEE address of the joining device (must be used with install code) eg: 00:0a:bf:00:01:10:23:35</param>
		///<param name="installCode">Install code of the joining device (must be used with source_ieee) eg: 1234-5678-1234-5678-AABB-CCDD-AABB-CCDD-EEFF</param>
		///<param name="qrCode">value of the QR install code (different between vendors) eg: Z:000D6FFFFED4163B$I:52797BF4A5084DAA8E1712B61741CA024051</param>
		public void Permit(long? @duration = null, string? @ieee = null, string? @sourceIeee = null, string? @installCode = null, string? @qrCode = null)
		{
			_haContext.CallService("zha", "permit", null, new ZhaPermitParameters{Duration = @duration, Ieee = @ieee, SourceIeee = @sourceIeee, InstallCode = @installCode, QrCode = @qrCode});
		}

		///<summary>Remove a node from the Zigbee network.</summary>
		public void Remove(ZhaRemoveParameters data)
		{
			_haContext.CallService("zha", "remove", null, data);
		}

		///<summary>Remove a node from the Zigbee network.</summary>
		///<param name="ieee">IEEE address of the node to remove eg: 00:0d:6f:00:05:7d:2d:34</param>
		public void Remove(string @ieee)
		{
			_haContext.CallService("zha", "remove", null, new ZhaRemoveParameters{Ieee = @ieee});
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void SetLockUserCode(ServiceTarget target, ZhaSetLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "set_lock_user_code", target, data);
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to set the code in eg: 1</param>
		///<param name="userCode">Code to set eg: 1234</param>
		public void SetLockUserCode(ServiceTarget target, string @codeSlot, string @userCode)
		{
			_haContext.CallService("zha", "set_lock_user_code", target, new ZhaSetLockUserCodeParameters{CodeSlot = @codeSlot, UserCode = @userCode});
		}

		///<summary>Set attribute value for the specified cluster on the specified entity.</summary>
		public void SetZigbeeClusterAttribute(ZhaSetZigbeeClusterAttributeParameters data)
		{
			_haContext.CallService("zha", "set_zigbee_cluster_attribute", null, data);
		}

		///<summary>Set attribute value for the specified cluster on the specified entity.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="endpointId">Endpoint id for the cluster</param>
		///<param name="clusterId">ZCL cluster to retrieve attributes for</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="attribute">id of the attribute to set eg: 0</param>
		///<param name="value">value to write to the attribute eg: 1</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void SetZigbeeClusterAttribute(string @ieee, long @endpointId, long @clusterId, long @attribute, string @value, string? @clusterType = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "set_zigbee_cluster_attribute", null, new ZhaSetZigbeeClusterAttributeParameters{Ieee = @ieee, EndpointId = @endpointId, ClusterId = @clusterId, ClusterType = @clusterType, Attribute = @attribute, Value = @value, Manufacturer = @manufacturer});
		}

		///<summary>This service uses the WD capabilities to emit a quick audible/visible pulse called a "squawk". The squawk command has no effect if the WD is currently active (warning in progress).</summary>
		public void WarningDeviceSquawk(ZhaWarningDeviceSquawkParameters data)
		{
			_haContext.CallService("zha", "warning_device_squawk", null, data);
		}

		///<summary>This service uses the WD capabilities to emit a quick audible/visible pulse called a "squawk". The squawk command has no effect if the WD is currently active (warning in progress).</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="mode">The Squawk Mode field is used as a 4-bit enumeration, and can have one of the values shown in Table 8-24 of the ZCL spec - Squawk Mode Field. The exact operation of each mode (how the WD “squawks”) is implementation specific.</param>
		///<param name="strobe">The strobe field is used as a Boolean, and determines if the visual indication is also required in addition to the audible squawk, as shown in Table 8-25 of the ZCL spec - Strobe Bit.</param>
		///<param name="level">The squawk level field is used as a 2-bit enumeration, and determines the intensity of audible squawk sound as shown in Table 8-26 of the ZCL spec - Squawk Level Field Values.</param>
		public void WarningDeviceSquawk(string @ieee, long? @mode = null, long? @strobe = null, long? @level = null)
		{
			_haContext.CallService("zha", "warning_device_squawk", null, new ZhaWarningDeviceSquawkParameters{Ieee = @ieee, Mode = @mode, Strobe = @strobe, Level = @level});
		}

		///<summary>This service starts the WD operation. The WD alerts the surrounding area by audible (siren) and visual (strobe) signals.</summary>
		public void WarningDeviceWarn(ZhaWarningDeviceWarnParameters data)
		{
			_haContext.CallService("zha", "warning_device_warn", null, data);
		}

		///<summary>This service starts the WD operation. The WD alerts the surrounding area by audible (siren) and visual (strobe) signals.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="mode">The Warning Mode field is used as an 4-bit enumeration, can have one of the values 0-6 defined below in table 8-20 of the ZCL spec. The exact behavior of the WD device in each mode is according to the relevant security standards.</param>
		///<param name="strobe">The Strobe field is used as a 2-bit enumeration, and determines if the visual indication is required in addition to the audible siren, as indicated in Table 8-21 of the ZCL spec. "0" means no strobe, "1" means strobe. If the strobe field is “1” and the Warning Mode is “0” (“Stop”) then only the strobe is activated.</param>
		///<param name="level">The Siren Level field is used as a 2-bit enumeration, and indicates the intensity of audible squawk sound as shown in Table 8-22 of the ZCL spec.</param>
		///<param name="duration">Requested duration of warning, in seconds (16 bit). If both Strobe and Warning Mode are "0" this field SHALL be ignored.</param>
		///<param name="dutyCycle">Indicates the length of the flash cycle. This provides a means of varying the flash duration for different alarm types (e.g., fire, police, burglar). Valid range is 0-100 in increments of 10. All other values SHALL be rounded to the nearest valid value. Strobe SHALL calculate duty cycle over a duration of one second. The ON state SHALL precede the OFF state. For example, if Strobe Duty Cycle Field specifies “40,” then the strobe SHALL flash ON for 4/10ths of a second and then turn OFF for 6/10ths of a second.</param>
		///<param name="intensity">Indicates the intensity of the strobe as shown in Table 8-23 of the ZCL spec. This attribute is designed to vary the output of the strobe (i.e., brightness) and not its frequency, which is detailed in section 8.4.2.3.1.6 of the ZCL spec.</param>
		public void WarningDeviceWarn(string @ieee, long? @mode = null, long? @strobe = null, long? @level = null, long? @duration = null, long? @dutyCycle = null, long? @intensity = null)
		{
			_haContext.CallService("zha", "warning_device_warn", null, new ZhaWarningDeviceWarnParameters{Ieee = @ieee, Mode = @mode, Strobe = @strobe, Level = @level, Duration = @duration, DutyCycle = @dutyCycle, Intensity = @intensity});
		}
	}

	public record ZhaClearLockUserCodeParameters
	{
		///<summary>Code slot to clear code from eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaDisableLockUserCodeParameters
	{
		///<summary>Code slot to disable eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaEnableLockUserCodeParameters
	{
		///<summary>Code slot to enable eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaIssueZigbeeClusterCommandParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>Endpoint id for the cluster</summary>
		[JsonPropertyName("endpoint_id")]
		public long? EndpointId { get; init; }

		///<summary>ZCL cluster to retrieve attributes for</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public string? ClusterType { get; init; }

		///<summary>id of the command to execute</summary>
		[JsonPropertyName("command")]
		public long? Command { get; init; }

		///<summary>type of the command to execute</summary>
		[JsonPropertyName("command_type")]
		public string? CommandType { get; init; }

		///<summary>args to pass to the command eg: [arg1, arg2, argN]</summary>
		[JsonPropertyName("args")]
		public object? Args { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaIssueZigbeeGroupCommandParameters
	{
		///<summary>Hexadecimal address of the group eg: 546</summary>
		[JsonPropertyName("group")]
		public string? Group { get; init; }

		///<summary>ZCL cluster to send command to</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public string? ClusterType { get; init; }

		///<summary>id of the command to execute</summary>
		[JsonPropertyName("command")]
		public long? Command { get; init; }

		///<summary>args to pass to the command eg: [arg1, arg2, argN]</summary>
		[JsonPropertyName("args")]
		public object? Args { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaPermitParameters
	{
		///<summary>Time to permit joins, in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>IEEE address of the node permitting new joins eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>IEEE address of the joining device (must be used with install code) eg: 00:0a:bf:00:01:10:23:35</summary>
		[JsonPropertyName("source_ieee")]
		public string? SourceIeee { get; init; }

		///<summary>Install code of the joining device (must be used with source_ieee) eg: 1234-5678-1234-5678-AABB-CCDD-AABB-CCDD-EEFF</summary>
		[JsonPropertyName("install_code")]
		public string? InstallCode { get; init; }

		///<summary>value of the QR install code (different between vendors) eg: Z:000D6FFFFED4163B$I:52797BF4A5084DAA8E1712B61741CA024051</summary>
		[JsonPropertyName("qr_code")]
		public string? QrCode { get; init; }
	}

	public record ZhaRemoveParameters
	{
		///<summary>IEEE address of the node to remove eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }
	}

	public record ZhaSetLockUserCodeParameters
	{
		///<summary>Code slot to set the code in eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }

		///<summary>Code to set eg: 1234</summary>
		[JsonPropertyName("user_code")]
		public string? UserCode { get; init; }
	}

	public record ZhaSetZigbeeClusterAttributeParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>Endpoint id for the cluster</summary>
		[JsonPropertyName("endpoint_id")]
		public long? EndpointId { get; init; }

		///<summary>ZCL cluster to retrieve attributes for</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public string? ClusterType { get; init; }

		///<summary>id of the attribute to set eg: 0</summary>
		[JsonPropertyName("attribute")]
		public long? Attribute { get; init; }

		///<summary>value to write to the attribute eg: 1</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaWarningDeviceSquawkParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>The Squawk Mode field is used as a 4-bit enumeration, and can have one of the values shown in Table 8-24 of the ZCL spec - Squawk Mode Field. The exact operation of each mode (how the WD “squawks”) is implementation specific.</summary>
		[JsonPropertyName("mode")]
		public long? Mode { get; init; }

		///<summary>The strobe field is used as a Boolean, and determines if the visual indication is also required in addition to the audible squawk, as shown in Table 8-25 of the ZCL spec - Strobe Bit.</summary>
		[JsonPropertyName("strobe")]
		public long? Strobe { get; init; }

		///<summary>The squawk level field is used as a 2-bit enumeration, and determines the intensity of audible squawk sound as shown in Table 8-26 of the ZCL spec - Squawk Level Field Values.</summary>
		[JsonPropertyName("level")]
		public long? Level { get; init; }
	}

	public record ZhaWarningDeviceWarnParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>The Warning Mode field is used as an 4-bit enumeration, can have one of the values 0-6 defined below in table 8-20 of the ZCL spec. The exact behavior of the WD device in each mode is according to the relevant security standards.</summary>
		[JsonPropertyName("mode")]
		public long? Mode { get; init; }

		///<summary>The Strobe field is used as a 2-bit enumeration, and determines if the visual indication is required in addition to the audible siren, as indicated in Table 8-21 of the ZCL spec. "0" means no strobe, "1" means strobe. If the strobe field is “1” and the Warning Mode is “0” (“Stop”) then only the strobe is activated.</summary>
		[JsonPropertyName("strobe")]
		public long? Strobe { get; init; }

		///<summary>The Siren Level field is used as a 2-bit enumeration, and indicates the intensity of audible squawk sound as shown in Table 8-22 of the ZCL spec.</summary>
		[JsonPropertyName("level")]
		public long? Level { get; init; }

		///<summary>Requested duration of warning, in seconds (16 bit). If both Strobe and Warning Mode are "0" this field SHALL be ignored.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Indicates the length of the flash cycle. This provides a means of varying the flash duration for different alarm types (e.g., fire, police, burglar). Valid range is 0-100 in increments of 10. All other values SHALL be rounded to the nearest valid value. Strobe SHALL calculate duty cycle over a duration of one second. The ON state SHALL precede the OFF state. For example, if Strobe Duty Cycle Field specifies “40,” then the strobe SHALL flash ON for 4/10ths of a second and then turn OFF for 6/10ths of a second.</summary>
		[JsonPropertyName("duty_cycle")]
		public long? DutyCycle { get; init; }

		///<summary>Indicates the intensity of the strobe as shown in Table 8-23 of the ZCL spec. This attribute is designed to vary the output of the strobe (i.e., brightness) and not its frequency, which is detailed in section 8.4.2.3.1.6 of the ZCL spec.</summary>
		[JsonPropertyName("intensity")]
		public long? Intensity { get; init; }
	}

	public class ZoneServices
	{
		private readonly IHaContext _haContext;
		public ZoneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public class ZwaveJsServices
	{
		private readonly IHaContext _haContext;
		public ZwaveJsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Allow for bulk setting partial parameters. Useful when multiple partial parameters have to be set at the same time.</summary>
		///<param name="target">The target for this service call</param>
		public void BulkSetPartialConfigParameters(ServiceTarget target, ZwaveJsBulkSetPartialConfigParametersParameters data)
		{
			_haContext.CallService("zwave_js", "bulk_set_partial_config_parameters", target, data);
		}

		///<summary>Allow for bulk setting partial parameters. Useful when multiple partial parameters have to be set at the same time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="parameter">The id of the configuration parameter you want to configure. eg: 9</param>
		///<param name="value">The new value(s) to set for this configuration parameter. Can either be a raw integer value to represent the bulk change or a mapping where the key is the bitmask (either in hex or integer form) and the value is the new value you want to set for that partial parameter. eg: {"0x1": 1, "0x10": 1, "0x20": 1, "0x40": 1}</param>
		public void BulkSetPartialConfigParameters(ServiceTarget target, string @parameter, object @value)
		{
			_haContext.CallService("zwave_js", "bulk_set_partial_config_parameters", target, new ZwaveJsBulkSetPartialConfigParametersParameters{Parameter = @parameter, Value = @value});
		}

		///<summary>Clear a usercode from a lock</summary>
		///<param name="target">The target for this service call</param>
		public void ClearLockUsercode(ServiceTarget target, ZwaveJsClearLockUsercodeParameters data)
		{
			_haContext.CallService("zwave_js", "clear_lock_usercode", target, data);
		}

		///<summary>Clear a usercode from a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public void ClearLockUsercode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zwave_js", "clear_lock_usercode", target, new ZwaveJsClearLockUsercodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on multiple Z-Wave devices using multicast, so all devices receive the message simultaneously. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		public void MulticastSetValue(ServiceTarget target, ZwaveJsMulticastSetValueParameters data)
		{
			_haContext.CallService("zwave_js", "multicast_set_value", target, data);
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on multiple Z-Wave devices using multicast, so all devices receive the message simultaneously. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="broadcast">Whether command should be broadcast to all devices on the networrk. eg: True</param>
		///<param name="commandClass">The ID of the command class for the value. eg: 117</param>
		///<param name="endpoint">The endpoint for the value. eg: 1</param>
		///<param name="property">The ID of the property for the value. eg: currentValue</param>
		///<param name="propertyKey">The ID of the property key for the value eg: 1</param>
		///<param name="options">Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</param>
		///<param name="value">The new value to set. eg: ffbb99</param>
		public void MulticastSetValue(ServiceTarget target, string @commandClass, string @property, object @value, bool? @broadcast = null, string? @endpoint = null, string? @propertyKey = null, object? @options = null)
		{
			_haContext.CallService("zwave_js", "multicast_set_value", target, new ZwaveJsMulticastSetValueParameters{Broadcast = @broadcast, CommandClass = @commandClass, Endpoint = @endpoint, Property = @property, PropertyKey = @propertyKey, Options = @options, Value = @value});
		}

		///<summary>Forces Z-Wave JS to try to reach a node. This can be used to update the status of the node in Z-Wave JS when you think it doesn't accurately reflect reality, e.g. reviving a failed/dead node or marking the node as asleep.</summary>
		///<param name="target">The target for this service call</param>
		public void Ping(ServiceTarget target)
		{
			_haContext.CallService("zwave_js", "ping", target);
		}

		///<summary>Force update value(s) for a Z-Wave entity</summary>
		public void RefreshValue(ZwaveJsRefreshValueParameters data)
		{
			_haContext.CallService("zwave_js", "refresh_value", null, data);
		}

		///<summary>Force update value(s) for a Z-Wave entity</summary>
		///<param name="entityId">Entity whose value(s) should be refreshed eg: sensor.family_room_motion</param>
		///<param name="refreshAllValues">Whether to refresh all values (true) or just the primary value (false)</param>
		public void RefreshValue(string @entityId, bool? @refreshAllValues = null)
		{
			_haContext.CallService("zwave_js", "refresh_value", null, new ZwaveJsRefreshValueParameters{EntityId = @entityId, RefreshAllValues = @refreshAllValues});
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The target for this service call</param>
		public void ResetMeter(ServiceTarget target, ZwaveJsResetMeterParameters data)
		{
			_haContext.CallService("zwave_js", "reset_meter", target, data);
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="meterType">The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</param>
		///<param name="value">The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</param>
		public void ResetMeter(ServiceTarget target, string? @meterType = null, string? @value = null)
		{
			_haContext.CallService("zwave_js", "reset_meter", target, new ZwaveJsResetMeterParameters{MeterType = @meterType, Value = @value});
		}

		///<summary>Allow for changing configuration parameters of your Z-Wave devices.</summary>
		///<param name="target">The target for this service call</param>
		public void SetConfigParameter(ServiceTarget target, ZwaveJsSetConfigParameterParameters data)
		{
			_haContext.CallService("zwave_js", "set_config_parameter", target, data);
		}

		///<summary>Allow for changing configuration parameters of your Z-Wave devices.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="parameter">The (name or id of the) configuration parameter you want to configure. eg: Minimum brightness level</param>
		///<param name="value">The new value to set for this configuration parameter. eg: 5</param>
		///<param name="bitmask">Target a specific bitmask (see the documentation for more information).</param>
		public void SetConfigParameter(ServiceTarget target, string @parameter, string @value, string? @bitmask = null)
		{
			_haContext.CallService("zwave_js", "set_config_parameter", target, new ZwaveJsSetConfigParameterParameters{Parameter = @parameter, Value = @value, Bitmask = @bitmask});
		}

		///<summary>Set a usercode on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void SetLockUsercode(ServiceTarget target, ZwaveJsSetLockUsercodeParameters data)
		{
			_haContext.CallService("zwave_js", "set_lock_usercode", target, data);
		}

		///<summary>Set a usercode on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to set the code. eg: 1</param>
		///<param name="usercode">Code to set. eg: 1234</param>
		public void SetLockUsercode(ServiceTarget target, string @codeSlot, string @usercode)
		{
			_haContext.CallService("zwave_js", "set_lock_usercode", target, new ZwaveJsSetLockUsercodeParameters{CodeSlot = @codeSlot, Usercode = @usercode});
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on a Z-Wave device. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, ZwaveJsSetValueParameters data)
		{
			_haContext.CallService("zwave_js", "set_value", target, data);
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on a Z-Wave device. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="commandClass">The ID of the command class for the value. eg: 117</param>
		///<param name="endpoint">The endpoint for the value. eg: 1</param>
		///<param name="property">The ID of the property for the value. eg: currentValue</param>
		///<param name="propertyKey">The ID of the property key for the value eg: 1</param>
		///<param name="value">The new value to set. eg: ffbb99</param>
		///<param name="options">Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</param>
		///<param name="waitForResult">Whether or not to wait for a response from the node. If not included in the payload, the integration will decide whether to wait or not. If set to `true`, note that the service call can take a while if setting a value on an asleep battery device.</param>
		public void SetValue(ServiceTarget target, string @commandClass, string @property, object @value, string? @endpoint = null, string? @propertyKey = null, object? @options = null, bool? @waitForResult = null)
		{
			_haContext.CallService("zwave_js", "set_value", target, new ZwaveJsSetValueParameters{CommandClass = @commandClass, Endpoint = @endpoint, Property = @property, PropertyKey = @propertyKey, Value = @value, Options = @options, WaitForResult = @waitForResult});
		}
	}

	public record ZwaveJsBulkSetPartialConfigParametersParameters
	{
		///<summary>The id of the configuration parameter you want to configure. eg: 9</summary>
		[JsonPropertyName("parameter")]
		public string? Parameter { get; init; }

		///<summary>The new value(s) to set for this configuration parameter. Can either be a raw integer value to represent the bulk change or a mapping where the key is the bitmask (either in hex or integer form) and the value is the new value you want to set for that partial parameter. eg: {"0x1": 1, "0x10": 1, "0x20": 1, "0x40": 1}</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }
	}

	public record ZwaveJsClearLockUsercodeParameters
	{
		///<summary>Code slot to clear code from eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZwaveJsMulticastSetValueParameters
	{
		///<summary>Whether command should be broadcast to all devices on the networrk. eg: True</summary>
		[JsonPropertyName("broadcast")]
		public bool? Broadcast { get; init; }

		///<summary>The ID of the command class for the value. eg: 117</summary>
		[JsonPropertyName("command_class")]
		public string? CommandClass { get; init; }

		///<summary>The endpoint for the value. eg: 1</summary>
		[JsonPropertyName("endpoint")]
		public string? Endpoint { get; init; }

		///<summary>The ID of the property for the value. eg: currentValue</summary>
		[JsonPropertyName("property")]
		public string? Property { get; init; }

		///<summary>The ID of the property key for the value eg: 1</summary>
		[JsonPropertyName("property_key")]
		public string? PropertyKey { get; init; }

		///<summary>Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The new value to set. eg: ffbb99</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }
	}

	public record ZwaveJsRefreshValueParameters
	{
		///<summary>Entity whose value(s) should be refreshed eg: sensor.family_room_motion</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Whether to refresh all values (true) or just the primary value (false)</summary>
		[JsonPropertyName("refresh_all_values")]
		public bool? RefreshAllValues { get; init; }
	}

	public record ZwaveJsResetMeterParameters
	{
		///<summary>The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</summary>
		[JsonPropertyName("meter_type")]
		public string? MeterType { get; init; }

		///<summary>The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public record ZwaveJsSetConfigParameterParameters
	{
		///<summary>The (name or id of the) configuration parameter you want to configure. eg: Minimum brightness level</summary>
		[JsonPropertyName("parameter")]
		public string? Parameter { get; init; }

		///<summary>The new value to set for this configuration parameter. eg: 5</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }

		///<summary>Target a specific bitmask (see the documentation for more information).</summary>
		[JsonPropertyName("bitmask")]
		public string? Bitmask { get; init; }
	}

	public record ZwaveJsSetLockUsercodeParameters
	{
		///<summary>Code slot to set the code. eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }

		///<summary>Code to set. eg: 1234</summary>
		[JsonPropertyName("usercode")]
		public string? Usercode { get; init; }
	}

	public record ZwaveJsSetValueParameters
	{
		///<summary>The ID of the command class for the value. eg: 117</summary>
		[JsonPropertyName("command_class")]
		public string? CommandClass { get; init; }

		///<summary>The endpoint for the value. eg: 1</summary>
		[JsonPropertyName("endpoint")]
		public string? Endpoint { get; init; }

		///<summary>The ID of the property for the value. eg: currentValue</summary>
		[JsonPropertyName("property")]
		public string? Property { get; init; }

		///<summary>The ID of the property key for the value eg: 1</summary>
		[JsonPropertyName("property_key")]
		public string? PropertyKey { get; init; }

		///<summary>The new value to set. eg: ffbb99</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }

		///<summary>Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>Whether or not to wait for a response from the node. If not included in the payload, the integration will decide whether to wait or not. If set to `true`, note that the service call can take a while if setting a value on an asleep battery device.</summary>
		[JsonPropertyName("wait_for_result")]
		public bool? WaitForResult { get; init; }
	}

	public static class AlarmControlPanelEntityExtensionMethods
	{
		///<summary>Send the alarm the command for arm away.</summary>
		public static void AlarmArmAway(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			target.CallService("alarm_arm_away", data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		public static void AlarmArmAway(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			target.CallService("alarm_arm_away", data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public static void AlarmArmAway(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_away", new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public static void AlarmArmAway(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_away", new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			target.CallService("alarm_arm_custom_bypass", data);
		}

		///<summary>Send arm custom bypass command.</summary>
		public static void AlarmArmCustomBypass(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			target.CallService("alarm_arm_custom_bypass", data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public static void AlarmArmCustomBypass(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_custom_bypass", new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public static void AlarmArmCustomBypass(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_custom_bypass", new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		public static void AlarmArmHome(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			target.CallService("alarm_arm_home", data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		public static void AlarmArmHome(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			target.CallService("alarm_arm_home", data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public static void AlarmArmHome(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_home", new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public static void AlarmArmHome(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_home", new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		public static void AlarmArmNight(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmNightParameters data)
		{
			target.CallService("alarm_arm_night", data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		public static void AlarmArmNight(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmNightParameters data)
		{
			target.CallService("alarm_arm_night", data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public static void AlarmArmNight(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_night", new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public static void AlarmArmNight(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_night", new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		public static void AlarmArmVacation(this AlarmControlPanelEntity target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			target.CallService("alarm_arm_vacation", data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		public static void AlarmArmVacation(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			target.CallService("alarm_arm_vacation", data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public static void AlarmArmVacation(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_arm_vacation", new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public static void AlarmArmVacation(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_arm_vacation", new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		public static void AlarmDisarm(this AlarmControlPanelEntity target, AlarmControlPanelAlarmDisarmParameters data)
		{
			target.CallService("alarm_disarm", data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		public static void AlarmDisarm(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmDisarmParameters data)
		{
			target.CallService("alarm_disarm", data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public static void AlarmDisarm(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_disarm", new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public static void AlarmDisarm(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_disarm", new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		public static void AlarmTrigger(this AlarmControlPanelEntity target, AlarmControlPanelAlarmTriggerParameters data)
		{
			target.CallService("alarm_trigger", data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		public static void AlarmTrigger(this IEnumerable<AlarmControlPanelEntity> target, AlarmControlPanelAlarmTriggerParameters data)
		{
			target.CallService("alarm_trigger", data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The AlarmControlPanelEntity to call this service for</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public static void AlarmTrigger(this AlarmControlPanelEntity target, string? @code = null)
		{
			target.CallService("alarm_trigger", new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The IEnumerable<AlarmControlPanelEntity> to call this service for</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public static void AlarmTrigger(this IEnumerable<AlarmControlPanelEntity> target, string? @code = null)
		{
			target.CallService("alarm_trigger", new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public static class AutomationEntityExtensionMethods
	{
		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this AutomationEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this AutomationEntity target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this IEnumerable<AutomationEntity> target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this AutomationEntity target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this IEnumerable<AutomationEntity> target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this AutomationEntity target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this AutomationEntity target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this AutomationEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ButtonEntityExtensionMethods
	{
		///<summary>Press the button entity.</summary>
		public static void Press(this ButtonEntity target)
		{
			target.CallService("press");
		}

		///<summary>Press the button entity.</summary>
		public static void Press(this IEnumerable<ButtonEntity> target)
		{
			target.CallService("press");
		}
	}

	public static class CameraEntityExtensionMethods
	{
		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this CameraEntity target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this CameraEntity target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this CameraEntity target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this IEnumerable<CameraEntity> target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this CameraEntity target, string @mediaPlayer, string? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this IEnumerable<CameraEntity> target, string @mediaPlayer, string? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this CameraEntity target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this IEnumerable<CameraEntity> target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this CameraEntity target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this IEnumerable<CameraEntity> target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this CameraEntity target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this IEnumerable<CameraEntity> target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this CameraEntity target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this IEnumerable<CameraEntity> target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this CameraEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this CameraEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this ClimateEntity target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this ClimateEntity target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this ClimateEntity target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this ClimateEntity target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this ClimateEntity target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this ClimateEntity target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this ClimateEntity target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this ClimateEntity target, string? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, string? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this ClimateEntity target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this ClimateEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this ClimateEntity target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this ClimateEntity target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this ClimateEntity target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this ClimateEntity target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this ClimateEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this ClimateEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class CoverEntityExtensionMethods
	{
		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this CoverEntity target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this CoverEntity target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this CoverEntity target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this CoverEntity target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this CoverEntity target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this CoverEntity target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this CoverEntity target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this CoverEntity target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this CoverEntity target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this CoverEntity target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this CoverEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this CoverEntity target)
		{
			target.CallService("toggle_cover_tilt");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle_cover_tilt");
		}
	}

	public static class FanEntityExtensionMethods
	{
		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		public static void DecreaseSpeed(this FanEntity target, FanDecreaseSpeedParameters data)
		{
			target.CallService("decrease_speed", data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		public static void DecreaseSpeed(this IEnumerable<FanEntity> target, FanDecreaseSpeedParameters data)
		{
			target.CallService("decrease_speed", data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public static void DecreaseSpeed(this FanEntity target, long? @percentageStep = null)
		{
			target.CallService("decrease_speed", new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public static void DecreaseSpeed(this IEnumerable<FanEntity> target, long? @percentageStep = null)
		{
			target.CallService("decrease_speed", new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		public static void IncreaseSpeed(this FanEntity target, FanIncreaseSpeedParameters data)
		{
			target.CallService("increase_speed", data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		public static void IncreaseSpeed(this IEnumerable<FanEntity> target, FanIncreaseSpeedParameters data)
		{
			target.CallService("increase_speed", data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public static void IncreaseSpeed(this FanEntity target, long? @percentageStep = null)
		{
			target.CallService("increase_speed", new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public static void IncreaseSpeed(this IEnumerable<FanEntity> target, long? @percentageStep = null)
		{
			target.CallService("increase_speed", new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		public static void Oscillate(this FanEntity target, FanOscillateParameters data)
		{
			target.CallService("oscillate", data);
		}

		///<summary>Oscillate the fan.</summary>
		public static void Oscillate(this IEnumerable<FanEntity> target, FanOscillateParameters data)
		{
			target.CallService("oscillate", data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public static void Oscillate(this FanEntity target, bool @oscillating)
		{
			target.CallService("oscillate", new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public static void Oscillate(this IEnumerable<FanEntity> target, bool @oscillating)
		{
			target.CallService("oscillate", new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		public static void SetDirection(this FanEntity target, FanSetDirectionParameters data)
		{
			target.CallService("set_direction", data);
		}

		///<summary>Set the fan rotation.</summary>
		public static void SetDirection(this IEnumerable<FanEntity> target, FanSetDirectionParameters data)
		{
			target.CallService("set_direction", data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="direction">The direction to rotate.</param>
		public static void SetDirection(this FanEntity target, string @direction)
		{
			target.CallService("set_direction", new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="direction">The direction to rotate.</param>
		public static void SetDirection(this IEnumerable<FanEntity> target, string @direction)
		{
			target.CallService("set_direction", new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		public static void SetPercentage(this FanEntity target, FanSetPercentageParameters data)
		{
			target.CallService("set_percentage", data);
		}

		///<summary>Set fan speed percentage.</summary>
		public static void SetPercentage(this IEnumerable<FanEntity> target, FanSetPercentageParameters data)
		{
			target.CallService("set_percentage", data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="percentage">Percentage speed setting.</param>
		public static void SetPercentage(this FanEntity target, long @percentage)
		{
			target.CallService("set_percentage", new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="percentage">Percentage speed setting.</param>
		public static void SetPercentage(this IEnumerable<FanEntity> target, long @percentage)
		{
			target.CallService("set_percentage", new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		public static void SetPresetMode(this FanEntity target, FanSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		public static void SetPresetMode(this IEnumerable<FanEntity> target, FanSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public static void SetPresetMode(this FanEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public static void SetPresetMode(this IEnumerable<FanEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set fan speed.</summary>
		public static void SetSpeed(this FanEntity target, FanSetSpeedParameters data)
		{
			target.CallService("set_speed", data);
		}

		///<summary>Set fan speed.</summary>
		public static void SetSpeed(this IEnumerable<FanEntity> target, FanSetSpeedParameters data)
		{
			target.CallService("set_speed", data);
		}

		///<summary>Set fan speed.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="speed">Speed setting. eg: low</param>
		public static void SetSpeed(this FanEntity target, string @speed)
		{
			target.CallService("set_speed", new FanSetSpeedParameters{Speed = @speed});
		}

		///<summary>Set fan speed.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="speed">Speed setting. eg: low</param>
		public static void SetSpeed(this IEnumerable<FanEntity> target, string @speed)
		{
			target.CallService("set_speed", new FanSetSpeedParameters{Speed = @speed});
		}

		///<summary>Toggle the fan on/off.</summary>
		public static void Toggle(this FanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle the fan on/off.</summary>
		public static void Toggle(this IEnumerable<FanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn fan off.</summary>
		public static void TurnOff(this FanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn fan off.</summary>
		public static void TurnOff(this IEnumerable<FanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn fan on.</summary>
		public static void TurnOn(this FanEntity target, FanTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn fan on.</summary>
		public static void TurnOn(this IEnumerable<FanEntity> target, FanTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public static void TurnOn(this FanEntity target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			target.CallService("turn_on", new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public static void TurnOn(this IEnumerable<FanEntity> target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			target.CallService("turn_on", new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public static class HarmonyEntityExtensionMethods
	{
		///<summary>Sends change channel command to the Harmony HUB</summary>
		public static void ChangeChannel(this RemoteEntity target, HarmonyChangeChannelParameters data)
		{
			target.CallService("change_channel", data);
		}

		///<summary>Sends change channel command to the Harmony HUB</summary>
		public static void ChangeChannel(this IEnumerable<RemoteEntity> target, HarmonyChangeChannelParameters data)
		{
			target.CallService("change_channel", data);
		}

		///<summary>Sends change channel command to the Harmony HUB</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="channel">Channel number to change to</param>
		public static void ChangeChannel(this RemoteEntity target, long @channel)
		{
			target.CallService("change_channel", new HarmonyChangeChannelParameters{Channel = @channel});
		}

		///<summary>Sends change channel command to the Harmony HUB</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="channel">Channel number to change to</param>
		public static void ChangeChannel(this IEnumerable<RemoteEntity> target, long @channel)
		{
			target.CallService("change_channel", new HarmonyChangeChannelParameters{Channel = @channel});
		}

		///<summary>Syncs the remote's configuration.</summary>
		public static void Sync(this RemoteEntity target)
		{
			target.CallService("sync");
		}

		///<summary>Syncs the remote's configuration.</summary>
		public static void Sync(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("sync");
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this InputBooleanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this InputBooleanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this InputBooleanEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class InputDatetimeEntityExtensionMethods
	{
		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this InputDatetimeEntity target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The InputDatetimeEntity to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this InputDatetimeEntity target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The IEnumerable<InputDatetimeEntity> to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public static class InputNumberEntityExtensionMethods
	{
		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this InputNumberEntity target)
		{
			target.CallService("decrement");
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("decrement");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this InputNumberEntity target)
		{
			target.CallService("increment");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("increment");
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this InputNumberEntity target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The InputNumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this InputNumberEntity target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The IEnumerable<InputNumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}
	}

	public static class InputTextEntityExtensionMethods
	{
		///<summary>Set the value of an input text entity.</summary>
		public static void SetValue(this InputTextEntity target, InputTextSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input text entity.</summary>
		public static void SetValue(this IEnumerable<InputTextEntity> target, InputTextSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The InputTextEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public static void SetValue(this InputTextEntity target, string @value)
		{
			target.CallService("set_value", new InputTextSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The IEnumerable<InputTextEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public static void SetValue(this IEnumerable<InputTextEntity> target, string @value)
		{
			target.CallService("set_value", new InputTextSetValueParameters{Value = @value});
		}
	}

	public static class KodiEntityExtensionMethods
	{
		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		public static void AddToPlaylist(this MediaPlayerEntity target, KodiAddToPlaylistParameters data)
		{
			target.CallService("add_to_playlist", data);
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		public static void AddToPlaylist(this IEnumerable<MediaPlayerEntity> target, KodiAddToPlaylistParameters data)
		{
			target.CallService("add_to_playlist", data);
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaType">Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</param>
		///<param name="mediaId">Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</param>
		///<param name="mediaName">Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</param>
		///<param name="artistName">Optional artist name for filtering media. eg: AC/DC</param>
		public static void AddToPlaylist(this MediaPlayerEntity target, string @mediaType, string? @mediaId = null, string? @mediaName = null, string? @artistName = null)
		{
			target.CallService("add_to_playlist", new KodiAddToPlaylistParameters{MediaType = @mediaType, MediaId = @mediaId, MediaName = @mediaName, ArtistName = @artistName});
		}

		///<summary>Add music to the default playlist (i.e. playlistid=0).</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaType">Media type identifier. It must be one of SONG or ALBUM. eg: ALBUM</param>
		///<param name="mediaId">Unique Id of the media entry to add (`songid` or albumid`). If not defined, `media_name` and `artist_name` are needed to search the Kodi music library. eg: 123456</param>
		///<param name="mediaName">Optional media name for filtering media. Can be 'ALL' when `media_type` is 'ALBUM' and `artist_name` is specified, to add all songs from one artist. eg: Highway to Hell</param>
		///<param name="artistName">Optional artist name for filtering media. eg: AC/DC</param>
		public static void AddToPlaylist(this IEnumerable<MediaPlayerEntity> target, string @mediaType, string? @mediaId = null, string? @mediaName = null, string? @artistName = null)
		{
			target.CallService("add_to_playlist", new KodiAddToPlaylistParameters{MediaType = @mediaType, MediaId = @mediaId, MediaName = @mediaName, ArtistName = @artistName});
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		public static void CallMethod(this MediaPlayerEntity target, KodiCallMethodParameters data)
		{
			target.CallService("call_method", data);
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		public static void CallMethod(this IEnumerable<MediaPlayerEntity> target, KodiCallMethodParameters data)
		{
			target.CallService("call_method", data);
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="method">Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</param>
		public static void CallMethod(this MediaPlayerEntity target, string @method)
		{
			target.CallService("call_method", new KodiCallMethodParameters{Method = @method});
		}

		///<summary>Call a Kodi JSONRPC API method with optional parameters. Results of the Kodi API call will be redirected in a Home Assistant event: `kodi_call_method_result`.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="method">Name of the Kodi JSONRPC API method to be called. eg: VideoLibrary.GetRecentlyAddedEpisodes</param>
		public static void CallMethod(this IEnumerable<MediaPlayerEntity> target, string @method)
		{
			target.CallService("call_method", new KodiCallMethodParameters{Method = @method});
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity target, long? @transition = null, string? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this IEnumerable<LightEntity> target, long? @transition = null, string? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class LockEntityExtensionMethods
	{
		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this LockEntity target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this IEnumerable<LockEntity> target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this LockEntity target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this LockEntity target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this IEnumerable<LockEntity> target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this LockEntity target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this LockEntity target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this IEnumerable<LockEntity> target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this LockEntity target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
		public static void Join(this MediaPlayerEntity target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity target)
		{
			target.CallService("media_play");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, string @mediaContentType)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, string @mediaContentType)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity target, string @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, string @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity target)
		{
			target.CallService("unjoin");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity target)
		{
			target.CallService("volume_down");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity target)
		{
			target.CallService("volume_up");
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_up");
		}
	}

	public static class RemoteEntityExtensionMethods
	{
		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this RemoteEntity target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this RemoteEntity target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this RemoteEntity target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this RemoteEntity target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this RemoteEntity target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this RemoteEntity target, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this RemoteEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this RemoteEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this RemoteEntity target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this RemoteEntity target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public static class RokuEntityExtensionMethods
	{
		///<summary>Emulates opening the search screen and entering the search keyword.</summary>
		public static void Search(this MediaPlayerEntity target, RokuSearchParameters data)
		{
			target.CallService("search", data);
		}

		///<summary>Emulates opening the search screen and entering the search keyword.</summary>
		public static void Search(this IEnumerable<MediaPlayerEntity> target, RokuSearchParameters data)
		{
			target.CallService("search", data);
		}

		///<summary>Emulates opening the search screen and entering the search keyword.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="keyword">The keyword to search for. eg: Space Jam</param>
		public static void Search(this MediaPlayerEntity target, string @keyword)
		{
			target.CallService("search", new RokuSearchParameters{Keyword = @keyword});
		}

		///<summary>Emulates opening the search screen and entering the search keyword.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="keyword">The keyword to search for. eg: Space Jam</param>
		public static void Search(this IEnumerable<MediaPlayerEntity> target, string @keyword)
		{
			target.CallService("search", new RokuSearchParameters{Keyword = @keyword});
		}
	}

	public static class SceneEntityExtensionMethods
	{
		///<summary>Activate a scene.</summary>
		public static void TurnOn(this SceneEntity target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		public static void TurnOn(this IEnumerable<SceneEntity> target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The SceneEntity to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this SceneEntity target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The IEnumerable<SceneEntity> to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this IEnumerable<SceneEntity> target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public static class ScriptEntityExtensionMethods
	{
		///<summary>Toggle script</summary>
		public static void Toggle(this ScriptEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle script</summary>
		public static void Toggle(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this ScriptEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this ScriptEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class SelectEntityExtensionMethods
	{
		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this SelectEntity target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this IEnumerable<SelectEntity> target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The SelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this SelectEntity target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The IEnumerable<SelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<SelectEntity> target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a switch state</summary>
		public static void Toggle(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class TimerEntityExtensionMethods
	{
		///<summary>Cancel a timer.</summary>
		public static void Cancel(this TimerEntity target)
		{
			target.CallService("cancel");
		}

		///<summary>Cancel a timer.</summary>
		public static void Cancel(this IEnumerable<TimerEntity> target)
		{
			target.CallService("cancel");
		}

		///<summary>Finish a timer.</summary>
		public static void Finish(this TimerEntity target)
		{
			target.CallService("finish");
		}

		///<summary>Finish a timer.</summary>
		public static void Finish(this IEnumerable<TimerEntity> target)
		{
			target.CallService("finish");
		}

		///<summary>Pause a timer.</summary>
		public static void Pause(this TimerEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause a timer.</summary>
		public static void Pause(this IEnumerable<TimerEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Start a timer</summary>
		public static void Start(this TimerEntity target, TimerStartParameters data)
		{
			target.CallService("start", data);
		}

		///<summary>Start a timer</summary>
		public static void Start(this IEnumerable<TimerEntity> target, TimerStartParameters data)
		{
			target.CallService("start", data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The TimerEntity to call this service for</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public static void Start(this TimerEntity target, string? @duration = null)
		{
			target.CallService("start", new TimerStartParameters{Duration = @duration});
		}

		///<summary>Start a timer</summary>
		///<param name="target">The IEnumerable<TimerEntity> to call this service for</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public static void Start(this IEnumerable<TimerEntity> target, string? @duration = null)
		{
			target.CallService("start", new TimerStartParameters{Duration = @duration});
		}
	}

	public static class VacuumEntityExtensionMethods
	{
		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this VacuumEntity target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this VacuumEntity target)
		{
			target.CallService("locate");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("locate");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this VacuumEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this VacuumEntity target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this VacuumEntity target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this VacuumEntity target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this VacuumEntity target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this VacuumEntity target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this VacuumEntity target)
		{
			target.CallService("start");
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this VacuumEntity target)
		{
			target.CallService("start_pause");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start_pause");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this VacuumEntity target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this VacuumEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this VacuumEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class XiaomiMiioEntityExtensionMethods
	{
		///<summary>Start cleaning of the specified segment(s).</summary>
		public static void VacuumCleanSegment(this VacuumEntity target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			target.CallService("vacuum_clean_segment", data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		public static void VacuumCleanSegment(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			target.CallService("vacuum_clean_segment", data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public static void VacuumCleanSegment(this VacuumEntity target, object? @segments = null)
		{
			target.CallService("vacuum_clean_segment", new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public static void VacuumCleanSegment(this IEnumerable<VacuumEntity> target, object? @segments = null)
		{
			target.CallService("vacuum_clean_segment", new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		public static void VacuumCleanZone(this VacuumEntity target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			target.CallService("vacuum_clean_zone", data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		public static void VacuumCleanZone(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			target.CallService("vacuum_clean_zone", data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public static void VacuumCleanZone(this VacuumEntity target, object? @zone = null, long? @repeats = null)
		{
			target.CallService("vacuum_clean_zone", new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public static void VacuumCleanZone(this IEnumerable<VacuumEntity> target, object? @zone = null, long? @repeats = null)
		{
			target.CallService("vacuum_clean_zone", new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		public static void VacuumGoto(this VacuumEntity target, XiaomiMiioVacuumGotoParameters data)
		{
			target.CallService("vacuum_goto", data);
		}

		///<summary>Go to the specified coordinates.</summary>
		public static void VacuumGoto(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumGotoParameters data)
		{
			target.CallService("vacuum_goto", data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public static void VacuumGoto(this VacuumEntity target, string? @xCoord = null, string? @yCoord = null)
		{
			target.CallService("vacuum_goto", new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public static void VacuumGoto(this IEnumerable<VacuumEntity> target, string? @xCoord = null, string? @yCoord = null)
		{
			target.CallService("vacuum_goto", new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		public static void VacuumRemoteControlMove(this VacuumEntity target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			target.CallService("vacuum_remote_control_move", data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		public static void VacuumRemoteControlMove(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			target.CallService("vacuum_remote_control_move", data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMove(this VacuumEntity target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move", new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMove(this IEnumerable<VacuumEntity> target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move", new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			target.CallService("vacuum_remote_control_move_step", data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		public static void VacuumRemoteControlMoveStep(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			target.CallService("vacuum_remote_control_move_step", data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move_step", new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMoveStep(this IEnumerable<VacuumEntity> target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move_step", new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		public static void VacuumRemoteControlStart(this VacuumEntity target)
		{
			target.CallService("vacuum_remote_control_start");
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		public static void VacuumRemoteControlStart(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("vacuum_remote_control_start");
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		public static void VacuumRemoteControlStop(this VacuumEntity target)
		{
			target.CallService("vacuum_remote_control_stop");
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		public static void VacuumRemoteControlStop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("vacuum_remote_control_stop");
		}
	}

	public static class ZhaEntityExtensionMethods
	{
		///<summary>Clear a user code from a lock</summary>
		public static void ClearLockUserCode(this LockEntity target, ZhaClearLockUserCodeParameters data)
		{
			target.CallService("clear_lock_user_code", data);
		}

		///<summary>Clear a user code from a lock</summary>
		public static void ClearLockUserCode(this IEnumerable<LockEntity> target, ZhaClearLockUserCodeParameters data)
		{
			target.CallService("clear_lock_user_code", data);
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public static void ClearLockUserCode(this LockEntity target, string @codeSlot)
		{
			target.CallService("clear_lock_user_code", new ZhaClearLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public static void ClearLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot)
		{
			target.CallService("clear_lock_user_code", new ZhaClearLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Disable a user code on a lock</summary>
		public static void DisableLockUserCode(this LockEntity target, ZhaDisableLockUserCodeParameters data)
		{
			target.CallService("disable_lock_user_code", data);
		}

		///<summary>Disable a user code on a lock</summary>
		public static void DisableLockUserCode(this IEnumerable<LockEntity> target, ZhaDisableLockUserCodeParameters data)
		{
			target.CallService("disable_lock_user_code", data);
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to disable eg: 1</param>
		public static void DisableLockUserCode(this LockEntity target, string @codeSlot)
		{
			target.CallService("disable_lock_user_code", new ZhaDisableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to disable eg: 1</param>
		public static void DisableLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot)
		{
			target.CallService("disable_lock_user_code", new ZhaDisableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Enable a user code on a lock</summary>
		public static void EnableLockUserCode(this LockEntity target, ZhaEnableLockUserCodeParameters data)
		{
			target.CallService("enable_lock_user_code", data);
		}

		///<summary>Enable a user code on a lock</summary>
		public static void EnableLockUserCode(this IEnumerable<LockEntity> target, ZhaEnableLockUserCodeParameters data)
		{
			target.CallService("enable_lock_user_code", data);
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to enable eg: 1</param>
		public static void EnableLockUserCode(this LockEntity target, string @codeSlot)
		{
			target.CallService("enable_lock_user_code", new ZhaEnableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to enable eg: 1</param>
		public static void EnableLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot)
		{
			target.CallService("enable_lock_user_code", new ZhaEnableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Set a user code on a lock</summary>
		public static void SetLockUserCode(this LockEntity target, ZhaSetLockUserCodeParameters data)
		{
			target.CallService("set_lock_user_code", data);
		}

		///<summary>Set a user code on a lock</summary>
		public static void SetLockUserCode(this IEnumerable<LockEntity> target, ZhaSetLockUserCodeParameters data)
		{
			target.CallService("set_lock_user_code", data);
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to set the code in eg: 1</param>
		///<param name="userCode">Code to set eg: 1234</param>
		public static void SetLockUserCode(this LockEntity target, string @codeSlot, string @userCode)
		{
			target.CallService("set_lock_user_code", new ZhaSetLockUserCodeParameters{CodeSlot = @codeSlot, UserCode = @userCode});
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to set the code in eg: 1</param>
		///<param name="userCode">Code to set eg: 1234</param>
		public static void SetLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot, string @userCode)
		{
			target.CallService("set_lock_user_code", new ZhaSetLockUserCodeParameters{CodeSlot = @codeSlot, UserCode = @userCode});
		}
	}

	public static class ZwaveJsEntityExtensionMethods
	{
		///<summary>Clear a usercode from a lock</summary>
		public static void ClearLockUsercode(this LockEntity target, ZwaveJsClearLockUsercodeParameters data)
		{
			target.CallService("clear_lock_usercode", data);
		}

		///<summary>Clear a usercode from a lock</summary>
		public static void ClearLockUsercode(this IEnumerable<LockEntity> target, ZwaveJsClearLockUsercodeParameters data)
		{
			target.CallService("clear_lock_usercode", data);
		}

		///<summary>Clear a usercode from a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public static void ClearLockUsercode(this LockEntity target, string @codeSlot)
		{
			target.CallService("clear_lock_usercode", new ZwaveJsClearLockUsercodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Clear a usercode from a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public static void ClearLockUsercode(this IEnumerable<LockEntity> target, string @codeSlot)
		{
			target.CallService("clear_lock_usercode", new ZwaveJsClearLockUsercodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Resets the meter(s) on a node.</summary>
		public static void ResetMeter(this SensorEntity target, ZwaveJsResetMeterParameters data)
		{
			target.CallService("reset_meter", data);
		}

		///<summary>Resets the meter(s) on a node.</summary>
		public static void ResetMeter(this IEnumerable<SensorEntity> target, ZwaveJsResetMeterParameters data)
		{
			target.CallService("reset_meter", data);
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The SensorEntity to call this service for</param>
		///<param name="meterType">The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</param>
		///<param name="value">The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</param>
		public static void ResetMeter(this SensorEntity target, string? @meterType = null, string? @value = null)
		{
			target.CallService("reset_meter", new ZwaveJsResetMeterParameters{MeterType = @meterType, Value = @value});
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The IEnumerable<SensorEntity> to call this service for</param>
		///<param name="meterType">The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</param>
		///<param name="value">The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</param>
		public static void ResetMeter(this IEnumerable<SensorEntity> target, string? @meterType = null, string? @value = null)
		{
			target.CallService("reset_meter", new ZwaveJsResetMeterParameters{MeterType = @meterType, Value = @value});
		}

		///<summary>Set a usercode on a lock</summary>
		public static void SetLockUsercode(this LockEntity target, ZwaveJsSetLockUsercodeParameters data)
		{
			target.CallService("set_lock_usercode", data);
		}

		///<summary>Set a usercode on a lock</summary>
		public static void SetLockUsercode(this IEnumerable<LockEntity> target, ZwaveJsSetLockUsercodeParameters data)
		{
			target.CallService("set_lock_usercode", data);
		}

		///<summary>Set a usercode on a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to set the code. eg: 1</param>
		///<param name="usercode">Code to set. eg: 1234</param>
		public static void SetLockUsercode(this LockEntity target, string @codeSlot, string @usercode)
		{
			target.CallService("set_lock_usercode", new ZwaveJsSetLockUsercodeParameters{CodeSlot = @codeSlot, Usercode = @usercode});
		}

		///<summary>Set a usercode on a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to set the code. eg: 1</param>
		///<param name="usercode">Code to set. eg: 1234</param>
		public static void SetLockUsercode(this IEnumerable<LockEntity> target, string @codeSlot, string @usercode)
		{
			target.CallService("set_lock_usercode", new ZwaveJsSetLockUsercodeParameters{CodeSlot = @codeSlot, Usercode = @usercode});
		}
	}
}