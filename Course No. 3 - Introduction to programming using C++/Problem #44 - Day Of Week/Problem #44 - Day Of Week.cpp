
#include <iostream>
using namespace std;
int a;
enum enDays{Sunday=1,Monday=2,Tuesday=3,Wednesday=4,Thursday=5,Friday=6,Saturday=7};
void PrintStatics() {
	
	cout << "********************************\n" << endl;
	    cout << ".1 Print Sunday" << endl;
		cout<<".2 Print Monday" << endl;
		cout<<".3 Print Tuesday" << endl;
		cout<<".4 Print Wednesday" << endl;
		cout<<".5 Print Thursday" << endl;
		cout<<".6 Print Friday" << endl;
		cout<<".7 Print Saturday\n" << endl;
		cout << "********************************" << endl;




}
int ReadNum() {
	
		cout << "Enter A Number" << endl;
		cin >> a;
	return a;
}
void TheChoise(int num) {

	
	
	enDays Day;
	Day = (enDays)a;
	switch (Day)
	{
	case Sunday:
		cout << "Sunday\n ";
		break;
	case Monday:
		cout << "Monday\n ";
		break;
	case Tuesday:
		cout << "Tuesday\n";
		break;
	case Wednesday:
		cout << "Wednesday\n";
		break;
	case Thursday:
		cout << "Thursday\n";
		break;
	case Friday:
		cout << "Friday\n";
		break;
	case Saturday:
		break;
	default:
		cout << "WrongDay\n";
		break;
	}





}
int main()
{
	PrintStatics();
	TheChoise(ReadNum());

}