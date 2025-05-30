#include <iostream>
#include <cmath>

using namespace std;

class ComplexNum
{
	public:
		void inputComplex( void );
		ComplexNum addComplex(ComplexNum, ComplexNum);
		ComplexNum multiComplex(ComplexNum, ComplexNum);
		double modulComplex( ComplexNum );
		void displayComplex( void );
		double getReal( void )
			{ return real; }
		double getImag( void )
			{ return imag; }
	private:
		double real;
		double imag;
	
}; // end ComplexNum

void main( void )
{
	ComplexNum u,v, t;

	cout << "Vavedete 1-vo kompleksno chislo" << endl;
	u.inputComplex();

	cout << "Vavedete 2-ro kompleksno chislo" << endl;
	v.inputComplex();

	cout << endl << "Sabirane na kompleksni chisla" << endl;
	t = t.addComplex(u,v);
	t.displayComplex();

	cout << endl << "Umnozenie na kompleksni chisla" << endl;
	t = t.multiComplex(u,v);
	t.displayComplex();

	cout << endl << "Modul= " << u.modulComplex(u) << endl;

} //end main

void ComplexNum::inputComplex( void )
{
	cout << "Vavedete Real: ";
	cin >> real;

	cout << "Vavedete Imag: ";
	cin >> imag;
} // end inputComplex

ComplexNum ComplexNum::addComplex(ComplexNum x, ComplexNum y)
{
	ComplexNum z; // работен обект
	z.real = x.real + y.real;
	z.imag = x.imag + y.imag;
	return z;
} // end addComplex

ComplexNum ComplexNum::multiComplex(ComplexNum x, ComplexNum y)
{
	ComplexNum z;
	z.real = x.real * y.real - x.imag * y.imag;
	z.imag = x.real * y.imag + x.imag * y.real;
	return z;
} // end multiComplex

double ComplexNum::modulComplex(ComplexNum x)
{
	return sqrt( x.real*x.real + x.imag*x.imag );
} // end modulComplex

void ComplexNum::displayComplex( void )
{
	cout << endl << "Real = " << getReal();
	cout << endl << "Imag = " << getImag() << endl;
} // end displayComplex