#define _CRT_SECURE_NO_WARNINGS

#pragma once
#ifndef TRUCK_H
#define TRUCK_H

// Truck
class Truck : public Vehicle {
public:
	void initialize(int, float);
	virtual int getWheels(void);
	virtual float getWeight(void);
	Truck(const char* t = "class Truck");
	~Truck() { delete truck; }
	virtual void print(void);
private:
	char* truck;
	int wheels;
	float weight;
};
// end Truck
#endif // !TRUCK_H