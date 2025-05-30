#define _CRT_SECURE_NO_WARNINGS

#include "vehicle.h"
#include "car.h"
#include "performance.h"
#include "supercar.h"

#include <iostream>
using namespace std;

// Supercar
void Supercar::initialize(int inSpeed, int inPassengers) {
	speed = inSpeed;
	passengers = inPassengers;
}

int Supercar::getSpeed(void) {
	return speed;
}

int Supercar::getPassengers(void) {
	return passengers;
}
Supercar::Supercar(const char* s) {
	supercar = new char[strlen(s) + 1];
	strcpy(supercar, s);
}

void Supercar::print(void) {
	cout << supercar << endl;
}
// end Supercar