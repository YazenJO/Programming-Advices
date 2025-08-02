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

			arr[i][j] = RandomNumberforarr(0, 10);


		}
	}

}
void MulipuleTwoDArray(int arr[3][3], int arr2[3][3],int result[3][3], short Rows, short Clos) {
	
	for (int i = 0; i < Rows; i++)
	{
		
		for (int j = 0; j < Clos; j++) {
			result[i][j] = arr[i][j]*arr2[i][j];



		}
		
	}

}
void PrintTwoDArray(int arr[3][3], short Rows, short Clos)
{
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {

			printf("%0*d\t", 2, arr[i][j]);
		



		}
		cout << endl;
	}
}

int main()
{
	srand((unsigned)time(NULL));
	int arr[3][3], arr2[3][3], result[3][3];
	
	FillMatrixWithRandomNumbers(arr, 3, 3);
	FillMatrixWithRandomNumbers(arr2, 3, 3);

	cout << "\nThe following is a 3x3 random matrix:\n";
	PrintTwoDArray(arr, 3, 3);
	cout << "\nThe following is a 2nd 3x3 random matrix:\n";
	PrintTwoDArray(arr2, 3, 3);

	cout << "\nThe following is a Multiple of Two matrixs:\n";
	MulipuleTwoDArray(arr, arr2, result, 3, 3);
	PrintTwoDArray(result, 3,3);
}
