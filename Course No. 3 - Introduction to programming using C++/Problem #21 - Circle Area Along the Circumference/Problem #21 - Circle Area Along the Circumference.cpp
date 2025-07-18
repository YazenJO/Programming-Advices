#include <iostream>
#include <cmath>
using namespace std;

const float Pi = 3.14;
float Area(float l) {
	float area;

	area = ((l * l) / (4 * Pi));

	return area;
}
int main()
{
	float l = 0;
	cout << "enter l to calculate circle areas along the circumference " << endl;
	cin >> l;
	
	cout << "the area is : " << Area(l) << endl;
	cout << "The result with floor = " << floor(Area(l)) << endl;


}


