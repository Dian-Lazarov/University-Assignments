#include <iostream>
using namespace std;

struct item {
	int info; // char
	item* L, * R;
};
typedef item* point;
point Root;

// Function to search for a node in a search tree
point Search_S_Tree(int x, point P) {
	if (P == NULL)	return NULL;
	else if (x < P->info) return Search_S_Tree(x, P->L);
	else if (x > P->info) return Search_S_Tree(x, P->R);
	else return P;
}

// Recursive function to add a node to a search tree
void Add_S_Tree(int x, point& P) {
	if (P == NULL) {
		// If the tree/subtree is empty, create a new node
		P = new item;
		P->info = x;
		P->L = P->R = NULL; // Initialize the new node's children as NULL
	}
	else if (x < P->info) {
		// If x is smaller, add it to the left subtree
		Add_S_Tree(x, P->L);
	}
	else if (x > P->info) {
		// If x is greater, add it to the right subtree
		Add_S_Tree(x, P->R);
	}
	else {
		// If x already exists in the tree, do nothing (no duplicates)
		cout << "Възелът " << x << " вече съществува в дървото." << endl;
	}
}

// Function to print the tree in ascending order (left-root-right)
void PrintAscendingOrder(point P) {
	if (P != NULL) {
		PrintAscendingOrder(P->L);
		cout << P->info << " ";
		PrintAscendingOrder(P->R);
	}
}

// Function to print the tree in descending order (right-root-left)
void PrintDescendingOrder(point P) {
	if (P != NULL) {
		PrintDescendingOrder(P->R);
		cout << P->info << " ";
		PrintDescendingOrder(P->L);
	}
}

int PathLength_S_Tree(int x, point P) {
	int length = 0;
	while (P != NULL) {
		if (x == P->info) {
			return length; // Return the current path length when the node is found
		}
		else if (x < P->info) {
			P = P->L; // Move to the left subtree
		}
		else if (x > P->info) {
			P = P->R; // Move to the right subtree
		}
		length++; // Increment the path length
	}
	return -1; // If the node with key "x" is not found
}

point FindParent_S_Tree(int key, point P) {
	if (P == NULL || (P->L == NULL && P->R == NULL)) {
		return NULL; // Tree is empty or there are no children, so no parent
	}

	// Traverse the tree to find the parent
	while (P != NULL) {
		if ((P->L != NULL && P->L->info == key) || (P->R != NULL && P->R->info == key)) {
			// The current node is the parent of the node with the key
			return P;
		}
		else if (key < P->info) {
			P = P->L; // Move to the left subtree
		}
		else if (key > P->info) {
			P = P->R; // Move to the right subtree
		}
	}
	return NULL; // If the key is not found in the tree
}

int CountNode(point P) {
	if (P == NULL) {
		return 0;
	}
	else {
		return 1 + CountNode(P->L) + CountNode(P->R);
	}
}

void main() {
	system("chcp 1251"); // Set the character encoding
	Root = NULL;

	int input; // char
	cout << "Въведете число: "; cin >> input;

	// Continue adding numbers until the user inputs 0
	while (input != 0) { // (input != '0')
		Add_S_Tree(input, Root);
		cout << "Въведете число: "; cin >> input;
	}

	// Print the resulting tree in order
	cout << "Получено дърво (във възходящ ред): "; PrintAscendingOrder(Root); cout << endl;
	cout << "Получено дърво (във низходящ ред): "; PrintDescendingOrder(Root); cout << endl;

	cout << "Брой възли: " << CountNode(Root) << endl;

	int key_length;
	cout << "Въведете ключ за намиране на дължината на пътя: ";
	cin >> key_length;

	int pathLength = PathLength_S_Tree(key_length, Root);
	if (pathLength != -1) {
		cout << "Дължината на пътя до възел с ключ " << key_length << " е: " << pathLength << endl;
	}
	else {
		cout << "Възелът с ключ " << key_length << " не е намерен в дървото." << endl;
	}

	int key_parent;
	cout << "Въведете ключ за намиране на родител: ";
	cin >> key_parent;

	point parent = FindParent_S_Tree(key_parent, Root);
	if (parent != NULL) {
		cout << "Родителят на възела с ключ " << key_parent << " е: " << parent->info << endl;
	}
	else {
		cout << "Възелът с ключ " << key_parent << " няма родител или не съществува в дървото." << endl;
	}

	system("pause");
}