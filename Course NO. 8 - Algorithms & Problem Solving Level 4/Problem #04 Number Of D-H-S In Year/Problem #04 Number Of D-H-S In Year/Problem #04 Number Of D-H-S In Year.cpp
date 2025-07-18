#include<iostream>
using namespace std;

bool IsLeapYear(short Year) {


	return (Year % 400 == 0 || Year % 4 == 0 && Year % 100 != 0);


}
short ReadYear() {
	short Year;
	cout << "\nPlease enter a year to check? ";
	cin >> Year; return Year;
}
short NumberOfDaysInYear(short Year) {

	return (IsLeapYear(Year) ? 366 : 365);
}
short NumberOfHoursInYear(short Year) {

	return (NumberOfDaysInYear(Year) * 24);

}
int NumberOfMinutesInAYear(short Year) {

	return (60 * NumberOfHoursInYear(Year));
}
int NumberOfSecondsInYear(short Year) {
	return (60 * NumberOfMinutesInAYear(Year));
}



int main() {
	short Year = ReadYear();

	cout << "\nNumber of Days    in Year [" << Year << "] is " << NumberOfDaysInYear(Year);
	cout << "\nNumber of Hours   in Year [" << Year << "] is " << NumberOfHoursInYear(Year);
	cout << "\nNumber of Minutes in Year [" << Year << "] is " << NumberOfMinutesInAYear(Year);
	cout << "\nNumber of Seconds in Year [" << Year << "] is " << NumberOfSecondsInYear(Year);
	system("pause>0");
	return 0;
}
	