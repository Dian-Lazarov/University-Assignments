#include <iostream>

using namespace std;

template <class T>
void printArray(T* array, int count) {
	for (int i = 0; i < count; i++) {
		cout << array[i] << endl;
	}
}

template <class T>
void searchArray(T* array, int count, T key) {
	
}

void main() {
	int array[3] = {4, 7, 8};
	printArray(array, 3);
}