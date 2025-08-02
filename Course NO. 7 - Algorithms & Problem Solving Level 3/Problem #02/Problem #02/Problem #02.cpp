#include <iostream>
#include<vector>
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
void SumRowsOfTwoDArray(int arr[3][3],int Sum[3], short Rows, short Clos) {
	int sum = 0;
	for (int i = 0; i < Rows; i++)
	{
		sum = 0;
		for (int j = 0; j < Clos; j++) {
			sum += arr[i][j];



		}
			Sum[i] = sum;
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
	int Sum[3];
	FillMatrixWithRandomNumbers(arr,3,3);

	cout << "\nThe following is a 3x3 random matrix:\n";
	PrintTwoDArray(arr,3,3);

	cout << "\nThe following is a sum of each row in the matrix:\n";
	 SumRowsOfTwoDArray(arr, Sum, 3, 3);
	PrintArray(Sum,3);
}
