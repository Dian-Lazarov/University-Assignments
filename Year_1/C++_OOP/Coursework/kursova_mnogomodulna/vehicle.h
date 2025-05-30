#define _CRT_SECURE_NO_WARNINGS

#pragma once
#ifndef VEHICLE_H
#define VEHICLE_H

// Vehicle
class Vehicle {
public:
	Vehicle(const char* v = "class Vehicle");
	~Vehicle() { delete vehicle; }
	virtual void print(void);
	void link(Vehicle*);
	void printlist(Vehicle*);
protected:
	char* vehicle;
	Vehicle* next;
};
// end Vehicle

#endif // !VEHICLE_H