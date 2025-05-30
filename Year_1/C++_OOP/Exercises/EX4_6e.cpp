// EX4_6.CPP

#include <iostream>

using namespace std;

const int ARRAY_SIZE = 24;
class IntArray
{
public:
   IntArray( int sz = ARRAY_SIZE );
   IntArray( const IntArray& );
   ~IntArray( void); 
   void loadArray( void );
   void showArray( void );
   int findMin( void );
   void sortArray( void );
   int getSize( void ) { return size; }
   int *getPtr( void ) { return ia; }

private:
   int size;
   int *ia;
};

int maxArray( int *, int );
int nmaxArray( const IntArray& );

//	IntArray myArray(5);

void main( void )
{

	IntArray myArray(5);
  myArray.loadArray();
  IntArray newArray( myArray );
//  IntArray *pa = &myArray;
//  pa -> IntArray ::~IntArray();
  newArray.showArray();
  newArray.sortArray();
  newArray.showArray();
  int minel = newArray.findMin();
  cout << "Minimalen element " << minel << endl;
  int maxel = maxArray( newArray.getPtr(),newArray.getSize() );
  cout << "Maksimalen element: " << maxel << endl;
  maxel = nmaxArray( newArray );
  cout << "Maksimalen element: " << maxel << endl;

} //end main

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

IntArray :: ~IntArray( void )
{
	delete ia;
	cout << "Destructor " << endl;
}
void IntArray :: loadArray( void )
{
  cout << "Vavedete elementite na masiva" << endl;
  int sz = size;
  for ( int i=0; i<sz; ++i)
  {
    cout << "ia[" << i << "] = ";
    cin >> ia[i];
  }
}

void IntArray :: showArray( void )
{
  cout << "Izvezdane elementite na masiva" << endl;
  for ( int i=0; i<size; ++i)
	cout << "ia[" << i << "] = " << ia[i] << endl;
}

int IntArray :: findMin( void )
{
  int min;
  min = ia[0];
  for (int i=0; i<size; i++)
    if (min > ia[i]) min = ia[i];
  return min;
}

void IntArray :: sortArray( void )
{
  for (int k=0; k<(size-1); k++)
  {
    int minEl = ia[k];
    for (int i=k+1; i<size; i++)
      if (minEl > ia[i])
      {
	minEl=ia[i];
	ia[i] = ia[k];
	ia[k]=minEl;
      }
  }
}

int maxArray( int *ptIa, int sizeAr )
{
  int max;
  max = ptIa[0];
  for (int i=0; i<sizeAr; i++)
    if (max < ptIa[i]) max = ptIa[i];
  return max;
}

int nmaxArray( const IntArray &anArray )
{
  IntArray myArray( anArray );
  int *ptIa = myArray.getPtr();
  int sizeAr = myArray.getSize();
  int max;
  max = ptIa[0];
  for (int i=0; i<sizeAr; i++)
    if (max < ptIa[i]) max = ptIa[i];
  return max;
}
