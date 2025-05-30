// EX4_3.CPP
#define _CRT_SECURE_NO_WARNINGS    

#include <iostream>

using namespace std;

class Person
{
public:
	Person( void );
	Person( const char *, int );
	Person( Person & );
	~Person( void );
	void display( void );
private:
	char *name;
	int age;
}; // end Person

void main( void )
{

	Person john;
	john.display();

	Person mary("mary", 456);
	mary.display();

	Person alfa(john);
	alfa.display();


	Person *ptr;
	ptr = new Person[3];
	for ( int i=0; i<3; i++ )
		(ptr+i) -> display();

	delete [] ptr;

} // end main



Person::Person(void)
{
		cout << "Begin default constructor" << endl;
		char buf[20];
		cout << endl << "Name= ";
		cin >> buf;
		name = new char[strlen(buf)+1];
		strcpy(name,buf);
		cout << "Age = ";
		cin >> age;
} // end setData

Person::Person(const char *s, int num)
{
	cout << "Begin ini constructor" << endl;
	name = new char[strlen(s) + 1];
	strcpy(name,s);
	age = num;
}

Person::Person(Person &objPer)
{
	cout << "Begin Copy constructor" << endl;
	name = new char[strlen(objPer.name)+1];
	strcpy(name, objPer.name);
	age = objPer.age;
}

Person::~Person(void)
{
	delete name;
	cout << "End Person" << endl;
}

void Person::display( void )
{
	cout << endl << "Danni za liceto" << endl;
	cout << "Name = " << name << " Age = " << age << endl;
} // end display