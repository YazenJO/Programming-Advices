#include <iostream>
using namespace std;


void Swap(short &num1, short &num2) {
	short s;
	s = num1;
	num1 = num2;
	num2 = s;
	
}

int main() {
	short a=0, b;
	cin >> a >> b;

	cout << "The Numbers Before Swape is : " << a << "  " << b << endl;

  Swap(a, b);
  cout << a << " " << b << endl;
	










}