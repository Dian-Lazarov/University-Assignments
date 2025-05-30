#include <cstring>
#include <iostream>


using namespace std;

void main()
{
	char input[40];
	char *ptstr, *pr;
	unsigned int len;
	int c1 = 0;
	int c2 = 0;
	int c3 = 0;
	int c4 = 0;
	int ca = 0;


	cout << " Vavedete simvolen niz " << endl << endl;
	cin.get(input, 40);


	ptstr=_strdup(input);

	while (pr = strtok(ptstr," .,"))
	{
		len = strlen(pr);
		switch (len)
		{
			case 1: c1++; break;
			case 2: c2++; break;
			case 3: c3++; break;
			case 4: c4++; break;
			default: ca++;
		} //end switch
		ptstr = NULL;
	} //end while

	cout << "Broi 1 bukveni dumi: " << c1 << endl;
	cout << "Broi 2 bukveni dumi: " << c2 << endl;
	cout << "Broi 3 bukveni dumi: " << c3 << endl;
	cout << "Broi 4 bukveni dumi: " << c4 << endl;
	cout << "Broi drugi dumi: " << ca << endl << endl;

} // end main
