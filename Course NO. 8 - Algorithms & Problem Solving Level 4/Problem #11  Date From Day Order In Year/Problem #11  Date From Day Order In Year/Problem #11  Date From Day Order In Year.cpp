#include <iostream>
#include<string>
using namespace std;
struct sDate
{
    short Year;
    short Month = 1;
    short Day;
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
short CountDaysFromTheBeginningOfYear(short Year, short Month, short Day) {
    short NumberOfDays = 0;
    for (short i = 1; i <= Month; i++)
    {
        if (i != Month)
        {
            NumberOfDays += NumberOfDaysInAMonth(i, Year);
        }
        else
        {
            NumberOfDays += Day;
        }

    }


    return NumberOfDays;

}
string DateFromDayOrderINYear(short DayNumber,short Year) {
    string Date="";
    short Month = 0;
    short Day = 0;
    short Counter = 1;
    short NumberOfDaysinMonth=0;
    for (short i = 1; i <= 12; i++)
    {
        NumberOfDaysinMonth = NumberOfDaysInAMonth(i, Year);
        if (DayNumber> NumberOfDaysinMonth)
        {
            DayNumber -= NumberOfDaysinMonth;
            Counter++;
        }
        else
        {
            Day = DayNumber;
        }
    }
    
   
    return (to_string(Day) + "/" + to_string(Counter) + "/" + to_string(Year));

}
sDate GetDateFromDayOrderINYear(short DayNumber, short Year) {
    sDate Date;
    Date.Year = Year;
    short NumberOfDaysinMonth = 0;
    for (short i = 1; i <= 12; i++)
    {
        NumberOfDaysinMonth = NumberOfDaysInAMonth(i, Year);
        if (DayNumber > NumberOfDaysinMonth)
        {
            DayNumber -= NumberOfDaysinMonth;
            Date.Month++;
        }
        else
        {
            Date.Day = DayNumber;
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
  ///  short Day = ReadDay();
   // short Month = ReadMonth();
    sDate Date;
    short Year = ReadYear();
   // short countDaysFromTheBeginningOfYear = CountDaysFromTheBeginningOfYear(Year, Month, Day);
  //  cout << "Number Of Days From The Beginning Of Year : " << countDaysFromTheBeginningOfYear;
    Date = GetDateFromDayOrderINYear(250, Year);
//    cout << "\n\nDate for [" <<  "] is :" << ;
    cout << Date.Day << "/" << Date.Month << "/" << Date.Year;
}

