#include <iostream>
#include <string>
using namespace std;
string ReadString(string Massage) {
	string s1 = " ";
	cout << Massage << '\n';
	getline(cin, s1);
	return s1;
}
int PrintEachWordInString(string word) {
	string delim = " ";
	short pos = 0;
	string sword;
	short count=0;
	while ((pos = word.find(delim)) != std::string::npos)
	{
		if (sword != " ")
		{
			sword = word.substr(0, pos);
			count++;
		}
		word.erase(0, pos + delim.length());

	}
	if (word != "")
	{
		//cout << word << endl;
		count++;
	}
	return count;
}
int main()
{
	string s1 = ReadString("Enter A string ");
	
	cout<<PrintEachWordInString(s1);
}

