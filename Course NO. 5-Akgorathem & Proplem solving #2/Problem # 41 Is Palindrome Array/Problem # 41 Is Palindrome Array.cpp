#include<iostream>
#include<cstdlib>
using namespace std;

int ReadAPositiveNumber(string Massage) {
	int num;
	do {
		cout << Massage << "\n";
		cin >> num;

	} while (num < 0);
	return num;
}
void FillArray(int store[]) {
	store[0] = 10;
	store[1] = 20;
	store[2] = 30;
	store[3] = 30;
	store[4] = 20;
	store[5] = 10;
	
}
void AddArrayElement(int Number, int arr[], short& size) {
	size++;
	arr[size - 1] = Number;
}
void PrintTheArray(int store[], short size) {

	for (int i = 0; i < size; i++) {
		if (store[i] >= 0) {
			cout << store[i] << " ";
		}

	}
	cout << "\n";


}
void CopyArrayInReverseOrder(int copy[], int store[], short size) {
	
	
	for (int i = 0; i < size; i++) {
		copy[i] = store[size - 1 - i];
		
		
	}

}
bool IsPalindromeArray(int store[],int copy[],short size) {
	for (int i = 0; i < size; i++) {
		if (store[i] == copy[i]) {

			return 1;
		}
		else
		{
			return 0;
			break;
		}





	}
	




}
void PrintResults(bool result) {
	if (result)
	{
		cout << "\nYes,The Arrray is Palindrome :)";
	}
	else
	{
		cout << "No,The Arrray Not Palindrome :(";
	}

}

int main() {
	short size = 6;
	int store[100];
	int copy[100];

	FillArray(store);
	cout << "The Array Elements is : \n";
	PrintTheArray(store, size);
	
	CopyArrayInReverseOrder(copy, store, size);
	PrintResults(IsPalindromeArray(store, copy, size));

	
	return 0;
}