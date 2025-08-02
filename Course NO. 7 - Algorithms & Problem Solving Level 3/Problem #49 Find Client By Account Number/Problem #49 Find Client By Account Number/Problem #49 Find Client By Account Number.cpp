#include <iostream>
#include <fstream>
#include<vector>
#include <string>
using namespace std;
const string ClientsFileName = "Clients.txt";
struct stInfo {

	string AccountNumber;
	string PinCode;
	string Name;
	string PhoneNumber;
	double AccountBalacne;

};
void LoadDataFromFileToVector(string FileName, vector <string>& vFileContant) {
	fstream MyFile;

	MyFile.open(FileName, ios::in);

	if (MyFile.is_open()) {

		string line;
		while (getline(MyFile, line))
		{
			vFileContant.push_back(line);
		}
		MyFile.close();
	}
}
vector<string> SplitString(string S1, string Delim) {
	vector<string> vString;
	short pos = 0;
	string sWord = ""; // define a string variable  // use find() function to get the position of the delimiters  
	while ((pos = S1.find(Delim)) != std::string::npos) {
		sWord = S1.substr(0, pos); // store the word  
		if (sWord != "") {
			vString.push_back(sWord);
		} S1.erase(0, pos + Delim.length());
	} if (S1 != "") {
		vString.push_back(S1); // it adds last word of the string. 
	}
	return vString;
}
stInfo ConvertLinetoRecord(string Line, string Seperator = "#///#") {
	stInfo Client;
	vector<string> vClientData;
	vClientData = SplitString(Line, Seperator);
	Client.AccountNumber = vClientData[0];
	Client.PinCode = vClientData[1];
	Client.Name = vClientData[2];
	Client.PhoneNumber = vClientData[3];
	Client.AccountBalacne = stod(vClientData[4]);//cast string to doublereturn Client;
	return Client;
}
void ReadAClientsFromTheFile(string FileName, vector <stInfo>& ClientsData) {
	vector <string> FileContact;
	LoadDataFromFileToVector(FileName, FileContact);

	for (string& Line : FileContact)
	{
		ClientsData.push_back(ConvertLinetoRecord(Line));

	}


}
bool IsClientInFile(string AccountNumber,vector <stInfo> ClientsData, stInfo &TheFoundClient) {
	
	for (stInfo &Cleints: ClientsData)
	{
		if (Cleints.AccountNumber== AccountNumber)
		{
			TheFoundClient = Cleints;
			return true;
		}
	}
	return false;

}
void FindClientByAccountNumber(string AccountNumber, vector <stInfo> ClientsData) {
	stInfo Client;
	
	if (IsClientInFile(AccountNumber, ClientsData, Client))
	{
		cout << "\n\nThe Folowing is The Client Ditales : \n\n";
		cout << "The Client AccountNumber : "<< Client.AccountNumber << '\n';
		cout << "The Client PinCode       : "<<Client.PinCode << '\n';
		cout << "The Client Name          : "<<Client.Name<<'\n';
		cout << "The Client PhoneNumber   : "<<Client.PhoneNumber << '\n';
		cout << "The Client AccountBalacne: "<<Client.AccountBalacne << '\n';
	}
	else
	{
		cout << "Client With Number (" << AccountNumber << ") Not Found!\n";
	}


}
int main()
{
	vector <stInfo> ClientsData;
	string AccountNumber;
	cout << "Please Enter A Account Number : ";
	getline(cin, AccountNumber);
	ReadAClientsFromTheFile(ClientsFileName, ClientsData);

	FindClientByAccountNumber(AccountNumber, ClientsData);
}
