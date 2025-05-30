#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
using namespace std;

class Library {
public:
	Library(void);
	Library(int, const char*);
	Library(Library&);
	~Library(void) { delete[] materials; }
	virtual void print(void);
	const char* getClassName(void);
protected:
	int readers;
	char* materials;
};

class Book : public Library {
public:
	Book(void);
	Book(int, const char*, const char*, int, float);
	Book(Book&);
	~Book(void) {}
	virtual void print(void);
	const char* getClassName(void);
private:
	char* title;
	int pages;
	float price;
};

class Author : public Book {
public:
	Author(void);
	Author(int, const char*, const char*, int, float, const char*, const char*);
	Author(Author&);
	~Author(void) { delete[] first_name, last_name; }
	virtual void print(void);
	const char* getClassName(void);
private:
	char* first_name;
	char* last_name;
};

//main
void main() {

	//output (1st method)
	/*Library lib(155, "Available");
	cout << lib.getClassName() << endl;
	lib.print();

	Book bok(155, "Available", "Pain", 8000, 35.50);
	cout << bok.getClassName() << endl;
	bok.print();

	Author aut(155, "Available", "Pain", 8000, 35.50, "Dian", "Lazarov");
	cout << aut.getClassName() << endl;
	aut.print(); */

	//output (2nd method)
	/*Library* objlib = new Library(255, "Unavailable");
	cout << objlib->getClassName() << endl;
	objlib->print();

	Book* objbok = new Book(255, "Unavailable", "Pain", 8000, 35.50);
	cout << objbok->getClassName() << endl;
	objbok->print();

	Author* objaut = new Author(255, "Unavailable", "Pain", 8000, 35.50, "Dian", "Lazarov");
	cout << objaut->getClassName() << endl;
	objaut->print();*/

	//array of classes/objects
	Library* reading[3];
	Library* l = new Library(155, "Available");
	Library* b = new Book(155, "Available", "Pain", 14, 35.50);
	Library* a = new Author(155, "Available", "Pain", 14, 35.50, "Dian", "Lazarov");
	reading[0] = l;
	reading[1] = b;
	reading[2] = a;
	for (int i = 0; i < 3; i++) {
		//cout << reading[i]->getClassName() << endl;
		reading[i]->print();
	}

	//static array
	/*Library stat[3];
	for (int i = 0; i < 3; i++) {
		cout << stat[i].getClassName() << endl;
		stat[i].print();
	}*/

	//dynamic array
	/*Library* dyn;
	dyn = new Library[3];
	for (int i = 0; i < 3; i++) {
		cout << (dyn + i)->getClassName() << endl;
		(dyn + i)->print();
	}
	delete[] dyn;*/

	system("pause");
}
//end main

//definitions
//Library
Library::Library(void) {
	readers = 0;
	materials = new char[20];
	strcpy(materials, "None");
}

Library::Library(int read, const char* mat) {
	readers = read;
	materials = new char[strlen(mat) + 1];
	strcpy(materials, mat);
}

Library::Library(Library& objLib) {
	readers = objLib.readers;
	materials = new char[strlen(objLib.materials) + 1];
	strcpy(materials, objLib.materials);
}

void Library::print(void) {
	cout << Library::getClassName() << endl;
	cout << "Readers: " << readers << endl;
	cout << "Materials: " << materials << endl << endl;
}

const char* Library::getClassName(void) {
	return "===LIBRARY===";
}
//end Library

//Book
Book::Book(void) {
	title = new char[20];
	strcpy(title, "None");
	pages = 0;
	price = 0.0;
}

Book::Book(int read, const char* mat, const char* tit, int pag, float pri) :Library(read, mat) {
	title = new char[strlen(tit) + 1];
	strcpy(title, tit);
	pages = pag;
	price = pri;
}

Book::Book(Book& objBook) {
	title = new char[strlen(objBook.title) + 1];
	strcpy(title, objBook.title);
	pages = objBook.pages;
	price = objBook.price;
}

void Book::print(void) {
	cout << Book::getClassName() << endl;
	//Library::print();
	cout << "Title: " << title << endl;
	cout << "Pages: " << pages << endl;
	cout << "Price: " << price << " $"<< endl << endl;
}

const char* Book::getClassName(void) {
	return "===BOOK===";
}
//end Book

//Author
Author::Author(void) {
	first_name = new char[20];
	strcpy(first_name, "None");
	last_name = new char[20];
	strcpy(last_name, "None");
}

Author::Author(int read, const char* mat, const char* tit, int pag, float pri, const char* fname, const char* lname) :Book(read, mat, tit, pag, pri) {
	first_name = new char[strlen(fname) + 1];
	strcpy(first_name, fname);
	last_name = new char[strlen(lname) + 1];
	strcpy(last_name, lname);
}

Author::Author(Author& objAuth) {
	first_name = new char[strlen(objAuth.first_name) + 1];
	strcpy(first_name, objAuth.first_name);
	last_name = new char[strlen(objAuth.last_name) + 1];
	strcpy(last_name, objAuth.last_name);
}

void Author::print(void) {
	cout << Author::getClassName() << endl;
	//Book::print();
	cout << "First name: " << first_name << endl;
	cout << "Last name: " << last_name << endl << endl;
}

const char* Author::getClassName(void) {
	return "===AUTHOR===";
}
//end Author