#include <iostream>
#include<vector>
using namespace std;

int main()
{
	/*int print = 1;
	printf("Ahmed = %d\n", print);
	printf("Tareq =%0*d\n", 2, print);*/
	//int number = 1,number2 =2 ;
	//printf("The Sum Of %d + %d = %0*d\n", number, number2, 2,number + number2);*/
	/*float PI = 3.14159265359;
	
	printf("The Number = %.*f",2,PI);*/

	/*char Name[] = "Yazen";
    char SchoolName[] = "Acadime";

	printf("The Name OF user %s\n", Name);
	printf("School Name: %s\n", SchoolName);
	char Char = 'r';

	printf("The Letter In The Char is : %c", Char);*/
	vector <int> vec;
	for (int i = 0; i < 5; i++)
	{
		vec.push_back(i * 10);
	}
	for (int& store : vec) {
		cout << store<<" ";
	}

}

