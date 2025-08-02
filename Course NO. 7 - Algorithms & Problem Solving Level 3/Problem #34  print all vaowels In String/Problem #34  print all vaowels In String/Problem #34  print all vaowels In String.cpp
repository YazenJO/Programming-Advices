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
void GetVowelsInString(string Word,string &store) {
	
	
	for (int i = 0; i < Word.length(); i++)
	{
		if (isvowel(Word[i]))
		{
			store+= Word[i];
		}
	}
	
}
void Printstring(string s1) {
	for (int i = 0; i < s1.length(); i++)
	{
		cout << s1[i] << "     ";
	}
}
int main()
{
	string s1 = ReadAstring("Enter A String : ");
	string vowelChInSt;
	GetVowelsInString(s1, vowelChInSt);
	cout << "The num Of Vowel char in word : ";
	 Printstring(vowelChInSt);
}
