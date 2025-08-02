#include <iostream>
using namespace std;

int RandomNumber(int From, int To)
{
	//Function to generate a random number
	int randNum = rand() % (To - From + 1) + From;
	return randNum;
}
int ReadAPositiveNumber(string Massage) {
	int num;
	do {
		cout << Massage << "\n";
		cin >> num;

	} while (num < 0);
	return num;
}
void FillMatrixWithRandomNumbers(int arr[3][3], short Rows, short Clos) {
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {

			//arr[i][j] = 0;
			arr[i][j] = RandomNumber(0, 10);



		}
	}

}
int MinNumberInMatrix(int Matrix1[3][3],  short Rows, short Clos)
{
	int Min = Matrix1[0][0];
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {
			
			if (Matrix1[i][j] < Min)
			{
				Min = Matrix1[i][j];
			}




		}
	}
	return Min;
}
int MaxNumberInMatrix(int Matrix1[3][3], short Rows, short Clos)
{
	int Max = Matrix1[0][0];
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {

			if (Matrix1[i][j] > Max)
			{
				Max = Matrix1[i][j];
			}




		}
	}
	return Max;
}
void PrintTwoDArray(int arr[3][3], short Rows, short Clos)
{
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {

			//printf("%0*d\t", 2, arr[i][j]);
			cout << arr[i][j] << "\t";



		}
		cout << endl;
	}
}
int main()
{
	srand((unsigned)time(NULL));
	int Matrix[3][3];
	FillMatrixWithRandomNumbers(Matrix, 3, 3);
	cout << "\n Matrix1:\n";
	PrintTwoDArray(Matrix, 3, 3);
	
	
	cout << "\nThe Min Number is :"<< MinNumberInMatrix(Matrix, 3, 3);
	cout << "\nThe Max Number is :" << MaxNumberInMatrix(Matrix, 3, 3);
	
		
	
	return 0;


}

