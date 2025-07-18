#include <iostream>
#include<iostream>
using namespace std;
short ReadNumber(string Massage) {
	short Year;
	cout << Massage;
	cin >> Year; return Year;
}
short DayNumber(short Day, short Month, short Year) {
	short a = (14 - Month) / 12;
	short y = Year - a;

	short m = Month + (12 * a) - 2;

	return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}
int main(){

	short Year = ReadNumber("Enter The Year : ");
	short Month = ReadNumber("\nEnter The Month : ");
	short Day = ReadNumber("\nEnter The Day :  ");
	cout << DayNumber(Day, Month, Year);
}

