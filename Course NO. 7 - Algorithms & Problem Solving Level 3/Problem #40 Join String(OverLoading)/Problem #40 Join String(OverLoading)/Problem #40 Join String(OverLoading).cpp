#include <iostream>
#include <string>
#include <vector>
using namespace std;

string JoinString(vector <string> S1, string demin) {
	string Word = "";
	short VSize = S1.size();
	short countert = 0;
	for (string& sword : S1) {
		countert++;
		if (countert == VSize)

			Word += sword;

		else
			Word += sword + demin;
	}


	return Word;

}
string JoinString(string S1[], short ArraySize, string demin) {
	string Word = "";

	for (int i = 0; i < ArraySize; i++)
		Word += S1[i] + demin;



	return Word.substr(0, Word.length() - demin.length());

}
int main()
{

	string AString[] = { "Yazen","Ahmed","Khalid" };
	cout << JoinString(AString, 3, ",");
}

