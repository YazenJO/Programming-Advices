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
int FindNumberPositionInTheArray(int store[], short size,int number) {
	for (int i = 0; i < size; i++) {
		if (store[i] == number) {
			
			return i;
		}
		
	}
	return -1;
	
}
void PrintResults(int NumberPosition,int num) {
	if (NumberPosition==-1)
	{
		cout << "The Number Not Found :(";
	}
	else
	{
		cout << "The number U Are Looking For is : " << num;
		cout << "\nThe Number Found at Position    :" << NumberPosition;
		cout << "\nThe Number Found its  Order      :" << NumberPosition + 1;
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
	 PrintResults(NumberPosition, Number);


	return 0;
}