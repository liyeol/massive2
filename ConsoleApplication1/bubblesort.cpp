#include <iostream>
using namespace std;

class BubbleSort {
public:
	void bubblesort(int Array[], int x) {
		int t;
		for (int y = 0; y < x; y++)
			for (int i = 0; i < x - y - 1; i++)
				if (Array[i] > Array[i + 1]) {
					t = Array[i];
					Array[i] = Array[i + 1];
					Array[i + 1] = t;
				}
	}
};

void Input_bs(int Array[], int x) {
	cout << "Enter numbers: " << endl;
	for (int i = 0; i <= x - 1; i++) {
		cin >> Array[i];
	}
	cout << "Elements of unsorted list:  ";
	for (int i = 0; i <= x - 1; i++) {
		cout << Array[i] << " ";
	}
	cout << endl;

}

void Print_bs(int Array[], int x) {
	cout << "Elements of sorted list:  ";
	for (int i = 0; i < x; i++) {
		cout << Array[i] << " ";
	}
}

int main() {
	int x;
	cout << "Enter the count of element: ";
	cin >> x;
	int* Arr = new int[x];
	BubbleSort A;
	Input_bs(Arr, x);
	A.bubblesort(Arr, x);
	Print_bs(Arr, x);
	return 0;
}

