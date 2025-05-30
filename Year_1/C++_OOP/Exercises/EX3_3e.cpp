// Клас Time

#include <iostream>

using std::cout;
using std::cin;
using std::endl;

#include <iomanip>

using std::setfill;
using std::setw;

class Time
{

public:
	void setTime( int, int, int );  //set hour, minute, second
	void printUniversal( void );	//print universal-time format
	void printStandard( void );		//print standard-time format

private:
	int hour;		// 0-23
	int minute;		// 0-59
	int second;		// 0-59

}; //end Time

void main( void )
{

	Time t;
	int hh, mm, ss;

	for (int i=0; i<4; i++)
	{
		cout << endl << "Enter the time (hh mm ss): ";
		cin >> hh >> mm >> ss;
		t.setTime(hh,mm,ss);
		cout << endl << "The univetsal time is: ";
		t.printUniversal();
		cout << endl << "The standard time is: ";
		t.printStandard();
		cout << endl;
	} // end for

} // end main

// Member-function defenitions for class Time
void Time::setTime(int h, int m, int s)
{
	hour = ( h >= 0 && h < 24 ) ? h : 0;
	minute = ( m >= 0 && m < 60 ) ? m : 0;
	second = ( s >= 0 && s < 60 ) ? s : 0;

} // end setTime

void Time::printUniversal( void )
{
	cout << setfill('0') << setw(2) << hour << ":"
		 << setw(2) << minute << ":"
		 << setw(2) << second;

} //end printUniversal

void Time::printStandard( void )
{
	cout << ( (hour==0 ||  hour==12) ? 12 : hour%12 )
		 << ":" << setfill( '0' ) << setw(2) << minute
		 << ":" << setw(2) << second
		 << ( hour < 12 ? " AM" : " PM" );

} // end printStandard