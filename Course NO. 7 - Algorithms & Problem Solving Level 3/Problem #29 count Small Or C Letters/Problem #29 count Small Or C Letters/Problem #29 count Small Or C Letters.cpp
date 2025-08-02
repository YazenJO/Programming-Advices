#include <iostream>
#include <string>
using namespace std;
string ReadAstring(string Massage) {
	string Word;
	cout << Massage << "\n";
	getline(cin, Word);
	return Word;
}
char CountSmallCapitalCharacters(char s1,short &Capital,short &Small) {
	
	return (isupper(s1) ? ++Capital : ++Small);
}
string CountSmallCapitalStrting(string s1,short &Capital,short &Small) {

	for (int i = 0; i < s1.length(); i++)
	{
		 CountSmallCapitalCharacters(s1[i], Capital, Small);

	}
	return s1;

}
int main()
{
	short Capital = 0, Small = 0;
	string word = ReadAstring("Enter A Word");
	cout << "String Length is : " << word.length();
	CountSmallCapitalStrting(word, Capital,Small);
	cout << "\n" << "Capital Letters  : "<< Capital;
	cout << "\n" << "Small Letters  : " << Small;

	return 0;
}
