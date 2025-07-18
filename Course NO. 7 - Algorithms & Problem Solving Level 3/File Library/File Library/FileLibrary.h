#pragma once 
#include <iostream>
#include <fstream>
#include<vector>
#include <string>
#include <iomanip>
using namespace std;
namespace FileLibrary{
	const string ClientsFileName = "Clients.txt";
	struct stInfo {

		string AccountNumber;
		string PinCode;
		string Name;
		string PhoneNumber;
		double AccountBalacne;

	};

	void SaveVectorToFile(string FileName, vector <string>vFileContant) {

		fstream MyFile;

		MyFile.open(FileName, ios::out);
		if (MyFile.is_open())
		{

			for (string& Line : vFileContant) {
				if (Line != "")
				{
					MyFile << Line << endl;
				}
			}
			MyFile.close();
		}
	}
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
	void DeleteRecordInFile(string FileName, string Record) {
		vector <string> vFileContent;

		LoadDataFromFileToVector(FileName, vFileContent);


		for (string& Line : vFileContent) {

			if (Line == Record) {

				Line = "";

			}
		}

		SaveVectorToFile(FileName, vFileContent);
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
	bool IsClientInFile(string AccountNumber, vector <stInfo> ClientsData, stInfo& TheFoundClient) {

		for (stInfo& Cleints : ClientsData)
		{
			if (Cleints.AccountNumber == AccountNumber)
			{
				TheFoundClient = Cleints;
				return true;
			}
		}
		return false;

	}
	string ConvertRecordToLine(stInfo Client, string Seperator = "#///#") {
		string Line;
		Line += Client.AccountNumber + Seperator;
		Line += Client.PinCode + Seperator;
		Line += Client.Name + Seperator;
		Line += Client.PhoneNumber + Seperator;
		Line += to_string(Client.AccountBalacne) + Seperator;


		return Line;



	}
	void DeleteClientFromTheFile(string AccountNumber) {
		vector <stInfo>ClientsData;

		ReadAClientsFromTheFile(ClientsFileName, ClientsData);
		for (stInfo& C : ClientsData)
		{
			if (C.AccountNumber == AccountNumber) {
				DeleteRecordInFile(ClientsFileName, ConvertRecordToLine(C));



			}
		}






	}
	void UpdateRecordInFile(string FileName, string Record, string UpdateTo) {
		vector <string> vFileContent;
		LoadDataFromFileToVector(FileName, vFileContent);

		for (string& Line : vFileContent) {

			if (Line == Record) {

				Line = UpdateTo;

			}
		}

		SaveVectorToFile(FileName, vFileContent);
	}
	void UpdateClientData(stInfo& Client) {
		cout << "Enter PinCode ? ";
		getline(cin >> ws, Client.PinCode);
		cout << "Enter Name ? ";
		getline(cin, Client.Name);
		cout << "Enter Phone Number ? ";
		getline(cin, Client.PhoneNumber);
		cout << "Enter Account Balance ? ";
		cin >> Client.AccountBalacne;



	}
	void UpdateClientFromTheFile(string AccountNumber) {
		vector <stInfo>ClientsData;
		string ClientBeforUpdate;
		ReadAClientsFromTheFile(ClientsFileName, ClientsData);
		for (stInfo& C : ClientsData)
		{
			if (C.AccountNumber == AccountNumber) {
				ClientBeforUpdate = ConvertRecordToLine(C);
				UpdateClientData(C);
				ConvertRecordToLine(C);
				UpdateRecordInFile(ClientsFileName, ClientBeforUpdate, ConvertRecordToLine(C));
				break;


			}
		}






	}
	void Find_DeleteClientByAccountNumber(string AccountNumber, vector <stInfo> ClientsData) {
		stInfo Client;
		char Choice;
		if (IsClientInFile(AccountNumber, ClientsData, Client))
		{
			cout << "\n\nThe Folowing is The Client Ditales : \n\n";
			cout << "The Client AccountNumber : " << Client.AccountNumber << '\n';
			cout << "The Client PinCode       : " << Client.PinCode << '\n';
			cout << "The Client Name          : " << Client.Name << '\n';
			cout << "The Client PhoneNumber   : " << Client.PhoneNumber << '\n';
			cout << "The Client AccountBalacne: " << Client.AccountBalacne << '\n';
			cout << "Are u sure U Want To Delete This Client ? (Y/N) ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				DeleteClientFromTheFile(AccountNumber);
				cout << "Client Deleted Succesfully\n";
			}
		}
		else
		{
			cout << "Client With Number (" << AccountNumber << ") Not Found!\n";
		}


	}
	void Find_UpdateClientByAccountNumber(string AccountNumber, vector <stInfo> ClientsData) {
		stInfo Client;
		char Choice;
		if (IsClientInFile(AccountNumber, ClientsData, Client))
		{
			cout << "\n\nThe Folowing is The Client Ditales : \n\n";
			cout << "The Client AccountNumber : " << Client.AccountNumber << '\n';
			cout << "The Client PinCode       : " << Client.PinCode << '\n';
			cout << "The Client Name          : " << Client.Name << '\n';
			cout << "The Client PhoneNumber   : " << Client.PhoneNumber << '\n';
			cout << "The Client AccountBalacne: " << Client.AccountBalacne << '\n';
			cout << "Are u sure U Want To Upate This Client ? (Y/N) ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				UpdateClientFromTheFile(AccountNumber);
				cout << "Client Updated Succesfully\n";
			}
		}
		else
		{
			cout << "Client With Number (" << AccountNumber << ") Not Found!\n";
		}


	}
	void FindClientByAccountNumber(string AccountNumber, vector <stInfo> ClientsData) {
		stInfo Client;

		if (IsClientInFile(AccountNumber, ClientsData, Client))
		{
			cout << "\n\nThe Folowing is The Client Ditales : \n\n";
			cout << "The Client AccountNumber : " << Client.AccountNumber << '\n';
			cout << "The Client PinCode       : " << Client.PinCode << '\n';
			cout << "The Client Name          : " << Client.Name << '\n';
			cout << "The Client PhoneNumber   : " << Client.PhoneNumber << '\n';
			cout << "The Client AccountBalacne: " << Client.AccountBalacne << '\n';
		}
		else
		{
			cout << "Client With Number (" << AccountNumber << ") Not Found!\n";
		}


	}
	void PrintClientContenet(stInfo Client) {

		cout << "| " << left << setw(15) << Client.AccountNumber;
		cout << "| " << left << setw(10) << Client.PinCode;
		cout << "| " << left << setw(40) << Client.Name;
		cout << "| " << left << setw(12) << Client.PhoneNumber;
		cout << "| " << left << setw(12) << Client.AccountBalacne;
	}
	void PrintClients(vector <stInfo>vFileContant) {

		cout << "\n\t\t\t\t\tClient List (" << vFileContant.size() << ") Client(s).";
		cout << "\n_______________________________________________________";
		cout << "_________________________________________\n" << endl;
		cout << "| " << left << setw(15) << "Accout Number";
		cout << "| " << left << setw(10) << "Pin Code";
		cout << "| " << left << setw(40) << "Client Name";
		cout << "| " << left << setw(12) << "Phone";
		cout << "| " << left << setw(12) << "Balance";
		cout << "\n_______________________________________________________";
		cout << "_________________________________________\n" << endl;
		for (stInfo& Client : vFileContant) {
			PrintClientContenet(Client);

			cout << endl;
		}
		cout << "\n_______________________________________________________";
		cout << "_________________________________________\n" << endl;
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
	stInfo ReadNewClient() {
		stInfo Client;
		cout << "Enter Account Number? ";
		getline(cin >> ws, Client.AccountNumber);
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
	void AddNewClient() {
		stInfo Client;
		Client = ReadNewClient();
		SaveDataToFile(ClientsFileName, ConvertRecordToLine(Client));
	}
	void AddClientsToFile() {
		char AddMore = 'Y';
		do {
			system("cls");
			cout << "Adding New Client:\n\n";
			AddNewClient();
			cout << "\nClient Added Successfully, do you want to add more clients? Y/N? ";
			cin >> AddMore;
		} while (toupper(AddMore) == 'Y');
	}




}
