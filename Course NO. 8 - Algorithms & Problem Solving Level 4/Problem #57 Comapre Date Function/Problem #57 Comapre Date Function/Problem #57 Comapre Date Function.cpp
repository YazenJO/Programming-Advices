#include <iostream>
using namespace std;
struct stDate {
    short Year;
    short Month;
    short Day;
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
    stDate Date1 = ReadFullDate();
    cout << "\n\nEnter Date 2 : \n";
    stDate Date2 = ReadFullDate();
    short TheCompareResult = CompareDateFunction(Date1, Date2);
    cout << "\nTheCompareResult is : " << TheCompareResult;
    system("pause>0");
    return 0;
}

