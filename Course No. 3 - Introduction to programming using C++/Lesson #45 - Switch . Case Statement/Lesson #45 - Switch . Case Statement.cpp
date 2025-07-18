#include <iostream>
using namespace std;
enum enColor {Red=1,Bule=2,Green=3,Yallow=4};
void ColorSelection(int b)
{
	enColor a;
	a = (enColor)b;

	switch (a ) {
	case enColor::Red:
		system("color 4F");
		break;
	case enColor::Bule:
		system("color 1F");
		break;
	case enColor::Green:
		system("color 2F");
		break;
		case enColor::Yallow:
			system("color 6F");
			break;
	}

}
int ReadColorNUm() {
	int v;
	cin >> v;
	return v;
}
void PrintChoises() {
	cout << "***************************\n\n";
	cout << "Please choose the number of your color ? \n";
	cout << "(1) Red\n";
	cout << "(2) Blue\n";
	cout << "(3) Green\n";
	cout << "(4) Yellow\n";
	cout << "***************************\n\n";
	cout << "Your Choice ?\n";
}
int main()
{
	
	PrintChoises();
	ColorSelection(ReadColorNUm());
}