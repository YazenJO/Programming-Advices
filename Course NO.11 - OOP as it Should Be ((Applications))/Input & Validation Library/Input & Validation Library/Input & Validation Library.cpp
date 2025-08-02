#include <iostream>
#include "clsInputValidate.h"
using namespace std;
int main()
{
	cout << clsInputValidate::IsNumberBetween(5, 5, 10) << endl;;
	cout << clsInputValidate::IsDateBetween(clsDate(), clsDate(28, 7, 2024), clsDate(23, 7, 2024));


	cout << "\nPlease Enter A Number :\n";
	int x = clsInputValidate::ReadIntNumber("Invalid Number ,Enter again:\n");
	cout << "x =" << x;

	cout << "\nPlease Enter A Number Between 1 and 5 :\n";
	int y = clsInputValidate::ReadIntNumberBetween(1,5,"Invalid Number ,Enter again:\n");
	cout << "y =" << y;

	cout << "\nPlease Enter A Double Number :\n";
	double a = clsInputValidate::ReadDblNumber("Invalid Number ,Enter again:\n");
	cout << "a =" << a;

	cout << "\nPlease Enter A double Number Between 1 and 5 :\n";
	double b = clsInputValidate::ReadDblNumberBetween(1, 5, "Invalid Number ,Enter again:\n");
	cout << "b =" <<b;

	cout << endl << clsInputValidate::isValideDate(clsDate(35, 12, 2022)) << endl;
}
