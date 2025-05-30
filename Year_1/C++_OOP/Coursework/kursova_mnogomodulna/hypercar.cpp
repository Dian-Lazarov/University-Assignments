#define _CRT_SECURE_NO_WARNINGS

#include "vehicle.h"
#include "car.h"
#include "performance.h"
#include "hypercar.h"

#include <iostream>
using namespace std;

// Hypercar
void Hypercar::initialize(int inSpeed, int inPassengers) {
	speed = inSpeed;
	passengers = inPassengers;
}

int Hypercar::getSpeed(void) {
	return speed;
}

int Hypercar::getPassengers(void) {
	return passengers;
}
Hypercar::Hypercar(const char* h) {
	hypercar = new char[strlen(h) + 1];
	strcpy(hypercar, h);
}

void Hypercar::print(void) {
	cout << hypercar << endl;
}
// end Hypercar