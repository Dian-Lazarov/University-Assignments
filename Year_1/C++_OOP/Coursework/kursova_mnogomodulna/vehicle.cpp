#define _CRT_SECURE_NO_WARNINGS

#include "vehicle.h"

#include <iostream>
using namespace std;

// Vehicle
Vehicle::Vehicle(const char* v) {
	next = 0;
	vehicle = new char[strlen(v) + 1];
	strcpy(vehicle, v);
}

void Vehicle::print(void) {
	cout << vehicle << endl;
}

void Vehicle::link(Vehicle* pt) {
	next = pt;
}

void Vehicle::printlist(Vehicle* begin) {
	for (Vehicle* np = begin; np; np = np->next) {
		np->print();
	}
}
// end Vehicle