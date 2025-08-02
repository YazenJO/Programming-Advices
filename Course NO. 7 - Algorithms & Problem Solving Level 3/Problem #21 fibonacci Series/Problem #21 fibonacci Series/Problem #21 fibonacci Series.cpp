#include <iostream>
using namespace std;

int ReadAPositiveNumber(string Massage) {
	int num;
	do {
		cout << Massage << "\n";
		cin >> num;

	} while (num < 0);
	return num;
}
void FillMatrixWitFibonacci(int arr[], short Size) {
	arr[0] = 1;
	arr[1] = 1;
	for (int i = 2; i < Size +2; i++)
	{
		

			
			arr[i]=arr[i-2]+arr[i-1];



		
	}

}
void PrintArray(int arr[], short Size)
{
	for (int i = 0; i < Size; i++)
	{
		
			cout << arr[i] << "\t";



	}
}
int main()
{
	int* ptr;
	int num = ReadAPositiveNumber("Enter A Number");
	ptr = new int[num];
	
	FillMatrixWitFibonacci(ptr, num);
	cout << "\n Array1:\n";
	PrintArray(ptr, num);
	

	return 0;
}

