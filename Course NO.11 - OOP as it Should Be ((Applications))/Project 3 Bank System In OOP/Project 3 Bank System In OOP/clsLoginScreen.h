#pragma once
#include "clsUser.h"
#include <iostream>
#include "clsScreen.h"
#include "clsMainScreen.h"
#include "clsGlobal.h"
#include "clsUtil.h"
using namespace std;
class clsLoginScreen:public clsScreen
{
private:
	
	static bool _Login() {
		string UserName, Password;
		bool LoginFaild=false;
		short Logintrails = 3;
		
		do
		{
			if (Logintrails == 0)
			{
				cout << "\n\nYou Are Locked After 3 Feild Trails \n\n";
				return false;
			}
			if (LoginFaild)
			{
				Logintrails--;
				cout << "\t Invalid UserName / Passwrod !\n\n";
				cout << "\t You have " << Logintrails << " Trails To Login\n\n";
			}
			cout << "\nEnter UserName :";
			cin >> UserName;
			cout << "\nEnter Password :";
			cin >> Password;
			CurrentUser = clsUser::Find(UserName, Password);
			LoginFaild = CurrentUser.IsEmpty();
			
		} while (LoginFaild);
		CurrentUser.RegisterLogin();
		clsMainScreen::ShowMainMenuScreen();

	}
public:
	static bool LoginScreen() {
		system("cls");
		clsScreen::_DrawScreenHeader("\t     Login Screen");
		return _Login();




	}
};

