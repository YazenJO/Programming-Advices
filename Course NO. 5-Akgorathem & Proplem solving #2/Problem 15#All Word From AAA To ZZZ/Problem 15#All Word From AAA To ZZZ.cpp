#include <iostream>
using namespace std;


void PrintAllWordsFromAAAToZZZ() {

	for (int i = 1; i <= 26; i++) {

		for (int j = 1; j <= 26; j++) {

			for (int k = 1; k <= 26; k++)
			{
				cout << char(i + 64) << char(j + 64) << char(k + 64) << endl;
			}

		}
	}
}

int main()
{
	PrintAllWordsFromAAAToZZZ();
}
