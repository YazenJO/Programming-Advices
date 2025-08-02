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
void FillMatrixWitFibonacciUsingrecartion(int arr[], short Size,int N) {
	arr[0] = 1;
	arr[1] = 1;
	
	if (N != Size) {


		arr[N] = arr[N - 2] + arr[N - 1];
		
		FillMatrixWitFibonacciUsingrecartion(arr, Size, N+1);
		
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

	FillMatrixWitFibonacciUsingrecartion(ptr, num,0);
	cout << "\n Array1:\n";
	PrintArray(ptr, num);


	return 0;
}

