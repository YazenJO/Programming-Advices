#include <iostream>
#include <string>
using namespace std;
string ReadAstring(string Massage) {
	string Word;
	cout << Massage << "\n";
	getline(cin, Word);
	return Word;
}
//void GetTheFirstLetterOfAString(string Word) {
//	char FristLetter =' ';
//	short Wordlength = Word.length();
//	cout << Word[0] << "\n";
//	for (int i = 0; i < Wordlength; i++)
//	{
//		
//		if (Word[i] == ' ')
//		{
//			i++;
//			cout << Word[i] << "\n";
//		}
//	}
//
//
//	
//
//}
//void PrintFirstLetterOfEachWord(string S1) 
//{
//	bool isFirstLetter = true;
//cout << "\nFirst letters of this string: \n";
//for (short i = 0; i < S1.length(); i++)
//{ 
//	if (S1[i] != ' ' && isFirstLetter) 
//	cout << S1[i] << endl;
//      
//isFirstLetter = (S1[i] == ' ' ? true : false);
//} 
//}
void PrintFirstLetterOfEachWord(string s1) {
	bool isFirstLetter = true;
	cout << "The First Letter Of The Word\n";
	for (int i = 0; i < s1.length(); i++)
	{
		if (s1[i] != ' ' && isFirstLetter)
			cout << s1[i] << "\n";

		isFirstLetter = (s1[i] == ' ' ? true : false);
	}



}
int main()
{
	//string word = "Yazen Bilal AbuSharkh";
	PrintFirstLetterOfEachWord(ReadAstring("Enter A Word"));
	return 0;
}

