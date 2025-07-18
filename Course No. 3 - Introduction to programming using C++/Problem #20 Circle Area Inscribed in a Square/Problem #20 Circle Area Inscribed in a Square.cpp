#include <iostream>
using namespace std;
const float Pi = 3.14;
float CircleArea(float l) {
	float area;
	area = ((l * l * Pi ) / (4 ));

	return area;
}
int main()
{

	float l = 0, area = 9;
	cout << "enter l to calculate circle areas along the circumference " << endl;
	cin >> l;
	
	cout << "the area is : " << CircleArea(l) << endl;
	cout << "The result with ceil = " << ceil(CircleArea(l)) << endl;
}

