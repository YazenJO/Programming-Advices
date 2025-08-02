#include<iostream>

using namespace std;

int ReadAPositiveNumber(string Massage) {
	int num;
	do {
		cout << Massage << "\n";
		cin >> num;

	} while (num < 0);
	return num;
}
void AddArrayElemt(int Number, int arr[], int size) {
	size++;
	arr[size - 1] = Number;
}
bool YesOrNo(int choice) {
	if (choice == 1)
		return 1;
	else
		return 0;

	



}
void ReadUntilSayNo(int store[], short& size) {
	int i = 0;
	bool choice;
	do
	{
		store[i]=ReadAPositiveNumber("Enter A number");
		choice=YesOrNo(ReadAPositiveNumber("Do u Want To Add more Numbers ? [0]:NO  [1]:Yes ?"));
		size++;
		i++;
	} while (choice);
}

void PrintTheArray(int store[], short size) {
	cout << "Array Elements :  ";
	for (int i = 0; i < size; i++) {
		cout << store[i] << " ";


	}
	cout << "\n";


}

int main() {
	short size = 0;
	int store[100];
	
	ReadUntilSayNo(store, size);
	PrintTheArray(store, size);
		

	return 0;
}