#pragma once
#include <iostream>
#include "clsScreen.h"
#include  "clsBankClient.h"
#include "clsMainScreen.h"
#include "clsScreen.h"
using namespace std;

class clsDeleteClientScreen :public clsScreen
{
private:
	static void _PrintClientInfo(clsBankClient Client) {
		cout << "\n Client Card :\n";
		cout << "\n____________________";
		cout << "\nFirstName      : " << Client.FirstName;
		cout << "\nLastName       : " << Client.LastName;
		cout << "\nFullName       : " << Client.FullName();
		cout << "\nEmail          : " << Client.Email;
		cout << "\nPhone          : " << Client.Phone;
		cout << "\nAccountNumber  : " << Client.AccountNumber();
		cout << "\nPassword       : " << Client.PinCode;
		cout << "\nBalance        : " << Client.AccountBalance;
		cout << "\n____________________";

	}

public:
	static void DeleteClientScreen() {
		if (!clsScreen::CheckAccesRights(clsUser::enPermissions::pDeleteClient))
		{
			return;
		}
	string AccountNumber = "";
	char Choice;
	clsScreen::_DrawScreenHeader("\tDelete User Screen");
	cout << "\nPlease Enter Account Number: ";
	AccountNumber = clsInputValidate::ReadString();
	while (!clsBankClient::IsClientExist(AccountNumber))
	{
		cout << "\nAccount Number is not found Enter Another Number";
		cout << "\nEnter AccountNumber : ";
		AccountNumber = clsInputValidate::ReadString();
	}
	clsBankClient Client1 = clsBankClient::Find(AccountNumber);
	_PrintClientInfo(Client1);
	cout << "\nDo u Want To Delete Client : ";
	cin >> Choice;
	if (tolower(Choice)=='y')
	{
		if (Client1.DeleteClient())
		{
			cout << "\nClient Deleted Succefully";
		}

	}




	}
};

