#include <stdio.h>
#include <stdlib.h>

void main() {
	system("chcp 1251");

	int A[10][20], B[10];
	int m, n, i, j;

	printf_s("\nVuvedete broi redove: "); scanf_s("%d", &m);
	printf_s("Vuvedete broi stulbove: "); scanf_s("%d", &n);

	printf_s("\nVuvedete elementite na dvumerniq masiv A[%d][%d]:\n", m, n);
	for (i = 0; i < m; i++) {
		for (j = 0; j < n; j++) {
			scanf_s("%d", &A[i][j]);
		}
	}

	for (j = 0; j < n; j++) {
		int max_otr = -1; //nai-golqma otr stoinost
		int max_otr_index = -1; //index na nai-golqmata otr stoinost

		for (i = 0; i < m; i++) {
			if (A[i][j] < 0) {
				if (A[i][j] > max_otr || max_otr_index == -1) {
					max_otr = A[i][j];
					max_otr_index = i;
				}
			}

		}
		B[j] = max_otr_index;
	}

	for (j = 0; j < n; j++) {
		if (B[j] != -1) { //proverka za otricatelni stoinosti
			printf_s("Indeksut na nai-golqmata otricatelna stoinost v stulb %d e: %d\n", j, B[j]);
		}
		else {
			printf_s("Nqma otricatelni stoinosti v stulb %d\n", j);
		}
	}

	system("pause");
}