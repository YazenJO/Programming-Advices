#include <iostream>
#include <string>
using namespace std;
struct strings {
	string s1;
	string s2;
	string s3;


};

int main()
{
	strings s;
	string S1;
	
	cout << "Please Enter s1 :" << '\n';
	getline(cin, s.s1);

	cout << "Please Enter s2 :" << '\n';
	cin >> s.s2;

	cout << "Please Enter s3 :" << '\n';
	cin >> s.s3;

	S1 = s.s2 + s.s3;
	int Sum = stoi(s.s2) * stoi(s.s3);
	cout << "*******************************" << endl;
	cout << "The lengh of string1 is: " << s.s1.length() << '\n';
	cout << "Characters at 0,2,4,7 are  " << s.s1[0] << "  " << s.s1[2] << "  " << s.s1[4] << "  " << s.s1[7] << '\n';
	cout << "Comcatematomg Stromg 2 amd string 3 is:" << S1 << '\n';
	cout << stoi(s.s2) << " * " << stoi(s.s3);
	cout << "= " << Sum;






	return 0;
}
