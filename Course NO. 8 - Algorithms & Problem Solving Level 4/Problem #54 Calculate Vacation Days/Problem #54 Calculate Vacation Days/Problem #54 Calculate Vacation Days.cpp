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
stDate AddDaysToDate(short NumberOfDaysToAdd, stDate& Date) {//250>>>/3/10/2022
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
short DiffrenceDaysBetweenDate1AndDate2(stDate Date1, stDate Date2) {
    short DiffDays = 0;
    if (IsDate1BeforeDate2(Date1, Date2)) {

        if (Date1.Year != Date2.Year)
        {
            for (short i = Date1.Year; i < Date2.Year; i++)
            {
                if (isLeapYear(i))
                {
                    DiffDays += 366;
                }
                else
                    DiffDays += 365;
            }
        }
        if (Date1.Year == Date2.Year)
        {
            DiffDays += CountDaysFromTheBeginningOfYear(Date2.Year, Date2.Month, Date2.Day) - CountDaysFromTheBeginningOfYear(Date1.Year, Date1.Month, Date1.Day);
        }
    }
    else if (IsDate1EqualDate2(Date1, Date2))
    {
        cout << "\n\nThere is No Diffrence Between Date1 And Date 2 \n";
    }
    else
    {
        cout << "\nError Date1 Comes After Date 2 :(\n";
    }


    return DiffDays;
}
short DayNumber(stDate Date) {
    short a = (14 - Date.Month) / 12;
    short y = Date.Year - a;

    short m = Date.Month + (12 * a) - 2;

    return (Date.Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}
bool IsWeekend(stDate Date) {
    if (DayNumber(Date) == 6|| DayNumber(Date) == 5)
    {
        return 1;
    }


    return 0;
}
short CalculateVactationDays(stDate Date1, stDate Date2) {
    short DiffrentDays = DiffrenceDaysBetweenDate1AndDate2(Date1, Date2);
    short NOfVactatuinDays = 0;
  while(Date1.Day<= DiffrentDays)
    {
        if (!IsWeekend(Date1))
        {
            NOfVactatuinDays++;
        }
        Date1.Day++;
    }
    




  return NOfVactatuinDays;
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
    cout << "Vaction Strats :\n";
    stDate VactinStart = ReadFullDate();
    cout << "\nVaction Ends : \n";
    stDate VactinEnds = ReadFullDate();
    cout << "Vaction From : ";
    PrintDate(VactinStart);
    cout << "\nVaction End : ";
    PrintDate(VactinEnds);


    cout << "\n\nActual Vacation Days is : " << CalculateVactationDays(VactinStart, VactinEnds);
}

