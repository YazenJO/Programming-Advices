#include <iostream>
using namespace std;
int ReadNumber(string);//decleration
int SumTwoNumbers() {
	int num1 = ReadNumber("Enrer Number 1");
	int num2 = ReadNumber("Enter Number 2");
	return num1 + num2;



}
int ReadNumber(string Massage ) {
	int Num;
	cout << Massage << '\n';
	cin >> Num;
	
	return Num;  
}


int main()
{
	cout<<SumTwoNumbers();
}

