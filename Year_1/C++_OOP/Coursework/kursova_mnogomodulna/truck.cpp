#define _CRT_SECURE_NO_WARNINGS

#include "vehicle.h"
#include "truck.h"

#include <iostream>
using namespace std;

// Truck
void Truck::initialize(int inWheels, float inWeight) {
    wheels = inWheels;
    weight = inWeight;
}

int Truck::getWheels(void) {
    return wheels;
}

float Truck::getWeight(void) {
    return weight;
}
Truck::Truck(const char* t) {
    truck = new char[strlen(t) + 1];
    strcpy(truck, t);
}

void Truck::print(void) {
    cout << truck << endl;
}
// end Truck