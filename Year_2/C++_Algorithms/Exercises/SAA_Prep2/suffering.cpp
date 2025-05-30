#include <iostream>
using namespace std;

struct List {
	int info;
	List* next;
};
typedef List* point;
point Head;

void Create(point& Head) {
	point P; 	// текущ елемент
	point Last = NULL; 	// последен елемент
	char	ch;

	cout << "Нов елемент (Y/N) ?: ";
	cin >> ch;
	while (ch == 'Y' || ch == 'y') {
		P = new List;
		cin >> P->info;
		P->next = NULL;
		if (Head == NULL) 	Head = P;
		else	Last->next = P;
		Last = P;
		cout << "Нов елемент (Y/N) ?: ";
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

void InsertStart(point& Head, int x) {
	point newElem = new List;
	newElem->info = x;
	newElem->next = Head;
	Head = newElem;
}

void InsertEnd(point& Head, int y) {
	point newElem = new List;
	newElem->info = y;
	newElem->next = NULL;
	point P = Head;
	while (P->next != NULL) {
		P = P->next;
	}
	P->next = newElem;
}

void DeleteFirst(point& Head) {
	point P = Head;
	Head = Head->next;
	delete P;
}

void DeleteLast(point& Head) {
	point P = Head;
	while (P->next->next != NULL) {
		P = P->next;
	}
	delete P->next;
	P->next = NULL;
}

int CountElem(point P) {
	int br = 0;
	while (P != NULL) {
		br++;
		P = P->next;
	}
	return br;
}

float AvgElem(point P) {
	int sum = 0;
	int count = 0;
	while (P != NULL) {
		sum += P->info; // sum = sum + P->info;
		count++; // count = count + 1
		P = P->next;
	}
	return (float) sum / count;
}

int MaxElem(point P) {
	int max = 0;
	while (P != NULL) {
		if (P->info > max) {
			max = P->info;
		}
		P = P->next;
	}
	return max;
}

int MinElem(point P) {
	int min = P->info;
	point temp = P;
	while (temp != NULL) {
		if (temp->info < min) {
			min = temp->info;
		}
		temp = temp->next;
	}
	return min;
}

void NonRepeatElem(point P) {
	point current = P;
	cout << "Неповтарящи се елементи: ";

	while (current != NULL) {
		int count = 0;
		point temp = P;

		// Count occurrences of current->info in the list
		while (temp != NULL) {
			if (temp->info == current->info) {
				count++;
			}
			temp = temp->next;
		}

		// If the element is unique (appears only once), print it
		if (count == 1) {
			cout << current->info << " ";
		}

		current = current->next;
	}

	cout << endl;
}

int SumEven(point P) {
	int sum = 0;
	while (P != NULL) {
		if (P->info % 2 == 0) {
			sum += P->info;
		}
		P = P->next;
	}
	return sum;
}

int SumOdd(point P) {
	int sum = 0;
	while (P != NULL) {
		if (P->info % 2 != 0) {
			sum += P->info;
		}
		P = P->next;
	}
	return sum;
}


void main() {
	system("chcp 1251");
	point Head = NULL;
	Create(Head);
	cout << "Въведени елементи: "; PrintList(Head);
	cout << "Брой елементи: " << CountElem(Head) << endl;
	cout << "Средноаритметична стойност на елементите: " << AvgElem(Head) << endl;
	cout << "Сума на четните елементи: " << SumEven(Head) << endl;
	cout << "Сума на нечетните елементи: " << SumOdd(Head) << endl;
	cout << "Максимален елемент: " << MaxElem(Head) << endl;
	cout << "Минимален елемент: " << MinElem(Head) << endl;
	NonRepeatElem(Head);

	int x;
	cout << "Въведете елемент за вмъкване в началото на списъка: "; cin >> x;
	InsertStart(Head, x);
	cout << "Обновен списък: ";
	PrintList(Head);

	int y;
	cout << "Въведете елемент за вмъкване в края на списъка: "; cin >> y;
	InsertEnd(Head, y);
	cout << "Обновен списък: ";
	PrintList(Head);

	DeleteFirst(Head);
	cout << "Обновен списък след изтриване на първия елемент: ";
	PrintList(Head);

	DeleteLast(Head);
	cout << "Обновен списък след изтриване на последния елемент: ";
	PrintList(Head);

	system("pause");

}