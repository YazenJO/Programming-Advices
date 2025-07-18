#include <iostream>
using namespace std;

short Marks[3];

void ReadMArks() {


	cout << "Enter Mark 1" << endl;
	cin >> Marks[0];

	cout << "Enter Mark 2" << endl;
	cin >> Marks[1];

	cout << "Enter Mark 3" << endl;
	cin >> Marks[2];



}
float CalculateAvg(short Marks[3]) {

	return (Marks[0] + Marks[1] + Marks[2]) / 3;

}
bool PassOrFail(float Avg) {
	if (Avg >= 50)
		return true;
	return false;



}

void PrintResult(bool batat) {
	if (batat)
		cout << "Pass" << endl;
	else
		cout << "Fail" << endl;

}


int main()
{ 

	ReadMArks();

	PrintResult(PassOrFail(CalculateAvg(Marks)));
}
