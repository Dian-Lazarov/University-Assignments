// EX4_4.CPP

#include <iostream>
#include <cmath>

using namespace std;

class ComplexNum
{
public:
	ComplexNum( void );
	ComplexNum(double, double);
	ComplexNum(ComplexNum &);
	~ComplexNum( void );

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
	ComplexNum t(0,0);

	cout << "Vavedete 1-vo kompleksno chislo" << endl;
	ComplexNum u;

	cout << "Vavedete 2-ro kompleksno chislo" << endl;
	ComplexNum v;

	cout << endl << "Sabirane na kompleksni chisla" << endl;
	t = t.addComplex(u,v);
	t.displayComplex();

	ComplexNum alfa(t);
	alfa.displayComplex();

	cout << endl << "Umnozenie na kompleksni chisla" << endl;
	t = t.multiComplex(u,v);
	t.displayComplex();

	cout << endl << "Modul= " << u.modulComplex(u) << endl;

} //end main
ComplexNum::ComplexNum( void )
{
	cout << "Vavedete Real: ";
	cin >> real;

	cout << "Vavedete Imag: ";
	cin >> imag;
} // end inputComplex

ComplexNum::ComplexNum(double r, double i)
{
	real = r;	imag = i;
}

ComplexNum::ComplexNum(ComplexNum &objCom)
{
	real = objCom.real;
	imag = objCom.imag;
}

ComplexNum::~ComplexNum( void )
{
//	cout << "End ComplexNum" << endl;
}

ComplexNum ComplexNum::addComplex(ComplexNum x, ComplexNum y)
{
	ComplexNum z(0,0);
	z.real = x.real + y.real;
	z.imag = x.imag + y.imag;
	return z;
} // end addComplex

ComplexNum ComplexNum::multiComplex(ComplexNum x, ComplexNum y)
{
	ComplexNum z(0,0);
	z.real = x.real * y.real;
	z.imag = x.imag * y.imag;
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