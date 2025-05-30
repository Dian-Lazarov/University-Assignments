#define _CRT_SECURE_NO_WARNINGS

#pragma once
#ifndef CAR_H
#define CAR_H

// Car
class Car : public Vehicle {
public:
	void initialize(int, int);
	virtual int getSpeed(void);
	virtual int getPassengers(void);
	Car(const char* c = "class Car");
	~Car() { delete car; }
	virtual void print(void);
private:
	char* car;
	int speed;
	int passengers;
};
// end Car

#endif // !CAR_H