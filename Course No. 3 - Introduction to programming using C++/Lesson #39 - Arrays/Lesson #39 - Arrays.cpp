#include <iostream>
using namespace std;



int main()
{
    float grade[2] ;

    cout << "Enter Grade 1" << endl;
    cin >> grade[0];

    cout << "Enter Grade 2" << endl;
    cin >> grade[1];

    cout << "Enter Grade 3" << endl;
    cin >> grade[2];
    cout << "****************************" << endl;
    cout << "average of grades is = " << (grade[0] + grade[1] + grade[2]) / 3 << endl;
}
