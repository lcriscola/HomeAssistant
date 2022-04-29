#include "esphome.h"

class MyCurtainSwitch : public  PollingComponent, public Cover {

  
private:
 

public:
    MyCurtainSwitch() : PollingComponent(500) {
    }
    int ain1Pin = 1;
    int ain2Pin = 2;
    int closedStopSensorPin = 3;
    int openedStopSensorPin = 4;

    void setup() override {
        // This will be called by App.setup()
        pinMode(ain1Pin, OUTPUT);
        pinMode(ain2Pin, OUTPUT);
        pinMode(closedStopSensorPin, INPUT_PULLUP);
        pinMode(openedStopSensorPin, INPUT_PULLUP);

    }
    CoverTraits get_traits() override {
        auto traits = CoverTraits();
        traits.set_is_assumed_state(false);
        traits.set_supports_position(true);
        traits.set_supports_tilt(false);
        return traits;
    }

    void MoveForward() {
        digitalWrite(ain1Pin, HIGH);
        digitalWrite(ain2Pin, LOW);
    }
    void MoveBackward() {
        digitalWrite(ain1Pin, LOW);
        digitalWrite(ain2Pin, HIGH);
    }
    void Break() {
        digitalWrite(ain1Pin, LOW);
        digitalWrite(ain2Pin, LOW);
    }

    void Open() {
        ESP_LOGD("cover", "Opening");
        checkPosition = true;
    }

    void Close() {
        ESP_LOGD("cover", "Closing");
        checkPosition = true;
    }
    

    void Stop() {
        ESP_LOGD("cover", "Stop");
        checkPosition = false;
    }

    bool ShouldStop() {
        if (start != 0 && millis() - start > 3000)
        {
            start = 0;
            return true;
        }

        if (IsOpenedSensor())
            return true;
        if (IsClosedSensor())
            return true;

        return false;
    }

    bool IsOpenedSensor() {
        if (digitalRead(openedStopSensorPin)==LOW)
            return true;

        return false;
    }
    bool IsClosedSensor() {
        if (digitalRead(closedStopSensorPin) == LOW)
            return true;

        return false;
    }

    void update() override {
        // This will be called every "update_interval" milliseconds.
        if (checkPosition) {
            if (ShouldStop())
            {
                Stop();
            }

            if (IsOpenedSensor()) {
                this->position = 1;
            } else if (IsClosedSensor())
                this->position = 0;
            else
                this->position = 0.5;

            ESP_LOGD("cover", "current state %f", this->position);
            this->publish_state();
        }

    }

    void loop()  {

   
        //ESP_LOGD("cover", "looping");
    }
    
    int start = 0;
    bool checkPosition = true;
    void control(const CoverCall& call) override {
        // This will be called every time the user requests a state change.
        if (call.get_position().has_value()) {
            float pos = *call.get_position();
            // Write pos (range 0-1) to cover
            // ...

            //// Publish new state
            //this->position = pos;
            //this->publish_state();


            start = millis();
            if (pos == 0)
                Close();
            if (pos== 1)
                Open();


        }
        if (call.get_stop()) {
            Stop();
            // User requested cover stop
           

        }


    }
};