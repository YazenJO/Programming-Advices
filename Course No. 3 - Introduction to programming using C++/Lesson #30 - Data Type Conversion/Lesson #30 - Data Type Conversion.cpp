#include <iostream>
#include <string>
using namespace std;
int main()
{
	string st1 = "43.22";
	int N1 = 20;
	double N2 = 33.5;
	float N3 = 55.23;
	int int_s;
	double d_s;
	string s_n;
	s_n = stod(st1);
	cout << st1 << endl;

	s_n = stof(st1);
	cout << st1 << endl;

	s_n = stoi(st1);
	cout << s_n << endl;

	st1 = to_string(N1);
	cout << st1 << endl;

	st1 = to_string(N2);
	cout << st1 << endl;

	st1 = to_string(N3);
	cout << st1 << endl;

	N3 = int(N3);
	cout << N3 << endl;

}
