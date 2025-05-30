#include <iostream>
#include <iomanip>
#include <cstring>

#define MAXLEN 20

using namespace std;

void main()
{
	const char *color[3] = {"red", "green", "blue"};

	cout << "Bez formatirane (po podrazbirane):" << endl;
	for (int i=0; i<3; i++)
		cout << *(color+i);
	cout << endl;

	cout << endl << "Vseki cviat v pole s shirina 10 simvola, na 1 red:" << endl;
	for (int i=0; i<3; i++)
		cout << setw(10) << *(color+i) << endl;
	cout << endl;

	cout << "Left side adjustment:" << endl;
	cout << setiosflags(ios::left);
	for (int i=0; i<3; i++)
		cout << setw(10) << *(color+i) << endl;
	cout << endl;

	cout << "Right side adjustment:" << endl;
	cout << setiosflags(ios::right);
	for (int i=0; i<3; i++)
		cout << setw(10) << *(color+i) << endl;
	cout << endl;

	cout << "Zapalvane na praznite pozicii sas simvol *:" << endl;
	for (int i=0; i<3; i++)
		cout << setw(10) << setfill('*') << *(color+i) << endl;
	cout << endl;

	char text[MAXLEN];
	int len;
	for (int i=0; i<3; i++)
	{
		cout << endl << "Vavedete text: ";
		cin >> setw(MAXLEN) >> text;
		len = strlen(text);
		cout << "Vavedeniat text e: " << text << endl;
		cout << "s dalzina kato desetichno chislo " << dec << len << endl;
		cout << "s dalzina kato osmichno chislo " << oct << len << endl;
		cout << "s dalzina kato 16-tichno chislo " << hex << len << endl;

		cout << dec;
	}// end for

} // end main