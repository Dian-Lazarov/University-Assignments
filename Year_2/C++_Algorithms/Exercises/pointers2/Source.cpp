#include <iostream>
#include <string>
using namespace std;

struct ST {
    string s;
    int i;
};
typedef ST* PST;
PST P1, P2;

void main() {
    // Allocate memory for P1 and P2
    P1 = new ST;
    P1->s = "a1";
    P1->i = 1;

    P2 = new ST;
    P2->s = "a1";
    P2->i = 1;

   // if (P1 == P2) cout << "P1 == P2"; else cout << "P1 != P2"; // address (Y, P1 != P2)
   // if (*P1 == *P2) cout << "*P1 == *P2"; else cout << "*P1 != *P2"; // N (P1 and P2 are pointers)
   // cout << P1->s[1]; // Y, 1 (ще се отпечата символът с индекс 1 от низа "a1")
   // cout << P2; // Y, address
   // cout << *P1; // N (P1 is a pointer)
   // cin >> P2; // N (operation 'cin' is forbidden for pointers)
   // cin >> *P1; // N (operation 'cin' is forbidden for pointers)
}