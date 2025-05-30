#include <iostream>
using namespace std;

struct item {
	string info;
	item* next;
};
typedef item* point;
point Head;

void Create(point& Head) {
	point P; 	// current element
	point Last = NULL; 	// last element
	char	ch;

	cout << "Нов елемент (Y/N)?: ";
	cin >> ch;
	while (ch == 'Y' || ch == 'y') {
		P = new item;
		cout << "Въведете низ: ";
		cin >> P->info;
		P->next = NULL;
		if (Head == NULL) 	Head = P;
		else	Last->next = P;
		Last = P;
		cout << "Нов елемент (Y/N)?: ";
		cin >> ch;
	}	// while
}	// Create

void PrintList(point Head) {
	point P = Head;
	while (P != NULL) {
		cout << P->info << " ";
		P = P->next;
	}
	cout << endl;
}

float AvgStringLength(point P) {
	int maxLength = 0;
	int count = 0;
	while (P != NULL) {
		maxLength += P->info.length();
		count++;
		P = P->next;
	}
	return (float) maxLength / count;
}

void main() {
	system("chcp 1251");

	point Head = NULL;
	Create(Head);
	PrintList(Head);

	cout << "Средноаритметичната стойност на дължината на въведените низове е: " << AvgStringLength(Head) << endl;

	system("pause");
}