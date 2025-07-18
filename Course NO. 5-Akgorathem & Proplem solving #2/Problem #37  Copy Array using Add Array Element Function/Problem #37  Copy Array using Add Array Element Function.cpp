#include <iostream>
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
void AddArrayElemt(int Number, int arr[], short &size) {
	size++;
	arr[size - 1] = Number;
}
int RandomNumbers(int From, int To) {
	int randNum = rand() % (To - From + 1) + From;


	return randNum;

}
void FillarrayWithRandomNumbers(int NumberOfElemnts, int store[],short &size) {

	for (int i = 0; i < NumberOfElemnts; i++) {
		AddArrayElemt(RandomNumbers(1, 100), store, size);
		
		

		
	}



}
void PrintTheArray(int store[], short size) {
	
	for (int i = 0; i < size; i++) {
		cout << store[i] << " ";


	}
	cout << "\n";


}
void CopyArray(int copy[], int store[], short size,short &size2) {
	
	do {

		AddArrayElemt(store[size2], copy, size2);

		
	} while (size2 < size);
	
	

	

}

int main() {
	short size = 0,size2=0;
	int store[100], copy[100];
	srand((unsigned)time(NULL));
	FillarrayWithRandomNumbers(ReadAPositiveNumber("Enter The Number Of Elameants U want "), store, size);
	cout << "Array Elements :  ";
	PrintTheArray(store, size);
	//
	cout << "The copy Of Array Elements :  ";
	CopyArray(copy, store, size, size2);
	
	PrintTheArray(copy,size2);

	return 0;
}

