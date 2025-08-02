#include <iostream>
using namespace std;

struct stMarried {
	string Yes = "1";
	string No = "0";
};
struct stGender {
	char Male= 'M';
	char female = 'F';
};
struct stsalary {

	int Yearsalary = 60000;
	int monthsalary = 5000;

};
struct stAddress {

	string country = "Jordan";
		string city = "Amman";


};
struct stId {
	string name = "Mohammad Abu-Hadhood";
	int year = 44;
	
	stAddress adress;
	stsalary salary;
	stGender  Gender;
	stMarried Married;

};

stId ReadUserInfo() {


	short Year = 0;

	stId user;
	cout << "Enter Your name\n";
	cin >> user.name;
	cout << "\n";

	cout << "Enter your age : \n";
	cin >> user.year;
	cout << "\n";

	cout << "Enter your city : ";
	cin >> user.adress.city;
	cout << "\n";

	cout << "Enter your country : \n";
	cin >> user.adress.country;
	cout << "\n";

	cout << "Enter your Month salary : " << endl;
	cin >> user.salary.monthsalary;
	cout << "\n";

	cout << "Enter your Gender : " << endl;
	cin >> user.Gender.Male;
	cout << "\n";

	cout << "Enter your Married : \n";
	cin >> user.Married.Yes;
	cout << "\n";

	Year = user.salary.monthsalary * 12;
	return user;

}


void PrintUserInfo(stId user) {


	cout << "***************************" << endl;
	cout << "name : " << user.name << endl;
	cout << "Age: " << user.year << endl;
	cout << "City :" << user.adress.city << endl;;
	cout << "Country :" << user.adress.country << endl;;
	cout << "MOnth salary:" << user.salary.monthsalary << endl;
	cout << "Year salary: " << user.salary.Yearsalary << endl;
	cout << "Gender : " << user.Gender.Male << endl;
	cout << "Married : " << user.Married.Yes << endl;
	cout << "***************************" << endl;



}


void PrintFullName(string Fname , string Lname) {

	cout << "Full Name Is : " << Fname << " " << Lname << endl;

}


string GetFullName(string Fname, string Lname) {


	return  Fname + " " + Lname;

}


void PrintPrimeNumbersBetween(int number1 , int number2) {

	if (number1 < number2) {
		for (int i = number1; i <= number2; i++) {

			if (i == 2 || i==3)
				cout << i << " ";

			if (i <= 7 && i % 2 != 0 && i != 2  && i != 3 && i!=1 )
				cout << i << " " ;

			if( i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i != 1){
				cout << i << " ";
			
			}


		}
		cout << endl;
	}

	else {


		for (int i = number2; i <= number1; i++) {

			if (i == 2 || i == 3)
				cout << i << " ";

			if (i <= 7 && i % 2 != 0 && i != 2 && i != 3 && i != 1)
				cout << i << " ";

			if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i != 1) {
				cout << i << " ";

			}


		}
		cout << endl;

	}

	
}

int main()
{

	//2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97

	PrintPrimeNumbersBetween(1, 100);


}








