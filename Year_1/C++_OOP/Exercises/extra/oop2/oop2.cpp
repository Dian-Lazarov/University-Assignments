#define _CRT_SECURE_NO_WARNINGS

#include <iostream>
using namespace std;

class Person {
public:
	Person(void); // default constructor
	Person(const char*, int); // initializational constructor
	Person(Person&); // copy constructor (optional)
	~Person(void); // destructor
	void display(void); // method

private:
	char* name;
	int age;
};

void main() {
	system("chcp 1251");

	Person obj;
	obj.display(); // using the method

	Person alpha("John", 22);
	alpha.display();

	Person beta(alpha);
	beta.display();

	// static array
	/* Person stat[3];
	for (int i = 0; i < 3; i++) {
		stat[i].display();
	}

	// dynamic array
	Person* ptr;
	ptr = new Person[3];
	for (int i = 0; i < 3; i++) {
		(ptr + i)->display();
	}
	delete[] ptr; */

	system("pause");
}

//definitions
Person::Person(void) {
	char buf[20];
	cout << "Name: ";
	cin >> buf;
	name = new char[strlen(buf) + 1];
	strcpy(name, buf);
	cout << "Age: ";
	cin >> age;
}
Person::Person(const char* n, int a) {
	name = new char[strlen(n) + 1];
	strcpy(name, n);
	age = a;
}
Person::Person(Person& obj) {
	name = new char[strlen(obj.name) + 1];
	strcpy(name, obj.name);
	age = obj.age;
}
Person::~Person(void) {
	delete name;
	cout << "End" << endl;
}
void Person::display(void) {
	cout << "\nName: " << name;
	cout << "\nAge: " << age << endl;
}