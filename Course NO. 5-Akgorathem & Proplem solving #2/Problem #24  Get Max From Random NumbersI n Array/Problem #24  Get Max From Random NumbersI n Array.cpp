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
int MaxNumberInTheArray(int store[], short size) {
	int max = store[0];
	cout << "Array Elements :  ";
	for (int i = 0; i < size; i++) {
		if (store[i] > max) {
			max = store[i];

		}


	}
	return max;


}

int main() {
	int store[100];
	short size=0;
	FillarrayWithRandomNumbers(ReadAPositiveNumber("Enter The Number Of Elements U Want"), store, size);
	PrintTheArray(store, size);
	cout<<"Max Number is : " << MaxNumberInTheArray(store, size);


	return 0;
}