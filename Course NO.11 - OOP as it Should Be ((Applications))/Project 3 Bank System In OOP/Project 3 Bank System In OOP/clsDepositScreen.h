#pragma once
#include <iostream>
#include "clsBankClient.h"
#include "clsInputValidate.h"
#include "clsScreen.h"
using namespace std;
class clsDepositScreen:protected clsScreen
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

	static double _ReadDepositConst() {
		double Deposit;
		cout << "\n\nPlease Enter deopsit amount?";
		Deposit = clsInputValidate::ReadDblNumber();
		return Deposit;
	}

public:
	static void Deposit() {
		char Awnser = 'n';
		string AccountNumber = "";
		char Choice;
		clsScreen::_DrawScreenHeader("\tDeposit Screen");
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
		double Amount = _ReadDepositConst();
		cout << "\nAre you sure you Want To perform this transactions :   ";
		cin >> Awnser;
		if (tolower(Awnser)=='y')
		{
			Client1.Deposit(Amount);
			cout << "\nAmount Deposited Successful";
			cout << "\nNew Balance Is: " << Client1.AccountBalance;
    
		}
		else
		{
			cout << "\nDeposit Transaction Has Been Canceled";
		}
		
		

	}

};

