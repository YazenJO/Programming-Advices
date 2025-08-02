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
	cout << "Array Elements :  ";
	for (int i = 0; i < size; i++) {
		cout << store[i] << " ";


	}
	cout << "\n";


}
void CopyArray(int copy[], int store[], short size) {
	cout << "The copy : ";
	for (int i = 0; i < size; i++) {
		copy[i] = store[i];


	}

}

int main() {
	short size=0;
	int store[100], copy[100];

	FillarrayWithRandomNumbers(ReadAPositiveNumber("Enter The Number Of Elameants U want "), store, size);
	PrintTheArray(store, size);
	CopyArray(copy, store, size);
	PrintTheArray(copy, size);

	return 0;
}