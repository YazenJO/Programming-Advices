#pragma once
#include <iostream>
#include "clsBankClient.h"
#include "clsInputValidate.h"
#include "clsScreen.h"
using namespace std;
class clsWithdrawScreen :protected clsScreen
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

	static double _ReadWithdrawConst() {
		double Withdraw;
		cout << "\n\nPlease Enter Withdraw amount?";
		Withdraw = clsInputValidate::ReadDblNumber();
		return Withdraw;
	}

public:
	static void Withdraw() {
		char Awnser = 'n';
		string AccountNumber = "";
		char Choice;
		clsScreen::_DrawScreenHeader("\tWithdraw Screen");
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
		double Amount = _ReadWithdrawConst();
		while (!Client1.Withdraw(Amount))
		{
			cout << "\n\nAmount Exceeds The Balance , you can Withdraw up to : " << Client1.AccountBalance;
			cout << "\nPlease Enter Withdrow amount?\n";
			cin >> Amount;

		}
		cout << "\nAre you sure you Want To perform this transactions :   ";
		cin >> Awnser;
		if (tolower(Awnser) == 'y')
		{
			
			cout << "\nAmount Withdrawed Successful";
			cout << "\nNew Balance Is: " << Client1.AccountBalance;

		}
		else
		{
			cout << "\nWithdraw Transaction Has Been Canceled";
		}



	}

};

