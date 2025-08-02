#include <iostream>
using namespace std;
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
	PrintTwoDArray(arr, 3, 3);
}

