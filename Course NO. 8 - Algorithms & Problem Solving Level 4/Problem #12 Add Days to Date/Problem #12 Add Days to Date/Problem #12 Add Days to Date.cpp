#include <iostream>
using namespace std;
struct stDate
{
    short Year;
    short Day;
    short Month ;

};
bool isLeapYear(short Year) {
    // if year is divisible by 4 AND not divisible by 100
    // OR if year is divisible by 400
    // then it is a leap year
    return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}
short NumberOfDaysInAMonth(short Month, short Year) {
    if (Month < 1 || Month > 12)
        return 0;
    int days[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];
}
stDate AddDaysToDate(short NumberOfDaysToAdd, stDate &Date) {//250>>>/3/10/2022
    while (NumberOfDaysToAdd > 0) {
        short NOfDaysInMonth = NumberOfDaysInAMonth(Date.Month, Date.Year);
        short ReminderOfDaysInTheMonth = NOfDaysInMonth - Date.Day;

        if (NumberOfDaysToAdd > ReminderOfDaysInTheMonth) {
            NumberOfDaysToAdd -= ReminderOfDaysInTheMonth + 1; // Move to the first day of the next month
            Date.Day = 1;
            Date.Month++;
            if (Date.Month == 13) {
                Date.Month = 1;
                Date.Year++;
            }
        }
        else {
            Date.Day += NumberOfDaysToAdd;
            NumberOfDaysToAdd = 0;
        }
    }
    return Date;
}
short ReadDay() {
    short Day;
    cout << "\nPlease enter a Day? ";
    cin >> Day;
    return Day;
}
short ReadMonth() {
    short Month;
    cout << "\nPlease enter a Month? ";
    cin >> Month;
    return Month;
}
short ReadYear() {
    short Year;
    cout << "\nPlease enter a year? ";
    cin >> Year;
    return Year;
}



int main()
{
    stDate Date;
    Date.Day = ReadDay();
    Date.Month = ReadMonth();
    Date.Year = ReadYear();
    short AddDays;
    cout << "\nEnter The Number Of Days u Want To Add : ";
    cin >> AddDays;
    AddDaysToDate(AddDays, Date);
    cout << "\n\nDate After Adding [" << AddDays << "] days is : " << Date.Day << "/" << Date.Month << "/" << Date.Year;
}

