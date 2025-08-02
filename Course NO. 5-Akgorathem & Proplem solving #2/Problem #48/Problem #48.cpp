#include <iostream>
#include<cmath>


using namespace std;

float ReadANumber(string Massage) {
	float Number = 0;
	cout << Massage << '\n';

	cin >> Number;


	return Number;
}

float AfterPointDigitForMines(float Number) {
	int N = -1 * Number;

	return  -1 * (Number + N);



}
int MyFloor(float Number) {
	if (Number > 0) {

		


			return Number;

	}
	else {
		if (AfterPointDigitForMines(Number) >= 0.1) {
			
			Number--;
			return Number;

		}
		else
		{
			
			return Number;
		}

	}




}

int main()
{
	float Number = ReadANumber("Enter A Number");
	cout << "My Floor : " << MyFloor(Number);
	cout << "\nC++ Floor : " << floor(Number);
}



