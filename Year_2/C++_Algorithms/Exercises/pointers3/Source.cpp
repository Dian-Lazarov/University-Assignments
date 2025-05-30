#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <string>
using namespace std;

struct st {
	char s[5];
	int i;
};
typedef st* x;
x P;
st Z;

void main() {
	P = new st;
	strcpy(P->s, "a12");
	P->i = 1;
	strcpy(Z.s, "b34");
	Z.i = 10;

	// cout << P; // Y (address)
	// cout << *P; // N (P is a pointer)
	// cout << P->s[0]; // Y, a (ще се изведе символът с индекс 0 от низа "a12")
	// int A = P->i - Z.i; cout << A; // Y (1 - 10 = -9)
	// x.i = "22"; cout << x; // N
}