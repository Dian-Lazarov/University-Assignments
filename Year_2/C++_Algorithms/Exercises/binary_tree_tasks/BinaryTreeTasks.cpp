#include <iostream>
#include <cstdlib> // For atoi
using namespace std;

struct item {
	char info;
	item* L, * R;
};
typedef item* point;
point T;

void Create_B_Tree(point& P) {
	char x; cin >> x;
	if (x != '0') {
		P = new item;
		P->info = x;
		P->L = P->R = NULL; // създаване на възел

		cout << "Ляв наследник на " << P->info << ": ";
		Create_B_Tree(P->L); // създаване на ляво поддърво
		cout << "Десен наследник на " << P->info << ": ";
		Create_B_Tree(P->R); // създаване на дясно поддърво
	}
}

void Print(point P) {
	if (P != NULL) {
		cout << P->info << " "; // корен
		Print(P->L); // ляво поддърво
		Print(P->R); // дясно поддърво
	}
}

int CountNode(point P) {
	if (P == NULL) {
		return 0;
	}
	else {
		return 1 + CountNode(P->L) + CountNode(P->R);
	}
}

int CountLeaf(point P) {
	if (P == NULL) {
		return 0;
	}
	else if (P->L == NULL && P->R == NULL) {
		return 1; // текущият възел е листо
	}
	else {
		return CountLeaf(P->L) + CountLeaf(P->R);
	}
}

int CountSymbol(point P) {
	if (P == NULL) {
		return 0;
	}
	else if (P->info == '+' || P->info == '-' || P->info == '*' || P->info == '/') {
		return 1 + CountSymbol(P->L) + CountSymbol(P->R);
	}
	else {
		return CountSymbol(P->L) + CountSymbol(P->R);
	}
}

int TreeDepth(point P) {
	if (P == NULL) {
		return 0; // Base case: depth of an empty tree is 0
	}
	int leftDepth = TreeDepth(P->L); // Calculate depth of the left subtree
	int rightDepth = TreeDepth(P->R); // Calculate depth of the right subtree
	return 1 + max(leftDepth, rightDepth); // Add 1 for the current node and return the max depth
}

void PrintExpression(point P) {
	if (P != NULL) {
		if (P->info == '+' || P->info == '-' || P->info == '*' || P->info == '/') {
			cout << "("; // Open parentheses before the left subtree
		}

		// INORDER
		PrintExpression(P->L);
		cout << P->info;
		PrintExpression(P->R);

		if (P->info == '+' || P->info == '-' || P->info == '*' || P->info == '/') {
			cout << ")"; // Close parentheses after the right subtree if the current node is an operator
		}
	}
}

int CalculateExpression(point P) {
	if (P == NULL) {
		return 0; // Base case: empty tree
	}

	// If the current node is a leaf (a number), convert it to an integer and return it
	if (P->L == NULL && P->R == NULL) {
		return atoi(&P->info); // Use atoi to convert the char to an integer
	}

	// Recursively evaluate the left and right subtrees
	int leftValue = CalculateExpression(P->L);
	int rightValue = CalculateExpression(P->R);

	// Perform the operation stored in the current node
	switch (P->info) {
	case '+': return leftValue + rightValue;
	case '-': return leftValue - rightValue;
	case '*': return leftValue * rightValue;
	case '/': return rightValue != 0 ? leftValue / rightValue : 0; // Handle division by zero
	default: return 0; // In case of an unexpected character
	}
}

bool DisplayPath(point P, char x) {
	if (P == NULL) {
		return false; // If the node is NULL, return false (value not found)
	}

	// Print the current node's value as part of the path
	cout << P->info << " ";

	// If the current node contains the value 'x', return true
	if (P->info == x) {
		return true;
	}

	// Recursively search for the value 'x' in the left and right subtrees
	if (DisplayPath(P->L, x) || DisplayPath(P->R, x)) {
		return true; // If the value is found in either subtree, return true
	}

	// If the value is not found in the current subtree, backtrack
	cout << "\b\b"; // Remove the last printed node if backtracking
	return false;
}

int FindPathLength(point P, char x, int depth = 0) {
	if (P == NULL) {
		return -1; // Return -1 if the value is not found in this subtree
	}

	// If the current node matches the value "x", return the current depth
	if (P->info == x) {
		return depth;
	}

	// Recursively search for "x" in the left subtree
	int leftLength = FindPathLength(P->L, x, depth + 1);
	if (leftLength != -1) {
		return leftLength; // If the value is found in the left subtree, return its depth
	}

	// Recursively search for "x" in the right subtree
	int rightLength = FindPathLength(P->R, x, depth + 1);
	if (rightLength != -1) {
		return rightLength; // If the value is found in the right subtree, return its depth
	}
}

void main() {
	system("chcp 1251");

	T = NULL;
	cout << "Корен: "; Create_B_Tree(T); cout << endl;

	cout << "Получено дърво: "; Print(T); cout << endl;

	cout << "Брой възли: " << CountNode(T) << endl;

	cout << "Брой листа: " << CountLeaf(T) << endl;

	cout << "Брой символи [+ - * /]: " << CountSymbol(T) << endl;

	cout << "Дълбочина на дървото: " << TreeDepth(T) << endl;

	cout << "Аритметичен израз със скоби: "; PrintExpression(T); cout << endl;

	cout << "Резултат от изчисление на аритметичен израз: " << CalculateExpression(T) << endl;

	// Input the value to search for
	char x;
	cout << "Въведете стойност на възела, за който да се покаже пътят: "; cin >> x;

	cout << "Път до възел " << x << ": ";
	if (!DisplayPath(T, x)) {
		cout << "Възелът не е намерен в дървото!" << endl;
	}
	cout << endl;

	int length = FindPathLength(T, x);
	if (length == -1) {
		cout << "Възелът не е намерен в дървото!" << endl;
	}
	else {
		cout << "Дължината на пътя до възел " << x << " е: " << length << endl;
	}

	system("pause");
}