#define _CRT_SECURE_NO_WARNINGS

#pragma once
#ifndef SPORTS_H
#define SPORTS_H

// Sports
class Sports : public Car {
public:
	void initialize(int, int);
	virtual int getSpeed(void);
	virtual int getPassengers(void);
	Sports(const char* s = "class Sports");
	~Sports() { delete sports; }
	virtual void print(void);
private:
	char* sports;
	int speed;
	int passengers;
};
// end Sports

#endif // !SPORTS_H