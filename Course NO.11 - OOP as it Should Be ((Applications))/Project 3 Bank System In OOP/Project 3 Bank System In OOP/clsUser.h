#pragma once
#include "clsPerson.h"
#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include "clsString.h"
#include "clsInputValidate.h"
#include "clsUtil.h"
using namespace std;

class clsUser :public clsPerson
{
private:
enum enMode
	{
		EmptyMode = 0, UpdateMode = 1, AddNewMode = 2
	};
	enMode _Mode;
	string _UserName;
	string _PassWord;
	int _Permissions;
	bool _MarkToDelete=false;
	struct stLoginRegisterRecord;
	  string _ConvertLoginDataToLine(string sperator = "#//#") {

		 return (clsDate::GetSystemDateTimeStrig() + sperator + UserName + sperator +Password + sperator + to_string(Permissions));
	 }
	  static stLoginRegisterRecord ConvertLineToLgoinRecored(string Line) {
		  stLoginRegisterRecord LinRecord;
		  vector <string>VLineData = clsString::Split(Line, "#//#");
		  LinRecord.DateTime=VLineData[0];
		  LinRecord.UserName = VLineData[1];
		  LinRecord.PassWord = VLineData[2];
		  LinRecord.Permisstion = stoi(VLineData[3]);
		  return LinRecord;
	  }
	static clsUser _ConvertLineToUserObject(string line, string sperator = "#//#") {

		vector <string> VUserData;

		VUserData = clsString::Split(line, sperator);

		return clsUser(enMode::UpdateMode, VUserData[0], VUserData[1], VUserData[2], VUserData[3], VUserData[4], clsUtil::DecryptText(VUserData[5]), stod(VUserData[6]));

	}
	static string _ConverUserObjectToLine(clsUser User, string Seperator = "#//#")
	{

		string stUserRecord = "";
		stUserRecord += User.FirstName + Seperator;
		stUserRecord += User.LastName + Seperator;
		stUserRecord += User.Email + Seperator;
		stUserRecord += User.Phone + Seperator;
		stUserRecord += User.GetUserName() + Seperator;
		stUserRecord += clsUtil::EncryptText(User.GetPassword()) + Seperator;
		stUserRecord += to_string(User.GetPermissions());

		return stUserRecord;

	}
	static clsUser _GetEmptyUserObject() {

		return clsUser(enMode::EmptyMode, "", "", "", "", "", "", 0);


	}
	void _SaveVectorToFile(string FileName, vector <clsUser>vFileContant) {

		fstream MyFile;

		MyFile.open(FileName, ios::out);
		if (MyFile.is_open())
		{

			for (clsUser& U : vFileContant) {
				if (U._MarkToDelete == false)
				{
					MyFile << _ConverUserObjectToLine(U) << endl;
				}

			}
			MyFile.close();
		}
	}
	static vector <clsUser> _LoadDataFromFileToVector(string FileName) {
		vector <clsUser> VUserData;
		fstream MyFile;

		MyFile.open(FileName, ios::in);

		if (MyFile.is_open()) {

			string line;
			while (getline(MyFile, line))
			{
				VUserData.push_back(_ConvertLineToUserObject(line));
			}
			MyFile.close();
		}
		return VUserData;
	}
	void _Update() {
		vector <clsUser> VUsers;

		VUsers = _LoadDataFromFileToVector("Users.txt");
		for (clsUser& U : VUsers)
		{
			if (U.GetUserName() == GetUserName())
			{
				U = *this;
				break;
			}

		}

		_SaveVectorToFile("Users.txt", VUsers);
	}
	void _AddNew() {

		_AddDataLineToFile(_ConverUserObjectToLine(*this));

	}
	void _AddDataLineToFile(string  stDataLine,string FileName= "Users.txt")
	{
		fstream MyFile;
		MyFile.open(FileName, ios::out | ios::app);

		if (MyFile.is_open())
		{

			MyFile << stDataLine << endl;

			MyFile.close();
		}

	}
	// 1 + 2 = 3 

public:
	struct  stLoginRegisterRecord
	{
		string DateTime;
		string UserName;
		string PassWord;
		int Permisstion;

	};

	 enum enPermissions {
		eAll = -1, pListClients = 1, pAddNewClient = 2, pDeleteClient = 4,
		pUpdateClients = 8, pFindClient = 16, pTranactions = 32, pManageUsers = 64,pLoginRegister=128
	};
	
