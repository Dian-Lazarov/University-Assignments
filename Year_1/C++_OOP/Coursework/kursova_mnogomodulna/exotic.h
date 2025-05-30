#define _CRT_SECURE_NO_WARNINGS

#ifndef EXOTIC_H
#define EXOTIC_H

// Exotic
class Exotic : public Sports {
public:
	void initialize(int, int);
	virtual int getSpeed(void);
	virtual int getPassengers(void);
	Exotic(const char* e = "class Exotic");
	~Exotic() { delete exotic; }
	virtual void print(void);
private:
	char* exotic;
	int speed;
	int passengers;
};
// end Exotic

#endif // !EXOTIC_H