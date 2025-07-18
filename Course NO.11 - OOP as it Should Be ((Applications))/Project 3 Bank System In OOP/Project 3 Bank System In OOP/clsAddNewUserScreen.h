#pragma once
#include <iostream>
#include "clsScreen.h"
#include "clsUser.h"
#include <iomanip>
#include <vector>
using namespace std;

class clsAddNewUserScreen:public clsScreen
{
	
private:
	
	static short ReadPrimisstions() {
		short Primisstions = 0;
		char Choice;
		cout << "\nDo u Want To give Full access ? y/n ? ";
		cin >> ws >> Choice;
		if (toupper(Choice) == 'Y')
			return clsUser::enPermissions::eAll;
		else
		{
			cout << "\nDo u Want To give acces to :\n";
			cout << "\nShow Client List ? y/n ? ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				
				Primisstions |= clsUser::enPermissions::pListClients;
			}
			cout << "\nAdd New Client ? y/n ? ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				Primisstions |= clsUser::enPermissions::pAddNewClient/*Option_Two*/;
			}
			cout << "\nDelete Client ? y/n ? ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				Primisstions |= clsUser::enPermissions::pDeleteClient/*Option_Three*/;
			}
			cout << "\nUpdate Client ? y/n ? ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				Primisstions |= clsUser::enPermissions::pUpdateClients/*Option_Four*/;
			}
			cout << "\nFind Clients ? y/n ? ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				Primisstions |= clsUser::enPermissions::pFindClient/*Option_Five*/;
			}
			cout << "\nTransactions ? y/n ? ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				Primisstions |= clsUser::enPermissions::pTranactions/*Option_Six*/;
			}
			cout << "\nManage Users ? y/n ? ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				Primisstions |= clsUser::enPermissions::pManageUsers/*Option_Seven*/;
			}
			cout << "\nLogin Register ? y/n ? ";
			cin >> Choice;
			if (toupper(Choice) == 'Y')
			{
				Primisstions |= clsUser::enPermissions::pLoginRegister/*Option_Seven*/;
			}
		}
		return Primisstions;
	}

	static void _ReadUserInfo(clsUser& User) {
		cout << "\nEnter FirstName: ";
		User.FirstName = clsInputValidate::ReadString();
		cout << "\nEnter LastName: ";
		User.LastName = clsInputValidate::ReadString();
		cout << "\nEnter Email: ";
		User.Email = clsInputValidate::ReadString();
		cout << "\nEnter Phone: ";
		User.Phone = clsInputValidate::ReadString();
		cout << "\nEnter Password: ";
		User.Password = clsInputValidate::ReadString();
		cout << "\nEnter The Primisstions U Want : ";
		User.Permissions = ReadPrimisstions();

	}
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

	static void AddNewUserScreen() {
		string UserName = "";
		clsScreen::_DrawScreenHeader("\tAdd New User Screen");
		cout << "\nPlease Enter UserName: ";
		UserName = clsInputValidate::ReadString();
		while (clsUser::IsUserExist(UserName))
		{
			cout << "\nAccounat Number Is Already used, Choose another one : ";
			UserName = clsInputValidate::ReadString();
		}
		clsUser NewClient = clsUser::GetAddNewUserobject(UserName);
		_ReadUserInfo(NewClient);
		clsUser::enSave SaveResult;
		SaveResult = NewClient.Save();

		switch (SaveResult)
		{
		case clsUser::svFaildEmptyObject:
			cout << "\nAccount Not Saved  :(";
			break;
		case clsUser::svFaildUserNameExist:
			cout << "\nAccount Not Added bcs AccountNumber Exist :(";
			break;
		case clsUser::svSucceded:
			cout << "\nAccount Added Succsefully";
			PrintUserRecordLine(NewClient);
			break;
		default:
			break;
		}

	}

};

