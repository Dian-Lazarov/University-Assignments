#include <iostream>

using namespace std;

const int ARRAY_SIZE = 3;

class IntArray
{
public:
   IntArray( int sz = ARRAY_SIZE );
   IntArray( const IntArray& );
   ~IntArray() { delete ia;
		 cout << " End of IntArray" << endl; 
   }
   void loadArray( void );
   void showArray( void );
   int getSize( void ) { return size; }
   IntArray& operator = ( const IntArray& );
   int& operator [] ( int );
   IntArray& operator ++ ( void );
   IntArray operator + ( const IntArray& );

private:
   int size;
   int *ia;
};

void main ( void )
{
  IntArray myArray;

  myArray.loadArray();
  IntArray newArray( myArray);
  newArray.showArray();

  IntArray Obj1(2);
  Obj1.loadArray();
  Obj1.showArray();

  IntArray Obj2(Obj1.getSize());
  Obj2.loadArray();
  Obj2.showArray();
  Obj1 = Obj2;
  cout << "Obj1" << endl;
  Obj1.showArray();
  cout << "Obj2" << endl;
  Obj2.showArray();

  int alf = Obj2[1];
  cout << alf << endl;
  
  Obj2[1] = 10000;
  Obj2.showArray();
  
  Obj2++;
  Obj2.showArray();
  
  IntArray Obj3( Obj1.getSize() );
  Obj3 = Obj2 + Obj1;
  Obj3.showArray();

} // end main

IntArray :: IntArray( int sz )
{
  size = sz;
  ia = new int[size];
  for (int i=0; i<sz; ++i) ia[i] = 0;
}

IntArray :: IntArray( const IntArray &oldIa )
{
  size = oldIa.size;
  ia = new int[size];
  for ( int i=0; i<size; ++i) ia[i] = oldIa.ia[i];
}

void IntArray :: loadArray( void )
{
  cout << "Enter the elements" << endl;
  int sz = size;
  for ( int i=0; i<sz; ++i)
  {
    cout << "ia[" << i << "] = ";
    cin >> ia[i];
  }
}

void IntArray :: showArray( void )
{
  cout << "Display the elements" << endl;
  for ( int i=0; i<size; ++i)
	cout << "ia[" << i << "] = " << ia[i] << endl;
}

IntArray& IntArray :: operator = ( const IntArray &oldAr )
{
//   for ( int i=0; i<size; i++ ) delete [i] ia;
  delete ia;
  size = oldAr.size;
  ia = new int[size];
  for ( int i=0; i<size; i++ ) ia[i]=oldAr.ia[i];
  return *this;
}

int& IntArray :: operator [] ( int index )
{
  return ia[index];
}

IntArray& IntArray :: operator ++ ( void )
{
  for (int i=0; i<size; i++ ) ia[i]++;
  return *this;
}

IntArray IntArray :: operator + ( const IntArray &oldAr )
{
  char *mess = "Different sizes";
  if ( size != oldAr.size)
  {
    cout << mess << endl; exit(0);
  }
  IntArray newAr(size);
  for (int i=0; i<size; i++) newAr.ia[i] = ia[i] + oldAr.ia[i];
  return newAr;
}
