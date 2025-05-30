#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void fun1(float n) {
    while (n > 0) {
        printf_s("%3.1f=", n); n--;
    }
    printf_s("?\n");
}

int main() {
    fun1(3.5);
    /* int m = 8;
    int n = 5;
    int s = 0;

    while (m >= n) {
        s = s + m; //s += m;
        m--;
    }
    printf("The sum is: %d\n", s);
    return s; */
}