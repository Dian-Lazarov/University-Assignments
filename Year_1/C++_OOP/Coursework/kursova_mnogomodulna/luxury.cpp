#define _CRT_SECURE_NO_WARNINGS

#include "vehicle.h"
#include "car.h"
#include "sports.h"
#include "luxury.h"

#include <iostream>
using namespace std;

// Luxury
void Luxury::initialize(int inSpeed, int inPassengers) {
	speed = inSpeed;
	passengers = inPassengers;
}

int Luxury::getSpeed(void) {
	return speed;
}

int Luxury::getPassengers(void) {
	return passengers;
}
Luxury::Luxury(const char* l) {
	luxury = new char[strlen(l) + 1];
	strcpy(luxury, l);
}

void Luxury::print(void) {
	cout << luxury << endl;
}
// end Luxury