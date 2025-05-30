
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>
#include <time.h>

void main() //int main ()
{
	system("chcp 1251");

	for (int i = 1; i <= 10; i++)

		printf("\n%1.3d\n", i);

	system("pause");

	/*
	   ---BASICS---
	   &&         //AND
	   ||         //OR
	   !=         //NOT [1]
	   !(a == b)  //NOT [2]
	   ?:        //IF CONDITION IS TRUE ? THEN VALUE "x" : OTHERWISE VALUE "y"
	   sizeof()  //RETURNS THE SIZE OF A VARIABLE (DEPENDING ON ITS TYPE)
	   long int a;    //32-bit
	   long long int a;   //64-bit
	   x = x + y <=> x += y
	   ---BASICS---


	   ---POINTERS---
	   int *a   //POINTER TO A VARIABLE TOWARDS INT
	   &a   //RETURNS THE ACTUAL ADDRESS OF A VARIABLE
	   a = new int[already declared variable];
	   if(a==NULL) //if(!a) => "the array isn't created!"
       return;     //end of void main function
	   return 0;    //end of int main function
       delete[]a;      //after system("pause"); [to free the memory]
	   ---POINTERS---

	   ---STRINGS---
	   #include <string.h>
	   char s[n];     //%c – one symbol, %s – multiple symbols
	   gets();     //text w/ intervals (vuvejdane)
	   puts();     //text w/ intervals (izvejdane)
	   fgets();     //prenasq simvoli ot bufera v stringa, dokato ne sreshtne \n
	   strlen();    //function which takes a string as an argument and returns its length
	   sizeof();    //calculates the size of its operand
	   strcat();    //appends a copy of the source string to the destination string
	   strcpy();    //copies the C string pointed by source into the array pointed by destination, including the terminating null character (and stopping at that point)
	   strcmp();    //compares two strings in alphabetical order (returns 0	if strings are equal, returns >0 if the first non-matching character in str1 is greater than that of str2, returns <0 if the first non-matching character in str1 is lower than that of str2)
	   2-36 simvola za osnova na br. sistema
	   ---STRINGS---
	*/
}