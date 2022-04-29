// MaddogStepper.h
#include "Stepper.h"

#ifndef _MADDOGSTEPPER_h
#define _MADDOGSTEPPER_h

#if defined(ARDUINO) && ARDUINO >= 100
	#include "arduino.h"
#else
	#include "WProgram.h"

#endif
enum StepperStatus {
	CW,
	CCW,
	Stopped
};
class MaddogStepper {
public:
	MaddogStepper(int directionPin, int stepPin, int resetPin=0, int speed=500, int steps=200);
	void MoveClockwise(int steps = 0);
	void MoveCounterClockWise(int steps = 0);
	void Stop();
	void Run();
	StepperStatus Status = StepperStatus::Stopped;
private:
	Stepper *_stepper;
	int _stepstoRun = -1;
	int _stepsCounter = 0;
	int _resetPin = 0;
	int _speed = 0;
	long _startedAt = 0;
};

#endif

