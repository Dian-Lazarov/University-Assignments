#include <iostream>
#include <climits> // For INT_MIN and INT_MAX
using namespace std;

struct item {
	int info;
	item* L, * R;
};
typedef item* point;
point Root;

void Create_B_Tree(point& P) {
	int x; cin >> x;
	if (x != 0) {
		P = new item; P->info = x; P->L = P->R = NULL;
		cout << "ляв наследник на " << P->info << "= ";
		Create_B_Tree(P->L);
		cout << "десен наследник на " << P->info << "= ";
		Create_B_Tree(P->R);
	}
}

void Print(point P) {
	if (P != NULL) {
		cout << P->info << " ";
		Print(P->L);
		Print(P->R);
	}
}

// Function to find the maximum value in the binary tree
int FindMaxValue(point P) {
	if (P == NULL) return INT_MIN; // Base case: empty tree

	// Get the maximum value from the left and right subtrees
	int leftMax = FindMaxValue(P->L);
	int rightMax = FindMaxValue(P->R);

	// Return the maximum among the current node, leftMax, and rightMax
	return max(P->info, max(leftMax, rightMax));
}

// Function to find the minimum value in the binary tree
int FindMinValue(point P) {
	if (P == NULL) return INT_MAX; // Base case: empty tree

	// Get the minimum value from the left and right subtrees
	int leftMin = FindMinValue(P->L);
	int rightMin = FindMinValue(P->R);

	// Return the minimum among the current node, leftMin, and rightMin
	return min(P->info, min(leftMin, rightMin));
}

int CalculateSum(point P) {
	if (P == NULL) {
		return 0;
	}
	else {
		return P->info + CalculateSum(P->L) + CalculateSum(P->R);
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
		return 1;
	}
	else {
		return CountLeaf(P->L) + CountLeaf(P->R);
	}
}

float AverageNode(point P) {
	if (P == NULL) {
		return 0;
	}
	else {
		int sum = CalculateSum(P);
		int count = CountNode(P);
		return (float) sum / count;
	}
}

// Сума на всички възли с цифра на единиците равна на 6
int Sum_Nodes_With_Units_Digit_Six(point P) {
	int sum = 0;

	if (P == NULL) {
		return 0;
	}
	if (P->info % 10 == 6) {
		sum += P->info;
	}
	sum += Sum_Nodes_With_Units_Digit_Six(P->L);
	sum += Sum_Nodes_With_Units_Digit_Six(P->R);
	return sum;
}

// Сума на всички възли с цифра на десетиците равна на 6
int Sum_Nodes_With_Tens_Digit_Six(point P) {
	int sum = 0;

	if (P == NULL) {
		return 0;
	}
	if ((P->info / 10) % 10 == 6) {
		sum += P->info;
	}
	sum += Sum_Nodes_With_Tens_Digit_Six(P->L);
	sum += Sum_Nodes_With_Tens_Digit_Six(P->R);
	return sum;
}

// Сума на всички възли с цифра на стотиците равна на 6
int Sum_Nodes_With_Hundreds_Digit_Six(point P) {
	int sum = 0;

	if (P == NULL) {
		return 0;
	}
	if ((P->info / 100) % 10 == 6) {
		sum += P->info;
	}
	sum += Sum_Nodes_With_Hundreds_Digit_Six(P->L);
	sum += Sum_Nodes_With_Hundreds_Digit_Six(P->R);
	return sum;
}

// Височина на дървото (най-дълъг път от корена до листо)
int TreeHeight(point P) {
	if (P == NULL) {
		return 0;
	}
	int leftHeight = TreeHeight(P->L);  // Recursively find the height of the left subtree
	int rightHeight = TreeHeight(P->R); // Recursively find the height of the right subtree
	return 1 + max(leftHeight, rightHeight); // Height is 1 + the maximum of left and right subtree heights
}

// Степен на дървото (максимален брой наследници)
int TreePower(point P) {
	if (P == NULL) {
		return 0; // Base case: if the node is NULL, the power is 0
	}

	int leftPower = TreePower(P->L);  // Recursively find the power of the left subtree
	int rightPower = TreePower(P->R); // Recursively find the power of the right subtree

	// Current node's power is the number of non-NULL children
	int currentPower = 0;
	if (P->L != NULL) {
		currentPower++;
	}
	if (P->R != NULL) {
		currentPower++;
	}

	// Return the maximum of the current node's power, left subtree's power, and right subtree's power
	return max(currentPower, max(leftPower, rightPower));
}

void main() {
	system("chcp 1251");
	Root = NULL;
	cout << "корен= "; Create_B_Tree(Root); cout << endl;

	cout << "Получено дърво: "; Print(Root); cout << endl;

	cout << "Максимална стойност: " << FindMaxValue(Root) << endl;
	cout << "Минимална стойност: " << FindMinValue(Root) << endl;

	cout << "Сума: " << CalculateSum(Root) << endl;
	cout << "Брой възли: " << CountNode(Root) << endl;
	cout << "Брой листа: " << CountLeaf(Root) << endl;
	cout << "Средноаритметична стойност на възлите: " << AverageNode(Root) << endl;
	cout << "Сума на всички възли с цифра на единиците равна на 6: " << Sum_Nodes_With_Units_Digit_Six(Root) << endl;
	cout << "Сума на всички възли с цифра на десетиците равна на 6: " << Sum_Nodes_With_Tens_Digit_Six(Root) << endl;
	cout << "Сума на всички възли с цифра на стотиците равна на 6: " << Sum_Nodes_With_Hundreds_Digit_Six(Root) << endl;
	cout << "Височина на дървото: " << TreeHeight(Root) << endl;
	cout << "Степен на дървото: " << TreePower(Root) << endl;

	system("pause");
}