#include <iostream>
#include <iostream>
using namespace std;

struct stDate {
    short Year;
    short Month;
    short Day;
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
    return (Date.Day ==1);
}
bool IsFirstMonthInYear(short Month) {
    return (Month == 1);
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
stDate DecreaseDateByXDay(stDate Date, short Days) {
    for (int i = 1; i <= Days; i++)
    {
        Date = DecreaseDateByOneDay(Date);
    }


    return Date;

}
stDate DecreaseDateByOneWeek(stDate Date) {

    Date = DecreaseDateByXDay(Date, 7);


    return Date;
}
stDate DecreaseDateByXWeek(stDate Date, short NumberOfWeeks) {
    for (short i = 1; i <= NumberOfWeeks; i++)
    {
        Date = DecreaseDateByOneWeek(Date);
    }
    return Date;
}
stDate DecreaseDateByOneMonth(stDate Date) {
    if (Date.Month == 1)
    {
        Date.Month = 12;
        Date.Year--;

    }
    else
    {
        Date.Month--;
    }
    short NumberOfDaysInCurrentMonth = NumberOfDaysInAMonth(Date.Month, Date.Year);
    if (Date.Day > NumberOfDaysInCurrentMonth)
    {
        Date.Day = NumberOfDaysInCurrentMonth;
    }
    return Date;
}
stDate DecreaseDateByXMonth(stDate Date, short NumberOfMonths) {
    for (short i = 1; i <= NumberOfMonths; i++)
    {
        Date = DecreaseDateByOneMonth(Date);
    }
    return Date;
}
stDate DecreaseDateByOneYear(stDate Date) {

    Date.Year--;


    return Date;
}
stDate DecreaseDateByXYear(stDate Date, short NumberOfYears) {
    for (short i = 1; i <= NumberOfYears; i++)
    {
        Date = DecreaseDateByOneYear(Date);
    }
    return Date;
}
stDate DecreaseDateByXYearFaster(stDate Date, short NumberOfYears) {

    Date.Year -= NumberOfYears;

    return Date;
}
stDate DecreaseDateByOneDecade(stDate Date) {
    Date = DecreaseDateByXYear(Date, 10);



    return Date;
}
stDate DecreaseDateByXDecade(stDate Date, short NumberOfDecates) {
    for (short i = 1; i <= NumberOfDecates; i++)
    {
        Date = DecreaseDateByXYear(Date, 10);
    }




    return Date;
}
stDate DecreaseDateByXDecadeFaster(stDate Date, short NumberOfDecates) {
    Date = DecreaseDateByXYearFaster(Date, 10 * (NumberOfDecates));



    return Date;
}
stDate DecreaseDateByOneCentury(stDate Date) {
    Date = DecreaseDateByXDecadeFaster(Date, 10);



    return Date;
}
stDate DecreaseDateByOneMillennium(stDate Date) {
    Date = DecreaseDateByXDecadeFaster(Date, 100);



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
void PrintDate(stDate Date) {
    cout << Date.Day << "/" << Date.Month << "/" << Date.Year;


}

int main()
{
    stDate Date = ReadFullDate();
    cout << "Date After \n\n";
    cout << "01-Subtracting one Day is : ";
    PrintDate(DecreaseDateByOneDay(Date));
    cout << "\n02-Subtracting 10 Days is : ";

    PrintDate(DecreaseDateByXDay(Date, 10));
    cout << "\n03-Subtracting one Week is : ";
    PrintDate(DecreaseDateByOneWeek(Date));
    cout << "\n04-Subtracting 10 Weeks is : ";
    PrintDate(DecreaseDateByXWeek(Date, 10));
    cout << "\n05-Subtracting One Month is : ";
    PrintDate(DecreaseDateByOneMonth(Date));
    cout << "\n06-Subtracting 10 Months is : ";
    PrintDate(DecreaseDateByXMonth(Date, 10));
    cout << "\n07-Subtracting One Year is : ";
    PrintDate(DecreaseDateByOneYear(Date));
    cout << "\n08-Subtracting 10 Years is : ";
    PrintDate(DecreaseDateByXYear(Date, 10));
    cout << "\n09-Subtracting 10 Years(Faster) is : ";
    PrintDate(DecreaseDateByXYearFaster(Date, 10));
    cout << "\n10-Subtracting One Deacade is : ";
    PrintDate(DecreaseDateByOneDecade(Date));
    cout << "\n11-Subtracting 10 Deacades is : ";
    PrintDate(DecreaseDateByXDecade(Date, 10));
    cout << "\n12-Subtracting 10 Deacades (faster) is : ";
    PrintDate(DecreaseDateByXDecadeFaster(Date, 10));
    cout << "\n13-Subtracting one Centry  is : ";
    PrintDate(DecreaseDateByOneCentury(Date));
    cout << "\n14-Subtracting one Millennium  is : ";
    PrintDate(DecreaseDateByOneMillennium(Date));
    system("pause>0");
}
