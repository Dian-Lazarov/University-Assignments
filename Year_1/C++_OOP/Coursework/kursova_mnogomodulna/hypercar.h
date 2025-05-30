#define _CRT_SECURE_NO_WARNINGS

#pragma once
#ifndef HYPERCAR_H
#define HYPERCAR_H

// Hypercar
class Hypercar : public Performance {
public:
	void initialize(int, int);
	virtual int getSpeed(void);
	virtual int getPassengers(void);
	Hypercar(const char* h = "class Hypercar");
	~Hypercar() { delete hypercar; }
	virtual void print(void);
private:
	char* hypercar;
	int speed;
	int passengers;
};
// end Hypercar

#endif // !HYPERCAR_H