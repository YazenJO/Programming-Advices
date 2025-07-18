#pragma once
#include <iostream>
#include <vector>
#include "clsInputValidate.h"
#include "clsBankClient.h"
#include <iomanip>
#include "clsUtil.h"
#include "clsScreen.h"
#include "clsClientListScreen.h"
#include "clsAddNewClientScreen.h"
#include "clsUpdateClientScreen.h"
#include "clsFindClientScreen.h"
#include "clsTransactionsScreen.h"
#include "clsDeleteClientScreen.h"
#include "clsManageUserScreen.h"
#include "clsLoginRegisterScreen.h"
#include "clsCurrencyMainScreen.h"
#include "clsGlobal.h"
using namespace std;
class clsMainScreen : protected clsScreen
{
private:
    enum enMainMenuOptions {
        eListClients = 1, eAddNewClient = 2, eDeleteClient = 3,
        eUpdateClient = 4, eFindClient = 5, eShowTransactionsMenu = 6,
        eManageUsers = 7,eLoginRegister=8,eShowCerruncyMenu=9, eExit = 10
    };
    static short _ReadMainMenuOption() {
		short Choice;
		cout << setw(37) << left << "\t\t\t\t\tChoose What Do u Want to do ? [1 to 10] ? ";
		Choice = clsInputValidate::ReadShortNumberBetween(1, 10);
		return Choice;


	}
    static  void _GoBackToMainMenu()
    {
        cout << setw(37) << left << "" << "\n\tPress any key to go back to Main Menu...\n";

        system("pause>0");
        ShowMainMenuScreen();
    }

    static void _ShowAllClientsScreen()
    {
        clsClientListScreen::ShowClientsList();
    }

    static void _ShowAddNewClientsScreen()
    {
        clsAddNewClientScreen::AddNewClient();
    }

    static void _ShowDeleteClientScreen()
    {
        clsDeleteClientScreen::DeleteClientScreen();
    }

    static void _ShowUpdateClientScreen()
    {
        clsUpdateClientScreen::UpdateClientScreen();
        
    }

    static void _ShowFindClientScreen()
    {
        clsFindClientScreen::FindClientScreen();

    }

    static void _ShowTransactionsMenu()
    {
        clsTransactionsScreen::TransactionsMenuScreen();

    }
    static void _ShowCurrencyExchangeMenu()
    {
        clsCurrencyMainScreen::CurrencyMenuScreen();

    }

    static void _ShowManageUsersMenu()
    {
        
        clsManageUserScreen::ShowManageUserMenu();
    }
    static void _ShowLoginRegisterScreen()
    {
        
        clsLoginRegisterScreen::ShowLoginRegisterList();
    }
    static void _ShowEndScreen()
    {
        CurrentUser = clsUser::Find("", "");
        

    }

    static void _PerfromMainMenuOption(enMainMenuOptions MainMenuOption)
    {
        switch (MainMenuOption)
        {
        case enMainMenuOptions::eListClients:
        {
            system("cls");
            _ShowAllClientsScreen();
            _GoBackToMainMenu();
            break;
        }
        case enMainMenuOptions::eAddNewClient:
            system("cls");
            _ShowAddNewClientsScreen();
            _GoBackToMainMenu();
            break;

        case enMainMenuOptions::eDeleteClient:
            system("cls");
            _ShowDeleteClientScreen();
            _GoBackToMainMenu();
            break;

        case enMainMenuOptions::eUpdateClient:
            system("cls");
            _ShowUpdateClientScreen();
            _GoBackToMainMenu();
            break;

        case enMainMenuOptions::eFindClient:
            system("cls");
            _ShowFindClientScreen();
            _GoBackToMainMenu();
            break;

        case enMainMenuOptions::eShowTransactionsMenu:
            system("cls");
            _ShowTransactionsMenu();
            _GoBackToMainMenu();
            break;

        case enMainMenuOptions::eManageUsers:
            system("cls");
            _ShowManageUsersMenu();
            _GoBackToMainMenu();
            break;
        case enMainMenuOptions::eLoginRegister:
            system("cls");
            _ShowLoginRegisterScreen();
            _GoBackToMainMenu();
            break;
        case enMainMenuOptions::eShowCerruncyMenu:
            system("cls");
            _ShowCurrencyExchangeMenu();
            _GoBackToMainMenu();
            break;

        case enMainMenuOptions::eExit:
            system("cls");
            _ShowEndScreen();

            break;
        }

    }

public:
  static void ShowMainMenuScreen() {

      system("cls");
      _DrawScreenHeader("\t\tMain Screen");

      cout << setw(37) << left << "" << "===========================================\n";
      cout << setw(37) << left << "" << "\t\t\tMain Menu\n";
      cout << setw(37) << left << "" << "===========================================\n";
      cout << setw(37) << left << "" << "\t[1] Show Client List.\n";
      cout << setw(37) << left << "" << "\t[2] Add New Client.\n";
      cout << setw(37) << left << "" << "\t[3] Delete Client.\n";
      cout << setw(37) << left << "" << "\t[4] Update Client Info.\n";
      cout << setw(37) << left << "" << "\t[5] Find Client.\n";
      cout << setw(37) << left << "" << "\t[6] Transactions.\n";
      cout << setw(37) << left << "" << "\t[7] Manage Users.\n";
      cout << setw(37) << left << "" << "\t[8] Login Register.\n";
      cout << setw(37) << left << "" << "\t[9] Currency Exchange.\n";
      cout << setw(37) << left << "" << "\t[10] Logout.\n";
      cout << setw(37) << left << "" << "===========================================\n";

      _PerfromMainMenuOption((enMainMenuOptions)_ReadMainMenuOption());

}

};

