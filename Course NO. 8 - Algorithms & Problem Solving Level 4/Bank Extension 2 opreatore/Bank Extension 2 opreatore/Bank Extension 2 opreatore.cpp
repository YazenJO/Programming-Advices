#include <iostream>
#include <fstream>
#include<vector>
#include <string>
#include <iomanip>

using namespace std;

const int Option_One = 1;//1 << 0; // 1
const int Option_Two = 1 << 1; // 2
const int Option_Three = 1 << 2; // 4
const int Option_Four = 1 << 3; // 8
const int Option_Five = 16;//1 << 4; // 16
const int Option_Six = 32;//1 << 5; // 32
const int Option_Seven = 1 << 6; // 64
const string ClientsFileName = "Clients.txt";
const string UseresFileName = "Users.txt";
enum enMainMenuOptions { ShowClients = 1, AddClient = 2, DeleteClient = 3, UpdateClient = 4, FindClient = 5, Transactions = 6, ManageUsers =7  ,Logout=8};
enum enTransactionsOptions { Deposite = 1, Withdrraw = 2, TotalBalane = 3, MainMenu = 4 };
enum enMangeUserOptions{ListUsers=1,AddANewUser=2,DeleteUser=3,UpdateUser=4,FindUser=5,TheMainMenu=6};
struct stUserInfo {
	string UserName;
	string Password;
	short Primisstions;


};
struct stInfo {

