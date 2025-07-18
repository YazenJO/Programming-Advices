#include <iostream>
#include <string>
using namespace std;
string ReadAstring(string Massage) {
	string Word;
	cout << Massage << "\n";
	getline(cin, Word);
	return Word;
}
bool CompareLetters(char Ch1,char Ch2) {

	return (Ch1== Ch2);
}
short CountLettersinString(string s1,char Ch) {
	short count = 0;
	for (int i = 0; i < s1.length(); i++)
	{
		
		if (CompareLetters(s1[i], Ch))
			count++;
	}
	return count;

}
int main()
{
	char Ch = ' ';
	string word = ReadAstring("Enter A Word");
	cout << '\n' << "Please Enrer A Chararacter : ";
	cin >> Ch;
	
	cout << "\n" << "Chracter \""<< Ch<<"\" Count = "<< CountLettersinString(word, Ch);
	

	return 0;
}
