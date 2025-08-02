#include <iostream>
#include <fstream>
#include<vector>
#include <string>
#include <iomanip>

using namespace std;
const string ClientsFileName = "C:\\Users\\yazen\\OneDrive\\Desktop\\C++\\Course NO. 8 - Algorithms & Problem Solving Level 4\\Bank Extension 2 opreatore\\Bank Extension 2 opreatore\\Clients.txt";
enum enMainMenuOptions { QuickWithdraw = 1, NormalWithdraw = 2, Deposit = 3, CheckBalance = 4, Logout = 5 };
struct stInfo {

	string AccountNumber;
	string PinCode;
	string Name;
	string PhoneNumber;
	double AccountBalacne;
};
stInfo gClient;

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
void BackToMainMenu();
short ReadUserChoice(string Massage) {
	short Choice;
	cout << Massage << "\n";
	cin >>ws>> Choice;

	return Choice;

}
void DepositAClientBalance( double Deposit) {
	string ClientBeforUpdate;
			ClientBeforUpdate = ConvertRecordToLine(gClient);
			gClient.AccountBalacne += Deposit;
			ConvertRecordToLine(gClient);
			UpdateRecordInFile(ClientsFileName, ClientBeforUpdate, ConvertRecordToLine(gClient));

}
void WidrowAClientBalance( double Witdraw) {
	string ClientBeforUpdate;
			ClientBeforUpdate = ConvertRecordToLine(gClient);
			gClient.AccountBalacne -= Witdraw;
			ConvertRecordToLine(gClient);
			UpdateRecordInFile(ClientsFileName, ClientBeforUpdate, ConvertRecordToLine(gClient));

}
void ATMProject();
void login();
int WithdriwOptions(short Choice) {
	switch (Choice)
	{
	case 1:
		return  20;
case 2:
		return  50;
	case 3:
		return  100;
		
	case 4:
		return  200;
	
	case 5:
		return  400;
	
	case 6:
		return  600;
		
	case 7:
		return  800;
		
	case 8:
		return  1000;

	}
}
void QuickWithdrowScreen();
void PreFormWithdorwMenu(int Withdrow) {
	char Choice;
	while (Withdrow > gClient.AccountBalacne)
	{
		cout << "\n\nAmount Exceeds The Balance , you can Withdraw up to : " << gClient.AccountBalacne;
		cout << "\nSeclect Another Choice ";
		system("pause>0");
		system("cls");

		QuickWithdrowScreen();
	}
	cout << "\nAre U Sure You Want Perform This transactions ? y/n ? ";
	cin >> Choice;
	if (toupper(Choice)=='Y')
	{
		WidrowAClientBalance(Withdrow);
		cout << "\n\nDone Successfulyy.New Balance is : " << gClient.AccountBalacne;
	}
	BackToMainMenu();
	




}
void QuickWithdrowScreen() {
	short Choice;

	cout << "\n=======================================================";
	cout << "\n\t\t\tQuick Withdrow Screen  ";
	cout << "\n=======================================================";
	cout << "\n\t\t[" << 1 << "] 20\t\t[2] 50";
	cout << "\n\t\t[" << 3 << "] 100\t\t[4] 50";
	cout << "\n\t\t[" << 5 << "] 400\t\t[6] 50";
	cout << "\n\t\t[" << 7 << "] 800\t\t[8] 1000";
	cout << "\n\t\t[" << 9<< "] Exit.";
	cout << "\n=======================================================" << endl;
	cout << "Your Balance is " << gClient.AccountBalacne;
	Choice = ReadUserChoice("\nChoose What Do u Want to do ? [1 to 9]?");
	if (Choice ==9)
	{
		BackToMainMenu();
	}
	PreFormWithdorwMenu(WithdriwOptions(Choice));
}
bool CheckWithdrow(int &Withdrow){
	
	do
	{
		cout << "\n\nEnter an amount multiple of 5's ?";
	cin >> Withdrow;
	} 	while (Withdrow % 5 != 0);
	while (Withdrow > gClient.AccountBalacne)
	{
		cout << "\n\nAmount Exceeds The Balance , you can Withdraw up to : " << gClient.AccountBalacne;
		cout << "\nPlease Enter Withdrow amount?\n";
		cin >> Withdrow;
	}
	return Withdrow;
}
void NormalWithdrowScreen() {
	int Withdrow;
	char Choice;
	cout << "\n=======================================================";
	cout << "\n\t\t\tNormal Withdrow Screen  ";
	cout << "\n=======================================================";
		
	if (CheckWithdrow(Withdrow))
	{
		cout << "\nAre U Sure You Want Perform This transactions ? y/n ? ";
		cin >> Choice;
		if (toupper(Choice) == 'Y')
		{
			WidrowAClientBalance(Withdrow);
			cout << "\n\nDone Successfulyy.New Balance is : " << gClient.AccountBalacne;
		}
		
	}
	BackToMainMenu();
		
	
}
void BackToMainMenu() {
	cout << "\nEnter Any Key to return to Main Menu....\n";
	system("pause>0");
	system("cls");
	ATMProject();

}
void PrintTotalBalanceCintent(stInfo Client) {


	cout << "| " << left << setw(15) << Client.AccountNumber;
	cout << "| " << left << setw(40) << Client.Name;
	cout << "| " << left << setw(12) << Client.AccountBalacne;

}
void DepositScreen() {
	int Deposite;
	char Choice;
	cout << "\n=======================================================";
	cout << "\n\t\t\tNormal Withdrow Screen  ";
	cout << "\n======================================================="; 
	cout << "\nEnter a positive Deposit Amount ?";
	cin >> Deposite;
	cout << "\nAre U Sure You Want Perform This transactions ? y/n ? ";
	cin >> Choice;
	if (toupper(Choice) == 'Y')
	{
		DepositAClientBalance(Deposite);
		cout << "\n\nDone Successfulyy.New Balance is : " << gClient.AccountBalacne;
	}
	BackToMainMenu();
	


}
void PrintExitPage() {
	system("cls");
	cout << "\n=======================================================";
	cout << "\n\t\t\tProgram End  ";
	cout << "\n=======================================================\n";
	system("pause");
}
void CheckBalanceScreen() {
	cout << "\n=======================================================";
	cout << "\n\t\t\tNormal Withdrow Screen  ";
	cout << "\n=======================================================";
	cout << "\nYour Balance is " << gClient.AccountBalacne;
	BackToMainMenu();

}
void PerformMainMenuOption(enMainMenuOptions Option) {

	switch (Option)
	{
	case QuickWithdraw:
		system("cls");
		QuickWithdrowScreen();
		BackToMainMenu();
		break;
	case  NormalWithdraw:
		system("cls");
		NormalWithdrowScreen();
		BackToMainMenu();
		break;
	case Deposit:
		system("cls");
		DepositScreen();
		BackToMainMenu();
		break;
	case CheckBalance:
		system("cls");
		CheckBalanceScreen();
		BackToMainMenu();
		break;
	case Logout:
		system("cls");
		login();
		break;
	default:
		cout << "\nWrong Choice :(\n";
		break;
	}
}
void ATMProject() {
	short Choice;

	cout << "\n=======================================================";
	cout << "\n\t\t\tATM Main Menu Screen  ";
	cout << "\n=======================================================";
	cout << "\n\t\t[" << 1 << "] Quick Withdraw.";
	cout << "\n\t\t[" << 2 << "] Normal Withdraw.";
	cout << "\n\t\t[" << 3 << "] Deposit.";
	cout << "\n\t\t[" << 4 << "] Check Balance.";
	cout << "\n\t\t[" << 5 << "] Logout.";
	cout << "\n=======================================================" << endl;
	Choice = ReadUserChoice("Choose What Do u Want to do ? [1 to 5]?");
	PerformMainMenuOption((enMainMenuOptions)Choice);
}
bool CheckCAccountNumberAndPinCode(string AccountNumber) {
	vector <stInfo> vClients;
	stInfo Client;

	string ClientPinCode;

	ReadAClientsFromTheFile(ClientsFileName, vClients);

	if (IsClientInFile(AccountNumber, vClients, Client))
	{
		cout << "\nEnter Password ? ";
		getline(cin, ClientPinCode);
		if (Client.PinCode== ClientPinCode)
		{
			return true;
		}

	}

	return false;
}
void login() {
	vector <stInfo> Clients;
	ReadAClientsFromTheFile(ClientsFileName, Clients);
	string AccountNumber;

	cout << "\n=======================================================";
	cout << "\n\t\t\tLogin Menu Screen";
	cout << "\n=======================================================\n";
	cout << "\nEnter User Name ? ";
	getline(cin >> ws, AccountNumber);
	IsClientInFile(AccountNumber, Clients, gClient);
	while (!CheckCAccountNumberAndPinCode(AccountNumber))
	{
		cout << "Invalid UserName/Password\n";
		cout << "\nEnter User Name ? ";
		getline(cin >> ws, AccountNumber);
	}
	system("cls");
	ATMProject();




}

int main()
{
	login();
	system("pause<0");
}

