#include<iostream>
#include<cstdlib>
using namespace std;

enum PrimeOrNot { Prime = 1, NotPrime = 0 };

int ReadAPositiveNumber(string Massage) {
	int num;
	do {
		cout << Massage << "\n";
		cin >> num;

	} while (num < 0);
	return num;
}
int RandomNumbers(int From, int To) {
	int randNum = rand() % (To - From + 1) + From;


	return randNum;

}
void AddArrayElement(int Number, int arr[], short& size) {
	size++;
	arr[size - 1] = Number;
}
void FillarrayWithRandomNumbers(int NumberOfElemnts, int store[], short& size) {

	for (int i = 0; i < NumberOfElemnts; i++) {
		AddArrayElement(RandomNumbers(1, 100), store, size);




	}



}
void PrintTheArray(int store[], short size) {
	
	for (int i = 0; i < size; i++) {
		if (store[i] >= 0) {
			cout << store[i] << " ";
		}

	}
	cout << "\n";


}
PrimeOrNot IsPrime(int Num) {

	for (int i = 2; i < Num; i++) {
		if (Num % i == 0)
			return PrimeOrNot::NotPrime;
	}
	return PrimeOrNot::Prime;
}
void CopyOnlyPrimeNumbersArray(int copy[], int store[], short size, short& size2) {
	

	for (int i = 0; i < size; i++) {

		if (IsPrime(store[i]) == PrimeOrNot::Prime) {
			AddArrayElement(store[i], copy, size2);
		}

	}

}


int main() {
	short size = 0;
	short size2 = 0;
	int store[100], copy[100];
	srand((unsigned)time(NULL));
	FillarrayWithRandomNumbers(ReadAPositiveNumber("Enter The Number Of Elameants U want "), store, size);
	cout << "Array Elements :  ";
	PrintTheArray(store, size);
	CopyOnlyPrimeNumbersArray(copy, store, size, size2);
	cout << "The copy Of Array Elements :  ";
	PrintTheArray(copy, size2);

	return 0;
}