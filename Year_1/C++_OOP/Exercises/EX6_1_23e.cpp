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

class LuxCar : public Car
{
public:
	void initialize(int, float, int, int);
	int priceCar(void);
private:
	int price;		
}; // end class LuxCar

class SportCar : public Car
{
public:
	void initialize(int, float, int, int);
	int speedCar(void);
private:
	int speed;		
}; // end class Car

void main( void )
{
  Vehicle tricycle;
	tricycle.initialize(3, 37.5);
	cout << "The tricycle has " << tricycle.getWheels() << " wheels."<<endl;
	cout << "The load on one wheel of the tricycle is " 
			<< tricycle.wheelLoading() << " kg."<<endl;
	cout << "The tricycle weighs " << tricycle.getWeight() 
			<< " kg." <<endl<<endl;

	Vehicle bicycle;
	bicycle.initialize(2, 15.5);
	cout << "The bicycle has " << bicycle.getWheels() << " wheels." << endl;
	cout << "The load on one wheel of the bicycle is "
		<< bicycle.wheelLoading() << " kg." << endl;
	cout << "The bicycle weighs " << bicycle.getWeight()
		<< " kg." << endl << endl;

  Car sedan;
	sedan.initialize(4, 3500.0, 5);
	cout << "The sedan carries " << sedan.passengers() << " passengers."<<endl;
	cout << "The sedan weighs " << sedan.getWeight() << " kg."<<endl;
	cout << "The load on one wheel of the sedan is " 
			<< sedan.wheelLoading()<< " kg."<<endl<<endl;

	Car ford;
	ford.initialize(4, 1500.0, 4);
	cout << "The ford carries " << ford.passengers() << " passengers." << endl;
	cout << "The ford weighs " << ford.getWeight() << " kg" << endl;
	cout << "The load on one wheel of the ford is "
		<< ford.wheelLoading() << " kg." << endl << endl;

	Truck zil;
	zil.initialize(18, 12500.0);
	zil.initTruck(1, 33675.0);
	cout << "The zil weighs " << zil.getWeight() << " kg."<<endl;
	cout << "Payload efficieny is "
		<< 100.0 * zil.efficiency() << " %"<< endl << endl;

	LuxCar rolsRois;
	rolsRois.initialize(4, 10000.0, 6, 100000);
	cout << "The price of the rolls royce is " << rolsRois.priceCar() << " $" << endl;
	cout << "The rolls royce carries " << rolsRois.passengers() << " passengers." << endl;
	cout << "The rolls roys weighs " << rolsRois.getWeight() << " kg." << endl;
	cout << "The load on one wheel of the rolls royce is "
		<< rolsRois.wheelLoading() << " kg." << endl << endl;

	SportCar mazda;
	mazda.initialize(4, 2000.0, 2, 250);
	cout << "The speed of the mazda is " << mazda.speedCar() << " km/h." << endl;
	cout << "The mazda carries " << mazda.passengers() << " passengers." << endl;
	cout << "The mazda weighs " << mazda.getWeight() << " kg" << endl;
	cout << "The load on one wheel of the mazda is "
		<< mazda.wheelLoading() << " kg." << endl << endl;

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

void LuxCar::initialize(int inWheels, float inWeight, int people, int inPrice)
{
	price = inPrice;
	passengerLoad = people;
	wheels = inWheels;
	weight = inWeight;
}

int LuxCar::priceCar(void)
{
	return price;
}

void SportCar::initialize(int inWheels, float inWeight, int people, int inSpeed)
{
	speed = inSpeed;
	passengerLoad = people;
	wheels = inWheels;
	weight = inWeight;
}

int SportCar::speedCar(void)
{
	return speed;
}