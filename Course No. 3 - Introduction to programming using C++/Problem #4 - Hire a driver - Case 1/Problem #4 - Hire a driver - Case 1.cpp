#include <iostream>
using namespace std;

short ReadAgeData() {
	short age;
	cout << "Enter your age " << endl;
	cin >> age;

	return age;

}
string ReadDriverLicenseData() {
	string Data;
	cout << "Are u have a Driver license" << endl;
	cin >> Data;
	return Data;
}
void HiredOrRedjected(short age,string Data) {
	if (age > 21 && Data == "Yes")
		cout << "Hired" << endl;
	else
		cout << "Rejected" << endl;


}
int main()
{
	
	HiredOrRedjected(ReadAgeData(),ReadDriverLicenseData());

}

