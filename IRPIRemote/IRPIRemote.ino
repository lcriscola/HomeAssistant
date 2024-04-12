/*
 * IRremoteESP8266: IRrecvDemo - demonstrates receiving IR codes with IRrecv
 * This is very simple teaching code to show you how to use the library.
 * If you are trying to decode your Infra-Red remote(s) for later replay,
 * use the IRrecvDumpV2.ino (or later) example code instead of this.
 * An IR detector/demodulator must be connected to the input kRecvPin.
 * Copyright 2009 Ken Shirriff, http://arcfn.com
 * Example circuit diagram:
 *  https://github.com/crankyoldgit/IRremoteESP8266/wiki#ir-receiving
 * Changes:
 *   Version 0.2 June, 2017
 *     Changed GPIO pin to the same as other examples.
 *     Used our own method for printing a uint64_t.
 *     Changed the baud rate to 115200.
 *   Version 0.1 Sept, 2015
 *     Based on Ken Shirriff's IrsendDemo Version 0.1 July, 2009
 */

#include <Arduino.h>
#include <IRremoteESP8266.h>
#include <IRrecv.h>
#include <IRutils.h>

#define D1 5
#define D4 2

 // An IR detector/demodulator is connected to GPIO pin 14(D5 on a NodeMCU
 // board).
 // Note: GPIO 16 won't work on the ESP8266 as it does not have interrupts.
 // Note: GPIO 14 won't work on the ESP32-C3 as it causes the board to reboot.
 //https://randomnerdtutorials.com/esp8266-pinout-reference-gpios/ 
const uint16_t kRecvPin = D4;

IRrecv irrecv(kRecvPin);

decode_results results;


void setup() {
    Serial.begin(115200);

    irrecv.enableIRIn();  // Start the receiver
    //while (!Serial)  // Wait for the serial connection to be establised.
    //    delay(50);
    Serial.println();
    Serial.print("IRrecvDemo is now running and waiting for IR message on Pin ");
    Serial.println(kRecvPin);

    pinMode(D1, OUTPUT);
}

long POWER_ON[] = { (long)0xC800F8429, (long)0xC800F0429, (long)0x8FD7016B };
long POWER_OFF[] = { (long)0xC800F842A,(long) 0xD86E18EF,(long)0xC800F042A };


bool InList(long value, long* list, int listLength)
{


    for (int i = 0; i < listLength; i++) {
        //Serial.print("#");
        //Serial.print(i);
        //Serial.print(" value=");
        //Serial.print(value,HEX);
        //Serial.print(" list= ");
        //Serial.println(list[i],HEX);
        if (list[i] == value) {
            return true;
        }
    }
    //Serial.print("listLength=");
    //Serial.println(listLength);
    return false;
}

void loop() {
    //  digitalWrite(D1, HIGH);
    //  delay(1000);
    //  digitalWrite(D1, LOW);
    //  delay(1000);
    //Serial.println("...");

    if (irrecv.decode(&results)) {
        // print() & println() can't handle printing long longs. (uint64_t)
        serialPrintUint64(results.value, HEX);
        Serial.println("");

        if (InList(results.value,POWER_ON, sizeof(POWER_ON)/sizeof(long)))
        {
            Serial.println("POWER ON");
            digitalWrite(D1, HIGH);
        }
        if (InList(results.value, POWER_OFF, sizeof(POWER_OFF) / sizeof(long)))
        {
            Serial.println("POWER OFF");
            delay(10000);
            digitalWrite(D1, LOW);
        }
        irrecv.resume();  // Receive the next value
    }
    //delay(100);

}