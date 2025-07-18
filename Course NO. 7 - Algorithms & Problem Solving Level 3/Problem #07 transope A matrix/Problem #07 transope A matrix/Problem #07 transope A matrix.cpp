#include <iostream>
using namespace std;
void CopyTwoDArray(int arr1[3][3], int carr2[3][3], short Rows, short Clos) {
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {


			arr1[i][j] = carr2[i][j];

		
		}

	}

}
void FillMatrixWithRandomNumbers(int arr[3][3], short Rows, short Clos) {
	int counter = 1;
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {


			arr[i][j] = counter;

			counter++;
		}

	}

}
void TransposeAMatrix(int arr[3][3],short Rows, short Clos) {
	int arr2[3][3];

	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {
			
			
			
			arr2[i][j] = arr[j][i];

			
			
			
		}
		
	}

	CopyTwoDArray(arr, arr2,3,3);
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
int main()
{
	int arr[3][3];
	FillMatrixWithRandomNumbers(arr, 3, 3);
	cout << "The Matrix before Transpone \n";
	PrintTwoDArray(arr, 3, 3);
	cout << endl;
	cout << "The Matrix After Transpone \n";
	TransposeAMatrix(arr, 3, 3);
	PrintTwoDArray(arr, 3, 3);
}

