#include <iostream>
#include <fstream>
#include<vector>
#include <string>
using namespace std;
const string ClientsFileName = "Clients.txt";
struct Info {

	string AccountNumber;
	string PinCode;
	string Name;
	string PhoneNumber;
	double AccountBalacne;

};
Info ReadNewClient() {
	Info Client;
	cout << "Enter Account Number? ";
	getline(cin>>ws,Client.AccountNumber);
	cout << "Enter PinCode? ";
	getline(cin, Client.PinCode);
	cout << "Enter Name? ";
	getline(cin, Client.Name);
	cout << "Enter Phone? ";
	getline(cin, Client.PhoneNumber);
	cout << "Enter AccountBalance? ";
	cin>> Client.AccountBalacne;
	
	return Client;
}
string ConvertRecordToLine(Info Client, string Seperator = "#///#") {
	string Line;
	Line += Client.AccountNumber + Seperator;
	Line += Client.PinCode + Seperator;
	Line += Client.Name + Seperator;
	Line += Client.PhoneNumber + Seperator;
	Line += to_string(Client.AccountBalacne) + Seperator;


	return Line;



}
void SaveDataToFile(string FileName, string Data) {
	fstream MyFile;
	MyFile.open(FileName, ios::out | ios::app);
	if (MyFile.is_open())
	{
		MyFile << Data << endl;
		
		MyFile.close();
	}
}
//void LoadDataFromFileToVector(string FileName, vector <string>vFileContant) {
//	fstream MyFile;
//
//	MyFile.open(FileName, ios::in);
//
//	if (MyFile.is_open()) {
//
//		string line;
//		while (getline(MyFile, line))
//		{
//			vFileContant.push_back(line);
//		}
//		MyFile.close();
//	}
//}
//void PrintFileContenet(string FileName,vector <string>&FileContant ) {
//	fstream MyFile;
//
//	MyFile.open(FileName, ios::in);
//
//	if (MyFile.is_open()) {
//
//		string line;
//		while (getline(MyFile, line))
//		{
//			cout << line << endl;
//		}
//		MyFile.close();
//	}
//	
//}
//void SaveVectorToFile(string FileName, vector <string>vFileContant) {
//
//	fstream MyFile;
//
//	MyFile.open(FileName, ios::out|ios::app);
//	if (MyFile.is_open())
//	{
//	
//		for (string& Line : vFileContant) {
//			if (Line!="")
//			{
//				MyFile << Line << endl;
//			}
//		}
//		MyFile.close();
//	}
//
//
//
//
//
//
//}
//void DeleteRecordFromFile(string FileName, string Record) {}
//void UpdateRecordInFile(string FileName, string Record, string UpdateTo){
//vector <string> vFileContent;
//LoadDataFromFileToVector(FileName, vFileContent);
//vector <string> vFileContent;
//
//
//for (string& Line : vFileContent) {
//
//	if (Line == Record) {
//
//		Line = UpdateTo;
//
//	}
//}
//
//SaveVectorToFile(FileName, vFileContent);
//}
//void DeleteRecordInFile(string FileName, string Record) {
//	vector <string> vFileContent;
//
//	LoadDataFromFileToVector(FileName, vFileContent);
//
//
//	for (string& Line : vFileContent) {
//
//		if (Line == Record) {
//
//			Line = "";
//
//		}
//	}
//
//	SaveVectorToFile(FileName, vFileContent);
//}
void AddNewClient() {
	Info Client;
	Client = ReadNewClient(); 
	SaveDataToFile(ClientsFileName, ConvertRecordToLine(Client));
}
void AddClients() {
	char AddMore = 'Y';
	do {
		system("cls");   
		cout << "Adding New Client:\n\n";   
		AddNewClient();    
		cout << "\nClient Added Successfully, do you want to add more clients? Y/N? ";  
		cin >> AddMore;
	} while (toupper(AddMore) == 'Y');
}

int main()
{
	AddClients();
	system("pause>0");
	return 0;
	
	
}

