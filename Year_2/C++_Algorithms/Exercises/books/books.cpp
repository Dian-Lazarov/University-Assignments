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

//������ (FIFO)
void Create(point& Head) {
	point P; 	// ����� �������
	point Last = NULL; 	// �������� �������
	char ch;

	cout << "��� ������� (Y/N)? ";
	cin >> ch;
	while (ch == 'Y' || ch == 'y') {
		P = new book;
		cout << "�������� ��������: ";
		cin >> P->title;
		cout << "�������� �����: ";
		cin >> P->author;
		cout << "�������� ������ �� ��������: ";
		cin >> P->year;

		P->next = NULL;
		if (Head == NULL) {
			Head = P;
		}
		else {
			Last->next = P;
		}
		Last = P;
		cout << "��� ������� (Y/N)? ";
		cin >> ch;
	}	// while
}	// Create

void PrintList(point P) {
	while (P != NULL) {
		cout << "��������: " << P->title << endl;
		cout << "�����: " << P->author << endl;
		cout << "������ �� ��������: " << P->year << endl << endl;
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
	cout << "������� �����: "; cin >> auth;
	BookAuthor(auth, Head1);
	cout << endl;

	int G;
	cout << "������� ������: "; cin >> G;
	point PointK = SearchBook(G, Head1);
	if (PointK != NULL) {
		cout << PointK->title << endl;
		cout << PointK->author << endl;
	}
	else {
		cout << "���� ������ ������!" << endl;
	}
	cout << endl;

	int Year;
	cout << "������� ������, ����� ����� �� �� �������� �����: "; cin >> Year; cout << endl;
	DeleteBook(Year, Head1);
	cout << "===������� ������===" << endl << endl;
	PrintList(Head1);

	system("pause");
}