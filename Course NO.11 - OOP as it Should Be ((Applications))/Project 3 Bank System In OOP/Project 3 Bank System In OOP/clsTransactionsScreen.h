#pragma once
#include <iostream>
#include "clsScreen.h"
#include <iomanip>
#include "clsBankClient.h"
#include "clsInputValidate.h"
#include "clsDepositScreen.h"
#include "clsWithdrawScreen.h"
#include "clsTotalBalancesScreen.h"
#include "clsMainScreen.h"
#include "clsTransferScreen.h"
#include "clsTransferLogScreen.h"
using namespace std;
class clsTransactionsScreen :protected clsScreen
{
private:
	enum enTransactionsOptions { Deposite = 1, Withdrraw = 2, TotalBalane = 3,Transfer=4,TransferLog=5, MainMenu = 6 };
	static void _ShowDepositMenu() {
		clsDepositScreen::Deposit();
	}
	static void _ShowWithDrowMenu() {
		clsWithdrawScreen::Withdraw();
 	}
	static void _ShowTotalBalanceMenu() {
		clsTotalBalancesScreen::ShowTotalBalance();
	}
	static void _ShowTransferScreen() {
		clsTransferScreen::TransferScreen();
	}
	static void _ShowTransferLogScreen() {
		clsTransferLogScreen::TransferLogScreen();
	}

	static void _BackToTransactionsMenu() {
		cout << setw(37) << left << "" << "\n\tPress any key to go back to Transactions Menu...\n";

		system("pause>0");
		TransactionsMenuScreen();
	}
	static short _ReadTransactionsMenuOption() {
		short Choice;
		cout << setw(37) << left << "\t\t\t\t\tChoose What Do u Want to do ? [1 to 6] ? ";
		Choice = clsInputValidate::ReadShortNumberBetween(1, 6);
		return Choice;


	}

	static void _PreformTransactionsMenuOption(enTransactionsOptions Choice) {
		switch (Choice)
		{
		case Deposite:
			system("cls");
			_ShowDepositMenu();
			_BackToTransactionsMenu();
			break;
		case Withdrraw:
			system("cls");
			_ShowWithDrowMenu();
			_BackToTransactionsMenu();
			break;
		case TotalBalane:
			system("cls");
			_ShowTotalBalanceMenu();
			_BackToTransactionsMenu();
			break;
		case Transfer:
			system("cls");
			_ShowTransferScreen();
			_BackToTransactionsMenu();
			break;
		case TransferLog:
			system("cls");
			_ShowTransferLogScreen();
			_BackToTransactionsMenu();
			break;

		case MainMenu:
			{}
		}
	}
public:
	static void TransactionsMenuScreen() {
		system("cls");
		if (!clsScreen::CheckAccesRights(clsUser::enPermissions::pTranactions))
		{
			return;
		}
		
		_DrawScreenHeader("\t  Transactions Screen");

		cout << setw(37) << left << "" << "===========================================\n";
		cout << setw(37) << left << "" << "\t\t  Transactions Menu\n";
		cout << setw(37) << left << "" << "===========================================\n";
		cout << setw(37) << left << "" << "\t[1] Deposit.\n";
		cout << setw(37) << left << "" << "\t[2] Withdraw.\n";
		cout << setw(37) << left << "" << "\t[3] Total Balances.\n";
		cout << setw(37) << left << "" << "\t[4] Transfer.\n";
		cout << setw(37) << left << "" << "\t[5] Transfer Log.\n";
		cout << setw(37) << left << "" << "\t[6] Main Menu.\n";
		cout << setw(37) << left << "" << "===========================================\n";

		_PreformTransactionsMenuOption((enTransactionsOptions)_ReadTransactionsMenuOption());
	}
};

