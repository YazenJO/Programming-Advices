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
short DayNumber(stDate Date) {
    short a = (14 - Date.Month) / 12;
    short y = Date.Year - a;

    short m = Date.Month + (12 * a) - 2;

    return (Date.Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
}
bool IsWeekend(stDate Date) {
    if (DayNumber(Date) == 6 || DayNumber(Date) == 5)
    {
        return 1;
    }


    return 0;
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
stDate CalculateVactationReturnDate(stDate Date1,short NOfDays)  {
   
   
    short NOfVactatuinDays = 0;
   
    while (NOfVactatuinDays <= NOfDays)
    {
       
        if (!IsWeekend(Date1))
        {
            
            NOfVactatuinDays++;
        }
       Date1 = IncreaseDateByOneDay(Date1);
        
    }




    
    return Date1;
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
    short VactinDaysNumber = 0;
    cout << "Vaction Strats :\n";
    stDate VactinStart = ReadFullDate();
    cout << "\nEnter Vaction Days : ";
    cin >> VactinDaysNumber;
    stDate VactioEnd = CalculateVactationReturnDate(VactinStart, VactinDaysNumber);
    cout << "Return Date : ";
    PrintDate(VactioEnd);
   
    


}
  
