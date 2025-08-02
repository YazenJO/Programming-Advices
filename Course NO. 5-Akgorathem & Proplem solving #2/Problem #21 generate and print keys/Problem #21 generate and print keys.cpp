#include <iostream>

using namespace std;

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

enum enCharType { SamallLetter = 1, CapitalLetter = 2, SpecialCharacter = 3, Digit = 4 };
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
string GenerateWord(enCharType CharType, short Length) {
	string Word = "";
	for (int i = 1; i <= Length; i++) {
		Word += GetRandomCharacter(CharType);
	}


	return Word;
}
string GenerateKey() { 
	string key = "";
	
		key += GenerateWord(enCharType::CapitalLetter, 4)+"-";
		key += GenerateWord(enCharType::CapitalLetter, 4) + "-";
		key += GenerateWord(enCharType::CapitalLetter, 4) + "-";
		key += GenerateWord(enCharType::CapitalLetter, 4) ;
		
		return key;
}
void FillArrayWithGeneratedKeys(int store[], int Number, short longOfKey, short length) {
	for (int k = 1; k <= Number; k++) {
		cout <<"key[" << k << "] :";
		for (int i = 1; i <= longOfKey; i++) {
			
			for (int j = 1; j <=length; j++) {

				cout<<"Array ["<<k-1<<"]  :"<<store[k - 1] == GetRandomCharacter(enCharType::CapitalLetter);


				
			}


			if(i!= longOfKey)
			cout << "-";
		}
		cout << "\n";
	}



}
int main()
{
	int stroe[100];
	srand((unsigned)time(NULL));
	
	int NOfKeys = ReadAPositiveNumber("Enter The Number Of Keys");
	short Length = ReadAPositiveNumber("Enter The Length Of each Word ");
	short longOfKey = ReadAPositiveNumber("Enter The Number Of Words");
	FillArrayWithGeneratedKeys(store,NOfKeys,longOfKey,Length);
}

