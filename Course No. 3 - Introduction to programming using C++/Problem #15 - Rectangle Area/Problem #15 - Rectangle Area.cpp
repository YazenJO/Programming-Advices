#include <iostream>
using namespace std;
short AreaOfrectange(short a, short b) {
 

	return a * b;
}

int main()
{
	short num1, num2;
	cout << "Enter the lentgh and width" << endl;
	cin >> num1 >> num2;

	cout << "the area of rectangle is : " << AreaOfrectange(num1,num2) << endl;

}

