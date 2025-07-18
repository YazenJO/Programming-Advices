#include <iostream>
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
int SumCol(int arr[3][3], short NOfClos, short Clos) {
	int sum = 0;
	for (int i = 0; i < NOfClos; i++)
	{
		sum +=  arr[i][Clos];
	}


	return sum;
}
void PrintTheSumOfEachClos(int arr[3][3], short NOfClos) {

	for (int i = 0; i < NOfClos; i++)
	{
		cout << "The Sum Of Col " << "[" << i << "]" << SumCol(arr, NOfClos, i) << endl;
	}




}
int main()
{
	srand((unsigned)time(NULL));
	int arr[3][3];
	
	FillMatrixWithRandomNumbers(arr, 3, 3);

	cout << "\nThe following is a 3x3 random matrix:\n";
	PrintTwoDArray(arr, 3, 3);

	cout << "\nThe following is a sum of each Cols in the matrix:\n";
	PrintTheSumOfEachClos(arr, 3);


}
