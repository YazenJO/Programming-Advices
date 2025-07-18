#include <iostream>
#include <cmath>
using namespace std;

float AreaOfrectange(float num1, float num2) {
    float area;
    area = (num1) * (sqrt((pow(num2, 2)) - (pow(num1, 2))));
    return area;
}

int main()
{
    short a, d;
    cout << "Enter a and d \n" << endl;
    cin >> a >> d;
  
    cout << "The area of rectangle is :" << AreaOfrectange(a, d) << endl;
    

}
