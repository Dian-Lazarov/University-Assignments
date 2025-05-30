#include <iostream>
using namespace std;

struct book {
	string title; //char
	string author;
	int year;
	book* next;
};

typedef book* point;
//point Head;

//Опашка (FIFO)
void Create(point& Head) {
	point P; 	// текущ елемент
	point Last = NULL; 	// последен елемент
	char ch;

	cout << "Нов елемент (Y/N)? ";
	cin >> ch;
	while (ch == 'Y' || ch == 'y') {
		P = new book;
		cout << "Въведете заглавие: ";
		cin >> P->title;
		cout << "Въведете автор: ";
		cin >> P->author;
		cout << "Въведете година на издаване: ";
		cin >> P->year;

		P->next = NULL;
		if (Head == NULL) {
			Head = P;
		}
		else {
			Last->next = P;
		}
		Last = P;
		cout << "Нов елемент (Y/N)? ";
		cin >> ch;
	}	// while
}	// Create

void PrintList(point P) {
	while (P != NULL) {
		cout << "Заглавие: " << P->title << endl;
		cout << "Автор: " << P->author << endl;
		cout << "Година на издаване: " << P->year << endl << endl;
		P = P->next;
	}
}

void BookAuthor(string aname, point P) {
	while (P != NULL) {
		if (P->author == aname) {
			cout << P->title << endl;
			cout << P->year << endl;
		}
		P = P->next;
	}
}

point SearchBook(int X, point P) {
	while (P != NULL && P->year != NULL) {
		P = P->next;
		return P;
	}
}

void DeleteBook(int Y, point& Head) {
	point P = Head;
	point Pprev = NULL;
	while (P != NULL) {
		if (P->year < Y) {
			if (Pprev != NULL) {
				Pprev->next = P->next;
			}
			else {
				Head = P->next;
			}
			point Pdel = P;
			P = P->next;
			delete Pdel;
		}
		else {
			Pprev = P;
			P = P->next;
		}
	}
}

void main() {
	system("chcp 1251");

	point Head1, Head2;
	Head1 = Head2 = NULL;

	Create(Head1);
	Create(Head2);

	PrintList(Head1);
	PrintList(Head2);

	string auth;
	cout << "Задайте автор: "; cin >> auth;
	BookAuthor(auth, Head1);
	cout << endl;

	int G;
	cout << "Задайте година: "; cin >> G;
	point PointK = SearchBook(G, Head1);
	if (PointK != NULL) {
		cout << PointK->title << endl;
		cout << PointK->author << endl;
	}
	else {
		cout << "Няма такава година!" << endl;
	}
	cout << endl;

	int Year;
	cout << "Задайте година, преди която ще се изтриват книги: "; cin >> Year; cout << endl;
	DeleteBook(Year, Head1);
	cout << "===ОБНОВЕН СПИСЪК===" << endl << endl;
	PrintList(Head1);

	system("pause");
}