#define _CRT_SECURE_NO_WARNINGS

#pragma once
#ifndef SUPERCAR_H
#define SUPERCAR_H

// Supercar
class Supercar : public Performance {
public:
	void initialize(int, int);
	virtual int getSpeed(void);
	virtual int getPassengers(void);
	Supercar(const char* s = "class Supercar");
	~Supercar() { delete supercar; }
	virtual void print(void);
private:
	char* supercar;
	int speed;
	int passengers;
};
// end Supercar

#endif // !SUPERCAR_H