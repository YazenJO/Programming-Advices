#pragma once
#include "clsCurrency.h"
#include "clsScreen.h"
#include "iomanip"
#include <vector>
#include "clsCurrenyListScreen.h"
#include "clsFindCurrencyScreen.h"
#include "clsUpdateCurrencyScreen.h"
#include "clsCurrencyCalculate.h"
using namespace std;
class clsCurrencyMainScreen :protected clsScreen
{
private:
	enum enCurrencyExchangeOptions { List = 1, Find = 2, UpdateRate = 3, CurrencyCalculate = 4,  MainMenu = 5};
	static void _ShowListScreen() {
		clsCurrenyListScreen::ShowCurrencyList();
	}
	static void _ShowFindScreen() {
		clsFindCurrencyScreen::FindCuttencyScreen();
	}
	static void _ShowUpdateRateScren() {
		clsUpdateCurrencyScreen::UpdateCurrencyRate();
	}
	static void _ShowCurrencyCalculateScreen() {
		clsCurrencyCalculate::CurrencyCalculate();

	}

	static void _BackToTransactionsMenu() {
		cout << setw(37) << left << "" << "\n\tPress any key to go back to Transactions Menu...\n";

		system("pause>0");
		CurrencyMenuScreen();
	}
	static short _ReadTransactionsMenuOption() {
		short Choice;
		cout << setw(37) << left << "\t\t\t\t\tChoose What Do u Want to do ? [1 to 5] ? ";
		Choice = clsInputValidate::ReadShortNumberBetween(1, 5);
		return Choice;


	}


	static void _PreformCurrencyMenuOption(enCurrencyExchangeOptions Choice) {
		switch (Choice)
		{
		case clsCurrencyMainScreen::List:
			system("cls");
			_ShowListScreen();
			_BackToTransactionsMenu();
			break;
		case clsCurrencyMainScreen::Find:
			system("cls");
			_ShowFindScreen();
			_BackToTransactionsMenu();
			break;
		case clsCurrencyMainScreen::UpdateRate:
			system("cls");
			_ShowUpdateRateScren();
			_BackToTransactionsMenu();
			break;
		case clsCurrencyMainScreen::CurrencyCalculate:
			system("cls");
			_ShowCurrencyCalculateScreen();
			_BackToTransactionsMenu();
			break;
		case clsCurrencyMainScreen::MainMenu:
			{}
		}
	
	}

public:
	static void CurrencyMenuScreen() {
		system("cls");
		//if (!clsScreen::CheckAccesRights(clsUser::enPermissions::pTranactions))
		//{
		//	return;
		//}

		_DrawScreenHeader("\t  Currency Screen");

		cout << setw(37) << left << "" << "===========================================\n";
		cout << setw(37) << left << "" << "\t\t  Currency Exchange Menu\n";
		cout << setw(37) << left << "" << "===========================================\n";
		cout << setw(37) << left << "" << "\t[1] List Currencies.\n";
		cout << setw(37) << left << "" << "\t[2] Find Currencies.\n";
		cout << setw(37) << left << "" << "\t[3] Update Rate.\n";
		cout << setw(37) << left << "" << "\t[4] Currency Calculate.\n";
		cout << setw(37) << left << "" << "\t[5] Main Menu.\n";
		cout << setw(37) << left << "" << "===========================================\n";

		_PreformCurrencyMenuOption((enCurrencyExchangeOptions)_ReadTransactionsMenuOption());
	}
};

