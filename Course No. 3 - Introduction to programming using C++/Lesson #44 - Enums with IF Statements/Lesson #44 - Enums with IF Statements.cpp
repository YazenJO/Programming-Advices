#include <iostream>
using namespace std;
enum enColor { Red = 1, Blue = 2,Green=3,Yallow=4 };
void PrintSeclection() {
	cout << "***************************\n\n";
	cout << "Please choose the number of your color ? \n";
	cout << "(1) Red\n";
	cout << "(2) Blue\n";
	cout << "(3) Green\n";
	cout << "(4) Yellow\n";
	cout << "***************************\n\n";
	cout << "Your Choice ?\n";




}
int ColorSeclection(int a) {
	enColor Color;
	Color = (enColor)a;

	if (a == enColor::Red)
		system("color 4F");
	else if (a == enColor::Blue)
		system("color 1F");
	else if (a == enColor::Green)
		system("color 2F");
	else if (a == enColor::Yallow)
		system("color 6F");
	else
	{
		cout << "Wrong number\n";
		system("color 4F");

	}

	return a;

}
int main()
{
	int c;
	PrintSeclection();
	
	cin >> c;
	cout << ColorSeclection(c);
	return 0;
}

