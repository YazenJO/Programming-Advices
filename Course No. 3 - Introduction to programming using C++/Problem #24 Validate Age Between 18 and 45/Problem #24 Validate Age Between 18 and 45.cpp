#include <iostream>
using namespace std;
short age;
short ReadAge() {
	cout << "Enter Age " << endl;
	cin >> age;


	return age;
}
bool VaildOrNot(short age) {
	if (age >= 18 && age <= 45)
		return true;
	return false;

}
void PrintResult(bool result) {
	if (result)
		cout << "Valid" << endl;
	else
		cout << "Invaild" << endl;

}
int main()
{

	PrintResult(VaildOrNot(ReadAge()));
}

