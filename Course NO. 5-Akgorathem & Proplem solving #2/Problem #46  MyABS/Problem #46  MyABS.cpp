#include <iostream>
#include<cmath>
using namespace std;

int ReadANumber(string Massage) {
	int num;
	
		cout << Massage << "\n";
		cin >> num;

	
	return num;
}
int MyAbs(int Number) {
	if (Number < 0)
		return -Number;
	else
	{
		return Number;
	}

}


int main() {
	int Number = ReadANumber("Enter A Number");
	
	cout << "\nMy abs Result : " << MyAbs(Number);
	cout << "\nC++ abs Result : " << abs(Number);
	return 0;
}

