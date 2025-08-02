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
float AvgNumberInTheArray(int store[], short size) {
	float sum = 0;

	for (int i = 0; i < size; i++) {
		sum += store[i];


	}
	return sum/size;


}

int main() {
	int store[100];
	short size = 0;
	srand((unsigned)time(NULL));
	FillarrayWithRandomNumbers(ReadAPositiveNumber("Enter The Number Of Elements U Want"), store, size);
	PrintTheArray(store, size);
	cout << "The Avg Of Number is : " << AvgNumberInTheArray(store, size);


	return 0;
}