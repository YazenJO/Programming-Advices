#include <iostream>
using namespace std;

int ReadAPositiveNumber(string Massage) {
	int num;
	do {
		cout << Massage << "\n";
		cin >> num;

	} while (num < 0);
	return num;
}
void ReadNnumberOfArrayElemnts(int NumberOfElemnts,int store[], int &size) {

	for (int i = 0; i < NumberOfElemnts; i++) {
		cout << "Element [" << i + 1<<"] :";
		cin >> store[i];
		cout << "\n";

		size++;
	}



}
int CheckNumberRepeatInArray(int Number, int store[],int size) {
	int repeation=0;
	for (int i = 0; i < size; i++) {
		if (store[i] == Number) {
			repeation++;

		}
	}
	return repeation;



}
void PrintTheArray(int store[],int size) {
	cout << "The Original Array : ";
	for (int i = 0; i < size; i++) {
		cout << store[i]<<" ";


	}
	cout << "\n";


}
int main()
{
	int size=0 ,store[100], TheCheckNumber;
	int NumberOfElemnts = ReadAPositiveNumber("Enter The Number Of Elemnts U want");
	
	ReadNnumberOfArrayElemnts(NumberOfElemnts,store,size);
	TheCheckNumber = ReadAPositiveNumber("Enter The Number U want To Check");
	PrintTheArray(store, size);
	cout << TheCheckNumber << " Is Repeated " << CheckNumberRepeatInArray(TheCheckNumber, store, size) << " time(s)";
}


