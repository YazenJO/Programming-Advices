#include <iostream>
#include <string>
using namespace std;
string ReadAstring(string Massage) {
	string Word;
	cout << Massage << "\n";
	getline(cin, Word);
	return Word;
}

void UpperOfEachWordString(string& s1) {
	
	for (int i = 0; i < s1.length(); i++)
	{
	
			s1[i] = toupper(s1[i]);
		
		
	}


}
void LowerOfEachWordString(string& s1) {

	for (int i = 0; i < s1.length(); i++)
	{
		
			s1[i] = tolower(s1[i]);


	}


}
int main()
{
	string word = ReadAstring("Enter A Word");
	UpperOfEachWordString(word);
	cout << word;
	LowerOfEachWordString(word);
	cout <<"\n" << word;
	return 0;
}