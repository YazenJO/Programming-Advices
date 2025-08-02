#include <iostream>
#include <string>
using namespace std;
string ReadAstring(string Massage) {
	string Word;
	cout << Massage << "\n";
	getline(cin, Word);
	return Word;
}

bool CompareLettersWithMatchCase(char Ch1, char Ch2) {

	return (Ch1 == Ch2||Ch1==toupper(Ch2));
}
bool CompareLettersWithoutMatchCase(char Ch1, char Ch2) {

	return (Ch1 == Ch2);
}
short CountLettersinString(string s1, char Ch,bool MatchCase=true) {
	short counter = 0;
	for (int i = 0; i < s1.length(); i++)
	{

		if (MatchCase) {
			
			if (CompareLettersWithMatchCase(s1[i], Ch))
				counter++;
		}
		else
		{
			if (CompareLettersWithoutMatchCase(s1[i], Ch))

				counter++;
		}
			
	}
	return counter;
}
int main()
{
	char Ch = ' ';

	string word = ReadAstring("Enter A Word");
	cout << '\n' << "Please Enrer A Chararacter : ";
	cin >> Ch;
	
	cout << "\n" << "Chracter \"" << Ch << "\" Count = " << CountLettersinString(word,Ch,false);
	cout << "\n" << "Chracter \"" << Ch << "\" Or \""<<(char)toupper(Ch)<<"\" Count = " << CountLettersinString(word, Ch, true);


	return 0;
}
