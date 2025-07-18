#include <iostream>
using namespace std;
string ReadACapitaletters(string Massage) {
	string Letters;
	cout << Massage << "\n";
	cin >> Letters;

	return Letters;
}
bool GuessPassword(string password) {
	string Word = "";
	int Trail = 1;
	for (int i = 1; i <= 26; i++) {

		for (int j = 1; j <= 26; j++) {

			for (int k = 1; k <= 26; k++)
			{
				Word += char(i + 64);
				Word += char(j + 64);
				Word+=char(k + 64);
				cout << "Treail [" << Trail << "]" << Word << "\n";
				if (password == Word) {

					cout << "Passworcd is " << password << endl;
					cout << "Found After " << Trail << " Trial(s)"<< endl;
					return true;
				}
				Word = "";
				Trail++;
			}

		}
	}
	
}


int main()
{

	GuessPassword(ReadACapitaletters("Enter 3 letters Password All Capital"));
	
}

