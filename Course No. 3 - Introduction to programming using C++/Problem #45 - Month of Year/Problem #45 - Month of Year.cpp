 #include <iostream>
using namespace std;
enum enMonthes{ Jonuary=1,February=2,March=3,April=4,May=5,June=6,July=7,August=8,September=9,October=10,November=11,December=12};
int ReadChoise() {
	int num;
	cout << "Enter a Num\n";
	cin >> num;
	
	return num;
}
void PrintStatic() {
	cout << "************************************\n" << endl;
	    cout << ".1  Print Jonuary\n";
		cout<<".2  Print February\n";
		cout<<".3  Print March\n";
		cout<<".4  Print April\n";
		cout<<".5  Print May\n";
		cout<<".6  Print June\n";
		cout<<".7  Print July\n";
		cout<<".8  Print August\n";
		cout<<".9  Print September\n";
		cout<<".10 Print October\n";
		cout<<".11 Print November\n";
		cout<<".12 December\n";
  cout << "************************************\n" << endl;
}
void Seclection(int choise) {
	enMonthes Month;
	Month = (enMonthes)choise;
	switch (Month)
	{
	case Jonuary:
		cout << "Jonuary" << endl;
		break;
	case February:
		cout << "February" << endl;
		break;
	case March:
		cout << "March" << endl;
		break;
	case April:
		cout << "April" << endl;
		break;
	case May:
		cout << "May" << endl;
		break;
	case June:
		cout << "June" << endl;
		break;
	case July:
		cout << "July" << endl;
		break;
	case August:
		cout << "August" << endl;
		break;
	case September:
		cout << "September" << endl;
		break;
	case October:
		cout << "October" << endl;
		break;
	case November:
		cout << "November" << endl;
		break;
	case December:
		cout << "December" << endl;
		break;
	default:
		cout << "Wrong number " << endl;
		break;
	}
	
}
int main()
{
	PrintStatic();
	Seclection(ReadChoise());
}
