#include <iostream>
#include <string>
using namespace std;
char ReadAChar(string Massage) {
	char Word;
	cout << Massage << "\n";
	cin >> Word;
	return Word;
}
char InvertCharacter(char s1) {
	if (isupper(s1))
	{
		s1 = tolower(s1);
	}
	else
	{
		s1 = toupper(s1);

	}
	return s1;
}

int main()
{
	char c = ReadAChar("Enter A Char");
	cout << c << '\n';
	
	cout << '\n' << InvertCharacter(c) << '\n';
	return 0;
}
