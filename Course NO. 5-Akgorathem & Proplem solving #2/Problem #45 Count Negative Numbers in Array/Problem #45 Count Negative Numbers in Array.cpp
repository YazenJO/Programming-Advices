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
		AddArrayElement(RandomNumbers(-100, 100), store, size);




	}



}
void PrintTheArray(int store[], short size) {

	for (int i = 0; i < size; i++) {
		cout << store[i] << " ";


	}
	cout << "\n";


}
bool IsPositive(int number) {

	return number > 0;
}
short CountPositiveNumberInArray(int copy[], int store[], short arrLength, short& size2) {
	short counter = 0;
	for (int i = 0; i < arrLength; i++) {
		if (!IsPositive(store[i])) {
			counter++;
		}
	}
	return counter;
}

int main() {
	short size = 0, size2 = 0;
	int store[100], copy[100];

	srand((unsigned)time(NULL));

	FillarrayWithRandomNumbers(ReadAPositiveNumber("Enter The Number Of Elameants U want "), store, size);
	cout << "Array Elements :  ";
	PrintTheArray(store, size);

	cout << "\nThe Number Of Positive elemnts in Array :  ";
	cout << CountPositiveNumberInArray(copy, store, size, size2);



	return 0;
}

