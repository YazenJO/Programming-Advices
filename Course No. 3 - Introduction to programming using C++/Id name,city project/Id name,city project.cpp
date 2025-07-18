#include <iostream>
using namespace std;

int main()
{
	string Name, City, country;
	short Age, Monthlysalary = 1, Year_salary = 0;

	bool Married;
	char Gender;

	cout << "Enter Your name\n";
	cin >> Name;

	cout << "\n";

	cout << "Enter your age : \n";
	cin >> Age;

	cout << "\n";
	cout << "Enter your city : ";
	cin >> City;

	cout << "\n";
	cout << "Enter your country : \n";
	cin >> country;

	cout << "\n";
	cout << "Enter your Month salary : " << endl;
	cin >> Monthlysalary;

	cout << "\n";
	cout << "Enter your Gender : " << endl;
	cin >> Gender;

	cout << "\n";
	cout << "Enter your Married : \n";
	cin >> Married;

	cout << "\n";
	Year_salary = Monthlysalary * 12;
	cout << "***************************" << endl;
	cout << "name : " << Name << endl;
	cout << "Age: " << Age << " years" << endl;
	cout << "City :" << City << endl;
	cout << "Country :" << country << endl;
	cout << "MOnth salary: " << Monthlysalary << endl;
	cout << "Year salary: " << Year_salary << endl;
	cout << "Gender : " << Gender << endl;
	cout << "Married : " << Married << endl;
	cout << "***************************" << endl;


}

