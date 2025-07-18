#include <iostream>
#include <fstream>
#include<vector>
#include <string>
#include <iomanip>

using namespace std;
const string ClientsFileName = "Clients.txt";
enum enMainMenuOptions { ShowClients = 1, AddClient = 2, DeleteClient = 3, UpdateClient = 4, FindClient = 5,Transactions=6, Exit = 7};
enum enTransactionsOptions{Deposite=1,Withdrraw=2,TotalBalane=3,MainMenu=4};

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
string ReadAccountNumber() {
	string AccountNumber;
	cout << "Enter The Account Number ?";
	getline(cin >> ws, AccountNumber);
	return AccountNumber;
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
bool ClientExistsByAccountNumber(string AccountNumber, string FileName) {
	vector <stInfo> vClients;
	fstream MyFile;
	MyFile.open(FileName, ios::in);//read Mode
	if (MyFile.is_open())
	{
		string Line;
		stInfo Client;
		while (getline(MyFile, Line))
		{
			Client = ConvertLinetoRecord(Line);
			if (Client.AccountNumber == AccountNumber)
			{
				MyFile.close();
				return true;
			}
			vClients.push_back(Client);
		}
		MyFile.close();
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
void UpdateVectorData(vector <stInfo>& vClientsData) {
	vClientsData.clear();
	ReadAClientsFromTheFile(ClientsFileName, vClientsData);



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
	UpdateVectorData(ClientsData);
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
	UpdateVectorData(ClientsData);
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
	UpdateVectorData(ClientsData);
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
	UpdateVectorData(vFileContant);
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
short ReadUserChoice(string Massage) {
	short Choice;
	cout << Massage<<"\n";
	cin >> Choice;

	return Choice;

}
void DepositAClientBalance(string AccountNumber,double Deposit) {
	vector <stInfo>ClientsData;
	string ClientBeforUpdate;
	ReadAClientsFromTheFile(ClientsFileName, ClientsData);
	for (stInfo& C : ClientsData)
	{
		if (C.AccountNumber == AccountNumber) {
			ClientBeforUpdate = ConvertRecordToLine(C);
			C.AccountBalacne += Deposit;
			ConvertRecordToLine(C);
			UpdateRecordInFile(ClientsFileName, ClientBeforUpdate, ConvertRecordToLine(C));
			break;


		}
	}




}
void Deposit(string AccountNumber, vector <stInfo> &ClientsData) {
	UpdateVectorData(ClientsData);
	double Deposit;
	stInfo Client;
	if (IsClientInFile(AccountNumber, ClientsData, Client))
	{
		cout << "\n\nThe Folowing is The Client Ditales : \n\n";
		cout << "--------------------------------------\n";
		cout << "The Client AccountNumber : " << Client.AccountNumber << '\n';
		cout << "The Client PinCode       : " << Client.PinCode << '\n';
		cout << "The Client Name          : " << Client.Name << '\n';
		cout << "The Client PhoneNumber   : " << Client.PhoneNumber << '\n';
		cout << "The Client AccountBalacne: " << Client.AccountBalacne << '\n';
		cout << "--------------------------------------\n";
		cout << "Please Enter deopsit amount?";
		cin >> Deposit;
		DepositAClientBalance(AccountNumber, Deposit);
		
			
			cout << "Client Updated Succesfully\n";
	}
	else
	{
		cout << "Client With Number (" << AccountNumber << ") Not Found!\n";
	}


}
void WidrowAClientBalance(string AccountNumber, double Witdraw) {
	vector <stInfo>ClientsData;
	string ClientBeforUpdate;
	ReadAClientsFromTheFile(ClientsFileName, ClientsData);
	for (stInfo& C : ClientsData)
	{
		if (C.AccountNumber == AccountNumber) {
			
			ClientBeforUpdate = ConvertRecordToLine(C);
			C.AccountBalacne -= Witdraw;
			ConvertRecordToLine(C);
			UpdateRecordInFile(ClientsFileName, ClientBeforUpdate, ConvertRecordToLine(C));
			break;


		}
	}


}
void Widrow(string AccountNumber, vector <stInfo>& ClientsData) {
	UpdateVectorData(ClientsData);
	double Withdrow;
	stInfo Client;
	if (IsClientInFile(AccountNumber, ClientsData, Client))
	{
		cout << "\n\nThe Folowing is The Client Ditales : \n\n";
		cout << "--------------------------------------\n";
		cout << "The Client AccountNumber : " << Client.AccountNumber << '\n';
		cout << "The Client PinCode       : " << Client.PinCode << '\n';
		cout << "The Client Name          : " << Client.Name << '\n';
		cout << "The Client PhoneNumber   : " << Client.PhoneNumber << '\n';
		cout << "The Client AccountBalacne: " << Client.AccountBalacne << '\n';
		cout << "--------------------------------------\n";
		cout << "Please Enter Withdrow amount?";
		cin >> Withdrow;
		while (Withdrow > Client.AccountBalacne)
		{
			cout << "\n\nAmount Exceeds The Balance , you can Withdraw up to : " << Client.AccountBalacne;
			cout << "\nPlease Enter Withdrow amount?\n";
			cin >> Withdrow;
		}
		WidrowAClientBalance(AccountNumber, Withdrow);


		cout << "Client Updated Succesfully\n";
	}
	else
	{
		cout << "Client With Number (" << AccountNumber << ") Not Found!\n";
	}







}
void TransactionsMenuScreen(vector <stInfo>&Clients);
void BackToTransactionsMenu(vector <stInfo>Clients) {
	cout << "\nEnter Any Key to return to Main Menu....\n";
	system("pause>0");
	system("cls");
	TransactionsMenuScreen(Clients);
}
void BankProject(vector <stInfo> Clients);
void BackToMainMenu(vector <stInfo> Clients) {
	cout << "\nEnter Any Key to return to Main Menu....\n";
	system("pause>0");
	system("cls");
	BankProject(Clients);

}
void PrintTotalBalanceCintent(stInfo Client) {
	 

		cout << "| " << left << setw(15) << Client.AccountNumber;
		cout << "| " << left << setw(40) << Client.Name;
		cout << "| " << left << setw(12) << Client.AccountBalacne;
	
}
void TotalBalance(vector <stInfo> Clients) {
	UpdateVectorData(Clients);
	double TotalBalance=0;
	cout << "\n\t\t\t\t\tClient List (" << Clients.size() << ") Client(s).";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	cout << "| " << left << setw(15) << "Accout Number";
	cout << "| " << left << setw(40) << "Client Name";
	cout << "| " << left << setw(12) << "Balance";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	for (stInfo& Client : Clients) {
		 TotalBalance+=Client.AccountBalacne;
		 PrintTotalBalanceCintent(Client);

		cout << endl;
	}
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	cout << "\n\nTotal Balance : " << TotalBalance;
}
void PrintExitPage() {
	system("cls");
	cout << "\n=======================================================";
	cout << "\n\t\t\tProgram End  ";
	cout << "\n=======================================================\n";
	system("pause");
}
void TransactionsMenuScreen(vector <stInfo>& Clients) {

	system("cls");
	cout << "\n=======================================================";
	cout << "\n\t\t\tTransactions Menu Screen";
	cout << "\n=======================================================\n";
	cout << "\n\t\t[" << 1 << "] Deposit.";
	cout << "\n\t\t[" << 2 << "] Withdraw.";
	cout << "\n\t\t[" << 3 << "] Total Balances.";
	cout << "\n\t\t[" << 4 << "] Main Menu.";
	cout << "\n=======================================================" << endl;
	switch ((enTransactionsOptions)ReadUserChoice("\nChoose What Do u Want to do ? [1 to 4] ? "))
	{
	case Deposite:
		system("cls");
		Deposit(ReadAccountNumber(), Clients);
		BackToTransactionsMenu(Clients);
		break;
	case Withdrraw:
		system("cls");
		Widrow(ReadAccountNumber(), Clients);
		BackToTransactionsMenu(Clients);
		break;
	case TotalBalane:
		system("cls");
		TotalBalance(Clients);
		BackToTransactionsMenu(Clients);
		break;
	case MainMenu:
	
		BackToMainMenu(Clients);
		break;
	default:
		break;
	}
}
void PerformMainMenuOption(enMainMenuOptions Option, vector <stInfo>& Clients) {

	switch (Option)
	{
	case ShowClients:

		system("cls");
		PrintClients(Clients);
		BackToMainMenu(Clients);
		break;
	case AddClient:

		AddClientsToFile();
		BackToMainMenu(Clients);
		break;
	case DeleteClient:
		system("cls");
		Find_DeleteClientByAccountNumber(ReadAccountNumber(), Clients);
		BackToMainMenu(Clients);
		break;
	case UpdateClient:
		system("cls");
		Find_UpdateClientByAccountNumber(ReadAccountNumber(), Clients);
		BackToMainMenu(Clients);
		break;
	case FindClient:
		system("cls");
		FindClientByAccountNumber(ReadAccountNumber(), Clients);
		BackToMainMenu(Clients);
		break;
	case Transactions:
		system("cls");
		TransactionsMenuScreen(Clients);
		BackToMainMenu(Clients);
		break;
	case Exit:
		system("cls");
		PrintExitPage();
		break;
	default:
		cout << "\nWrong Choice :(\n";
		break;
	}
}
void BankProject(vector <stInfo> Clients) {
	short Choice;

	cout << "\n=======================================================";
	cout << "\n\t\t\tMain Menu Screecn  ";
	cout << "\n=======================================================";
	cout << "\n\t\t[" << 1 << "] Show Client List.";
	cout << "\n\t\t[" << 2 << "] Add New Client.";
	cout << "\n\t\t[" << 3 << "] Delete Client.";
	cout << "\n\t\t[" << 4 << "] Update Client.";
	cout << "\n\t\t[" << 5 << "] Find Client.";
	cout << "\n\t\t[" << 6 << "] Transactions.";
	cout << "\n\t\t[" << 7 << "] Exit.";
	cout << "\n=======================================================" << endl;
	Choice = ReadUserChoice("Choose What Do u Want to do ? [1 to 7]?");
	PerformMainMenuOption((enMainMenuOptions)Choice, Clients);
}

int main()
{
	vector <stInfo> Clients;
	ReadAClientsFromTheFile(ClientsFileName, Clients);
	BankProject(Clients);
	system("pause<0");
}

