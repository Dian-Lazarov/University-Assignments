#define _CRT_SECURE_NO_WARNINGS

#include <iostream>     

using namespace std;

class Person
{
	public:
		void setData( void );
		void display( void );
	private:
		char *name;
		unsigned int age;
}; // end Person

void main( void )
{
	Person john, mary;

	john.setData();
	mary.setData();

	john.display();
	mary.display();

} // end main

void Person::setData(void)
{
		char buf[20];
		cout << endl << "Name= ";
		cin >> buf;
		name = new char[strlen(buf)+1];
		strcpy(name,buf);
		cout << "Age = ";
		cin >> age;
} // end setData

void Person::display( void )
{
	cout << endl << "Danni za liceto" << endl;
	cout << "Name = " << name << " Age = " << age << endl;
} // end display