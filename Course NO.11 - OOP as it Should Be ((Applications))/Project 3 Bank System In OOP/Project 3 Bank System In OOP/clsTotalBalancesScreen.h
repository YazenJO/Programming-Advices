#pragma once
#include<vector>
#include <iostream>
#include "clsBankClient.h"
#include "clsUtil.h"
#include <iomanip>
using namespace std;
class clsTotalBalancesScreen :protected clsScreen
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
	static void ShowTotalBalance() {
		vector <clsBankClient> VClientData = clsBankClient::GetClientList();
		clsScreen::_DrawScreenHeader("\tTotal Balances Screen");
		cout << "\n\t\t\t\t\tClient List (" << VClientData.size() << ") Client(s).";
		cout << "\n_______________________________________________________";
		cout << "_________________________________________\n" << endl;
		cout << "| " << left << setw(15) << "Accout Number";
		cout << "| " << left << setw(10) << "Pin Code";
		cout << "| " << left << setw(40) << "Client Name";
		cout << "| " << left << setw(12) << "Phone";
		cout << "| " << left << setw(12) << "Balance";
		cout << "\n_______________________________________________________";
		cout << "_________________________________________\n" << endl;


		if (VClientData.size() == 0)
			cout << "\t\t\t\tNo Clients Available In the System!";
		else
		{
			for (clsBankClient& Client : VClientData) {

				_PrintClientInfo(Client);

				cout << endl;
			}

		}


		cout << "\n_______________________________________________________";
		cout << "_________________________________________\n" << endl;
		float TotalBalance = clsBankClient::GetTotalBalance();
		cout << "\t\t\t\t\t  | " << left << setw(15) << "Total Balacne : " << TotalBalance;
		cout << "\n\t\t\t\t\t  " << left << clsUtil::numberToText(TotalBalance);

	}
};

