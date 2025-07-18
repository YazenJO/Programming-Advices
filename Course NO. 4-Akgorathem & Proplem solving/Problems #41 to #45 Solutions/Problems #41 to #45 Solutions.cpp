#include <iostream>
using namespace std;

//problem 41

//float ReadAPositiveNumber(string Massage) {
//		short num;
//		do {
//			cout << "Enter A Number\n";
//			cin >> num;
//	
//		} while (num < 0);
//			return num;
//	}
//float calculateDayToWeek(float Days) {
//
//	return Days / 7;
//}
//float calculatehourTDays(float Hours) {
//	return Hours / 24;
//}
//int main()
//{
//	float hours = ReadAPositiveNumber("Enter The Number Of Hours : \n");
//	float Days = calculatehourTDays(hours);
//	float Weeks = calculateDayToWeek(Days);
//	
//	cout << "Number Of Days is : " << Days<<"\n";
//	cout << "Number Of Weeks is : " << Weeks << endl;
//
//}

//problem 42

//struct stNumber {
//	float sec,min,hours,days,total;
//	
//
//
//};
//float ReadAPositiveNumber(string Massage) {
//			short num;
//			do {
//				cout << Massage<<"\n";
//				cin >> num;
//		
//			} while (num < 0);
//				return num;
//		}
//stNumber ReadTaskduration(){
//	stNumber NumberOf;
//	NumberOf.sec = ReadAPositiveNumber("Enter The Number Of Sec \n");
//	NumberOf.min = ReadAPositiveNumber("\nEnter The Number Of min ");
//	NumberOf.hours = ReadAPositiveNumber("\nEnter The Number Of hours ");
//	NumberOf.days = ReadAPositiveNumber("\nEnter The Number Of days ");
//	return NumberOf;
//}
//float TotalSec(stNumber n) {
//	float t;
//	n.days *= 24 * 60 * 60;
//	n.hours *= 60 * 60;
//	n.min *= 60;
//	
//	t = n.days + n.hours + n.min + n.sec;
//	return t;
//
//
//}
//int main() {
//	
//	cout <<"Toltal of Sec is : " << TotalSec(ReadTaskduration()) << endl;
//	
//	
//
//
//}

//problem 43

//struct secper {
//    const int secperday = 24 * 60 * 60;
//	const int secperhour = 60 * 60;
//	const int secpermin = 60;
//};
//struct total_Of{
//	long int sec;
//	short days ,hours, min;
//	secper per;
//};
//int ReadAPositiveNumber(string Massage) {
//			int num;
//			do {
//				cout << Massage<<"\n";
//				cin >> num;
//		
//			} while (num < 0);
//				return num;
//		}
//total_Of Calculationtotal( int sec) {
//	total_Of t;
//	int reminder;
//	t.days= floor(sec / t.per.secperday);
//	reminder = (sec % t.per.secperday);
//	t.hours = floor(reminder / t.per.secperhour);
//	reminder = reminder % t.per.secperhour;
//	t.min = floor(reminder / t.per.secpermin);
//	reminder = (reminder % t.per.secpermin);
//	t.sec = (reminder);
//
//	return t;
//
//
//
//}
//void PrintResult(total_Of t) {
//	
//	cout << t.days << ":" << t.hours << ":" << t.min << ":" << t.sec << endl;
//
//
//
//
//}
//int main() {
//
//	PrintResult(Calculationtotal(ReadAPositiveNumber("Enter sec :")));
//
//	return 0;
//}

//problem 44

//enum enDays { Sunday = 1, Monday = 2, Tuesday = 3, Wednesday = 4, Thursday = 5, Friday = 6, Saturday = 7 };
//enDays ReadAPositiveNumber(string Massage,int From,int To) {
//			short num;
//			do {
//
//
//
//				cout << Massage << "\n";
//				cin >> num;
//				
//
//			} while (num < From || num > To);
//				return (enDays)num;
//		}
//string  GetDayOfWeek(enDays Day) {
//	
//	switch (Day)
//	{
//	case Sunday:
//		return  "Sunday\n ";
//	case Monday:
//		return  "Monday\n ";
//	case Tuesday:
//		return  "Tuesday\n";
//	case Wednesday:
//		return  "Wednesday\n";
//	case Thursday:
//		return  "Thursday\n";
//	case Friday:
//		return  "Friday\n";
//	case Saturday:
//	default:
//		return  "WrongDay\n";
//	}
//
//}
//int main() {
//
//
//	cout<<GetDayOfWeek(ReadAPositiveNumber("Enter The Number Of Day",1,7));
//
//}

//problem 45

//enum enMonthes { Jonuary = 1, February = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, September = 9, October = 10, November = 11, December = 12 };
//enMonthes ReadNumberInRange(string Massage, int From, int To) {
//				short num;
//				do {
//	
//	
//	
//					cout << Massage << "\n";
//					cin >> num;
//					
//	
//				} while (num < From || num > To);
//					return (enMonthes)num;
//			}
//string GetMonthOfYear(enMonthes month) {
//	switch (month)
//	{
//	case Jonuary:
//		return  "Jonuary\n ";
//	case February:
//		return  "February\n ";
//	case March:
//		return  "March\n ";
//	case April:
//		return  "April\n ";
//	case May:
//		return  "May\n ";
//	case June:
//		return  "June\n ";
//	case July:
//		return  "July\n ";
//	case August:
//		return  "August\n ";
//	case September:
//		return  "September\n ";
//	case October:
//		return  "October\n ";
//	case November:
//		return  "November\n ";
//	case December:
//		return  "December\n ";
//	default:
//		return  "Wrong Month\n ";
//	}
//
//
//
//
//
//
//
//}
int main() {
//	cout<<GetMonthOfYear(ReadNumberInRange("Enter The Number of The month u want : ", 1, 12));
cout << 345678 % 24 * 60;
}

