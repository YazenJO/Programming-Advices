#include <iostream>
#include <cmath>
using namespace std;

const int secperday = 24 * 60 * 60;
const int secperhour = 60 * 60;
const int secpermin = 60;

int main()
{
	short days = 0, hours = 0, min = 0, sec = 0, total_days = 0, total_hours = 0, total_minuts = 0, total_sec = 0, reminder = 0;

	cout << "Enter secands" << endl;
	cin >> sec;
	total_days = (sec / secperday);
	reminder = (sec % secperday);
	total_hours = (reminder / secperhour);
	reminder = reminder % secperhour;
	total_minuts = (reminder / secpermin);
	reminder = (reminder % secpermin);
	total_sec = (reminder);

	cout << total_days << ":" << total_hours << ":" << total_minuts << ":" << total_sec << endl;
	cout << "The result with ceil = "<<'\n'<< round(total_days) << ":" << round(total_hours) << ":" << round(total_minuts) << ":" << round(total_sec) << endl;
}

