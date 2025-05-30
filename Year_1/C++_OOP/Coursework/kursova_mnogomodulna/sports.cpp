#define _CRT_SECURE_NO_WARNINGS

#include "vehicle.h"
#include "car.h"
#include "sports.h"

#include <iostream>
using namespace std;

// Sports
void Sports::initialize(int inSpeed, int inPassengers) {
	speed = inSpeed;
	passengers = inPassengers;
}

int Sports::getSpeed(void) {
	return speed;
}

int Sports::getPassengers(void) {
	return passengers;
}
Sports::Sports(const char* s) {
	sports = new char[strlen(s) + 1];
	strcpy(sports, s);
}

void Sports::print(void) {
	cout << sports << endl;
}
// end Sports