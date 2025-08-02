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
bool IsFirstDayInMonth(stDate Date) {
    return (Date.Day == 1);
}
bool IsFirstMonthInYear(short Month) {
    return (Month == 1);
}
bool IsLastDayInMonth(stDate Date) {
    return (Date.Day == NumberOfDaysInAMonth(Date.Month, Date.Year));
}
bool IsLastMonthInYear(short Month) {
    return (Month == 12);
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
stDate IncreaseDateByOneDay(stDate Date) {
    if (IsLastDayInMonth(Date))
    {
        if (IsLastMonthInYear(Date.Month)) {
            Date.Month = 1;
            Date.Day = 1;
            Date.Year++;
        }
        else {
            Date.Day = 1;
            Date.Month++;
        }
    }
    else {
        Date.Day++;
    } return Date;
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
bool IstDate1BeforeDate2(stDate Date1, stDate Date2) {
    return  (Date1.Year < Date2.Year) ? true : ((Date1.Year == Date2.Year) ? (Date1.Month < Date2.Month ? true : (Date1.Month == Date2.Month ? Date1.Day < Date2.Day : false)) : false);
}
bool IstDate1EqualDate2(stDate Date1, stDate Date2) {
    if (Date1.Year = Date2.Year)
    {
        if (CountDaysFromTheBeginningOfYear(Date1.Year, Date1.Month, Date1.Day) == CountDaysFromTheBeginningOfYear(Date2.Year, Date2.Month, Date2.Day))
        {
            return 1;
        }
    }



    return 0;
}
bool IstDate1AfterDate2(stDate Date1, stDate Date2) {
    if (Date1.Year > Date2.Year)
    {
        return 1;
    }
    else if (CountDaysFromTheBeginningOfYear(Date1.Year, Date1.Month, Date1.Day) > CountDaysFromTheBeginningOfYear(Date2.Year, Date2.Month, Date2.Day))
    {
        return 1;
    }


    return 0;
}
enDateCompare CompareDateFunction(stDate Date1, stDate Date2) {
    if (IstDate1BeforeDate2(Date1, Date2))
    {
        return Before;
    }
    else if (IstDate1EqualDate2(Date1, Date2))
    {
        return Equal;
    }

    return After;
}
bool IsOvelapPeriods(stPeriodDates Period1, stPeriodDates Period2) {
    if (CompareDateFunction(Period1.startPeriod, Period2.startPeriod) == Before)
    {


        while (CompareDateFunction(Period1.startPeriod, Period1.EndPeriod) == Before)
        {
            if (CompareDateFunction(Period1.startPeriod, Period2.startPeriod) != Equal)
            {
                Period1.startPeriod = IncreaseDateByOneDay(Period1.startPeriod);
            }
            else if (CompareDateFunction(Period1.startPeriod, Period2.startPeriod) == Equal)
            {
                return 1;
            }

        }
    }
    else if(CompareDateFunction(Period1.startPeriod, Period2.startPeriod) == After)
    {
        while (CompareDateFunction(Period2.startPeriod, Period2.EndPeriod) == Before)
        {
            if (CompareDateFunction(Period1.startPeriod, Period2.startPeriod) != Equal)
            {
                Period2.startPeriod = DecreaseDateByOneDay(Period2.startPeriod);
            }
            else if (CompareDateFunction(Period1.startPeriod, Period2.startPeriod) == Equal)
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
stDate ReadFullDate() {
    stDate Date;
    Date.Day = ReadDay();
    Date.Month = ReadMonth();
    Date.Year = ReadYear();
    return Date;
}

int main()
{
    stPeriodDates Period1;
    stPeriodDates Period2;
    cout << "Enter Period 1  : \n";
    cout << "\nEnter Start Date : ";
    Period1.startPeriod = ReadFullDate();
    cout << "\nEnter End Date : ";
    Period1.EndPeriod = ReadFullDate();
    cout << "Enter Period 2  : \n";
    cout << "\n Enter Start Date [2] : ";
    Period2.startPeriod = ReadFullDate();
    cout << "\n Enter End Date [2] : ";
    Period2.EndPeriod = ReadFullDate();

    if (IsOvelapPeriods(Period1,Period2))
    {
        cout << "\nYes ,Periods Overlap\n";
    }
    else
    {
        cout << "\No ,Periods Is Not Overlap\n";
    }
    system("pause>0");
    return 0;

}
