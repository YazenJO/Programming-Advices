#include <iostream>
using namespace std;

void ReadGradeData(short x[2]) {
	cout << "Enter Grade 1" << endl;
	cin >> x[0];

	cout << "Enter Grade 2" << endl;
	cin >> x[1];

	cout << "Enter Grade 3" << endl;
	cin >> x[2];

}
float Avrg(short x[2]) {
	 

	return (x[0] + x[1] + x[2]) / 3;
}
 void PrintGradeData(short x[2]){
	cout << "*************************" << endl;
	cout << "The avg is " << Avrg(x) << endl;
		

	}
int main()
{
	short x[2];
	ReadGradeData(x);
	Avrg(x);
	PrintGradeData(x);
}
