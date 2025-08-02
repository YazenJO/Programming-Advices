#include<iostream>
#include <vector>
using namespace std;

int RandomNumberforarr(int From, int To)
{
	//Function to generate a random number
	int randNum = rand() % (To - From + 1) + From;
	return randNum;
}
void FillMatrixWithRandomNumbers(int arr[3][3], short Rows, short Clos) {
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {


			arr[i][j] = RandomNumberforarr(0, 100);


		}
	}

}
void GetTheMiddleRowInMatrix(int arr[3][3],int store[3]  , short Rows, short Clos) {
	int TheMiddileRowInMatrix = round(Rows / 2);
	for (int i = 0; i < Clos; i++)
	{
		store[i] = arr[TheMiddileRowInMatrix][i];
		
	}




}
void GetTheMiddleClosInMatrix(int arr[3][3], int store[3], short Rows, short Clos) {
	int TheMiddileClosInMatrix = round(Rows / 2);
	for (int i = 0; i < Clos; i++)
	{
		store[i] = arr[i][TheMiddileClosInMatrix];

	}




}
void PrintTwoDArray(int arr[3][3], short Rows, short Clos)
{
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {


			cout << arr[i][j] << "\t";



		}
		cout << endl;
	}
}
void PrintArray(int arr[100], int arrLength)
{
	for (int i = 0; i < arrLength; i++)
		cout << arr[i] << " ";
	cout << "\n";
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[3][3];
	int MiddleRow[3];
	int MiddleCol[3];
	FillMatrixWithRandomNumbers(arr, 3, 3);

	cout << "\nThe following is a 3x3 random matrix:\n";
	PrintTwoDArray(arr, 3, 3);

	cout << "\nThe Middle Rows\n";
	GetTheMiddleRowInMatrix(arr, MiddleRow, 3, 3);
	PrintArray(MiddleRow, 3);
	cout << "\nThe Middle Clo\n";
	GetTheMiddleClosInMatrix(arr, MiddleCol, 3, 3);
	PrintArray(MiddleCol, 3);

}
