#include <iostream>
using namespace std;

int main()
{

	float TotalBill = 0, Cachpaid = 0;
	cout << "Enter the Total of Bill" << endl;
	cin >> TotalBill;

	cout << "Enter the Cash paid" << endl;
	cin >> Cachpaid;

	cout << "The remainder is : " << Cachpaid - TotalBill << endl;


}

