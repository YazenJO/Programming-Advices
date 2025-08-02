#include <iostream>
#include<iomanip>
#include"Header.h";
using namespace std;

void MultipleNumbers(int arr[10][10]) {
	for (int i = 1; i <= 10; i++) {
		
		for (int j = 1; j <= 10; j++) {
			arr[i-1][j-1]=i* j;




		}


		

	}
}
int main()
{
	int arr[10][10];
	MultipleNumbers(arr);
	test::PrintATwoDArray(arr);
}
