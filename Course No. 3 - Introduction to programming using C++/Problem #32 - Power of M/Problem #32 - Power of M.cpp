#include <iostream>
#include <cmath>
using namespace std;
int main()
{
	short Num, M=1;
	cout << "Enter Num and M to ger Num^M :) " << endl;
	cin >> Num>> M;

	cout << pow(Num, M) << endl;
	cout << "The result with round  =  " << round(pow(Num, M)) << endl;



}