	string AccountNumber;
	string PinCode;
	string Name;
	string PhoneNumber;
	double AccountBalacne;
};
stUserInfo User;

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
bool CheckAccesPrimisstion(int Option);
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
stUserInfo ConvertLinetoRecordForUsers(string Line, string Seperator = "#///#") {
	stUserInfo User;
	vector<string> vUsertData;
	vUsertData = SplitString(Line, Seperator);
	 User.UserName= vUsertData[0];
	 User.Password= vUsertData[1];
	 User.Primisstions =stoi (vUsertData[2]);
	 return User;
}
void ReadAClientsFromTheFile(string FileName, vector <stInfo>& ClientsData) {
	vector <string> FileContact;
	LoadDataFromFileToVector(FileName, FileContact);

	for (string& Line : FileContact)
	{

		ClientsData.push_back(ConvertLinetoRecord(Line));

	}


}
void ReadAClientsFromTheFile(string FileName, vector <stUserInfo>& ClientsData) {
	vector <string> FileContact;
	LoadDataFromFileToVector(FileName, FileContact);

	for (string& Line : FileContact)
	{

		ClientsData.push_back(ConvertLinetoRecordForUsers(Line));

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
bool IsUserInFile(string UserName, vector <stUserInfo> UserData, stUserInfo& TheFoundClient) {

	for (stUserInfo& Users : UserData)
	{
		if (Users.UserName == UserName)
		{
			TheFoundClient = Users;
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
string ConvertRecordToLine(stUserInfo User, string Seperator = "#///#") {
	string Line;
	Line += User.UserName + Seperator;
	Line += User.Password+ Seperator;
	Line += to_string(User.Primisstions) + Seperator;


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
void DeleteUserFromTheFile(string UserName) {
	vector <stUserInfo>Users;

	ReadAClientsFromTheFile(UseresFileName, Users);
	for (stUserInfo& user: Users)
	{
		if (user.UserName == UserName) {
			DeleteRecordInFile(UseresFileName, ConvertRecordToLine(user));


		}
	}


}
short ReadPrimisstions();
void AccesDeniedScrreen();
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
void UpdateUserDate(stUserInfo& User) {
	cout << "Enter Password? ";
	getline(cin>>ws, User.Password);
	User.Primisstions = ReadPrimisstions();


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
void UpdateUsertFromTheFile(string UserName) {
	vector <stUserInfo>vUser;
	string UserBeforeUpdate;
	ReadAClientsFromTheFile(UseresFileName, vUser);
	for (stUserInfo& User : vUser)
	{
		if (User.UserName == UserName) {
			UserBeforeUpdate = ConvertRecordToLine(User);
			UpdateUserDate(User);
			ConvertRecordToLine(User);
			UpdateRecordInFile(UseresFileName, UserBeforeUpdate, ConvertRecordToLine(User));
			break;


		}
	}






}
void Find_DeleteClientByAccountNumber(string AccountNumber, vector <stInfo> ClientsData) {
	if (!CheckAccesPrimisstion(Option_Three))
	{
		AccesDeniedScrreen();
		return;
	}
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
	if (!CheckAccesPrimisstion(Option_Four))
	{
		AccesDeniedScrreen();
		return;
	}
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
	if (!CheckAccesPrimisstion(Option_Five))
	{
		AccesDeniedScrreen();
		return;
	}
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
	if (!CheckAccesPrimisstion(Option_One))
	{
		AccesDeniedScrreen();
		return;
	}
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
short ReadPrimisstions() {
	short Primisstions = 0;
	char Choice;
	cout << "\nDo u Want To give Full access ? y/n ? ";
	cin >> ws >> Choice;
	if (toupper(Choice)=='Y')
	return -1;
	else
	{
		cout << "\nDo u Want To give acces to :\n";
		cout << "\nShow Client List ? y/n ? ";
		cin >> Choice;
		if (toupper(Choice) == 'Y')
		{
			Primisstions |= Option_One;
		}
		cout << "\nAdd New Client ? y/n ? ";
		cin >> Choice;
		if (toupper(Choice) == 'Y')
		{
			Primisstions |= Option_Two;
		}
		cout << "\nDelete Client ? y/n ? ";
		cin >> Choice;
		if (toupper(Choice) == 'Y')
		{
			Primisstions |= Option_Three;
		}
		cout << "\nUpdat Client ? y/n ? ";
		cin >> Choice;
		if (toupper(Choice) == 'Y')
		{
			Primisstions |= Option_Four;
		}
		cout << "\nFind Clients ? y/n ? ";
		cin >> Choice;
		if (toupper(Choice) == 'Y')
		{
			Primisstions |= Option_Five;
		}
		cout << "\nTransactions ? y/n ? ";
		cin >> Choice;
		if (toupper(Choice) == 'Y')
		{
			Primisstions |= Option_Six;
		}
		cout << "\nMange Users ? y/n ? ";
		cin >> Choice;
		if (toupper(Choice) == 'Y')
		{
			Primisstions |= Option_Seven;
		}
	}
	return Primisstions;
}
stUserInfo ReadNewUser() {
	stUserInfo User;
	cout << "Enter User Name? ";

	getline(cin >> ws, User.UserName);
	cout << "Enter Password? ";
	getline(cin, User.Password);
	User.Primisstions=ReadPrimisstions();
	return User;
}
void AddNewClient() {
	stInfo Client;
	Client = ReadNewClient();
	SaveDataToFile(ClientsFileName, ConvertRecordToLine(Client));
}
void AddClientsToFile() {
	char AddMore = 'Y';
	if (!CheckAccesPrimisstion(Option_Two))
	{
		AccesDeniedScrreen();
		return;
	}
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
	cout << Massage << "\n";
	cin >> Choice;

	return Choice;

}
void DepositAClientBalance(string AccountNumber, double Deposit) {
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
void Deposit(string AccountNumber, vector <stInfo>& ClientsData) {
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
void TransactionsMenuScreen(vector <stInfo>& Clients);
void BackToTransactionsMenu(vector <stInfo>Clients) {
	cout << "\nEnter Any Key to return to Main Menu....\n";
	system("pause>0");
	system("cls");
	TransactionsMenuScreen(Clients);
}
void ATMProject(vector <stInfo> Clients);
void BackToMainMenu() {
	vector <stInfo> Clients;
	ReadAClientsFromTheFile(ClientsFileName, Clients);
	cout << "\nEnter Any Key to return to Main Menu....\n";
	system("pause>0");
	system("cls");
	ATMProject(Clients);

}
void PrintTotalBalanceCintent(stInfo Client) {


	cout << "| " << left << setw(15) << Client.AccountNumber;
	cout << "| " << left << setw(40) << Client.Name;
	cout << "| " << left << setw(12) << Client.AccountBalacne;

}
void TotalBalance(vector <stInfo> Clients) {
	UpdateVectorData(Clients);
	double TotalBalance = 0;
	cout << "\n\t\t\t\t\tClient List (" << Clients.size() << ") Client(s).";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	cout << "| " << left << setw(15) << "Accout Number";
	cout << "| " << left << setw(40) << "Client Name";
	cout << "| " << left << setw(12) << "Balance";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	for (stInfo& Client : Clients) {
		TotalBalance += Client.AccountBalacne;
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
void login();
bool CheckAccesPrimisstion(int Option) {
	if (User.Primisstions==-1)
	{
		return true;
	}
	if ((User.Primisstions&Option)==Option)
	{
		return true;
	}
	return false;

}
void TransactionsMenuScreen(vector <stInfo>& Clients) {
	if (!CheckAccesPrimisstion(Option_Six))
	{
		AccesDeniedScrreen();
		return;
	}

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

		BackToMainMenu();
		break;
	case Logout:
		system("cls");
		login();
		break;
	default:
		break;
	}
}
void PrintAccesDeniedScreent() {
	cout << "\n-------------------------------------------------------";
	cout << "\nAcces Denied,\n";
	cout << "You Dont Have Permission To Do This\n";
	cout << "Please Conact Your Admin,\n";
	cout << "\n-------------------------------------------------------";


}
void AccesDeniedScrreen() {
	system("cls");
	PrintAccesDeniedScreent();
	BackToMainMenu();
}
void AddNewUser() {
	stUserInfo User;
	User = ReadNewUser();
	SaveDataToFile(UseresFileName, ConvertRecordToLine(User));
}
void PrintUserContenet(stUserInfo User) {

	cout << "| " << left << setw(15) << User.UserName;
	cout << "| " << left << setw(10) << User.Password;
	cout << "| " << left << setw(40) << User.Primisstions;
}
void ManageUsersMenuScreen();
void BackToUsersMenuScreen() {
	cout << "\nEnter Any Key to return to Main Menu....\n";
	system("pause>0");
	system("cls");
	ManageUsersMenuScreen();

}
void ListUseres() {
	vector <stUserInfo> Users;
	ReadAClientsFromTheFile(UseresFileName, Users);
	cout << "\n\t\t\t\t\tUsers List (" << Users.size() << ") Client(s).";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	cout << "| " << left << setw(15) << "User Name";
	cout << "| " << left << setw(10) << "Password";
	cout << "| " << left << setw(40) << "Premissions";
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;
	for (stUserInfo& User : Users) {

		PrintUserContenet(User);

		cout << endl;
	}
	cout << "\n_______________________________________________________";
	cout << "_________________________________________\n" << endl;


}
void AddUsersScreen() {
	vector <stUserInfo> Users;
	ReadAClientsFromTheFile(UseresFileName, Users);
	char AddMore = 'Y';
	do {
		system("cls");
		cout << "Adding New User:\n\n";
		AddNewUser();
		cout << "\nUser Added Successfully, do you want to add more clients? Y/N? ";
		cin >> AddMore;
	} while (toupper(AddMore) == 'Y');

}
void DeleteUserScreen() {
	vector <stUserInfo> vUsers;
	string UserName;
	stUserInfo  User;
	char Choice;
	ReadAClientsFromTheFile(UseresFileName, vUsers);
	cout << "\n=======================================================";
	cout << "\n\t\t\tDelete User Screecn  ";
	cout << "\n=======================================================";
	cout << "\nEnter User Name ?";
	getline(cin >> ws, UserName);

	if (UserName != "Admin") {
		if (IsUserInFile(UserName, vUsers, User))
		{
			cout << "\n\nThe Folowing is The User Ditales : \n\n";
			cout << "\n------------------------------------------------------";
			cout << "The User Name         : " << User.UserName << '\n';
			cout << "The User Password     : " << User.Password << '\n';
			cout << "The User Primisstions : " << User.Primisstions << '\n';
			cout << "\n------------------------------------------------------";
			cout << "\nAre u sure U Want To Delete This Client ? (Y/N) ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				DeleteUserFromTheFile(UserName);
				cout << "Client Deleted Succesfully\n";
			}

		}
		else
		{
			cout << "User With UserName (" << UserName << ") Not Found!\n";
		}
	}
	else
	{
		cout << "\n\nYou Can't Acces To Admin\n\n";
	}
	
}
void UpdateUsersScreen() {
	vector <stUserInfo> vUsers;
	string UserName;
	stUserInfo  User;
	char Choice;
	ReadAClientsFromTheFile(UseresFileName, vUsers);
	cout << "\n=======================================================";
	cout << "\n\t\t\tUpdate User Screecn  ";
	cout << "\n=======================================================";
	cout << "\nEnter User Name ?";
	getline(cin >> ws, UserName);
	if (UserName != "Admin")
	{


		if (IsUserInFile(UserName, vUsers, User))
		{
			cout << "\n\nThe Folowing is The User Ditales : \n\n";
			cout << "\n------------------------------------------------------";
			cout << "The User Name         : " << User.UserName << '\n';
			cout << "The User Password     : " << User.Password << '\n';
			cout << "The User Primisstions : " << User.Primisstions << '\n';
			cout << "\n------------------------------------------------------";
			cout << "\nAre u sure U Want To Update This Client ? (Y/N) ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				UpdateUsertFromTheFile(UserName);
				cout << "Client Deleted Succesfully\n";
			}

		}
		else
		{
			cout << "User With UserName (" << UserName << ") Not Found!\n";
		}
	}
	else
	{
		cout << "\n\nYou Can't Acces To Admin\n\n";
	}


}
void FindUserScreen() {
	vector <stUserInfo> vUsers;
	string UserName;
	stUserInfo  User;
	ReadAClientsFromTheFile(UseresFileName, vUsers);
	cout << "\n=======================================================";
	cout << "\n\t\t\tFind User Screecn  ";
	cout << "\n=======================================================";
	cout << "\nEnter User Name ?";
	getline(cin >> ws, UserName);
	if (IsUserInFile(UserName, vUsers, User))
	{

		cout << "\n\nThe Folowing is The User Ditales : \n\n";
		cout << "\n-------------------------------------------------------";
		cout << "The User Name         : " << User.UserName << '\n';
		cout << "The User Password     : " << User.Password << '\n';
		cout << "The User Primisstions : " << User.Primisstions<< '\n';
		cout << "\n-------------------------------------------------------";
	}
	else
	{
		cout << "User With UserName (" << UserName << ") Not Found!\n";
	}



}
void PreFromMangeUserMenuOption(enMangeUserOptions Option) {
	switch (Option)
	{
	case ListUsers:
		system("cls");
		ListUseres();
		BackToUsersMenuScreen();
		break;
	case AddANewUser:
		system("cls");
		AddUsersScreen();
		BackToUsersMenuScreen();
		break;
	case DeleteUser:
		system("cls");
		DeleteUserScreen();
		BackToUsersMenuScreen();
		break;
	case UpdateUser:
		system("cls");
		UpdateUsersScreen();
		BackToUsersMenuScreen();
		break;
	case FindUser:
		system("cls");
		FindUserScreen();
		BackToUsersMenuScreen();
		break;
	case TheMainMenu:
		system("cls");
		BackToMainMenu();
		break;
	default:
		break;
	}

}
void ManageUsersMenuScreen() {
	if (!CheckAccesPrimisstion(Option_Seven))
	{
		AccesDeniedScrreen();
		return;
	}
	vector <stUserInfo> Users;
	stUserInfo User;
	ReadAClientsFromTheFile(UseresFileName, Users);
	system("cls");
	cout << "\n=======================================================";
	cout << "\n\t\t\tManage Users Menu Screen";
	cout << "\n=======================================================\n";
	cout << "\n\t\t[" << 1 << "] List Users.";
	cout << "\n\t\t[" << 2 << "] Add New User.";
	cout << "\n\t\t[" << 3 << "] Delete User.";
	cout << "\n\t\t[" << 4 << "] Update User.";
	cout << "\n\t\t[" << 5 << "] Find user.";
	cout << "\n\t\t[" << 6 << "] Main Menu.";
	cout << "\n=======================================================" << endl;
	PreFromMangeUserMenuOption((enMangeUserOptions)ReadUserChoice("\nChoose What Do u Want to do ? [1 to 6] ? "));


}
void login();
void PerformMainMenuOption(enMainMenuOptions Option, vector <stInfo>& Clients) {

	switch (Option)
	{
	case ShowClients:
			system("cls");
			PrintClients(Clients);
			BackToMainMenu();
			break;
	case AddClient:
			AddClientsToFile();
			BackToMainMenu();
			break;
	case DeleteClient:
			system("cls");
			Find_DeleteClientByAccountNumber(ReadAccountNumber(), Clients);
			BackToMainMenu();
			break;
	case UpdateClient:
			system("cls");
			Find_UpdateClientByAccountNumber(ReadAccountNumber(), Clients);
			BackToMainMenu();
			break;
	case FindClient:
			system("cls");
			FindClientByAccountNumber(ReadAccountNumber(), Clients);
			BackToMainMenu();
			break;
	case Transactions:
			system("cls");
			TransactionsMenuScreen(Clients);
			BackToMainMenu();
			break;
	case ManageUsers:
			system("cls");
			ManageUsersMenuScreen();
			break;
	case Logout:
		system("cls");
		//PrintExitPage();
		login();
		break;
	default:
		cout << "\nWrong Choice :(\n";
		break;
	}
}
void ATMProject(vector <stInfo> Clients) {
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
	cout << "\n\t\t[" << 7 << "] Manage Users.";
	cout << "\n\t\t[" << 8 << "] Logout.";
	cout << "\n=======================================================" << endl;
	Choice = ReadUserChoice("Choose What Do u Want to do ? [1 to 7]?");
	PerformMainMenuOption((enMainMenuOptions)Choice, Clients);
}
bool CheckUserNameAndPassword(string UserName) {
	vector <stUserInfo> Users;
	stUserInfo User;
	
	string UserPassword;

	ReadAClientsFromTheFile(UseresFileName, Users);
	
	if (IsUserInFile(UserName, Users, User))
	{
		cout << "\nEnter Password ? ";
		getline(cin, UserPassword);
		if (User.Password==UserPassword)
		{
			return true;
		}

	}

	return false;
}
void login() {
	vector <stInfo> Clients;
	vector <stUserInfo> Users;
	
	ReadAClientsFromTheFile(UseresFileName, Users);
	string UserName;
	
	cout << "\n=======================================================";
	cout << "\n\t\t\tLogin Menu Screen";
	cout << "\n=======================================================\n";
	cout << "\nEnter User Name ? ";
	getline(cin >> ws, UserName);
	IsUserInFile(UserName, Users, User);
	while (!CheckUserNameAndPassword(UserName))
	{
		cout << "Invalid UserName/Password\n";
		cout << "\nEnter User Name ? ";
		getline(cin >> ws, UserName);
	}
	system("cls");
	ATMProject(Clients);




}
int main()
{

   login();
	
	
	system("pause<0");
}