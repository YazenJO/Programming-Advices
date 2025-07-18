#include <iostream>
#include<string>
using namespace std;

string ReadACapitaletters(string Massage) {
	string Letters;
	cout << Massage << "\n";
	getline(cin, Letters);

	return Letters;
}
string Getencrypattion(string Word,int encrypttionKey) {
	string wordafter = "";
	short length = Word.length();
	for (char i = 0; i < length; i++) {
		Word[i]=int(Word[i])+ encrypttionKey;
		wordafter += char(Word[i]);
	}
	return wordafter;
}
string GetDecryption(string encrypttion, int encrypttionKey){
	string wordafter = "";
	short length = encrypttion.length();
	for (char i = 0; i < length; i++) {
		encrypttion[i] = int(encrypttion[i]) - encrypttionKey;
		wordafter += char(encrypttion[i]);
	}
	return wordafter;
}
int main()
{
	int encrypttionKey = 2;
	string Name= ReadACapitaletters("Enter A Name ");
	cout << "Text Before Encrypattion: " << Name<<'\n';
	cout << "Text After Encrypattion : " << Getencrypattion(Name,encrypttionKey) << '\n';;
	cout << "Text After Decryption   : " << GetDecryption(Getencrypattion(Name,encrypttionKey),encrypttionKey);
}

