#include <iostream>
#include<cmath>
using namespace std;

int main()
{

	float num = 0;
	cout << "Entaer a number" << endl;
	cin >> num;
	cout << "NUM^2 = " <<pow(num,2) << "\n" << "NUM^3 = " << pow(num, 3) << "\n" << "NUm^4 = " << pow(num, 4) << endl;
	cout << "The result with round is  = "<<'\n' << "NUM^2 (R)= " << round(pow(num, 2)) << "\n" << "NUM^3 (R) = " << round(pow(num, 3)) << "\n" << "NUm^4 (R) = " << round(pow(num, 4)) << endl;

}

