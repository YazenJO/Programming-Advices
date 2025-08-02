#include <iostream>
#include<cstdlib>
using namespace std;

enum evenOrOdd { odd = 1, even = 2 };
int ReadAPositiveNumber(string Massage) {
	int num;
	do {
		cout << Massage << "\n";
		cin >> num;

	} while (num < 0);
	return num;
}
void AddArrayElement(int Number, int arr[], short& size) {
	size++;
	arr[size - 1] = Number;
}
int RandomNumbers(int From, int To) {
	int randNum = rand() % (To - From + 1) + From;


	return randNum;

}
void FillarrayWithRandomNumbers(int NumberOfElemnts, int store[], short& size) {

	for (int i = 0; i < NumberOfElemnts; i++) {
		AddArrayElement(RandomNumbers(1, 100), store, size);




	}



}
void PrintTheArray(int store[], short size) {

	for (int i = 0; i < size; i++) {
		cout << store[i] << " ";


	}
	cout << "\n";


}
evenOrOdd CheckEvenOrOdd(int num) {
	if (num % 2 != 0)
		return odd;
	else
		return even;




}
void CopyArrayUsingAddArrayElement(int copy[], int store[], short arrLength, short& size2) {
	for (int i = 0; i < arrLength; i++)
		if (CheckEvenOrOdd(store[i]) == evenOrOdd::odd) {
			AddArrayElement(store[i], copy, size2);
		}
}

int main() {
	short size = 0, size2 = 0;
	int store[100], copy[100];

	srand((unsigned)time(NULL));

	FillarrayWithRandomNumbers(ReadAPositiveNumber("Enter The Number Of Elameants U want "), store, size);
	cout << "Array Elements :  ";
	PrintTheArray(store, size);

	
	CopyArrayUsingAddArrayElement(copy, store, size, size2);

	cout << "\nThe Number Off Odd Numbers is : " << size2;

	return 0;
}

