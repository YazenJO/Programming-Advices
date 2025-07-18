#include <iostream>
using namespace std;
enum enWeekday {
    Sunday = 0,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
};
struct stDate {
    short Year;
    short Month;
    short Day;
};
bool isLeapYear(short Year) {
    // if year is divisible by 4 AND not divisible by 100
    // OR if year is divisible by 400
    // then it is a leap year
    return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}
string GetWeekDayName(enWeekday Day) {
    switch (Day)
    {
    case Saturday:
        return "Saturday";
        break;
    case Sunday:
        return "Sunday";
        break;
    case Monday:
        return "Monday";
        break;
    case Tuesday:
        return "Tuesday";
        break;
    case Wednesday:
        return "Wednesday";
        break;
    case Thursday:
        return "Thursday";
        break;
    case Friday:
        return "Friday";
        break;
    default:
        break;
    }

}
short NumberOfDaysInAMonth(short Month, short Year) {
    if (Month < 1 || Month > 12)
        return 0;
    int days[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];
}
short CountDaysFromTheBeginningOfYear(stDate Date) {
    short NumberOfDays = 0;
    for (short i = 1; i <= Date.Month; i++)
    {
        if (i != Date.Month)
        {
            NumberOfDays += NumberOfDaysInAMonth(i, Date.Year);
        }
        else
        {
            NumberOfDays += Date.Day;
        }

    }


    return NumberOfDays;

}
short DayNumber(short Day, short Month, short Year) {
    short a = (14 - Month) / 12;
    short y = Year - a;

    short m = Month + (12 * a) - 2;

    return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}
short DayNumber(stDate Date) {
    short a = (14 - Date.Month) / 12;
    short y = Date.Year - a;

    short m = Date.Month + (12 * a) - 2;

    return (Date.Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}

bool IsEndOfWeek(stDate Date) {
    if (DayNumber(Date)==0)
    {
        return 1;
    }


    return 0;
}
bool IsWeekend(stDate Date) {
    if (DayNumber(Date) == 6)
    {
        return 1;
    }


    return 0;
}
bool IsBusinessDay(stDate Date) {
    if (!IsWeekend(Date))
    {
        return 1;
    }


    return 0;
}
short DaysUntilTheEndOfWeek(stDate Date) {
    if (!IsEndOfWeek(Date))
    {
        return (6-DayNumber(Date));
    }
    return 0;


}
short DaysUntilTheEndOfMonth(stDate Date){
    short NOfDaysForTheMonth = NumberOfDaysInAMonth(Date.Month, Date.Year);
    if (Date.Day!= NOfDaysForTheMonth)
    {
        return (NOfDaysForTheMonth - Date.Day);
    }
    return 0;
}
short DaysUntilTheEndOfYear(stDate Date) {
    if (isLeapYear(Date.Year))
    {
        return (366 - CountDaysFromTheBeginningOfYear(Date));
    }

    return (365 - CountDaysFromTheBeginningOfYear(Date));
}
stDate GetSystemDate() {
    time_t t = time(nullptr);
    tm local_time;
    localtime_s(&local_time, &t);

    stDate date;
    date.Year = local_time.tm_year + 1900;
    date.Month = local_time.tm_mon + 1;
    date.Day = local_time.tm_mday;

    return date;
}
void PrintDate(stDate Date) {
    cout << Date.Day << "/" << Date.Month << "/" << Date.Year;


}
int main()
{
    stDate Date = GetSystemDate();
    cout << "Today is " << GetWeekDayName((enWeekday)DayNumber(Date)) << ", ";
    PrintDate(Date);
    cout << "\nIs it End Of Week ? ";
    if (IsEndOfWeek(Date))
    {
        cout << "\n Yes its The End Of Week.";
    }
    else
    {
        cout << "\n No its Not The End Of Week.";
    }
    cout << "\n\nIs it Weekend ? ";
    if (IsWeekend(Date))
    {
        cout << "\n Yes its Weekend.";
    }
    else
    {
        cout << "\n No its Not Weekend.";
    }
    cout << "\n\nIs it Business Day ? ";
    if (IsBusinessDay(Date))
    {
        cout << "\n Yes itsBusiness Day.";
    }
    else
    {
        cout << "\n No its Not Business Day.";
    }

    cout << "\n\nDays until end of week :  "<<DaysUntilTheEndOfWeek(Date);
    cout << "\nDays until end of Month :  " << DaysUntilTheEndOfMonth(Date);
    cout << "\nDays until end of Year :  " << DaysUntilTheEndOfYear(Date);

    system("pause>0");
}

