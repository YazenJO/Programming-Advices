#include <iostream>
#include <cmath>
using namespace std;
const float Pi = 3.14;
float Areaofcircle(float n) {
	float area;

	area = (Pi) * (pow(n, 2));

	return area;



}
int main()
{
	
	float r;

	cout << "Enter r to calculate circle area " << endl;
	cin >> r;

	


	cout << "The Area = " << Areaofcircle(r) << endl;
	cout << "The Area With ceil =  " << ceil(Areaofcircle(r)) << endl;









}
