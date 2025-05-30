#include <iostream>

using std::cout;
using std::endl;

void main( )
{
	int		a=95;
	char	ch='a';
	float	b=8.31;
	const char	*str = "The results are:";

	cout << endl << "This is an example of output stream" << endl;
	cout << endl << str << endl;
	cout << endl << ch << " is " << a << endl;
	cout << endl << "b is " << b << endl;

	float *ptrb = &b;
	cout << endl << &a << " , " << ptrb << endl;
	cout << endl << (void *)str << endl;

} // end main