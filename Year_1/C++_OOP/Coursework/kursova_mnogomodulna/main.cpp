#define _CRT_SECURE_NO_WARNINGS

#include "vehicle.h"
#include "car.h"
#include "sports.h"
#include "luxury.h"
#include "exotic.h"
#include "performance.h"
#include "supercar.h"
#include "hypercar.h"
#include "motorcycle.h"
#include "truck.h"

#include <iostream>
using namespace std;

// main
void main() {
	Vehicle* vehicle = new Vehicle;
	Vehicle* car = new Car;
	Vehicle* sports = new Sports;
	Vehicle* luxury = new Luxury;
	Vehicle* exotic = new Exotic;
	Vehicle* performance = new Performance;
	Vehicle* supercar = new Supercar;
	Vehicle* hypercar = new Hypercar;
	Vehicle* motorcycle = new Motorcycle;
	Vehicle* truck = new Truck;

	Motorcycle scooter;
	scooter.initialize(2, 45.5);
	cout << "Skutera e ot "; motorcycle->print();
	cout << "Skutera ima " << scooter.getWheels() << " kolela" << endl;
	cout << "Skutera teji " << scooter.getWeight() << " kg\n\n";

	Truck scania;
	scania.initialize(6, 9645.18);
	cout << "Scania e ot "; truck->print();
	cout << "Scania ima " << scania.getWheels() << " kolela" << endl;
	cout << "Scania teji " << scania.getWeight() << " kg\n\n";

	Exotic aston_martin;
	aston_martin.initialize(340, 2);
	cout << "Aston Martin e ot "; exotic->print();
	cout << "Aston Martin vdiga " << aston_martin.getSpeed() << " km/h" << endl;
	cout << "Aston Martin pobira " << aston_martin.getPassengers() << " dushi\n\n";

	cout << "Spisuk ot klasovete v yerarhiyata:" << endl;


	vehicle->link(car);
	car->link(sports);
	sports->link(luxury);
	luxury->link(exotic);
	exotic->link(performance);
	performance->link(supercar);
	supercar->link(hypercar);
	hypercar->link(motorcycle);
	motorcycle->link(truck);

	vehicle->printlist(vehicle);


	delete vehicle;
	delete car;
	delete sports;
	delete luxury;
	delete exotic;
	delete performance;
	delete supercar;
	delete hypercar;
	delete motorcycle;
	delete truck;

	system("pause");
}
// end main