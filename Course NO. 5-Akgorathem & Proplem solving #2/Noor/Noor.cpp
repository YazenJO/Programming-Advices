#include <iostream>
using namespace std;
enum enPrimeNumber {Prime=1 ,NotPrime =2 };
int ReadPositiveNumber(string message) {
	int number;
	do{cout << message << endl;
	cin >> number;
	} while (number < 0);
	 
	
	return number; 
}

enPrimeNumber CheckIfPrime(int number) {
	int remainder = number/2; 
	for (int i = 2; i <= remainder; i++)
	{
		if (number % i == 0) {
			return enPrimeNumber::NotPrime;
		}

	}
	return enPrimeNumber::Prime;
}
void PrintNumber(enPrimeNumber ifPrime) {
	if (ifPrime == enPrimeNumber::Prime)
		cout << "PrimeNumber" << endl;
	else
		cout << "Not PrimeNumber"<<endl;
}void PrintNumberFromTo(int to, int from) {
	for (int i = from; i <= to; i++) {
		if (CheckIfPrime(i) == enPrimeNumber::Prime)
			cout << i << endl;
	}
	

}
int main() {
   
	PrintNumberFromTo( ReadPositiveNumber("enter to : "), ReadPositiveNumber("Enter from"));
}
