#include <iostream>
using namespace std;

int main()
{


	short Nickels = 0, Dimes = 0, Quarters = 0, Dollars = 0, penny = 1;
	float total_pennys, total_dollars;
	cout << "Enter pennys" << endl;
	cin >> penny;

	cout << "Enter Nickels \n";
	cin >> Nickels;
	Nickels = penny * 5;

	cout << "Enter Dimes \n";
	cin >> Dimes;
	Dimes = penny * 10;

	cout << "Enter Quarters \n";
	cin >> Quarters;
	Quarters = penny * 25;

	cout << "Enter Dollars \n";
	cin >> Dollars;
	Dollars = penny * 100;


	total_pennys = Nickels + Dimes + Quarters + Dollars + penny;
	total_dollars = total_pennys / 100;
	cout << total_pennys << " Pennies" << "\n";
	cout << total_dollars << " Dollars" << endl;

}

