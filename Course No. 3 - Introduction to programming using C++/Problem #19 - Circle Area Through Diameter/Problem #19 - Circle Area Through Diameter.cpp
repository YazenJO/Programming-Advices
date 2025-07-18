#include <iostream>
#include <cmath>
using namespace std;
const float Pi = 3.14;
float AreaOfCircle(float a) {
	float area;


	area = ((Pi * (a * a)) / 4);


	return area;
}
int main()
{

	float d;
	cout << "Enter the D to calculate circle area " << endl;
	cin >> d;
	cout << "The circle area is : " <<AreaOfCircle(d) << endl;
	cout << "The result with ceil = " << ceil(AreaOfCircle(d)) << endl;

}

