#include <iostream>
#include <string>
using namespace std;
string ReadAstring(string Massage) {
	string Word;
	cout << Massage << "\n";
	getline(cin, Word);
	return Word;
}
char InvertCharacter(char s1) {
	if (isupper(s1))
	{
		return tolower(s1);
	}
	else
	{
		return toupper(s1);

	}
	
}
string InvertLettersInStrting(string s1) {

	for (int i = 0; i < s1.length(); i++)
	{
		s1[i] = InvertCharacter(s1[i]);

	}
	return s1;

}
int main()
{
	string word = ReadAstring("Enter A Word");
	
	
	cout << "\n" << InvertLettersInStrting(word);
	return 0;
}
