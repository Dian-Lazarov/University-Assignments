#define _CRT_SECURE_NO_WARNINGS

#include <iostream>

using namespace std;

void f1(int a, int b) {
	cout << "������ �� ���������� ����� �� f1 �: " << a + b << endl;
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
	cout << "�������� ���� ����� �� ������� ���������: "; cin >> s1;
	cout << "�������� ���� ����� �� ������� ���������: "; cin >> s2;

	f1(s1, s2);
	f1(44, 89);

	r = f2(s1, s2);
	cout << "������ �� ���������� ����� �� f2 �: " << r << endl;

	f3(s1, s2, &r);
	cout << "������ �� ���������� ����� �� f3 �: " << r << endl;

	f4(s1, s2, r);
	cout << "������ �� ���������� ����� �� f4 �: " << r << endl;

	system("pause");

}