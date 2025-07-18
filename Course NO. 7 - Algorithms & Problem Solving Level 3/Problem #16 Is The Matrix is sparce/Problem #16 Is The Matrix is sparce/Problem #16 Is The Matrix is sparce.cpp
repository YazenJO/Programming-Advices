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
int NumberFrequancyInMatrix(int arr[3][3], int Number, short Rows, short Clos)
{
	int count = 0;
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {

			if (Number == arr[i][j])
			{
				count++;
			}




		}
	}
	return count;
}
bool IsTheMatrixSparce(int arr[3][3] ,short Rows, short Clos) {
	int zerocount = NumberFrequancyInMatrix(arr, 0, 3, 3);
	int OtherNCount = 0;
	//int sizeOfMatrix==Rows*Coloums;
	//return(zerocount>=(SizeOfMatrix/2);Another Slu
	for (int i = 0; i < Rows; i++)
	{
		for (int j = 0; j < Clos; j++) {

			if (arr[i][j]!=0) {
				OtherNCount++;
				
			}
			if (zerocount< OtherNCount)
			{
				return 0;
			}
		}
	}


	return 1;


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
	if (IsTheMatrixSparce(Matrix, 3, 3))
	{
		cout << "\nYes:The Matrcix is Sparce\n";
	}
	else
	{
		cout << "\nNo:The Matrcix is Not Sparce\n";
	}
	return 0;

	
}

