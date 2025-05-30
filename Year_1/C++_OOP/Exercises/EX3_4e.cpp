#define _CRT_SECURE_NO_WARNINGS

#include <iostream>      

using std::cout;
using std::cin;
using std::endl;
using std::fixed;

#include <iomanip>

using std::setprecision;

class SalesPerson
{
public:
	void getSalesFromUser( void );
	void printAnnualSales( void );		// summarize and print sales
private:
	void setSales( int, double );		// set sales for a month
	double totalAnnualSales( void );	// utility function
	char *name;
	double sales[12];

}; //end SalesPerson

void main( void )
{
	SalesPerson john, mary;

	john.getSalesFromUser();
	mary.getSalesFromUser();

	john.printAnnualSales();
	mary.printAnnualSales();

} // end main
void SalesPerson::getSalesFromUser( void )
{
	char bufName[20];
	double salesFigure;

	cout << endl << "Enter the name: ";
	cin >> bufName;
	name = new char[strlen(bufName)+1]; // заделяне на памет
	strcpy(name, bufName);

	for( int i=1; i<=12; i++)
	{
		cout << "Enter sales amount for month " << i << ": ";
		cin >> salesFigure;
		setSales(i, salesFigure);
	} // end for

} // getSalesFromUser

void SalesPerson::setSales(int month, double amount)
{
	if( month >= 1 && month <= 12 && amount > 0 )
		sales[month-1] = amount;
	else
		cout << "Invalid month or sales figure" << endl;
} // end setSales

void SalesPerson::printAnnualSales( void )
{
	cout << endl << name 
		 << setprecision(2) << fixed
		 << " -> The total annual sales are: $"
		 << totalAnnualSales() << endl;
} // end printAnnualSales

double SalesPerson::totalAnnualSales( void )
{
	double total = 0.0;

	for( int i=0; i<12; i++ )
		total = total + sales[i];
	
	return total;
} // end totalAnnualSales