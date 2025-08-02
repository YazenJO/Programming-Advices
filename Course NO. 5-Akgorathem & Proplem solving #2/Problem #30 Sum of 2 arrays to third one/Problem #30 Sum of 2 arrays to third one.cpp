#include <iostream>
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
void FillarrayWithRandomNumbers(int NumberOfElemnts, int store[], short& size) {

	for (int i = 0; i < NumberOfElemnts; i++) {

		store[i] = RandomNumbers(1, 100);


		size++;
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
void SumOfTowArrays(int store[],int Arr[],int SumArray[], short size) {
	for (int i = 0; i < size; i++) {
		SumArray[i] = store[i] + Arr[i];

		
	}
}


int main()
{
	int store[100], Arr[100], SumArray[100];
	short size=0;
	srand((unsigned)time(NULL));

	FillarrayWithRandomNumbers(ReadAPositiveNumber("Enter The Number of Elementnts For Array 1"), store, size);
	FillarrayWithRandomNumbers(ReadAPositiveNumber("Enter The Number of Elementnts For Array 1"), Arr, size);

	cout << "Array 1 Elements :  \n";
	PrintTheArray(store, size);
	cout << "Array 2 Elements :  \n";
	PrintTheArray(Arr, size);

	cout << "The Sum Of Two Arrays is\n";
	SumOfTowArrays(store, Arr, SumArray, size);
	PrintTheArray(SumArray, size);
}

