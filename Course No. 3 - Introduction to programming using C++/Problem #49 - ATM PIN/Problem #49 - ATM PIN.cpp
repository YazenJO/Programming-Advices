#include <iostream>
using namespace std;
short PIN;
short ReadPIN() {
	
	cout << "Enter the pin" << endl;
	cin >> PIN;

	return PIN;
}
bool Check(short Pin) {
	if (PIN == 1234)
		return true;
	return false;
}
void Printresult(bool result)
{
	if (result)
		cout << "Your Balance is :" << 7500 << endl;
	else
		cout << "Wrong PIn" << endl;

}

int main()
{
	Printresult(Check(ReadPIN()));
}
