#define _CRT_SECURE_NO_WARNINGS

#include "vehicle.h"
#include "motorcycle.h"

#include <iostream>
using namespace std;

// Motorcycle
void Motorcycle::initialize(int inWheels, float inWeight) {
	wheels = inWheels;
	weight = inWeight;
}

int Motorcycle::getWheels(void) {
	return wheels;
}

float Motorcycle::getWeight(void) {
	return weight;
}

Motorcycle::Motorcycle(const char* m) {
	motorcycle = new char[strlen(m) + 1];
	strcpy(motorcycle, m);
}

void Motorcycle::print(void) {
	cout << motorcycle << endl;
}
// end Motorcycle