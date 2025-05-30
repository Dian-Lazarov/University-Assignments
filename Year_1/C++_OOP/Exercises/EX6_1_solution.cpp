#include <iostream>

using namespace std;

class Vehicle
{
public:
	void initialize( int, float);
	int getWheels( void );
	float getWeight( void );
	float wheelLoading( void );
protected:
	int wheels;
	float weight;
}; // end class Vehicle

class Car : public Vehicle
{
public:
	void initialize(int, float, int = 4);
	int passengers( void );
protected:
	int passengerLoad;
}; // end class Car

class Truck : public Vehicle
{
public:
	void initTruck( int = 2, float = 24000.0);
	float efficiency( void );
	int passengers( void );
private:
	int passengerLoad;
	float payLoad;
}; // end class Truck

class SportCar : public Car
{
public:
	void initialize(int, float, int, int);
	int getSpeed(void);
private:
	int speed;
};

void main( void )
{
  Vehicle tricycle;
	tricycle.initialize(3, 37.5);
	cout << "Trikolkata ima " << tricycle.getWheels() << " kolela."<<endl;
	cout << "Natowarwaneto na edno kolelo na trikolkata e " 
			<< tricycle.wheelLoading() << " kilograma."<<endl;
	cout << "Trikolkata tezi " << tricycle.getWeight() 
			<< " kilograma" <<endl<<endl;

	Vehicle bicycle;
	bicycle.initialize(2, 7.5);
	cout << "Vel ima " << bicycle.getWheels() << " kolela." << endl;
	cout << "Natowarwaneto na edno kolelo na v e "
		<< bicycle.wheelLoading() << " kilograma." << endl;
	cout << "v tezi " << bicycle.getWeight()
		<< " kilograma" << endl << endl;

  Car sedan;
	sedan.initialize(4, 3500.0, 5);
	cout << "Sedanat vozi " << sedan.passengers() << " passengers."<<endl;
	cout << "Sedanat tezi " << sedan.getWeight() << " kilograma."<<endl;
	cout << "Natovarvaneto na edno kolelo na sedana e " 
			<< sedan.wheelLoading()<< " kilograma."<<endl<<endl;

  Truck zil;
	zil.initialize(18, 12500.0);
	zil.initTruck(1, 33675.0);
	cout << "Zilat tezi " << zil.getWeight() << " kilograma."<<endl;
	cout << "Koeficientat na polezen tovar e "
		<< 100.0 * zil.efficiency() << " procenta."<<endl;

	SportCar mazda;
	mazda.initialize(4, 2000.0, 2, 200);
	cout << "Skorost = " << mazda.getSpeed() << endl;
	cout << "Mazdata vozi " << mazda.passengers() << " passengers." << endl;
	cout << "Mazdata tezi " << mazda.getWeight() << " kilograma." << endl;
	cout << "Natovarvaneto na edno kolelo na mazdata e "
		<< mazda.wheelLoading() << " kilograma." << endl << endl;

} // end main

void Vehicle :: initialize( int inWheels, float inWeight)
{
	wheels = inWheels;
	weight = inWeight;
}
int Vehicle :: getWheels( void )
{
	return wheels;
}

float Vehicle :: getWeight( void )
{
	return weight;
}
float Vehicle :: wheelLoading( void )
{
	return weight/wheels;
}

void Car :: initialize(int inWheels, float inWeight, int people)
{
	passengerLoad = people;
	wheels = inWheels;
	weight = inWeight;
}

int Car :: passengers(void)
{
	return passengerLoad;
}

void Truck :: initTruck( int howMany, float maxLoad)
{
	passengerLoad = howMany;
	payLoad = maxLoad;
}
float Truck :: efficiency( void )
{
	return payLoad / (payLoad + weight);
}
int Truck :: passengers( void )
{
	return passengerLoad;
}

void SportCar::initialize(int kol, float teg, int pass, int s)
{
	wheels = kol;
	weight = teg;
	passengerLoad = pass;
	speed = s;
}

int SportCar::getSpeed(void)
{
	return speed;
}



