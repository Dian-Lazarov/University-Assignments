#define _CRT_SECURE_NO_WARNINGS

#include "vehicle.h"
#include "car.h"

#include <iostream>
using namespace std;

// Car
void Car::initialize(int inSpeed, int inPassengers) {
	speed = inSpeed;
	passengers = inPassengers;
}

int Car::getSpeed(void) {
	return speed;
}

int Car::getPassengers(void) {
	return passengers;
}
Car::Car(const char* c) {
	car = new char[strlen(c) + 1];
	strcpy(car, c);
}

void Car::print(void) {
	cout << car << endl;
}
// end Car