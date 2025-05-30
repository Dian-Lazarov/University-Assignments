#include <cstring>
#include <iostream>

using namespace std;

#define SIZE 81
#define LIM 20

void sortline( char * [], int);

void main()
{
	char input[LIM][SIZE];
	char *ptrstr[LIM];
	int ct = 0;

	cout << " Vavedete do " << LIM << " reda" << endl;
	cout << "Za prekratiavane na vavezdaneto "
		<< "natisnete <Ctrl/Z> v nachaloto na reda" << endl << endl;

	while ( ((cin >> input[ct])) && (ct++ < LIM))
		ptrstr[ct-1] = input[ct-1];

  sortline(ptrstr,ct);
    
	cout << endl << " SORTIRAN MASIV " << endl << endl;
    for ( int k=0; k<ct; k++) cout << ptrstr[k] << "\n";

} //end main

void sortline( char *strings[], int num )
{
	char *temp;
	int top,seek;

	for (top=0; top<num-1; top++)
		for (seek=top+1; seek<num; seek++)
			if (strcmp(strings[top],strings[seek]) > 0)
			 {
				temp = strings[top];
				strings[top] = strings[seek];
				strings[seek] = temp;
			 }
} // end sortline
