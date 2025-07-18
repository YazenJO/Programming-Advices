#include <iostream>
#include <string>
#include <vector>
using namespace std;


char ReturnTheMissingChar(vector <short> Values) {

	short FirstVlaue = Values.at(0);

	for (int i = 0; i < Values.size() ; i++) {

		if (Values[i + 1] == Values[i] + 2)
			return (char)Values[i] + 1;
	}

}

char findMissingLetter(const std::vector<char>& chars)
{
	// TODO: Find the missing char in the consecutive letter sequence and return it.

	vector <short> Values;

	short v = 0;
	for (char c : chars) {

		v = (int)c;
		Values.push_back(v);

	}

	return ReturnTheMissingChar(Values);
}

int main()
{

	cout << findMissingLetter({ 'O','Q','R','S' }) << endl;

	return 0;
}