#pragma once
#include "clsScreen.h"
#include  "clsBankClient.h"
class clsAddNewClientScreen :protected clsScreen
{
private :

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


public:
	static void AddNewClient() {
		if (!clsScreen::CheckAccesRights(clsUser::enPermissions::pAddNewClient))
		{
			return;
		}
		string AccountNumber = "";
		clsScreen::_DrawScreenHeader("\tAdd New Client Screen");
		cout << "\nPlease Enter Account Number: ";
		AccountNumber = clsInputValidate::ReadString();
		while (clsBankClient::IsClientExist(AccountNumber))
		{
			cout << "\nAccounat Number Is Already used, Choose another one : ";
			AccountNumber = clsInputValidate::ReadString();
		}
		clsBankClient NewClient = clsBankClient::GetAddNewClientobject(AccountNumber);
		_ReadClientInfo(NewClient);
		clsBankClient::enSave SaveResult;
		SaveResult = NewClient.Save();

		switch (SaveResult)
		{
		case clsBankClient::svFaildEmptyObject:
			cout << "\nAccount Not Saved  :(";
			break;
		case clsBankClient::svFaildAccountNumberExist:
			cout << "\nAccount Not Added bcs AccountNumber Exist :(";
			break;
		case clsBankClient::svSucceded:
			cout << "\nAccount Added Succsefully";
			_PrintClientInfo(NewClient);
			break;
		default:
			break;
		}

	}

};

