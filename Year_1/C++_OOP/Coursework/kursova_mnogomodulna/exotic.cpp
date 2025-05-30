#define _CRT_SECURE_NO_WARNINGS

#include "vehicle.h"
#include "car.h"
#include "sports.h"
#include "exotic.h"

#include <iostream>
using namespace std;

// Exotic
void Exotic::initialize(int inSpeed, int inPassengers) {
	speed = inSpeed;
	passengers = inPassengers;
}

int Exotic::getSpeed(void) {
	return speed;
}

int Exotic::getPassengers(void) {
	return passengers;
}
Exotic::Exotic(const char* e) {
	exotic = new char[strlen(e) + 1];
	strcpy(exotic, e);
}

void Exotic::print(void) {
	cout << exotic << endl;
}
// end Exotic