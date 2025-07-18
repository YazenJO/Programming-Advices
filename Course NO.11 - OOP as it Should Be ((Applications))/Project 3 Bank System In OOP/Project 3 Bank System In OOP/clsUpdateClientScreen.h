#pragma once
#include <iostream>
#include "clsScreen.h"
#include  "clsBankClient.h"
#include "clsMainScreen.h"
using namespace std;

class clsUpdateClientScreen:protected clsScreen
{
private:

	static void _ReadClientInfo(clsBankClient& Client) {
		cout << "\nEnter FirstName: ";
		Client.FirstName = clsInputValidate::ReadString();
		cout << "\nEnter LastName: ";
		Client.LastName = clsInputValidate::ReadString();
		cout << "\nEnter Email: ";
		Client.Email = clsInputValidate::ReadString();
		cout << "\nEnter Phone: ";
		Client.Phone = clsInputValidate::ReadString();
		cout << "\nEnter PinCode: ";
		Client.PinCode = clsInputValidate::ReadString();
		cout << "\nEnter Account Balance: ";
		Client.AccountBalance = clsInputValidate::ReadDblNumber();

	}
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
	static  void _GoBackToMainMenu()
	{
		cout << setw(37) << left << "" << "\n\tPress any key to go back to Main Menu...\n";

		system("pause>0");
		
	}

public:

	static void UpdateClientScreen() {
		if (!clsScreen::CheckAccesRights(clsUser::enPermissions::pUpdateClients))
		{
			return;
		}
		string AccountNumber = "";
		char Choice;
		clsScreen::_DrawScreenHeader("\tUpdate Client Screen");
		cout << "\nEnter AccountNumber : ";
		AccountNumber = clsInputValidate::ReadString();
		while (!clsBankClient::IsClientExist(AccountNumber))
		{
			cout << "\nAccount Number is not found Enter Another Number";
			cout << "\nEnter AccountNumber : ";
			AccountNumber = clsInputValidate::ReadString();
		}
		clsBankClient Client1 = clsBankClient::Find(AccountNumber);
		_PrintClientInfo(Client1);
		cout << "\n\nUpdate Client Info:";
		cout << "\n_____________________\n";
		cout << "\nAre You Sure Want To Upadate This CLient ? (y/n)?";
		cin >> Choice;
		if (tolower(Choice) == 'y')
		{


			_ReadClientInfo(Client1);
			clsBankClient::enSave SaveResult;
			SaveResult = Client1.Save();
			switch (SaveResult)
			{
			case clsBankClient::svFaildEmptyObject:
				cout << "\nAccount Not Saved :(";
				break;
			case clsBankClient::svSucceded:
				cout << "\nAccount Updated Succsefully";
				_PrintClientInfo(Client1);
				break;
			default:
				break;
			}
		}
		else
		{
			cout << "\nAccount Update Hase Been Canceld\n\n";
		}
	}

};

