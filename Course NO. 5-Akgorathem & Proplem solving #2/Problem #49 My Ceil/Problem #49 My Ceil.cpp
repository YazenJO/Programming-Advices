#include <iostream>
#include<cmath>


using namespace std;

float ReadANumber(string Massage) {
	float Number = 0;
	cout << Massage << '\n';

	cin >> Number;


	return Number;
}
float AfterPointDigitForPositive(float Number) {
	int N =  Number;

	return   (Number - N);



}
float AfterPointDigitForMines(float Number) {
	int N = -1 * Number;

	return  -1 * (Number + N);



}

int MyCeil(float Number) {
	if (Number>0)
	{
		if (AfterPointDigitForPositive(Number) >= 0) {
			return Number+1;
		}
		else
		{
			return Number;
		}

	}
	else
	{
		if (AfterPointDigitForMines(Number) >= 0) {

			return Number;

		}
	}


}

int main()
{
	float Number = ReadANumber("Enter A Number");
	cout << "My Ceil : " << MyCeil(Number);
	cout << "\nC++ Ceil : " << ceil(Number);
}



