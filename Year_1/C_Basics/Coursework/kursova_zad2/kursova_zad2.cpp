#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct STUDENT
{
	char ime[41];
	char EGN[11];
	char FN[7];
	int ocenki[10];
	float sr_uspeh;
};

FILE* fp;
char imefl[31];
STUDENT student;

//vuvejdane
void ReadStud(STUDENT* st)
{
	printf_s("\nVuvedete ime: ");
	gets_s(st->ime);
	printf_s("Vuvedete EGN: ");
	gets_s(st->EGN);
	printf_s("Vuvedete fakulteten nomer: ");
	gets_s(st->FN);
	printf_s("Vuvedete ocenkite po 10 disciplini:\n");
	for (int i = 0; i < 10; i++) {
		printf_s("Disciplina %d: ", i + 1);
		scanf_s("%d", &st->ocenki[i]); getchar();
	}
}

//izvejdane
void WriteStud(STUDENT st)
{
	printf_s("\nIme: %s\nEGN: %s\nFakulteten nomer: %s\n", st.ime, st.EGN, st.FN);
	printf_s("Ocenki:");
	for (int i = 0; i < 10; i++) {
		printf_s("%3d", st.ocenki[i]);
	}
}

//suzdavane na file
void CreateFL()
{
	fp = fopen(imefl, "w"); fclose(fp);
	printf_s("\nFailut e suzdaden!\n");
}

//dobavqne na informaciq kum faila
void AddFL()
{
	fp = fopen(imefl, "a+b");
	char ch;
	do {
		ReadStud(&student);
		fwrite(&student, sizeof(student), 1, fp);
		WriteStud(student);
		printf_s("\n\nShte produljite li vuvejdaneto (d/n)? ");
		ch = getchar(); getchar();
	} while (ch != 'n');
	fclose(fp);
}

//izchislqvane na sreden uspeh
void CalcAverage()
{
	fp = fopen(imefl, "rb");
	fread(&student, sizeof(student), 1, fp);

	while (!feof(fp)) {
		float sum_oc = 0;
		int br_oc = 0;

		for (int i = 0; i < 10; i++) {
			sum_oc += student.ocenki[i];
			if (student.ocenki[i] != 0) {
				br_oc++;
			}
		}
		student.sr_uspeh = sum_oc / br_oc;
		printf_s("\nSreden uspeh za %s (%s): %0.2f", student.ime, student.FN, student.sr_uspeh);
		fread(&student, sizeof(student), 1, fp);
	}
	printf_s("\n");
	fclose(fp);
}

//spisuk
void ListFN()
{
	fp = fopen(imefl, "rb");
	fread(&student, sizeof(student), 1, fp);
	printf_s("\nSpisuk ot fakultetnite nomera s ne poveche ot dve dvoiki:");

	while (!feof(fp)) {

		int br_dvoiki = 0;

		for (int i = 0; i < 10; i++) {
			if (student.ocenki[i] == 2) {
				br_dvoiki++;
			}
		}
		if (br_dvoiki <= 2) {
			printf_s("\n%s", student.FN);
		}
		fread(&student, sizeof(student), 1, fp);
	}
	printf_s("\n");
	fclose(fp);
}

void main()
{
	system("chcp 1251");

	char izbor[3];
	printf_s("\nZadaite ime na file: "); gets_s(imefl);
	do {
		printf_s("\n===MENU===\n");
		printf_s("1. Suzdavane na prazen file.\n");
		printf_s("2. Dobavqne na informaciq za student.\n");
		printf_s("3. Izchislqvane na sreden uspeh.\n");
		printf_s("4. Suzdavane na spisuk ot fakultetnite nomera s ne poveche ot dve dvoiki.\n");
		printf_s("0. Krai na programata.\n");
		gets_s(izbor);

		switch (izbor[0]) {
		case '1': CreateFL(); break;
		case '2': AddFL(); break;
		case '3': CalcAverage(); break;
		case '4': ListFN(); break;
		case '0': printf_s("Krai.\n"); break;
		default: printf_s("\nNevaliden izbor!\n");
		}
	}
	while (izbor[0] != '0');

	system("pause");
}