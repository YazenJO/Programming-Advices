#include <iostream>
#include<vector>
#include<string>

using namespace std;
struct Info {
	
	string AccountNumber;
	string PinCode;
	string Name;
	string PhoneNumber;
	double AccountBalacne;

};
Info ReadNEWClient() {
	Info Client;
	cout << "Enter Account Number? ";
	getline(cin, Client.AccountNumber);
	cout << "Enter PinCode? ";
	getline(cin, Client.PinCode);
	cout << "Enter Name? ";
	getline(cin, Client.Name);
	cout << "Enter Phone? ";
	getline(cin, Client.PhoneNumber);
	cout << "Enter AccountBalance? ";
	cin >> Client.AccountBalacne;
	return Client;
}
vector <string> SplitString(string S1, string Delim) {
	vector<string> vString; short pos = 0; string sWord;// define a string variable  // use find() function to get the position of the delimiters 
	while ((pos = S1.find(Delim)) != std::string::npos)
	{
		sWord = S1.substr(0, pos); // store the word   
		if (sWord != "")
		{
			vString.push_back(sWord);
		}
		S1.erase(0, pos + Delim.length());/* erase() until positon and move to next word. */
	} if (S1 != "")
	{
		vString.push_back(S1); // it adds last word of the string. 
	}
	return vString;
}
Info ConvertLineToDataRecord(vector <string> Words) {
	Info Client;
	for (int i = 0; i < Words.size(); i++)
	{
		if (i==0)
			Client.AccountNumber = Words[i];
		if (i == 1)
			Client.PinCode= Words[i];
			if (i == 2)
				Client.Name= Words[i];
				if (i == 3)
					Client.PhoneNumber = Words[i];
					if (i == 4)
						Client.AccountBalacne= stod(Words[i]);

	}
	return Client;


}
int main()
{
	Info Client;
	
	string ClientInfo = "1234#///#2234#///#Yazen-Bilal#///#0795325610#///#5000.000000#///#";
	Client=ConvertLineToDataRecord(SplitString(ClientInfo, "#///#"));
	cout << Client.AccountNumber;
}


