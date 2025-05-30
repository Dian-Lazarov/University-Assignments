#include <iostream>
#include <cstring>
using namespace std;

void main() {
	system("chcp 1251");

	typedef int* pInt;
	pInt PI;
	int I;

	PI = new int;
	*PI = 66;
	I = 22;

	// delete I; (N)
	// delete PI; (Y)
	// pInt = new int; (N)
	// PI = I / 11; (N)
	// *PI = I / 11; (Y)
	// I = (*PI) % 3; (Y, 0)
	// cout << PI << endl; (Y, address)
	// cout << *PI << endl; (Y, value)
	// cin >> PI; (N)
	// cin >> *PI; (Y)

	typedef char* charP;
	charP PC;
	char Ch;

	PC = new char;
	*PC = '&';
	Ch = '@';

	// Ch = new char; (N)
	// delete* PC; (N)
	// delete PC; (Y)
	// delete Ch; (N)
	// Ch = *PC; cout << Ch << endl; (Y)
	// cout << (*PC).char << endl; (N)
	// charP = new char; (N)

	system("pause");
}