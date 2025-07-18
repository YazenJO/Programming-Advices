#include <iostream>
using namespace std;

void PrintPrimeNumbersBetween(int number1, int number2) {

	if (number1 < number2) {
		for (int i = number1; i <= number2; i++) {

			if (i == 2 || i == 3)
				cout << i << " ";

			if (i <= 7 && i % 2 != 0 && i != 2 && i != 3 && i != 1)
				cout << i << " ";

			if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i != 1) {
				cout << i << " ";

			}


		}
		cout << endl;
	}

	else {


		for (int i = number2; i <= number1; i++) {

			if (i == 2 || i == 3)
				cout << i << " ";

			if (i <= 7 && i % 2 != 0 && i != 2 && i != 3 && i != 1)
				cout << i << " ";

			if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i != 1) {
				cout << i << " ";

			}


		}
		cout << endl;

	}


}

int main()
{
	int From = 0, To = 0;
	cout << "Entrer two numbers (x,y) to claculate the prime number Between Them : \n";
	cout << "Entrer From Number : ";
	cin >> From;
	cout << "Entrer To Number : ";
	cin >> To;
	
	cout << "The  Prime numbers between   (" << From << ") And  (" << To << ")  is" << endl;
	PrintPrimeNumbersBetween(From, To);


}
