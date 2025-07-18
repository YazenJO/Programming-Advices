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

			arr[i][j] = 0;
			//arr[i][j] = RandomNumberforarr(0, 10);
			arr[i][i] = 1;


		}
	}

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
bool isMatrixIdentity(int Matrix1[3][3], short Rows, short Clos) {

	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {



			if (i == j)
			{
				if (Matrix1[i][j] == 1) {
					continue;
				}


			}
			else if (Matrix1[i][j] == 0)
			{
				
				
					continue;
				
			}
			else
			{
				return 0;
			}
















		}

		return 1;

	}
}
int main()
{
	srand((unsigned)time(NULL));
	int Matrix1[3][3];
	FillMatrixWithRandomNumbers(Matrix1, 3, 3);
	cout << "\nThe following is a 3x3 random matrix:\n";
	//Matrix1[0][1] = 2;
	PrintTwoDArray(Matrix1, 3, 3);
	if (isMatrixIdentity(Matrix1, 3, 3))
	{
		cout << "\nThe Matrcies is identity\n";
	}
	else
	{
		cout << "\nThe Matrcies is not identity\n";
	}
	return 0;


}

