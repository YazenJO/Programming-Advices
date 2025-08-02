#include <iostream>
using namespace std;
void AAABACAD() {

	for (char a = 65; a <= 90; a++) {
		cout << "Letter :" << a << endl;
		for (char b = 65; b <= 90; b++) {
			cout << a << b;
			cout << '\n';

		}

		cout << '\n';
	}

}
int main()
{
	AAABACAD();
}

