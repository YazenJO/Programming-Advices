#include<iostream>
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
int TheSumOfMatrix(int arr[3][3], short Rows, short Clos) {
	int sum = 0;
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {


			sum+= arr[i][j];



		}
		
	}


	return sum;
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
	
	FillMatrixWithRandomNumbers(arr, 3, 3);

	cout << "\nThe following is a 3x3 random matrix:\n";
	PrintTwoDArray(arr, 3, 3);

	cout << "\nThe Sum Of matrix:\n";
	cout<<TheSumOfMatrix(arr, 3, 3);
	return 0;
}

