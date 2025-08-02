#include <iostream>
#include <string>
using namespace std;
struct stidinfo {
	string namw;
	int age;
	string country;
	string city;
	int monthsalary;
	char Gender;
	bool married;

};
void ReadInfo(stidinfo &Person1) {
	cout << "Enter Your name\n";
	getline(cin,Person1.namw) ;

	cout << "Enter your age : \n";
	cin >> Person1.age;

	cout << "Enter your city : ";
	cin >> Person1.city;

	cout << "Enter your country : \n";
	cin >> Person1.country;

	cout << "Enter your Month salary : " << endl;
	cin >> Person1.monthsalary;

	cout << "Enter your Gender : " << endl;
	cin >> Person1.Gender;

	cout << "Enter your Married : \n";
	cin >> Person1.married;



}
void PrintInfo(stidinfo Person1) {
	cout << "***************************" << endl;
	cout << "name : " << Person1.namw<< endl;
	cout << "Age: " << Person1.age << " years" << endl;
	cout << "City :" << Person1.city << endl;
	cout << "Country :" << Person1.country << endl;
	cout << "MOnth salary: " << Person1.monthsalary << endl;
	cout << "Year salary: " << Person1.monthsalary *12<< endl;
	cout << "Gender : " << Person1.Gender << endl;
	cout << "Married : " << Person1.married << endl;
	cout << "***************************" << endl;




}



int main()
{
	stidinfo Person1;
	ReadInfo( Person1);
	PrintInfo(Person1);
}
