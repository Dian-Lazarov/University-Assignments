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
		cout << "��� ��������� �� " << P->info << ": ";
		Create_B_Tree(P->L);
		cout << "����� ��������� �� " << P->info << ": ";
		Create_B_Tree(P->R);
	}
}

void Print_Preorder(point P) {
	if (P != NULL) {
		cout << P->info << " "; // �����
		Print_Preorder(P->L); // ���� ��������
		Print_Preorder(P->R); // ����� ��������
	}
}

void Print_Inorder(point P) {
	if (P != NULL) {
		Print_Inorder(P->L); // ���� ��������
		cout << P->info << " "; // �����
		Print_Inorder(P->R); // ����� ��������
	}
}

void Print_Postorder(point P) {
	if (P != NULL) {
		Print_Postorder(P->L); // ���� ��������
		Print_Postorder(P->R); // ����� ��������
		cout << P->info << " "; // �����
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
		cout << "��������� �� � ������!\n";
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
	cout << "�����: "; Create_B_Tree(Root);
	cout << endl;

	cout << "��������� ����� (Preorder): "; Print_Preorder(Root);
	cout << endl;

	//cout << "�������� ����� (Inorder): "; Print_Inorder(Root);
	//cout << endl;

	//cout << "���������� ����� (Postorder): "; Print_Postorder(Root);
	//cout << endl;

	int N;
	// Add an element to the tree
	cout << "�������� ��� ������� (�����) �� �������� � �������: "; cin >> N;
	Add(N, Root);
	cout << "�������� ����� ���� ��������: "; Print_Preorder(Root);
	cout << endl;

	// Delete an element from the tree
	cout << "�������� ������� (�����) �� ��������� �� �������: "; cin >> N;
	Delete(N, Root);
	cout << "�������� ����� ���� ���������: "; Print_Preorder(Root);
	cout << endl;

	system("pause");
}