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
		
			cout << store[i] << " ";
		

	}
	cout << "\n";


}
void Swap(int &A,int &B) {
		int Temp;
		Temp = A;
		A = B;
		B = Temp;
	
	}
void ShuffleArray(int store[],short size) {
	
	for (int i = 0; i < size; i++) {
		Swap(store[RandomNumbers(1, size) - 1], store[RandomNumbers(1, size) - 1]);
	}
}
int main() {
	int store[100];
    short size=0;

	srand((unsigned)time(NULL));
	FillarrayWithRandomNumbers(ReadAPositiveNumber("Print The Numbers Of Elements"), store, size);
	cout << "Array elemts before shuffle\n";
	PrintTheArray(store, size);

	ShuffleArray(store, size);
	cout << "Array elemts after shuffle\n";

	PrintTheArray(store, size);
	

	return 0;
}