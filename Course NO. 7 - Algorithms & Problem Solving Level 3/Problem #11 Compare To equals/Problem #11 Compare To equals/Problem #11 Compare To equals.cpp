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

			printf("%0*d\t", 2, arr[i][j]);
			



		}
		cout << endl;
	}
}
int TheSumOfMatrix(int arr[3][3], short Rows, short Clos) {
	int sum = 0;
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {


			sum += arr[i][j];



		}

	}


	return sum;
}
bool AreTheMatrciesEquals(int Matrix1[3][3], int Matrix2[3][3]) {
	return (TheSumOfMatrix(Matrix1, 3, 3) == TheSumOfMatrix(Matrix2, 3, 3));
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
	int Matrix1[3][3];
	int Matrix2[3][3];

	FillMatrixWithRandomNumbers(Matrix1, 3, 3);
	FillMatrixWithRandomNumbers(Matrix2, 3, 3);
	cout << "\nThe following is a 3x3 random matrix:\n";
	PrintTwoDArray(Matrix1, 3, 3);
	cout << "\nThe following is a 3x3 random matrix2:\n";
	PrintTwoDArray(Matrix2, 3, 3);

	if (AreTheMatrciesEquals(Matrix1, Matrix2))
	{
		cout << "\nThe Matrcies is equals\n";
	}
	else
	{
		cout << "\nThe Matrcies is not equals\n";
	}
	return 0;

}

