/* Finding the key codes for your remote. More info: https://www.makerguides.com */
#include "IRremote.h" // include the IRremote library
#define RECEIVER_PIN 5 // define the IR receiver pin
IRrecv receiver(RECEIVER_PIN); // create a receiver object of the IRrecv class
decode_results results; // create a results object of the decode_results class
void setup() {
    Serial.begin(115200); // begin serial communication with a baud rate of 9600
    receiver.enableIRIn(); // enable the receiver
    receiver.blink13(true); // enable blinking of the built-in LED when an IR signal is received
}


unsigned long key_value = 0;
long lastCommand = 0;
const uint32_t POWER_CODE = 0x425D;
const uint32_t INPUT_CODE = 0x40DD;
const uint32_t UP_CODE =    0x4055;
const uint32_t DOWN_CODE =  0x4395;

bool CommandRecognized(uint32_t value) {
  
    long now = millis();
    //if (now - lastCommand > 100)
    {
        lastCommand = now;

        if (value == POWER_CODE) {
            Serial.println("POWER ON");
            return true;
        }else if (value == INPUT_CODE) {
            Serial.println("INPUT");
            return true;
        } else if (value == DOWN_CODE) {
            Serial.println("DOWN");
            return true;
        } else if (value == UP_CODE) {
            Serial.println("UP");
            return true;
        }
    }
    //lastCommand = now;
    //Serial.println(results.value, HEX); // print the values in the Serial Monitor
    return false;
}
void loop() {
    if (receiver.decode()) { // decode the received signal and store it in results
       
        if (CommandRecognized(receiver.decodedIRData.decodedRawData))
        {

        }
        else
            Serial.println(receiver.decodedIRData.decodedRawData, HEX); // print the values in the Serial Monitor

        key_value = results.value;
        receiver.resume(); // reset the receiver for the next code
    }
}