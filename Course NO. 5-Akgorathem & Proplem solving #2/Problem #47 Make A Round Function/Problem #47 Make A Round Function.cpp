#include <iostream>
#include<cmath>
using namespace std;

float ReadANumber(string Massage) {
	float Number = 0;
	cout << Massage << '\n';

	cin >> Number;


	return Number;
}
float AfterPointDigitForPositive (float Number) {


	int n = Number;


	return Number - n;


}
float AfterPointDigitForMines(float Number) {
	int N = -1 * Number;

	return  -1*(Number + N);



}
int MyRoundForPositive(float Number) {
	if (Number > 0) {

		if (AfterPointDigitForPositive(Number) >= 0.5) {

			Number += 1;
			return Number;

		}
		else
		{
			return Number;
		}







	}
	else {
		if (AfterPointDigitForMines(Number) >= 0.5) {

			Number -= 1;
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
	
	cout <<"My Round : "<<MyRoundForPositive(Number);
	cout <<"\nC++ Fun : "<<round(Number);

}

