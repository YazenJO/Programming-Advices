#include <iostream>
using namespace std;
struct stDate {
    short Year;
    short Month;
    short Day;
};
struct stPeriodDates
{
    stDate startPeriod;
    stDate EndPeriod;
};
enum enDateCompare
{
    Before = -1, Equal = 0, After = 1
};
bool isLeapYear(short Year) {
    return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}
short NumberOfDaysInAMonth(short Month, short Year) {
    if (Month < 1 || Month > 12)
        return 0;
    int days[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];
}
bool IsLastDayInMonth(stDate Date) {
    return (Date.Day == NumberOfDaysInAMonth(Date.Month, Date.Year));
}
bool IsLastMonthInYear(short Month) {
    return (Month == 12);
}
bool IsFirstDayInMonth(stDate Date) {
    return (Date.Day == 1);
}
bool IsFirstMonthInYear(short Month) {
    return (Month == 1);
}
stDate IncreaseDateByOneDay(stDate Date) {
    if (IsLastMonthInYear(Date.Month) && IsLastDayInMonth(Date))
    {
        Date.Year++;
        Date.Day = 1;
        Date.Month = 1;

    }
    else if (IsLastDayInMonth(Date))
    {
        Date.Month++;
        Date.Day = 1;
    }
    else
    {
        Date.Day++;
    }

    return Date;


}
stDate DecreaseDateByOneDay(stDate Date) {
    if (IsFirstDayInMonth(Date))
    {
        if (IsFirstMonthInYear(Date.Month)) {
            Date.Month = 12;
            Date.Day = 31;
            Date.Year--;
        }
        else {

            Date.Month--;
            Date.Day = NumberOfDaysInAMonth(Date.Month, Date.Year);
        }
    }
    else {
        Date.Day--;
    }
    return Date;
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
bool IsDate1BeforeDate2(stDate Date1, stDate Date2) {
    return  (Date1.Year < Date2.Year) ? true : ((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}
bool IsDate1EqualDate2(stDate Date1, stDate Date2) {
    if (Date1.Year = Date2.Year)
    {
        if (CountDaysFromTheBeginningOfYear(Date1.Year, Date1.Month, Date1.Day) == CountDaysFromTheBeginningOfYear(Date2.Year, Date2.Month, Date2.Day))
        {
            return 1;
        }
    }



    return 0;
}
enDateCompare CompareDateFunction(stDate Date1, stDate Date2) {
    if (IsDate1BeforeDate2(Date1, Date2))
    {
        return Before;
    }
    else if (IsDate1EqualDate2(Date1, Date2))
    {
        return Equal;
    }

    return After;
}
bool IsDateWithinPeriod(stPeriodDates Period1, stDate Date1) {
    if (CompareDateFunction(Period1.startPeriod, Date1) == Before)
    {


        while (CompareDateFunction(Period1.startPeriod, Period1.EndPeriod) == Before)
        {
            if (CompareDateFunction(Period1.startPeriod, Date1) != Equal)
            {
                Period1.startPeriod = IncreaseDateByOneDay(Period1.startPeriod);
            }
            else if (CompareDateFunction(Period1.startPeriod, Date1) == Equal)
            {
                return 1;
            }

        }
    }
    

    return 0;
}
short ReadDay() {
    short Day;
    cout << "\nPlease enter a Day? ";
    cin >> Day;
    return Day;
}
short ReadMonth() {
    short Month;
    cout << "Please enter a Month? ";
    cin >> Month;
    return Month;
}
short ReadYear() {
    short Year;
    cout << "Please enter a Year? ";
    cin >> Year;
    return Year;
}
stDate ReadFullDate() {
    stDate Date;
    Date.Day = ReadDay();
    Date.Month = ReadMonth();
    Date.Year = ReadYear();
    return Date;
}
stPeriodDates ReadPeriod() {
    stPeriodDates Period;
    cout << "\nEnter Start Date:\n";
    Period.startPeriod = ReadFullDate();
    cout << "\nEnter End Date:\n";
    Period.EndPeriod = ReadFullDate();
    return Period;
}
int main()
{
    stPeriodDates Period = ReadPeriod();
    stDate Date = ReadFullDate();
   cout<< IsDateWithinPeriod(Period, Date);
}
