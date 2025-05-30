
#include <stdio.h>
#include <stdlib.h>

void main()
{
	system("chcp 1251");

	int a, b, c;

	printf("a="); scanf_s("%d", &a);
	printf("b="); scanf_s("%d", &b);
	printf("c="); scanf_s("%d", &c);

	if (a + b > c && b + c > a && a + c > b && a == b && b == c && a == c) {
		printf("Отсечките образуват равностранен триъгълник.\n");
	}

	else {
		printf("Отсечките не образуват равностранен триъгълник.\n");
	}

	system("pause");
}