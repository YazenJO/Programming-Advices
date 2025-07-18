#include <iostream>
using namespace std;

int main()
{


	short LoanAmount = 0, MonthlyPayment;
	cout << "Enter the LoanAmount \n";
	cin >> LoanAmount;

	cout << "Enter the MonthlyPayment\n";
	cin >> MonthlyPayment;

	cout << LoanAmount / MonthlyPayment << " Monthes" << endl;

}

