#include <iostream>
using namespace std;

struct item {
	string info;
	item* next, * prev;
};
typedef item* point;
point Head;

void Create(point& Head) {
	point P; // current element
	point Last = NULL; // last element

	char input;
	cout << "Would you like to add a new element? (Y/N): "; cin >> input;
	while (input == 'Y' || input == 'y') {
		P = new item;
		cin >> P->info;
		P->next = NULL;

		if (Head == NULL) {
			P->prev = NULL; // creation of first element
			Head = P;
		}
		else {
			P->prev = Last;
			Last->next = P;
		}
		Last = P;
		cout << "Would you like to add a new element? (Y/N): "; cin >> input;
	} // while
} // Create

void PrintList(point Head) {
	point P = Head;
	while (P != NULL) {
		cout << P->info << " ";
		P = P->next;
	}
	cout << endl;
}

bool IsPalindrome(point Head) {
	if (Head == NULL) {
		return true; // An empty list is a palindrome
	}

	point front = Head;
	point back = Head;

	// Move back to the last element
	while (back->next != NULL) {
		back = back->next;
	}

	// Compare elements from front and back
	while (front != back && front->prev != back) {
		if (front->info != back->info) {
			return false; // Not a palindrome
		}
		front = front->next;
		back = back->prev;
	}
	return true; // It's a palindrome
}

void main() {
	system("chcp 1251");
	Head = NULL;
	Create(Head);
	PrintList(Head);

	if (IsPalindrome(Head)) {
		cout << "The list is a palindrome!" << endl;
	}
	else {
		cout << "The list is NOT a palindrome!" << endl;
	}

	system("pause");
}