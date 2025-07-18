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
	cout << "Array1 Elements :  \n";
	for (int i = 0; i < size; i++) {
		cout << store[i] << " ";


	}
	cout << "\n";


}
int FindNumberPositionInTheArray(int store[], short size, int number) {
	for (int i = 0; i < size; i++) {
		if (store[i] == number) {

			return i;
		}

	}
	return -1;

}
bool ISNumberExist(int NumberPosition) {
	
	
	
		return NumberPosition!=-1;


}
void PrintResults(bool result) {
	if (result)
	{
		cout << "Yes,The Number is Found :)";
	}
	else
	{
		cout << "No,The Number Not Found :(";
	}
	
}
int main() {
	int store[100];
	short size = 0;
	srand((unsigned)time(NULL));

	FillarrayWithRandomNumbers(ReadAPositiveNumber("Enter The Number Of Elements U Want"), store, size);
	PrintTheArray(store, size);
	int Number = ReadAPositiveNumber("Enter The Number u Want To Search ");
	int NumberPosition = FindNumberPositionInTheArray(store, size, Number);
	PrintResults(ISNumberExist(NumberPosition));


	return 0;
}