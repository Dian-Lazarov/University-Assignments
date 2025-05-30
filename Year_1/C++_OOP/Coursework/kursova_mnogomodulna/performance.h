#define _CRT_SECURE_NO_WARNINGS

#pragma once
#ifndef PERFORMANCE_H
#define PERFORMANCE_H

// Performance
class Performance : public Car {
public:
	void initialize(int, int);
	virtual int getSpeed(void);
	virtual int getPassengers(void);
	Performance(const char* p = "class Performance");
	~Performance() { delete performance; }
	virtual void print(void);
private:
	char* performance;
	int speed;
	int passengers;
};
// end Performance

#endif // !PERFORMANCE_H