	clsUser(enMode Mode, string FirstName, string LastName, string Email, string Phone, string UserName, string PassWord, int Permissions)
		:
		clsPerson(FirstName, LastName, Email, Phone) {

		_Mode = Mode;
		_UserName = UserName;
		_PassWord = PassWord;
		_Permissions = Permissions;
	}
	 string GetUserName()
	{
		return _UserName;
	}

	void SetUserName(string UserName)
	{
		_UserName = UserName;
	}

	__declspec(property(get = GetUserName, put = SetUserName)) string UserName;

	void SetPassword(string Password)
	{
		_PassWord = Password;
	}

	string GetPassword()
	{
		return _PassWord;
	}
	__declspec(property(get = GetPassword, put = SetPassword)) string Password;

	void SetPermissions(int Permissions)
	{
		_Permissions = Permissions;
	}

	int GetPermissions()
	{
		return _Permissions;
	}
	__declspec(property(get = GetPermissions, put = SetPermissions)) int Permissions;

	bool IsEmpty() {
		return (_Mode == enMode::EmptyMode);
	}
	static clsUser Find(string UserName) {
		vector <clsUser> vFileContant;
		fstream MyFile;


		MyFile.open("Users.txt", ios::in);

		if (MyFile.is_open()) {

			string line;

			while (getline(MyFile, line))
			{
				clsUser User = _ConvertLineToUserObject(line);
				if (User.UserName == UserName)
				{
					MyFile.close();
					return User;
				}
				vFileContant.push_back(User);
			}
			MyFile.close();

		}
		return _GetEmptyUserObject();
	}
	static clsUser Find(string UserName, string PassWord) {
		vector <clsUser> vFileContant;
		fstream MyFile;


		MyFile.open("Users.txt", ios::in);

		if (MyFile.is_open()) {

			string line;

			while (getline(MyFile, line))
			{
				
				clsUser User = _ConvertLineToUserObject(line);
				
				if (User.UserName == UserName && (User.Password) == PassWord)
				{
					MyFile.close();
					return User;
				}
				vFileContant.push_back(User);
			}
			MyFile.close();

		}
		return _GetEmptyUserObject();



	}
	static bool IsUserExist(string UserName) {
		clsUser User = clsUser::Find(UserName);


		return (!User.IsEmpty());

	}
	enum enSave
	{
		svFaildEmptyObject = 0, svSucceded = 1, svFaildUserNameExist = 2
	};
	enSave Save() {
		switch (_Mode)
		{
		case clsUser::EmptyMode:
			return enSave::svFaildEmptyObject;
			break;
		case clsUser::UpdateMode:
			_Update();
			return enSave::svSucceded;
			break;
		case clsUser::AddNewMode:
			if (IsUserExist(UserName))
			{
				return enSave::svFaildUserNameExist;
			}
			else
			{
				_AddNew();
				_Mode = enMode::UpdateMode;
				return enSave::svSucceded;
				break;
			}

		default:
			break;
		}



	}
	static clsUser GetAddNewUserobject(string UserName) {

		return clsUser(enMode::AddNewMode, "", "", "", "", UserName, "", 0);


	}
	static vector <clsUser> GetUserList() {

		return _LoadDataFromFileToVector("Users.txt");


	}
	

	bool DeleteUser() {
		vector <clsUser> VUserData;
		VUserData = _LoadDataFromFileToVector("Users.txt");
		for (clsUser& U : VUserData)
		{
			if (U.UserName == UserName)
			{
				U._MarkToDelete = true;

			}
		}
		_SaveVectorToFile("Users.txt", VUserData);
		*this = _GetEmptyUserObject();

		return true;
	}

	bool CheckAccesPrimisstion(enPermissions Permission) 
	{
		if (this->Permissions == enPermissions::eAll)
		{
			
			return true;
		}
		if ((this->Permissions & Permission) == Permission)
																																	 
		{
			return true;
		}
		return false;

	}
	void RegisterLogin() {
		string Line = _ConvertLoginDataToLine();
		_AddDataLineToFile(Line,"LoginRegister.txt");
	}
	 static vector <stLoginRegisterRecord> LoadLoginRigsterData(string FileName) {
		vector <stLoginRegisterRecord> VLoginRegisterData;
		fstream MyFile;

		MyFile.open(FileName, ios::in);

		if (MyFile.is_open()) {

			string line;
			stLoginRegisterRecord LoginRecird;

			while (getline(MyFile, line))
			{
				LoginRecird = ConvertLineToLgoinRecored(line);
				VLoginRegisterData.push_back(LoginRecird);
			}
			MyFile.close();
		}
		return VLoginRegisterData;
	}

};

