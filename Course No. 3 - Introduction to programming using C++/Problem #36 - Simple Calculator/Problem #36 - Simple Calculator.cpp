#include <iostream>
using namespace std;

int a, b;

void ReadNumbers() {
	
		cout << "Enter number 1 \n";
		cin >> a;
		cout << "Enter number 1 \n";
		cin >> b;
	
}
char ReadOpreation() {
	char Opreation;
	cout << "Enter the Operation u want (+ , - , * ,/)\n";
	cin >> Opreation;
		return Opreation;
}
void Calculate(char Opreation) {

	switch (Opreation)
	{
	case '+':
		cout << a << "+"<< b <<" = " << a + b << '\n';
		break;

	case '-':
		cout << a - b << '\n';

		break;
	case '*':
		cout << a * b << '\n';

		break;
	case '/':
		cout  << a / b << '\n';
		break;

	default:
		cout << "Wrong Opreation" << endl;
		
	}




}

int main()
{

	
	ReadNumbers();
	Calculate(ReadOpreation());



}

