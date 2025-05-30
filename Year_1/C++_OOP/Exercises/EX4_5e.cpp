// EX4_5.CPP

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
	Time( int=0, int=0, int=0 );
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

	Time t1;
	Time t2( 2 );
	Time t3( 21, 34 );
	Time t4( 12, 25, 24 );
	Time t5( 27, 74, 99 );

	cout << endl << "The univetsal time is: ";
	t1.printUniversal();
	cout << endl << "The standard time is: ";
	t1.printStandard();	
	
	cout << endl << "The univetsal time is: ";
	t2.printUniversal();
	cout << endl << "The standard time is: ";
	t2.printStandard();	
	
	cout << endl << "The univetsal time is: ";
	t3.printUniversal();
	cout << endl << "The standard time is: ";
	t3.printStandard();	
	
	cout << endl << "The univetsal time is: ";
	t4.printUniversal();
	cout << endl << "The standard time is: ";
	t4.printStandard();	
	
	cout << endl << "The univetsal time is: ";
	t5.printUniversal();
	cout << endl << "The standard time is: ";
	t5.printStandard();	
	
} // end main

// Member-function defenitions for class Time
Time::Time( int hr, int min, int sec )
{
	setTime(hr,min,sec);
}

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