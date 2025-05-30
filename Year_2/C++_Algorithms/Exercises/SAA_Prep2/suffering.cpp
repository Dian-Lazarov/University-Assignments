#include <iostream>
using namespace std;

struct List {
	int info;
	List* next;
};
typedef List* point;
point Head;

void Create(point& Head) {
	point P; 	// ����� �������
	point Last = NULL; 	// �������� �������
	char	ch;

	cout << "��� ������� (Y/N) ?: ";
	cin >> ch;
	while (ch == 'Y' || ch == 'y') {
		P = new List;
		cin >> P->info;
		P->next = NULL;
		if (Head == NULL) 	Head = P;
		else	Last->next = P;
		Last = P;
		cout << "��� ������� (Y/N) ?: ";
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
	cout << "����������� �� ��������: ";

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
	cout << "�������� ��������: "; PrintList(Head);
	cout << "���� ��������: " << CountElem(Head) << endl;
	cout << "����������������� �������� �� ����������: " << AvgElem(Head) << endl;
	cout << "���� �� ������� ��������: " << SumEven(Head) << endl;
	cout << "���� �� ��������� ��������: " << SumOdd(Head) << endl;
	cout << "���������� �������: " << MaxElem(Head) << endl;
	cout << "��������� �������: " << MinElem(Head) << endl;
	NonRepeatElem(Head);

	int x;
	cout << "�������� ������� �� �������� � �������� �� �������: "; cin >> x;
	InsertStart(Head, x);
	cout << "������� ������: ";
	PrintList(Head);

	int y;
	cout << "�������� ������� �� �������� � ���� �� �������: "; cin >> y;
	InsertEnd(Head, y);
	cout << "������� ������: ";
	PrintList(Head);

	DeleteFirst(Head);
	cout << "������� ������ ���� ��������� �� ������ �������: ";
	PrintList(Head);

	DeleteLast(Head);
	cout << "������� ������ ���� ��������� �� ��������� �������: ";
	PrintList(Head);

	system("pause");

}