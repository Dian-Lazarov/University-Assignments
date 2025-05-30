#define _CRT_SECURE_NO_WARNINGS

#include "vehicle.h"
#include "car.h"
#include "performance.h"

#include <iostream>
using namespace std;

// Performance
void Performance::initialize(int inSpeed, int inPassengers) {
	speed = inSpeed;
	passengers = inPassengers;
}

int Performance::getSpeed(void) {
	return speed;
}

int Performance::getPassengers(void) {
	return passengers;
}
Performance::Performance(const char* p) {
	performance = new char[strlen(p) + 1];
	strcpy(performance, p);
}

void Performance::print(void) {
	cout << performance << endl;
}
// end Performance