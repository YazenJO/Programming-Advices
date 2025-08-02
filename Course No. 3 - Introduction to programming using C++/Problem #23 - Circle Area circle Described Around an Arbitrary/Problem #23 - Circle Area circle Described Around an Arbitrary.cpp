#include <iostream>
#include<cmath>
using namespace std;
const float Pi = 3.14;
float Area(float a, float b, float c) {

	float area,p;

	p = (a + b + c) / (2);

	area = Pi * pow((a * b * c) / (4 * sqrt(p * (p - a) * (p - b) * (p - c))), 2);

	return area;
}
int main()
{
	float a, b, c;
	cout << "Enter a ,b , c to calculate circle area circle described around on an arbiray triangle" << endl;
	cin >> a >> b >> c;


	cout << "The Area = " << Area(a,b,c) << endl;
	cout << "The result with round  = " << round(Area(a, b, c));

}
