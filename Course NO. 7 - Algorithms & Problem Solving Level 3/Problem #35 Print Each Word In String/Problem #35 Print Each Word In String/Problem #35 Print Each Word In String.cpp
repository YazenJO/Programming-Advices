#include <iostream>
#include <string>
using namespace std;
string ReadString(string Massage) {
	string s1 = " ";
	cout << Massage << '\n';
	getline(cin, s1);
	return s1;
}
void PrintEachWordInString(string word) {
	string s1 = " ";
	
	for (int i = 0; i < word.length(); i++)
	{
		s1 = " ";
		while (word[i]!=' '&&i!= word.length())
		{
			s1 += word[i];
				i++;
		}
		cout << s1 << '\n';
		
	}
}
int main()
{ 
	string s1 = ReadString("Enter A string ");
	PrintEachWordInString(s1);
}

