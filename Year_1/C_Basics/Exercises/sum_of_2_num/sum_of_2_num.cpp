
#include <stdio.h>
#include <stdlib.h>

void main()
{
	system("chcp 1251");

	int x, y, z;

	printf("������� �������� �� x: "); scanf_s("%d", &x);
	printf("������� �������� �� y: "); scanf_s("%d", &y);

	z = x + y;

	printf("z=%d\n", z);

	system("pause");
}