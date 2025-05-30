#define _CRT_SECURE_NO_WARNINGS

#pragma once
#ifndef MOTORCYCLE_H
#define MOTORCYCLE_H

// Motorcycle
class Motorcycle : public Vehicle {
public:
	void initialize(int, float);
	virtual int getWheels(void);
	virtual float getWeight(void);
	Motorcycle(const char* m = "class Motorcycle");
	~Motorcycle() { delete motorcycle; }
	virtual void print(void);
private:
	char* motorcycle;
	int wheels;
	float weight;
};
// end Motorcycle

#endif // !MOTORCYCLE_H