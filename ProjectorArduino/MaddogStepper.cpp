// 
// 
// 

#include "Stepper.h"
#include "MaddogStepper.h"

MaddogStepper::MaddogStepper(int directionPin, int stepPin, int resetPin=0, int speed = 500, int steps = 200)
{
	_resetPin = resetPin;
	if (_resetPin != 0) {
		pinMode(_resetPin, OUTPUT);
		digitalWrite(_resetPin, LOW);
	}

	_speed = speed;
	_stepper = new Stepper(steps, directionPin, stepPin);
	_stepper->setSpeed(speed);

}

void MaddogStepper::MoveClockwise(int steps = 0)
{
	_startedAt = millis();
	_stepper->setSpeed(_speed);
	Status = StepperStatus::CW;
	_stepstoRun = steps;
	_stepsCounter = 0;
	digitalWrite(_resetPin, HIGH);
}

void MaddogStepper::MoveCounterClockWise(int steps = 0)
{
	_startedAt = millis();
	_stepper->setSpeed(_speed);
	Status = StepperStatus::CCW;
	_stepstoRun = steps;
	_stepsCounter = 0;
	digitalWrite(_resetPin, HIGH);
}

void MaddogStepper::Stop() {
	Status = StepperStatus::Stopped;
	_stepstoRun = -1;
	_stepsCounter = 0;
	digitalWrite(_resetPin, LOW);
	_startedAt = 0;
}
void MaddogStepper::Run()
{
	if (Status == StepperStatus::Stopped)
		return;

	int steps = 0;
	if (Status == StepperStatus::CW)
	{
		steps = -1;
	}
	else {
		steps = 1;
	}
	_stepsCounter += abs(steps);
	if (_stepstoRun != 0) {
		if (_stepsCounter > _stepstoRun)
		{
			this->Stop();
			return;
		}
	}

	if (Status == StepperStatus::CCW)
	{
		int newSpeed = _speed;
		//if ((millis() - _startedAt) < 1500)
		//	newSpeed = 200;

		_stepper->setSpeed(newSpeed);
	}
	_stepper->step(steps);

}
