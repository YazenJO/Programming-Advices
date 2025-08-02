#include <iostream>
using namespace std;
float ReadANumber(string Massage) {
	float Number = 0;
	cout << Massage << '\n';

	cin >> Number;


	return Number;
}
float MySqrt(int Number) {

	return pow(Number, 0.5);
}
int main()
{
	int Number = ReadANumber("Enter A Number");
	cout << "\nMy MySqrt Result : " << MySqrt(Number) << endl;
	cout << "\nC++ sqrt Result: " << sqrt(Number) <<endl;
	return 0;

}

