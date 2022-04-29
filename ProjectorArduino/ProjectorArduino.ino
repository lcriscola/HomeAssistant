#include "MaddogStepper.h"
#include <IRremote.h> // include the IRremote library

#define RECEIVER_PIN 5 // define the IR receiver pin
#define STEPS 200
#define DIRECTION_PIN 3
#define STEP_PIN 2
#define RESET_PIN 4
#define FULLY_OPEN_SENSOR_PIN 6
#define FULLY_CLOSED_SENSOR_PIN 7
#define ON_OFF_SWITCH_PIN 8

IRrecv receiver(RECEIVER_PIN); // create a receiver object of the IRrecv class

MaddogStepper stepper(DIRECTION_PIN, STEP_PIN, RESET_PIN,800 );

const uint32_t POWER_CODE = 0x425D;
const uint32_t INPUT_CODE = 0x40DD;
const uint32_t UP_CODE = 0x4055;
const uint32_t DOWN_CODE = 0x4395;

void PressReleaseRemoteButton(){
	digitalWrite(ON_OFF_SWITCH_PIN, HIGH);
	 delay(200);
	 digitalWrite(ON_OFF_SWITCH_PIN, LOW);
}
void TurnOnProjector() {
	PressReleaseRemoteButton();
}
void TurnOffProjector() {
	PressReleaseRemoteButton();
	delay(500);
	PressReleaseRemoteButton();
	delay(500);
	PressReleaseRemoteButton();
}
void OpenDrawer() {
	stepper.MoveClockwise();

}
void CloseDrawer() {
	stepper.MoveCounterClockWise();

}

bool CommandRecognized(uint32_t value) {

	long now = millis();
	//if (now - lastCommand > 100)
	{

		if (value == POWER_CODE) {
			TurnOnProjector();
			Serial.println("POWER ON");
			return true;
		}
		else if (value == INPUT_CODE) {
			TurnOffProjector();
			Serial.println("INPUT");
			return true;
		}
		else if (value == DOWN_CODE) {
			OpenDrawer();

			Serial.println("DOWN");
			return true;
		}
		else if (value == UP_CODE) {
			CloseDrawer();
			Serial.println("UP");
			return true;
		}
	}
	//lastCommand = now;
	//Serial.println(results.value, HEX); // print the values in the Serial Monitor
	return false;
}

void setup() {
	// put your setup code here, to run once:
	Serial.begin(115200);
	receiver.enableIRIn(); // enable the receiver
	receiver.blink13(true); // enable blinking of the built-in LED when an IR signal is received


	pinMode(ON_OFF_SWITCH_PIN, OUTPUT);
	pinMode(FULLY_OPEN_SENSOR_PIN, INPUT_PULLUP);
	pinMode(FULLY_CLOSED_SENSOR_PIN, INPUT_PULLUP);
	//stepper.setMaxSpeed(50);
	//stepper.setSpeed(50);
}

void loop() {

	if (stepper.Status == StepperStatus::CW && digitalRead(FULLY_OPEN_SENSOR_PIN)==LOW)
	{
		stepper.Stop();
	}else if (stepper.Status == StepperStatus::CCW && digitalRead(FULLY_CLOSED_SENSOR_PIN) == LOW)
	{
		stepper.Stop();
	}

	stepper.Run();
	// put your main code here, to run repeatedly:
	//Serial.println(millis());
	//delay(500);

	if (receiver.decode()) { // decode the received signal and store it in results

		if (CommandRecognized(receiver.decodedIRData.decodedRawData))
		{

		}
		//else
		//    Serial.println(receiver.decodedIRData.decodedRawData, HEX); // print the values in the Serial Monitor

		receiver.resume(); // reset the receiver for the next code
	}
 
}
