#include <iostream>
#include <vector>

using namespace std;

//compared to arrays, vectors consume more memory in exchange 
//for the ability to manage storageand grow dynamically in an efficient way.
//
//Compared to the other dynamic sequence containers(deques, lists and forward_lists), 
//vectors are very efficient accessing its elements(just like arrays) and relatively efficient 
//adding or removing elements from its end.For operations that involve inserting or 
//removing elements at positions other than the end, they perform worse than the others, 
//and have less consistent iteratorsand references than listsand forward_lists.

void main()
{
	vector <int> v_int;

	for (int i = 0; i < 9999999; i++) {
		v_int.push_back(i);
	}

	for (int i = 0; i < v_int.size(); i++)
		cout << "i = " << v_int[i] << endl;


	//ITERATORS
	//begin -Return iterator to beginning
	//end - Return iterator to end
	cout << "Output of begin and end: ";
	for (auto i = v_int.begin(); i != v_int.end(); ++i)
		cout << *i << " ";

	//cbegin - Return const_iterator to beginning
	//cend - Return const_iterator to end
	cout << "\nOutput of cbegin and cend: ";
	for (auto i = v_int.cbegin(); i != v_int.cend(); ++i)
		cout << *i << " ";

	//rbegin - Return reverse iterator to reverse beginning
	//rend - Return reverse iterator to reverse end
	cout << "\nOutput of rbegin and rend: ";
	for (auto ir = v_int.rbegin(); ir != v_int.rend(); ++ir)
		cout << *ir << " ";

	//crbegin - Return const_reverse_iterator to reverse beginning
	//crend - Return const_reverse_iterator to reverse end
	cout << "\nOutput of crbegin and crend : ";
	for (auto ir = v_int.crbegin(); ir != v_int.crend(); ++ir)
		cout << *ir << " ";

}