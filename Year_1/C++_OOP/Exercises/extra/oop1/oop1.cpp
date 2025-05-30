#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;

void f1(int a, int b) {
	cout << "Сумата на въведените числа за f1 е: " << a + b << endl;
}

int f2(int a, int b) {
	return a + b;
}

void f3(int a, int b, int* c) {
	*c = a + b;
}

void f4(int a, int b, int& c) {
	c = a + b;
}

void main() {

	system("chcp 1251");

	//cout << endl << endl << "Hello, world!" << endl << endl;

	int s1, s2, r;
	cout << "Въведете цяло число за първото събираемо: "; cin >> s1;
	cout << "Въведете цяло число за второто събираемо: "; cin >> s2;

	f1(s1, s2);
	f1(44, 89);

	r = f2(s1, s2);
	cout << "Сумата на въведените числа за f2 е: " << r << endl;

	f3(s1, s2, &r);
	cout << "Сумата на въведените числа за f3 е: " << r << endl;

	f4(s1, s2, r);
	cout << "Сумата на въведените числа за f4 е: " << r << endl;

	system("pause");

}