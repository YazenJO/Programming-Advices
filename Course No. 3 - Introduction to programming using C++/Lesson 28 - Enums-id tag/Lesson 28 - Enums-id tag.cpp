#include <iostream>
using namespace std;
//gemder ..married ...my favorite color
struct stgender {
	string gender;
};
enum enmarried { Yes=1, No=0 };
struct stColor {
	string Color;
};
struct stAdress{
	string Contry;
	string City;
	short Zipcode;

};
struct stsallary {
	short Monthly;
	short Yearly;

};
struct stName {
	string FirstName;
	string LastName;
};
struct stAge {
	short age;
};
struct stPerson1{
	stgender gender;
	enmarried married;
	stColor Color;
	stAdress Adress;
	stsallary sallary;
	stName Name;
	stAge Age;

};

void DispalyMyCardInfo() {
	stPerson1 Person1;
	cout << "Enter Your First name\n";
	cin >> Person1.Name.FirstName;

	cout << "Enter your Last Name : \n";
	cin >> Person1.Name.LastName;

	cout << "Enter your age : \n";
	cin >> Person1.Age.age;

	cout << "Enter your country : \n";
	cin >> Person1.Adress.Contry;

	cout << "Enter your City : \n";
	cin >> Person1.Adress.City;

	cout << "Enter your ZipCode : \n";
	cin >> Person1.Adress.Zipcode;

	cout << "Enter your Month salary : " << endl;
	cin >> Person1.sallary.Monthly;

	cout << "Enter your Gender : " << endl;
	cin >> Person1.gender.gender;

	cout << "Enter your FavoriteClolr : \n";
	cin >> Person1.Color.Color;

	Person1.sallary.Yearly = Person1.sallary.Monthly * 12;
	Person1.married = enmarried::Yes;
	cout << "***************************" << '\n';
	cout << "name : " << Person1.Name.FirstName << "  " << Person1.Name.LastName << '\n';
	cout << "age : " << Person1.Age.age << endl;
	cout << "Country :" << Person1.Adress.Contry << '\n';
	cout << "City:" << Person1.Adress.City << '\n';
	cout << "Zip Code : " << Person1.Adress.Zipcode << '\n';
	cout << "MOnth salary: " << Person1.sallary.Monthly << '\n';
	cout << "Year salary: " << Person1.sallary.Yearly << endl;
	cout << "Gender : " << Person1.gender.gender << '\n';
	cout << "Married : " << Person1.married << '\n';
	cout << "My favorite color is : " << Person1.Color.Color << '\n';
	cout << "***************************" << '\n';


};
int main()
{
	

	DispalyMyCardInfo();


}
