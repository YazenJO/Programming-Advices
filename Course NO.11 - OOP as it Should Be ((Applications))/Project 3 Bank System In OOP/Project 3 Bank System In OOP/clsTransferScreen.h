#pragma once
#include "clsScreen.h"
#include "clsUser.h"
#include "clsBankClient.h"
#include "clsInputValidate.h"
class clsTransferScreen :protected clsScreen
{
private:
    static void _PrintClient(clsBankClient Client)
    {
        cout << "\nUser Card:";
        cout << "\n___________________";
        cout << "\nFull Name       : " << Client.FullName();
        cout << "\nAccount Number  : " << Client.AccountNumber();
		cout << "\nBalance         : " << Client.AccountBalance;
        cout << "\n___________________\n";

    }
public:
	static void TransferScreen() {
		clsScreen::_DrawScreenHeader("\tTransfer Screen");
		string FromAccountNumber;
		string ToAccountNumber;
		float TransferAmount;
		cout << "\n\nPlease Enter Account Number To Transfer From : ";
		FromAccountNumber=clsInputValidate::ReadString();

		while (!clsBankClient::IsClientExist(FromAccountNumber))
		{
			cout << "\nAccount number is not found, choose another one: ";
			FromAccountNumber = clsInputValidate::ReadString();
		}


		clsBankClient TransferFromUser = clsBankClient::Find(FromAccountNumber);
		_PrintClient(TransferFromUser);

		cout << "\n\nPlease Enter Number To Transfer To : ";
		ToAccountNumber = clsInputValidate::ReadString();
		while (!clsBankClient::IsClientExist(ToAccountNumber))
		{
			cout << "\nAccount number is not found, choose another one: ";
			ToAccountNumber = clsInputValidate::ReadString();
		}
		clsBankClient TransferToUser = clsBankClient::Find(ToAccountNumber);
		_PrintClient(TransferToUser);

		cout << "\nEnter Transfer Amount ?";
		cin >> TransferAmount;

		while (!TransferFromUser.Transfer(TransferAmount, TransferToUser)) {
			cout << "Amount Exceeds the available Balance, Enter another Amount ?";
			cin >> TransferAmount;
		} 
		cout << "\nAre you sure you want to perform this operation? y/n? ";
		char Answer = 'n';
		cin >> Answer;
		if (tolower(Answer) =='y')
		{
			cout << "\nTransfer Done Succesfully \n";

			_PrintClient(TransferFromUser);
			_PrintClient(TransferToUser);

		}
		else
		{
			cout << "\nTransfer Canceld \n";
			return;
		}


		
			
	}
};

