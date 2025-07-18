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
	if (Month == 2)
	{
		return (IsLeapYear(Year) ? 29 : 28);
	}
	short arr31Days[] = { 1,3,5,7,8,10,12 };
	for (short i = 1; i <=7;i++; i++)
	{
		if (arr31Days[i - 1] == Month)
		{
			return 31;
		}
		
			return 30;
	}
	if (Month%2==0)
		return 30;
	else
	
		return 31;
	

	
}
short NumberOfHoursInMonth(short Year, short Month) {

	return (NumberOfDaysInMonth(Year, Month) * 24);

}
int NumberOfMinutesInMonth(short Year, short Month) {

	return (60 * NumberOfHoursInMonth(Year,Month));
}
int NumberOfSecondsInMonth(short Year, short Month) {
	return (60 * NumberOfMinutesInMonth(Year,Month));
}



int main() {
	short Year = ReadNumber("Please enter a year to check? ");
	short Month = ReadNumber("\nPlease enter a Month to check ? ");
	cout << "\nNumber of Days    in Month [" << Month << "] is " << NumberOfDaysInMonth(Year,Month);
	cout << "\nNumber of Hours   in Month [" << Month << "] is " << NumberOfHoursInMonth(Year,Month);
	cout << "\nNumber of Minutes in Month [" << Month << "] is " << NumberOfMinutesInMonth(Year,Month);
	cout << "\nNumber of Seconds in Month [" << Month << "] is " << NumberOfSecondsInMonth(Year,Month);
	system("pause>0");
	return 0;
}
