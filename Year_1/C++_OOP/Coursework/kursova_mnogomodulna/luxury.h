#define _CRT_SECURE_NO_WARNINGS

#pragma once
#ifndef LUXURY_H
#define LUXURY_H

// Luxury
class Luxury : public Sports {
public:
	void initialize(int, int);
	virtual int getSpeed(void);
	virtual int getPassengers(void);
	Luxury(const char* l = "class Luxury");
	~Luxury() { delete luxury; }
	virtual void print(void);
private:
	char* luxury;
	int speed;
	int passengers;
};
// end Luxury

#endif // !LUXURY_H