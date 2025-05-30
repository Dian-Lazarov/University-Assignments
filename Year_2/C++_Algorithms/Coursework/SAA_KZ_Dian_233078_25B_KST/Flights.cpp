#include <iostream>
using namespace std;

// описание на едносвързания списък (структурата)
struct Flight {
	string flightNumber;
	int freeSeats;
	int occupiedSeats;
	Flight* next;
};
typedef Flight* point;
point Head;

// опашка (FIFO) – процедура за създаване на списъка
void CreateFlight(point& Head) {
	point P; // текущ елемент
	point Last = NULL; // последен елемент

	char input;
	cout << "Желаете ли да добавите информация за нов полет? (Y/N): "; cin >> input;
	while (input == 'Y' || input == 'y') {
		// създаване и добавяне на нов елемент с указател P в списъка
		P = new Flight;
		cout << "Въведете номер на полет: "; cin >> P->flightNumber;
		cout << "Въведете брой свободни места: "; cin >> P->freeSeats;
		cout << "Въведете брой заети места: "; cin >> P->occupiedSeats;
		cout << endl;
		P->next = NULL; // край на списъка

		if (Head == NULL) {
			Head = P; // ако списъкът е празен, новият елемент става първи („глава“ на списъка)
		}

		else {
			Last->next = P; // ако списъкът не е празен, новият елемент се свързва към досегашния последен
		}

		Last = P; // новият елемент става последен
		cout << "Желаете ли да добавите информация за нов полет? (Y/N): "; cin >> input;
	}
}

// процедура за извеждане на информация за въведените полети
void PrintFlight(point P) {
	while (P != NULL) {	// докато списъкът не е празен
		cout << "Номер на полет: " << P->flightNumber << endl;
		cout << "Свободни места: " << P->freeSeats << endl;
		cout << "Заети места: " << P->occupiedSeats << endl;
		cout << "=============================" << endl;
		P = P->next; // пренасочване на указателя на текущия елемент към следващия
	}
}

// процедура за запазване на място по зададен номер на полет
void ReserveSeat(point P, string flightNumber) {
	bool FlightFoundCheck = false; // булева променлива, която проверява дали въведеният полет е в списъка
	while (P != NULL) {
		if (P->flightNumber == flightNumber) {
			FlightFoundCheck = true; // true, ако въведеният полет съвпада с текущия
			if (P->freeSeats > 0) { // проверка за полети със свободни места
				P->freeSeats--;
				P->occupiedSeats++;
				cout << "Мястото за полет " << flightNumber << " е запазено успешно!" << endl << endl;
			}
			else {
				cout << "Няма свободни места за полет " << flightNumber << endl << endl;
			}
		}
		P = P->next;
	}
	if (FlightFoundCheck == false) { // false, ако въведеният полет не е открит в списъка
		cout << "Полетът " << flightNumber << " не е открит в списъка!" << endl << endl;
	}
}

// процедура за извеждане на информация за всички полети със свободни места
void PrintFreeSeats(point P) {
	bool FreeSeatsCheck = false; // булева променлива, която проверява дали има полети със свободни места
	while (P != NULL) {
		if (P->freeSeats > 0) {
			FreeSeatsCheck = true; // true, ако броят на свободните места е > 0
			cout << "Номер на полет: " << P->flightNumber << endl;
			cout << "Свободни места: " << P->freeSeats << endl;
			cout << "Заети места: " << P->occupiedSeats << endl;
			cout << "=============================" << endl;
		}
		P = P->next;
	}
	if (FreeSeatsCheck == false) { // false, ако няма полети със свободни места
		cout << "Няма полети със свободни места!" << endl;
	}
}

void main() {
	system("chcp 1251");

	// празен списък
	Head = NULL;

	// извикване на процедурата за създаване на списъка
	CreateFlight(Head);

	// прекратяване на програмата, ако списъкът е празен
	if (Head == NULL) {
		cout << "Няма въведени полети!" << endl;
		return;
	}
	// извикване на процедурата за извеждане на информация за полетите
	PrintFlight(Head);


	// извикване на процедурата за запазване на място по зададен номер на полет и повторно отпечатване на обновения списък
	string flightReserve;
	cout << "Въведете номер на полет, за който желаете да запазите място: "; cin >> flightReserve;
	ReserveSeat(Head, flightReserve);
	PrintFlight(Head);

	// извикване на процедурата за извеждане на информация за всички полети със свободни места
	cout << "\nПолети със свободни места:\n" << endl;
	PrintFreeSeats(Head);

	system("pause");
}