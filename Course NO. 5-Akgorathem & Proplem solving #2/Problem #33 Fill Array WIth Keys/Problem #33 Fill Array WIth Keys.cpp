#include <iostream>
#include<cstdlib>
using namespace std;

enum enCharType { SamallLetter = 1, CapitalLetter = 2, SpecialCharacter = 3, Digit = 4 };
int ReadAPositiveNumber(string Massage) {
	int num;
	do {
		cout << Massage << "\n";
		cin >> num;

	} while (num < 0);
	return num;
}
int RandomNumber(int From, int To) {

	int randNum = rand() % (To - From + 1) + From;
	return  randNum;
}
char GetRandomCharacter(enCharType CharType)
{
	switch (CharType)
	{
	case  enCharType::SamallLetter:
	{
		return char(RandomNumber(97, 122));
		break;
	}
	case enCharType::CapitalLetter:
	{
		return char(RandomNumber(65, 90));
		break;
	}
	case enCharType::SpecialCharacter:
	{
		return char(RandomNumber(33, 47));
		break;
	}
	case enCharType::Digit:
	{
		return char(RandomNumber(48, 57));
		break;
	}
	}
}
void FillArrayWithGeneratedKeys(string store[], int Number, short longOfKey, short length) {
	for (int k = 1; k <= Number; k++) {
		
		for (int i = 1; i <= longOfKey; i++) {

			for (int j = 1; j <= length; j++) {

				store[k-1]+= GetRandomCharacter(enCharType::CapitalLetter);



			}


			if (i != longOfKey)
				store[k - 1] += "-";
		}
		
	}



}
void PrintTheArray(string store[], short size) {
	
	for (int i = 0; i < size; i++) {
		cout << "\nArray [" << i  << "] :";
		cout << store[i] << " ";


	}
	cout << "\n";


}
int main() {
	string store[100];
	srand((unsigned)time(NULL));

	int NOfKeys = ReadAPositiveNumber("Enter The Number Of Keys");
	short Length = ReadAPositiveNumber("Enter The Length Of each Word ");
	short longOfKey = ReadAPositiveNumber("Enter The Number Of Words");
	FillArrayWithGeneratedKeys(store,NOfKeys, longOfKey, Length);
	PrintTheArray(store, NOfKeys);
	return 0;
}
