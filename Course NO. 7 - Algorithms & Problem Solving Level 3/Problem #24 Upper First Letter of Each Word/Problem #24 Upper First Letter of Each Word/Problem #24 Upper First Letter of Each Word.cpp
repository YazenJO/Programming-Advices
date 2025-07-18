#include <iostream>
#include <string>
using namespace std;
string ReadAstring(string Massage) {
	string Word;
	cout << Massage << "\n";
	getline(cin, Word);
	return Word;
}

void UpperFirstLetterOfEachWord(string &s1) {
	bool IsFirstLetter = true;
	for (int i = 0; i < s1.length(); i++)
	{
		if (s1[i] != ' ' && IsFirstLetter) {
			s1[i]= (char)(s1[i]-32);
		}
		IsFirstLetter = (s1[i] == ' ' ? true : false);
	}


}

int main()
{
	string word = ReadAstring("Enter A Word");
	UpperFirstLetterOfEachWord(word);
	cout << word;
	return 0;
}