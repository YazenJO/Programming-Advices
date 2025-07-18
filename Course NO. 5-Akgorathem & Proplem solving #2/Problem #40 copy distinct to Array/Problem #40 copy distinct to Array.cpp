#include<iostream>
using namespace std;

void FillArray(int store[]) {
	store[0] = 10;
	store[1] = 15;
	store[2] = 88;
	store[3] = 75;
	store[4] = 10;
	store[5] = 88;
	store[6] = 3;
	store[7] = 3;
	store[8] = 15;
	store[9] = 66;
}
void PrintArray(int arr[100], int arrLength) {
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << " ";
	cout << "\n";
}
short FindNumberPositionInArray(int Number, int arr[100], int arrLength) {
	for (int i = 0; i < arrLength; i++)
	{
		if (arr[i] == Number)
			return i;//return the index    
	} //if you reached here, this means the number is not foundreturn -1; 
}
bool IsNumberInArray(int Number, int arr[100], int arrLength)
{
	return FindNumberPositionInArray(Number, arr, arrLength) != -1;
}
void AddArrayElement(int Number, int arr[100], int& arrLength) {
	//its a new element so we need to add the length by 
	arrLength++;
	arr[arrLength - 1] = Number;
}
void CopyDistinctNumbersToArray(int arrSource[100], int arrDestination[100], int SourceLength, int& DestinationLength) {
	for (int i = 0; i < SourceLength; i++)
	{
		if (!IsNumberInArray(arrSource[i], arrDestination, DestinationLength))
		{
			AddArrayElement(arrSource[i], arrDestination, DestinationLength);
		}
	}
}
int  main() {
	int  arrSource[100], SourceLength = 0, arrDestination[100], DestinationLength = 0;
	FillArray(arrSource, SourceLength);
	cout << "\nArray 1 elements:\n";
	PrintArray(arrSource, SourceLength);
	CopyDistinctNumbersToArray(arrSource, arrDestination, SourceLength, DestinationLength);
	cout << "\nArray 2 distinct elements:\n";

	PrintArray(arrDestination, DestinationLength);
	return 0;
}