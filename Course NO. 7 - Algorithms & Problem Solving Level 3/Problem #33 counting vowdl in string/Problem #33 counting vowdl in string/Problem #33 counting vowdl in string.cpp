#include <iostream>
#include <string>
using namespace std;
string ReadAstring(string Massage) {
	string Word;
	cout << Massage << "\n";
	getline(cin, Word);
	return Word;
}
bool isvowel(char ch) {
	tolower(ch);
	return (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');
}
short CountVowel(string Word) {
	short counter = 0;
	for (short i = 0; i < Word.length(); i++)
	{
		if (isvowel(Word[i]))
		{
			counter++;
		}
	}
	



	return counter;
}
int main()
{
	cout <<"The num Of Vowel char in word : " << CountVowel(ReadAstring("Enter A String : "));
}
