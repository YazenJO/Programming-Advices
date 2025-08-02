#include <iostream>
#include<vector>
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
			arr[i][j] = RandomNumber(0, 100);



		}
	}

}
bool IsNumberInMatrix(int arr[3][3], int Number, short Rows, short Clos)
{

	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {

			if (Number == arr[i][j])
			{
				return 1;;
			}




		}
	}
	return 0;
}
void TheInterstedNumbersInMatrices(int Matrix1[3][3], int Matrix2[3][3], vector <int> &store, short Rows, short Clos) {
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {

			if ( IsNumberInMatrix(Matrix2, Matrix1[i][j], 3, 3))
			{
				store.push_back(Matrix1[i][j]);
					
			}
			



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
void PrintVector(vector <int> &store) {
	for (int& Num : store) {
		cout << Num << "\t";
	}




}
int main()
{
	srand((unsigned)time(NULL));
	int Matrix1[3][3];
	int Matrix2[3][3];
	vector <int> storage;
	FillMatrixWithRandomNumbers(Matrix1, 3, 3);
	FillMatrixWithRandomNumbers(Matrix2, 3, 3);
	cout << "\nMatrix1:\n";
	PrintTwoDArray(Matrix1, 3, 3);
	cout << "\nMatrix2:\n";
	PrintTwoDArray(Matrix2, 3, 3);
	TheInterstedNumbersInMatrices(Matrix1, Matrix2, storage, 3, 3);
	cout << "\n";
	PrintVector(storage);
}

