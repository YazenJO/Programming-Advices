#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <ctime>
using namespace std;

class clsDate
{
private:
	short _Year;
	short _Month;
	short _Day;
    enum enMonthes {
        January = 1,
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
        December
    };



public:

	clsDate() {
       this->GetSystemDate();
	}
    clsDate(int Day, int Month, int Year) {
        _Year = Year;
        _Month = Month;
        _Day = Day;

    }
    clsDate(int Day, int Year) {
        GetDateFromDayOrderInYear(Day, Year);

    }
    clsDate(string Date) {
        vector <string> VDate;
        VDate = SplitString(Date,"/");
        _Day = stoi(VDate[0]);
        _Month = stoi(VDate[1]);
        _Year = stoi(VDate[2]);

    }

    void GetSystemDate() {

        // Get the current time
        time_t t = time(nullptr);
        // Convert it to local time
        tm now;
        localtime_s(&now, &t);


        // Store the date in the class members
        this->_Year = now.tm_year + 1900;
        this->_Month = now.tm_mon + 1;
        this->_Day = now.tm_mday;

    }
    vector<string> SplitString(string S1, string Delim) {
        vector<string> vString;
        short pos = 0;
        string sWord; // define a string variable
        // use find() function to get the position of the delimiters
        while ((pos = S1.find(Delim)) != std::string::npos) {
            sWord = S1.substr(0, pos); // store the word
            if (sWord != "") {
                vString.push_back(sWord);
            }
            S1.erase(0, pos + Delim.length()); // erase() until position and move to next word.
        }
        if (S1 != "") {
            vString.push_back(S1); // it adds the last word of the string.
        }
        return vString;
    }
    string ReplaceWordInString(string S1, string StringToReplace, string sRepalceTo) {
        short pos = S1.find(StringToReplace);
        while (pos != std::string::npos) {
            S1 = S1.replace(pos, StringToReplace.length(), sRepalceTo);
            pos = S1.find(StringToReplace); // find next
        }
        return S1;
    }
    void StringToDate(string DateString) {
        clsDate Date;
        vector<string> vDate;
        vDate = SplitString(DateString, "/");
        _Day = stoi(vDate[0]);
        _Month = stoi(vDate[1]);
        _Year = stoi(vDate[2]);

    }
    static string DateToString(clsDate Date) {

        return (to_string(Date._Day) + "/" + to_string(Date._Month) + "/" + to_string(Date._Year));


    }
    string DateToString() {

        return DateToString(*this);
    }
    static bool isLeapYear(short Year) {
        // if year is divisible by 4 AND not divisible by 100
        // OR if year is divisible by 400
        // then it is a leap year
        return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
    }
    static short NumberOfDaysInAMonth(short Month, short Year) {
        if (Month < 1 || Month > 12)
            return 0;
        int days[12] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        return (Month == 2) ? (isLeapYear(Year) ? 29 : 28) : days[Month - 1];
    }
    static short CountDaysFromTheBeginningOfYear(short Year, short Month, short Day) {
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
    void GetDateFromDayOrderInYear(int shortDateOrderInYear, int shortYear) {
        int RemainingDays = shortDateOrderInYear;
        int MonthDays = 1;
        this->_Year = shortYear;
        this->_Month = 1;

        while (true) {
            MonthDays = NumberOfDaysInAMonth(this->_Month, this->_Year);
            if (RemainingDays > MonthDays) {
                RemainingDays -= MonthDays;
                this->_Month++;
            }
            else {
                this->_Day = RemainingDays;
                break;
            }
        }
    }
    static void PrintNumber(short Year, short Month, short index) {

        for (int i = 1; i <= NumberOfDaysInAMonth(Year, Month); i++)
        {
            index++;

            if (index != 7)
            {
                cout << i << "\t";
            }

            else {
                cout << i << "\n";
                index = 0;
            }

        }



    }
    static void DayOfTheMonth(short Year, short Month) {

        int dNumber = DayNumber(1, Month, Year);

        for (int i = 1; i <= NumberOfDaysInAMonth(Year, Month); i++)
        {
            cout << "\t";
            if (i == dNumber)
            {
                PrintNumber(Year, Month, i);

            }

        }

    }
    static string GetMonthName(enMonthes Month) {
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
    static bool IsLastDayInMonth(clsDate Date) {
        return (Date._Day == NumberOfDaysInAMonth(Date._Month, Date._Year));
    }
    static bool IsLastMonthInYear(short Month) {
        return (Month == 12);
    }
    static bool IsDate1BeforeDate2(clsDate Date1, clsDate Date2) {
        return  (Date1._Year < Date2._Year) ? true : ((Date1._Year == Date2._Year) ? (Date1._Month < Date2._Month ? true : (Date1._Month == Date2._Month ? Date1._Day < Date2._Day : false)) : false);
    }
    static bool IsDate1EqualDate2(clsDate Date1, clsDate Date2) {
        if (Date1._Year = Date2._Year)
        {
            if (CountDaysFromTheBeginningOfYear(Date1._Year, Date1._Month, Date1._Day) == CountDaysFromTheBeginningOfYear(Date2._Year, Date2._Month, Date2._Day))
            {
                return 1;
            }
        }



        return 0;
    }
    static bool IsWeekend(clsDate Date) {
        if (DayNumber(Date._Day, Date._Month, Date._Year) == 6 || DayNumber(Date._Day, Date._Month, Date._Year) == 5)
        {
            return 1;
        }


        return 0;
    }

     void Print() {
    
        cout << _Day << "/" << _Month << "/" << _Year << endl;
    
    }
     static short DayNumber(short Day, short Month, short Year) {
         short a = (14 - Month) / 12;
         short y = Year - a;

         short m = Month + (12 * a) - 2;

         return (Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7;
     }
     short DayNumber() {
         return DayNumber(this->_Day, this->_Month, this->_Year);


     }
     static void PrintMonthCelender(short Month, short Year) {
         //WeekDays Days = DayOfTheMonth(Year, Month);
         cout << "\t\n__________________" << GetMonthName((enMonthes)Month) << "____________________________\n";
         cout << "\nSun\tMon\tTue\tWed\tThu\tFri\tSat\t\n";
         DayOfTheMonth(Year, Month);
         cout << "\t\n_____________________________________________________\n";

     }
     void PrintMonthCelender() {

         return PrintMonthCelender(this->_Month, this->_Year);

     }
     static void PrintYearCelender(short Year) {
         printf("\n  _________________________________\n");
         cout << "\n\t   Celendar - " << Year << "\n";
         printf("\n  _________________________________\n");
         for (int i = 1; i <= 12; i++)
         {
             PrintMonthCelender(i, Year);
         }
     }
     void PrintYearCelender() {
         return PrintYearCelender(this->_Year);
     }
      void AddDaysToDate(short NumberOfDaysToAdd) {//250>>>/3/10/2022
         while (NumberOfDaysToAdd > 0) {
             short NOfDaysInMonth = NumberOfDaysInAMonth(this->_Month, this->_Year);
             short ReminderOfDaysInTheMonth = NOfDaysInMonth - this->_Day;

             if (NumberOfDaysToAdd > ReminderOfDaysInTheMonth) {
                 NumberOfDaysToAdd -= ReminderOfDaysInTheMonth + 1; // Move to the first day of the next month
                 this->_Day = 1;
                 this->_Month++;
                 if (this->_Month == 13) {
                     this->_Month = 1;
                     this->_Year++;
                 }
             }
             else {
                 this->_Day += NumberOfDaysToAdd;
                 NumberOfDaysToAdd = 0;
             }
         }
     }
     static void IncreaseDateByOneDay(clsDate &Date) {
          if (IsLastMonthInYear(Date._Month) && IsLastDayInMonth(Date))
          {
              Date._Year++;
              Date._Day = 1; 
              Date._Month = 1;

          }
          else if (IsLastDayInMonth(Date))
          {
              Date._Month++;
              Date._Day = 1;
          }
          else
          {
              Date._Day++;
          }
      }
     void IncreaseDateByOneDay() {

        return IncreaseDateByOneDay(*this);


     }
     static short DiffrenceDaysBetweenDate1AndDate2(clsDate Date1, clsDate Date2) {
         short DiffDays = 0;
         if (IsDate1BeforeDate2(Date1, Date2)) {

             if (Date1._Year != Date2._Year)
             {
                 for (short i = Date1._Year; i < Date2._Year; i++)
                 {
                     if (isLeapYear(i))
                     {
                         DiffDays += 366;
                     }
                     else
                         DiffDays += 365;
                 }
             }
             if (Date1._Year == Date2._Year)
             {
                 DiffDays += CountDaysFromTheBeginningOfYear(Date2._Year, Date2._Month, Date2._Day) - CountDaysFromTheBeginningOfYear(Date1._Year, Date1._Month, Date1._Day);
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
     short DiffrenceDaysBetweenDate1AndDate2(clsDate Date2) {

         return DiffrenceDaysBetweenDate1AndDate2(*this, Date2);


     }
     static short CalculateVactationDaystDate(clsDate Date1, clsDate Date2) {
         short DiffrentDays = DiffrenceDaysBetweenDate1AndDate2(Date1, Date2);
         short NOfVactatuinDays = 0;
         while (Date1._Day <= DiffrentDays)
         {
             if (!IsWeekend(Date1))
             {
                 NOfVactatuinDays++;
             }
             Date1._Day++;
         }





         return NOfVactatuinDays;
     }
     short CalculateVactationDaystDate(clsDate Date2) {

         return CalculateVactationDaystDate(*this, Date2);

     }
    static string CalculateVactationReturnDate(clsDate Date1, short NOfDays) {


         short NOfVactatuinDays = 0;

         while (NOfVactatuinDays <= NOfDays)
         {

             if (!IsWeekend(Date1))
             {

                 NOfVactatuinDays++;
             }
             Date1.IncreaseDateByOneDay();

         }

         return Date1.DateToString();



     }
     string CalculateVactationReturnDate(short NOfDays) {

         return CalculateVactationReturnDate(*this, NOfDays);
     }
     static bool IsValidate(clsDate Date) {
         return ((Date._Month >= 1 && Date._Month <= 12) && (Date._Day >= 1 && NumberOfDaysInAMonth(Date._Month, Date._Year) >= Date._Day));

     }
     bool IsValidate() {

         return IsValidate(*this);

     }

};

