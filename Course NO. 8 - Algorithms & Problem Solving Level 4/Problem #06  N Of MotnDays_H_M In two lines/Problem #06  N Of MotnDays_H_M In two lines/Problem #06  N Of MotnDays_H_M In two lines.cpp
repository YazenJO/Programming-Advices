#include<iostream>
using namespace std;

bool IsLeapYear(short Year) {


	return (Year % 400 == 0 || Year % 4 == 0 && Year % 100 != 0);


}
short ReadNumber(string Massage) {
	short Year;
	cout << Massage;
	cin >> Year; return Year;
}
short NumberOfDaysInMonth(short Year, short Month) {
	if (Month < 1 || Month>12)
	{
		return 0;
	}
	return ((Month == 2) ? (IsLeapYear(Year) ? 29 : 28) : (Month == 4 || Month == 6 || Month == 9|| Month == 11) ? 30 : 31);

}
short NumberOfHoursInMonth(short Year, short Month) {

	return (NumberOfDaysInMonth(Year, Month) * 24);

}
int NumberOfMinutesInMonth(short Year, short Month) {

	return (60 * NumberOfHoursInMonth(Year, Month));
}
int NumberOfSecondsInMonth(short Year, short Month) {
	return (60 * NumberOfMinutesInMonth(Year, Month));
}



int main() {
	short Year = ReadNumber("Please enter a year to check? ");
	short Month = ReadNumber("\nPlease enter a Month to check ? ");
	cout << "\nNumber of Days    in Month [" << Month << "] is " << NumberOfDaysInMonth(Year, Month);
	cout << "\nNumber of Hours   in Month [" << Month << "] is " << NumberOfHoursInMonth(Year, Month);
	cout << "\nNumber of Minutes in Month [" << Month << "] is " << NumberOfMinutesInMonth(Year, Month);
	cout << "\nNumber of Seconds in Month [" << Month << "] is " << NumberOfSecondsInMonth(Year, Month);
	system("pause>0");
	return 0;
}
