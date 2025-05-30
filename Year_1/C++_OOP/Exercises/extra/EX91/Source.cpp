#include <iostream>

using namespace std;

template <class T>
T maxF(T a, T b)
{
	return a > b ? a : b;
}

void main() {
	int n = 1, m = 2;
	float x = 5.61, y= 3.17;
	int i = maxF(n, m);
	float z = maxF(x, y);
	cout << i << endl;
	cout << z << endl;
}