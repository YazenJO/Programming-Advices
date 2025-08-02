#include <iostream>
using namespace std;
string RemovePunctuations(string S1) {
	string s2 = "";
	string::iterator it = S1.begin();
	while (it != S1.end())
	{
		//if ((int)*it >= 33 && (int)*it <= 47 || (int)*it >= 58 && (int)*it <= 64 || (int)*it >= 91 && (int)*it <= 96 || (int)*it >= 123 && (int)*it <= 126)
		if(ispunct(*it))
		{
			*it = 0;
		}
		s2 += *it;
		++it;
	}



	return s2;

}

int main()
{
	string Name = "Yazen ,Bilal Ab'U-Sharkh !";
	cout<<RemovePunctuations(Name);
}
