#include <iostream>
using namespace std;

struct item {
	int info; // char
	item* L, * R;
};
typedef item* point;
point Root;

void Create_B_Tree(point& P) {
	int x; cin >> x; // char

	if (x == 0) { // x == '0'
		P = NULL;
	}
	else {
		P = new item;
		P->info = x;
		cout << "Ляв наследник на " << P->info << ": ";
		Create_B_Tree(P->L);
		cout << "Десен наследник на " << P->info << ": ";
		Create_B_Tree(P->R);
	}
}

void Print_Preorder(point P) {
	if (P != NULL) {
		cout << P->info << " "; // корен
		Print_Preorder(P->L); // ляво поддърво
		Print_Preorder(P->R); // дясно поддърво
	}
}

void Print_Inorder(point P) {
	if (P != NULL) {
		Print_Inorder(P->L); // ляво поддърво
		cout << P->info << " "; // корен
		Print_Inorder(P->R); // дясно поддърво
	}
}

void Print_Postorder(point P) {
	if (P != NULL) {
		Print_Postorder(P->L); // ляво поддърво
		Print_Postorder(P->R); // дясно поддърво
		cout << P->info << " "; // корен
	}
}

void Add(int n, item*& t) {
	if (t == NULL) {
		t = new item;
		t->info = n;
		t->L = t->R = NULL;
	}
	else {
		if (t->info < n) {
			Add(n, t->R);
		}
		else {
			Add(n, t->L);
		}
	}
}

// Helper function to find the minimum value node in a tree
item* FindMin(item* t) {
	while (t->L != NULL) {
		t = t->L;
	}
	return t;
}

// Function to delete a node from the binary tree
void Delete(int n, item*& t) {
	if (t == NULL) {
		cout << "Елементът не е открит!\n";
		return;
	}

	if (n < t->info) {
		// Search in the left subtree
		Delete(n, t->L);
	}
	else if (n > t->info) {
		// Search in the right subtree
		Delete(n, t->R);
	}
	else {
		// Node to be deleted found
		if (t->L == NULL && t->R == NULL) {
			// Case 1: No children (leaf node)
			delete t;
			t = NULL;
		}
		else if (t->L == NULL) {
			// Case 2: Only right child
			item* temp = t;
			t = t->R;
			delete temp;
		}
		else if (t->R == NULL) {
			// Case 2: Only left child
			item* temp = t;
			t = t->L;
			delete temp;
		}
		else {
			// Case 3: Two children
			// Find the in-order successor (smallest in the right subtree)
			item* temp = FindMin(t->R);
			t->info = temp->info; // Replace current node's value with successor's value
			Delete(temp->info, t->R); // Delete the in-order successor
		}
	}
}

void main() {
	system("chcp 1251");

	Root = NULL;
	cout << "Корен: "; Create_B_Tree(Root);
	cout << endl;

	cout << "Префиксен запис (Preorder): "; Print_Preorder(Root);
	cout << endl;

	//cout << "Инфиксен запис (Inorder): "; Print_Inorder(Root);
	//cout << endl;

	//cout << "Постфиксен запис (Postorder): "; Print_Postorder(Root);
	//cout << endl;

	int N;
	// Add an element to the tree
	cout << "Въведете нов елемент (възел) за добавяне в дървото: "; cin >> N;
	Add(N, Root);
	cout << "Обновено дърво след добавяне: "; Print_Preorder(Root);
	cout << endl;

	// Delete an element from the tree
	cout << "Въведете елемент (възел) за изтриване от дървото: "; cin >> N;
	Delete(N, Root);
	cout << "Обновено дърво след изтриване: "; Print_Preorder(Root);
	cout << endl;

	system("pause");
}