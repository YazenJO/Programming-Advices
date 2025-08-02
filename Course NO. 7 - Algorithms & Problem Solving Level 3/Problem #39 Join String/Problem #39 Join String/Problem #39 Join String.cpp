#include <iostream>
#include <string>
#include <vector>
using namespace std;

string JoinString(vector <string> S1,string demin) {
	string Word = "";
	short VSize = S1.size();
	short countert = 0;
	for (string &sword : S1) {
		countert++;
		if (countert== VSize)
		
			Word += sword;
		
		else
			Word += sword+demin;
	}

	
	return Word;

}

int main()
{

	vector <string> vString= {"Yazen","Ahmed","Khalid"};
	cout << JoinString(vString, ",");
}

