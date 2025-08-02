#pragma once
#pragma once
#include <iostream>
#include <vector>
#include "clsInputValidate.h"
#include "clsBankClient.h"
#include <iomanip>
#include "clsUtil.h"
#include "clsScreen.h"
#include "clsUserListScreen.h"
#include "clsAddNewUserScreen.h"
#include "clsDeleteUserScreen.h"
#include "clsUpdateUserScreen.h"
#include "clsFindUserScreen.h"
class clsManageUserScreen:public clsScreen
{

private:
	enum enMangeUserOptions { ListUsers = 1, AddANewUser = 2, DeleteUser = 3, UpdateUser = 4, FindUser = 5, TheMainMenu = 6 };
    static short _ReadMainMenuOption(){
		short Choice;
		cout << setw(37) << left << "\t\t\t\t\tChoose What Do u Want to do ? [1 to 6] ? ";
		Choice = clsInputValidate::ReadShortNumberBetween(1, 6); 
		return Choice;
	}
	static void _ShowAllUsersScreen() {
		clsUserListScreen::ShowUsersList();
	};
	static void _ShowAddNewUsersScreen() {
		clsAddNewUserScreen::AddNewUserScreen();
	};
	static void _ShowDeleteUserScreen() {
		clsDeleteUserScreen::DeleteUserScreen();
	};
	static void _ShowUpdateUserscreen() {
		clsUpdateUserScreen::ShowUpdateUserScreen();
	};
	static void _GoBackManageUserMenu() {
		
			cout << setw(37) << left << "" << "\n\tPress any key to go back to Main Menu...\n";

			system("pause>0");

			ShowManageUserMenu();
	
	}
	static void _ShowFindUserscreen() {
		clsFindUserScreen::ShowFindUserScreen();
	};
	static void _GoBackMainMenuMenu()
	{

	}
	static void _PerfromManageUserMenu(enMangeUserOptions Choice) {
		switch (Choice)
		{
		case clsManageUserScreen::ListUsers:
			system("cls");
			_ShowAllUsersScreen();
			_GoBackManageUserMenu();
			break;
		case clsManageUserScreen::AddANewUser:
			system("cls");
			_ShowAddNewUsersScreen();
			_GoBackManageUserMenu();
			break;
		case clsManageUserScreen::DeleteUser:
			system("cls");
			_ShowDeleteUserScreen();
			_GoBackManageUserMenu();
			break;
		case clsManageUserScreen::UpdateUser:
			system("cls");
			_ShowUpdateUserscreen();
			_GoBackManageUserMenu();
			break;
		case clsManageUserScreen::FindUser:
			system("cls");
			_ShowFindUserscreen();
			_GoBackManageUserMenu();
			break;
		case clsManageUserScreen::TheMainMenu:
			{}
		}

	
	}
public:
	static void ShowManageUserMenu() {
		system("cls");
		if (!clsScreen::CheckAccesRights(clsUser::enPermissions::pManageUsers))
		{
			return;
		}
		clsScreen::_DrawScreenHeader("\tMange User Screen");
		cout << setw(37) << left << "" << "===========================================\n";
		cout << setw(37) << left << "" << "\t\t  Manage Users Menue\n";
		cout << setw(37) << left << "" << "===========================================\n";
		cout << setw(37) << left << "" << "\t[1] List Users.\n";
		cout << setw(37) << left << "" << "\t[2] Add New User.\n";
		cout << setw(37) << left << "" << "\t[3] Delete User.\n";
		cout << setw(37) << left << "" << "\t[4] Update User.\n";
		cout << setw(37) << left << "" << "\t[5] Find User.\n";
		cout << setw(37) << left << "" << "\t[6] Main Menue.\n";
		cout << setw(37) << left << "" << "===========================================\n";

		_PerfromManageUserMenu((enMangeUserOptions)_ReadMainMenuOption());





	}

};

