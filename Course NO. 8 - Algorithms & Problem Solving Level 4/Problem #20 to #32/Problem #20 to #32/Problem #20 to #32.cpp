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
bool IsLastDayInMonth(stDate Date) {
    return (Date.Day == NumberOfDaysInAMonth(Date.Month, Date.Year));
}
bool IsLastMonthInYear(short Month) {
    return (Month == 12);
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
stDate IncreaseDateByXDay(stDate Date,short Days) {
    for (int i = 1; i <= Days; i++)
    {
        Date=IncreaseDateByOneDay(Date);
    }


    return Date;

}
stDate IncreaseDateByOneWeek(stDate Date) {
   
        Date = IncreaseDateByXDay(Date,7);
   

    return Date;
}
stDate IncreaseDateByXWeek(stDate Date, short NumberOfWeeks) {
    for (short i = 1; i <= NumberOfWeeks; i++)
    {
        Date = IncreaseDateByOneWeek(Date);
    }
    return Date;
}
stDate IncreaseDateByOneMonth(stDate Date) {
    if (Date.Month==12)
    {
        Date.Month = 1;
        Date.Year++;

    }
    else
    {
        Date.Month++;
    }
    short NumberOfDaysInCurrentMonth = NumberOfDaysInAMonth(Date.Month,Date.Year);
    if (Date.Day>NumberOfDaysInCurrentMonth)
    {
        Date.Day = NumberOfDaysInCurrentMonth;
    }
    return Date;
}
stDate IncreaseDateByXMonth(stDate Date, short NumberOfMonths) {
    for (short i = 1; i <= NumberOfMonths; i++)
    {
        Date = IncreaseDateByOneMonth(Date);
    }
    return Date;
}
stDate IncreaseDateByOneYear(stDate Date) {

    Date.Year++;


    return Date;
}
stDate IncreaseDateByXYear(stDate Date, short NumberOfYears) {
    for (short i = 1; i <= NumberOfYears; i++)
    {
        Date = IncreaseDateByOneYear(Date);
    }
    return Date;
}
stDate IncreaseDateByXYearFaster(stDate Date, short NumberOfYears) {
  
   Date.Year+= NumberOfYears;
   
    return Date;
}
stDate IncreaseDateByOneDecade(stDate Date) {
    Date = IncreaseDateByXYear(Date, 10);
    


    return Date;
}
stDate IncreaseDateByXDecade(stDate Date,short NumberOfDecates) {
    for (short i = 1; i <= NumberOfDecates; i++)
    {
        Date = IncreaseDateByXYear(Date, 10);
    }
  



    return Date;
}
stDate IncreaseDateByXDecadeFaster(stDate Date,short NumberOfDecates) {
    Date = IncreaseDateByXYearFaster(Date, 10*(NumberOfDecates));



    return Date;
}
stDate IncreaseDateByOneCentury(stDate Date) {
    Date = IncreaseDateByXDecadeFaster(Date, 10);



    return Date;
}
stDate IncreaseDateByOneMillennium(stDate Date) {
    Date = IncreaseDateByXDecadeFaster(Date, 100);



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
    cout << "01-Adding one Day is : ";
    PrintDate(IncreaseDateByOneDay(Date));
    cout << "\n02-Adding 10 Days is : ";
   
    PrintDate(IncreaseDateByXDay(Date, 10));
    cout << "\n03-Adding one Week is : ";
    PrintDate(IncreaseDateByOneWeek(Date));
    cout << "\n04-Adding 10 Weeks is : ";
    PrintDate(IncreaseDateByXWeek(Date,10));
    cout << "\n05-Adding One Month is : ";
    PrintDate(IncreaseDateByOneMonth(Date));
    cout << "\n06-Adding 10 Months is : ";
    PrintDate(IncreaseDateByXMonth(Date,10));
    cout << "\n07-Adding One Year is : ";
    PrintDate(IncreaseDateByOneYear(Date));
    cout << "\n08-Adding 10 Years is : ";
    PrintDate(IncreaseDateByXYear(Date, 10));
    cout << "\n09-Adding 10 Years(Faster) is : ";
    PrintDate(IncreaseDateByXYearFaster(Date, 10));
    cout << "\n10-Adding One Deacade is : ";
    PrintDate(IncreaseDateByOneDecade(Date));
    cout << "\n11-Adding 10 Deacades is : ";
    PrintDate(IncreaseDateByXDecade(Date, 10));
    cout << "\n12-Adding 10 Deacades (faster) is : ";
    PrintDate(IncreaseDateByXDecadeFaster(Date, 10));
    cout << "\n13-Adding one Centry  is : ";
    PrintDate(IncreaseDateByOneCentury(Date));
    cout << "\n14-Adding one Millennium  is : ";
    PrintDate(IncreaseDateByOneMillennium(Date));
    system("pause>0");
}
