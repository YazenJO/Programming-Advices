#include <iostream>
#include <cmath>
using namespace std;
const float Pi = 3.14;
 float Area( float a, float b) {
	 float area;

	area = Pi * ((b * b) / 4) * (2 * a - b) / (2 * a + b);

	return area;
}
int main()
{
	short a = 0, b = 0;

	cout << "enter a and b to calculate circle area inscribed in on iscosceles Trinagle" << endl;
	cin >> a >> b;

	
	cout << "The area is : " << Area(a,b) << endl;
	cout << "The result with floor = " << floor(Area(a, b)) << endl;


}

