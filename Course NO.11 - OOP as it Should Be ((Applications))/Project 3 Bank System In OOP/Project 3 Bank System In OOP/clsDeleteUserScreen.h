#pragma once
#include <iostream>
#include "clsScreen.h"
#include  "clsBankClient.h"
#include "clsMainScreen.h"
#include "clsScreen.h"
using namespace std;

class clsDeleteUserScreen:protected clsScreen
{
private:
	static void PrintUserRecordLine(clsUser User)
	{

		cout << "\nUser Card:";
		cout << "\n___________________";
		cout << "\nFirstName   : " << User.FirstName;
		cout << "\nLastName    : " << User.LastName;
		cout << "\nFull Name   : " << User.FullName();
		cout << "\nEmail       : " << User.Email;
		cout << "\nPhone       : " << User.Phone;
		cout << "\nUser Name   : " << User.UserName;
		cout << "\nPassword    : " << User.Password;
		cout << "\nPermissions : " << User.Permissions;
		cout << "\n___________________\n";


	}

public:
	static void DeleteUserScreen() {

		string UserName = "";
		char Choice;
		clsScreen::_DrawScreenHeader("\tDelete User Screen");
		cout << "\nPlease Enter UserName: ";
		UserName = clsInputValidate::ReadString();
		while (!clsUser::IsUserExist(UserName))
		{
			cout << "\nUserName is not found Enter Another UserName";
			cout << "\nEnter UserName : ";
			UserName = clsInputValidate::ReadString();
		}
		clsUser User1 = clsUser::Find(UserName);
		PrintUserRecordLine(User1);
		cout << "\nDo u Want To Delete User : ";
		cin >> Choice;
		if (tolower(Choice) == 'y')
		{
			if (User1.DeleteUser())
			{
				cout << "\nClient Deleted Succefully";
			}

		}
	}

	};
