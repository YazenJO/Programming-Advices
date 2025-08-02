#include <iostream>
#include"MyArrLib.h";


using namespace std;
int main()
{
	int arr[100], arr2[100];
	int arrLength = 10, arr2length=0;
	MyArrLib::FillArrayHardCoded(arr, arrLength);
	MyArrLib::PrintArray(arr, arrLength);
	MyArrLib::CopyDistinctNumbersToArray(arr, arr2, arrLength, arr2length);
	MyArrLib::PrintArray(arr2, arr2length);
	
	

}