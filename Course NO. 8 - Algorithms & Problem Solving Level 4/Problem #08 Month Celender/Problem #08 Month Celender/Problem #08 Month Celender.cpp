#include <iostream>
using namespace std;

enum enMonthes { January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December };
enum enWeekday {
    Sunday = 0,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
};
bool IsLeapYear(short Year) {


    return (Year % 400 == 0 || Year % 4 == 0 && Year % 100 != 0);


}
string GetMonthName(enMonthes Month) {
    switch (Month)
    {
    case January:
        return "January";
        break;
    case February:
        return "February";
        break;
    case March:
        return "March";
        break;
    case April:
        return "April";
        break;
    case May:
        return "May";
        break;
    case June:
        return "June";
        break;
    case July:
        return "July";
        break;
    case August:
        return "August";
        break;
    case September:
        return "September";
        break;
    case October:
        return "October";
        break;
    case November:
        return "November";
        break;
    case December:
        return "December";
        break;
    default:
        break;
    }



}
string GetWeekDay(enWeekday Day) {
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
short NumberOfDaysInMonth(short Year, short Month) {
    if (Month < 1 || Month>12)
    {
        return 0;
    }
    return ((Month == 2) ? (IsLeapYear(Year) ? 29 : 28) : (Month == 4 || Month == 6 || Month == 9 || Month == 11) ? 30 : 31);

}
short DayNumber(short Day, short Month, short Year) {
    short a = (14 - Month) / 12;
    short y = Year - a;

    short m = Month + (12 * a) - 2;

    return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}
void PrintNumber(short Year,short Month,short index) {
   
    for(int i = 1; i <= NumberOfDaysInMonth(Year, Month); i++)
    {
        index++;

        if ( index != 7)
        {
            cout << i << "\t";
        }
     
        else {
            cout << i << "\n";
            index = 0;
        }
        
    }



}
void DayOfTheMonth(short Year, short Month) {

    int dNumber = DayNumber(1, Month ,Year);

    for (int i =1; i <= NumberOfDaysInMonth(Year, Month); i++)
    {
        cout << "\t";
        if (i == dNumber)
        {
            PrintNumber( Year, Month,i);
           
        }
        
    }
 
}
void PrintCelender(short Month, short Year) {
    //WeekDays Days = DayOfTheMonth(Year, Month);
    cout << "\t\n__________________" << GetMonthName((enMonthes) Month) << "____________________________\n";
	cout << "\nSun\tMon\tTue\tWed\tThu\tFri\tSat\t\n";
    DayOfTheMonth(Year, Month);
    cout << "\t\n_____________________________________________________\n";

}


short ReadDay() {

    short Day = 0;
    cin >> Day;
    while (Day < 1 && Day > 31) {

        cout << "Invalid Input!!" << endl;
        cin >> Day;

    }

    return Day;
}

short ReadMonth() {

    short Month = 0;
    cout << "\nEnter Month : ";
    cin >> Month;
    while (Month < 1 && Month > 12) {

        cout << "Invalid Input!!" << endl;
        cin >> Month;

    }

    return Month;
}

short ReadYear() {

    short Year = 0;
    cout << "\nEnter Year : ";
    cin >> Year;
    while (Year < 1) {

        cout << "Invalid Input!!" << endl;
        cin >> Year;

    }

    return Year;
}

int main()
{
   
	PrintCelender( ReadMonth(), ReadYear());
}
