#include <iostream>
using namespace std;

// �������� �� ������������� ������ (�����������)
struct Flight {
	string flightNumber;
	int freeSeats;
	int occupiedSeats;
	Flight* next;
};
typedef Flight* point;
point Head;

// ������ (FIFO) � ��������� �� ��������� �� �������
void CreateFlight(point& Head) {
	point P; // ����� �������
	point Last = NULL; // �������� �������

	char input;
	cout << "������� �� �� �������� ���������� �� ��� �����? (Y/N): "; cin >> input;
	while (input == 'Y' || input == 'y') {
		// ��������� � �������� �� ��� ������� � �������� P � �������
		P = new Flight;
		cout << "�������� ����� �� �����: "; cin >> P->flightNumber;
		cout << "�������� ���� �������� �����: "; cin >> P->freeSeats;
		cout << "�������� ���� ����� �����: "; cin >> P->occupiedSeats;
		cout << endl;
		P->next = NULL; // ���� �� �������

		if (Head == NULL) {
			Head = P; // ��� �������� � ������, ������ ������� ����� ����� (������� �� �������)
		}

		else {
			Last->next = P; // ��� �������� �� � ������, ������ ������� �� ������� ��� ���������� ��������
		}

		Last = P; // ������ ������� ����� ��������
		cout << "������� �� �� �������� ���������� �� ��� �����? (Y/N): "; cin >> input;
	}
}

// ��������� �� ��������� �� ���������� �� ���������� ������
void PrintFlight(point P) {
	while (P != NULL) {	// ������ �������� �� � ������
		cout << "����� �� �����: " << P->flightNumber << endl;
		cout << "�������� �����: " << P->freeSeats << endl;
		cout << "����� �����: " << P->occupiedSeats << endl;
		cout << "=============================" << endl;
		P = P->next; // ������������ �� ��������� �� ������� ������� ��� ���������
	}
}

// ��������� �� ��������� �� ����� �� ������� ����� �� �����
void ReserveSeat(point P, string flightNumber) {
	bool FlightFoundCheck = false; // ������ ����������, ����� ��������� ���� ���������� ����� � � �������
	while (P != NULL) {
		if (P->flightNumber == flightNumber) {
			FlightFoundCheck = true; // true, ��� ���������� ����� ������� � �������
			if (P->freeSeats > 0) { // �������� �� ������ ��� �������� �����
				P->freeSeats--;
				P->occupiedSeats++;
				cout << "������� �� ����� " << flightNumber << " � �������� �������!" << endl << endl;
			}
			else {
				cout << "���� �������� ����� �� ����� " << flightNumber << endl << endl;
			}
		}
		P = P->next;
	}
	if (FlightFoundCheck == false) { // false, ��� ���������� ����� �� � ������ � �������
		cout << "������� " << flightNumber << " �� � ������ � �������!" << endl << endl;
	}
}

// ��������� �� ��������� �� ���������� �� ������ ������ ��� �������� �����
void PrintFreeSeats(point P) {
	bool FreeSeatsCheck = false; // ������ ����������, ����� ��������� ���� ��� ������ ��� �������� �����
	while (P != NULL) {
		if (P->freeSeats > 0) {
			FreeSeatsCheck = true; // true, ��� ����� �� ���������� ����� � > 0
			cout << "����� �� �����: " << P->flightNumber << endl;
			cout << "�������� �����: " << P->freeSeats << endl;
			cout << "����� �����: " << P->occupiedSeats << endl;
			cout << "=============================" << endl;
		}
		P = P->next;
	}
	if (FreeSeatsCheck == false) { // false, ��� ���� ������ ��� �������� �����
		cout << "���� ������ ��� �������� �����!" << endl;
	}
}

void main() {
	system("chcp 1251");

	// ������ ������
	Head = NULL;

	// ��������� �� ����������� �� ��������� �� �������
	CreateFlight(Head);

	// ������������ �� ����������, ��� �������� � ������
	if (Head == NULL) {
		cout << "���� �������� ������!" << endl;
		return;
	}
	// ��������� �� ����������� �� ��������� �� ���������� �� ��������
	PrintFlight(Head);


	// ��������� �� ����������� �� ��������� �� ����� �� ������� ����� �� ����� � �������� ����������� �� ��������� ������
	string flightReserve;
	cout << "�������� ����� �� �����, �� ����� ������� �� �������� �����: "; cin >> flightReserve;
	ReserveSeat(Head, flightReserve);
	PrintFlight(Head);

	// ��������� �� ����������� �� ��������� �� ���������� �� ������ ������ ��� �������� �����
	cout << "\n������ ��� �������� �����:\n" << endl;
	PrintFreeSeats(Head);

	system("pause");
}