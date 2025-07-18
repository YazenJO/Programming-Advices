#include <iostream>
#include<cmath>
using namespace std;
struct stTime {
	unsigned short day;
	unsigned short hours;
	unsigned short min;
	unsigned short sec;
	

 };
stTime ReadTimeInfo() {
	stTime T;

	cout << "Enter Days" << endl;
	cin >> T.day;

	cout << "Enter hours" << endl;
	cin >> T.hours;

	cout << "Enter minuts" << endl;
	cin >> T.min;

	cout << "Enter secands" << endl;
	cin >> T.sec;

	return T;
}
double total(stTime T) {
	double total;


	total = T.day * 86400 + T.hours * 3600 + T.min * 60 + T.sec;

	return total;
}

int main()
{

	

	stTime TimeInfo = ReadTimeInfo();
	
	cout << "The time in sec is : " << total(TimeInfo) << endl;
	cout << "The result with round  = " << round(total(TimeInfo)) << endl;

}

