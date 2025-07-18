#include <iostream>
#include <string>
using namespace std;

short NumberOfClients = 0;

struct STPersonInfo {
	string name;
	int age;
	string country;
	string city;
	int monthsalary;
	char Gender;
	char married;
};
void ReadInfo(STPersonInfo& info) {

	cout << "\n\t\t***************** User Number (" << NumberOfClients + 1 << ") *****************\n";
	cout << "Enter Your name\n";
	getline(cin>>ws,info.name);

	cout << "Enter your age : \n";
	cin >>info.age;

	cout << "Enter your city : ";
	cin >>info.city;

	cout << "Enter your country : \n";
	cin >>info.country;

	cout << "Enter your Month salary : " << endl;
	cin >>info.monthsalary;

	cout << "Enter your Gender : " << endl;
	cin >>info.Gender;

	cout << "Enter your Married : \n";
	cin >>info.married;

	NumberOfClients++;

}
void PrintInfo(STPersonInfo info) {
	cout << "***************************" << endl;
	cout << "name : " <<info.name << endl;
	cout << "Age: " <<info.age << " years" << endl;
	cout << "City :" <<info.city << endl;
	cout << "Country :" <<info.country << endl;
	cout << "MOnth salary: " <<info.monthsalary << endl;
	cout << "Year salary: " <<info.monthsalary * 12 << endl;
	cout << "Gender : " <<info.Gender << endl;
	cout << "Married : " <<info.married << endl;
	cout << "***************************" << endl;







}
void ReadNPersons(STPersonInfo Person[100],int &length) {
	cout << "How many persons u want \n";
	cin >> length;
	for (int i = 0; i <= length - 1; i++) {


		ReadInfo(Person[i]);


	}
	

}
void PrintNPersons(STPersonInfo Person[100],int length) {

	for (int i = 0; i <= length - 1; i++) {


		PrintInfo(Person[i]);


	}


}
int main() {
	STPersonInfo Person[2];
	int length;
	ReadNPersons(Person,length);
	PrintNPersons(Person, length);



}
//void ReadPersonData(STPersonInfo &Person) {
//	cout << "Enter Your name\n";
//	getline(cin>>ws, Person.name);
//
//	cout << "Enter your age : \n";
//	cin >> Person.age;
//
//	cout << "Enter your city : ";
//	cin >> Person.city;
//
//	cout << "Enter your country : \n";
//	cin >> Person.country;
//
//	cout << "Enter your Month salary : " << endl;
//	cin >> Person.monthsalary;
//
//	cout << "Enter your Gender : " << endl;
//	cin >> Person.Gender;
//
//	cout << "Enter your Married : \n";
//	cin >> Person.married;
//
//
//
//
//}
//void PringPersonData(STPersonInfo  Person) {
//	cout << "***************************" << endl;
//	cout << "name : " << Person.name << endl;
//	cout << "Age: " << Person.age << " years" << endl;
//	cout << "City :" << Person.city << endl;
//	cout << "Country :" << Person.country << endl;
//	cout << "MOnth salary: " << Person.monthsalary << endl;
//	cout << "Year salary: " << Person.monthsalary * 12 << endl;
//	cout << "Gender : " << Person.Gender << endl;
//	cout << "Married : " << Person.married << endl;
//	cout << "***************************" << endl;
//
//
//
//}
//int main()
//{
//	STPersonInfo Person[2];
//	ReadPersonData(Person[0]);
//	PringPersonData(Person[0]);
//	ReadPersonData(Person[1]);
//	PringPersonData(Person[1]);
//
//
//
//}
//
