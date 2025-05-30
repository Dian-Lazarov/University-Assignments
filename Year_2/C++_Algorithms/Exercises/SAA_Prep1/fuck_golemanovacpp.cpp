#include <iostream>
//#include <iomanip>
using namespace std;
struct TEST {
	int age = 0;
	string name;
	float money = 0;
};
TEST Test;
TEST* PTest;
typedef TEST* t;
t test;
//Ptest = new t;

struct item {
	int info;
	item* next;
};
typedef item* point;
point Head;

void main() {
	system("chcp 1251");
	//Test.age;
	//PTest->money;
	int I = 666;
	typedef int* Po;
	Po pp;
	pp = new int; //initialize pointer P
	*pp = 666;
	*pp = I;
	if (I != *pp) { I = *pp; }
	cout << "Въведете стойност: "; cin >> *pp; // cin >> &pp; cin >> pp; (NO!)
	cout << *pp << endl; //value
	cout << &pp << endl; //address
	cout << pp << endl; //another address(?)
	delete pp; //free the dynamic memory

	/* int array[3];
	array[0] = 6;
	array[1] = 4;
	array[2] = 3;
	int br = 0;
	int sum = 0;

	for (int i = 0; i < 3; i++) {
		br++;
	}

	for (int i = 0; i < br; i++) {
		sum = sum + array[i];
	}

	for (int i = 0; i < br; i++) {
		cout << "Елемент " << i << ": " << array[i] << endl;
	}
	cout << "Сума на елементите: " << sum << endl;

	float avg = (float) sum / br;
	cout << "Средно-аритметична стойност на елементите: " << avg << endl;
	cout.precision(3);
	//cout << setprecision(3) << avg; */
	system("pause");
}