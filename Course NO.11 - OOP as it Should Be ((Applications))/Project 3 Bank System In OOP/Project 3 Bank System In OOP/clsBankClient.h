#pragma once
#include <iostream>
#include <fstream>
#include <vector>
#include <string>
#include "clsGlobal.h"
#include "clsPerson.h"
#include "clsUtil.h"
#include "clsString.h"
#include "clsInputValidate.h"
using namespace std;
class clsBankClient :public clsPerson
{
private:
	enum enMode { EmpetyMode = 0, UpdateMode = 1,AddNew=2 };

	string _AccountNumber;
	string _PinCode;
	float _AccountBalance;
	 enMode _Mode;
	 bool _MarkToDelete = false;
	
	static clsBankClient _ConvertLincToClientObject(string line,string sperator= "#//#") {
		
		vector <string> VClientData;
		
		VClientData = clsString::Split(line, sperator);

		return clsBankClient(enMode::UpdateMode,VClientData[0], VClientData[1], VClientData[2], VClientData[3], VClientData[4],clsUtil::DecryptText(VClientData[5]),stod(VClientData[6]));

	}
	static string _ConverClientObjectToLine(clsBankClient Client, string Seperator = "#//#")
	{

		string stClientRecord = "";
		stClientRecord += Client.FirstName + Seperator;
		stClientRecord += Client.LastName + Seperator;
		stClientRecord += Client.Email + Seperator;
		stClientRecord += Client.Phone + Seperator;
		stClientRecord += Client.AccountNumber() + Seperator;
		stClientRecord += clsUtil::EncryptText(Client.PinCode) + Seperator;
		stClientRecord += to_string(Client.AccountBalance);

		return stClientRecord;

	}
	string _ConvertTransferDataToLine(float Amount,clsBankClient To,string sperator = "#//#") {

		return (clsDate::GetSystemDateTimeStrig() + sperator + AccountNumber() + sperator +To.AccountNumber() + sperator 
			+ to_string(Amount)) + sperator + to_string(AccountBalance) + sperator + to_string(To.AccountBalance) + sperator + CurrentUser.UserName;
	}

	static clsBankClient _GetEmptyClientObject() {

		return clsBankClient(enMode::EmpetyMode, "", "", "", "", "", "",0);


	}
	void _SaveVectorToFile(string FileName, vector <clsBankClient>vFileContant) {

		fstream MyFile;

		MyFile.open(FileName, ios::out);
		if (MyFile.is_open())
		{

			for (clsBankClient& C : vFileContant) {
				if (C._MarkToDelete==false)
				{
					MyFile << _ConverClientObjectToLine(C) << endl;
				}
				
			}
			MyFile.close();
		}
	}
	struct  stTrnsferLogRecord;
	static stTrnsferLogRecord _ConvertLineToLgoinRecored(string Line) {
		stTrnsferLogRecord TrnsferLogRecord;
		vector <string>vTrnsferLogRecordLine = clsString::Split(Line, "#//#");
		TrnsferLogRecord.DateTime = vTrnsferLogRecordLine[0];
		TrnsferLogRecord.SourceAccountNumber = vTrnsferLogRecordLine[1];
		TrnsferLogRecord.DestinationAccountNumber = vTrnsferLogRecordLine[2];
		TrnsferLogRecord.Amount = stod(vTrnsferLogRecordLine[3]);
		TrnsferLogRecord.srcBalanceAfter = stod(vTrnsferLogRecordLine[4]);
		TrnsferLogRecord.destBalanceAfter = stod(vTrnsferLogRecordLine[5]);
		TrnsferLogRecord.UserName = vTrnsferLogRecordLine[6];

		return TrnsferLogRecord;
	}

	 static vector <clsBankClient> _LoadDataFromFileToVector(string FileName) {
		vector <clsBankClient> VClientData;
		fstream MyFile;

		MyFile.open(FileName, ios::in);

		if (MyFile.is_open()) {

			string line;
			while (getline(MyFile, line))
			{
				VClientData.push_back(_ConvertLincToClientObject(line));
			}
			MyFile.close();
		}
		return VClientData;
	}

	 void _Update() {
		vector <clsBankClient> VClients;

		VClients = _LoadDataFromFileToVector("Clients.txt");
		for (clsBankClient &C: VClients)
		{
			if (C.AccountNumber() ==AccountNumber() )
			{
				C = *this;
				break;
			}

		}

		_SaveVectorToFile("Clients.txt", VClients);
	}
	 void _AddNew() {

		 _AddDataLineToFile(_ConverClientObjectToLine(*this));

	 }

	 void _AddDataLineToFile(string  stDataLine)
	 {
		 fstream MyFile;
		 MyFile.open("Clients.txt", ios::out | ios::app);

		 if (MyFile.is_open())
		 {

			 MyFile << stDataLine << endl;

			 MyFile.close();
		 }

	 }
	 void _AddDataLineToFile(string  stDataLine, string FileName)
	 {
		 fstream MyFile;
		 MyFile.open(FileName, ios::out | ios::app);

		 if (MyFile.is_open())
		 {

			 MyFile << stDataLine << endl;

			 MyFile.close();
		 }

	 }
	 void _RegisterTransferLog(float Amount,clsBankClient To) {
		 string line = _ConvertTransferDataToLine(Amount, To);
		 _AddDataLineToFile(line, "TransferLog.txt");
	 }

public:
	struct  stTrnsferLogRecord
	{
		string DateTime;
		string SourceAccountNumber;
		string DestinationAccountNumber;
		float Amount;
		float srcBalanceAfter;
		float destBalanceAfter;
		string UserName;

	};


	clsBankClient(enMode Mode, string FirstName, string LastName, string email, string phone, string AccountNumber, string PinCode, float Balance) :
		clsPerson(FirstName, LastName, email, phone)
	{
		_Mode = Mode;
		_AccountNumber = AccountNumber;
		_PinCode = PinCode;
		_AccountBalance = Balance;
	}
	 string AccountNumber() {

		return _AccountNumber;
	}
	string GetPinCode() {
		return _PinCode;
	}
	void SetPinCode(string Pin) {

		_PinCode = Pin;
	}
	__declspec(property(get = GetPinCode, put = SetPinCode))string PinCode;
	static float GetTotalBalance() {
		float TotalBalance = 0;
		vector <clsBankClient> VClient;
		VClient = _LoadDataFromFileToVector("Clients.txt");
		for (clsBankClient &C: VClient)
		{
			TotalBalance += C.AccountBalance;
		}
		return TotalBalance;
	}
	void SetBalance(float Balance) {
		_AccountBalance = Balance;
	}
	float GetBalance() {

		return _AccountBalance;
	}
	__declspec(property(get = GetBalance, put = SetBalance))float AccountBalance;

	bool IsEmpty() {
		return (_Mode == enMode::EmpetyMode);
	}
	static clsBankClient Find(string AccountNumber) {
		vector <clsBankClient> vFileContant;
		fstream MyFile;


		MyFile.open("Clients.txt", ios::in);

		if (MyFile.is_open()) {

			string line;

			while (getline(MyFile, line))
			{
				clsBankClient Client = _ConvertLincToClientObject(line);
				if (Client.AccountNumber() == AccountNumber)
				{
					MyFile.close();
					return Client;
				}
				vFileContant.push_back(Client);
			}
			MyFile.close();

		}
		return _GetEmptyClientObject();
	}
	static clsBankClient Find(string AccountNumber, string PinCode) {
		vector <clsBankClient> vFileContant;
		fstream MyFile;


		MyFile.open("Clients.txt", ios::in);

		if (MyFile.is_open()) {

			string line;

			while (getline(MyFile, line))
			{
				clsBankClient Client = _ConvertLincToClientObject(line);
				if (Client.AccountNumber() == AccountNumber && Client.PinCode == PinCode)
				{
					MyFile.close();
					return Client;
				}
				vFileContant.push_back(Client);
			}
			MyFile.close();

		}
		return _GetEmptyClientObject();



	}

	
	static bool IsClientExist(string AccountNumber) {
		clsBankClient Client = clsBankClient::Find(AccountNumber);


		return (!Client.IsEmpty());

	}
	enum enSave
	{
		svFaildEmptyObject = 0, svSucceded = 1, svFaildAccountNumberExist=2
	};
	 enSave Save() {
		switch (_Mode)
		{
		case clsBankClient::EmpetyMode:
			return enSave::svFaildEmptyObject;
			break;
		case clsBankClient::UpdateMode:
			_Update();
			return enSave::svSucceded;
			break;
		case clsBankClient::AddNew:
			if (IsClientExist(AccountNumber()))
			{
				return enSave::svFaildAccountNumberExist;
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
	 static clsBankClient GetAddNewClientobject(string AccountNumber) {

		 return clsBankClient(enMode::AddNew, "", "", "", "", AccountNumber, "", 0);


	 }

	 bool DeleteClient() {
		 vector <clsBankClient> VClientData;
		 VClientData = _LoadDataFromFileToVector("Clients.txt");
		 for (clsBankClient &C: VClientData)
		 {
			 if (AccountNumber()==C.AccountNumber())
			 {
			     C._MarkToDelete = true;

			 }
		 }
		 _SaveVectorToFile("Clients.txt", VClientData);
		 *this = _GetEmptyClientObject();

		 return true;
	 }
	 static vector <clsBankClient> GetClientList() {

		 return _LoadDataFromFileToVector("Clients.txt");


	 }
	 void Deposit(double Amount) {
		 _AccountBalance += Amount;
		 Save();

	 }
	 bool Withdraw(double Amount) {
		 if (Amount > AccountBalance)
		 {
			 return false;
		 }
		 else
		 {
			 _AccountBalance -= Amount;
			 Save();
			 return true;
		 } 

	 }

	  bool Transfer(float Amount,  clsBankClient& To) {
		  if (Amount > AccountBalance) {
			  return false;
		  }
		  Withdraw(Amount);
		  To.Deposit(Amount);
		  _RegisterTransferLog(Amount, To);
			  return true;


	 }
	  static vector <stTrnsferLogRecord> LoadTransferRecordData(string FileName) {
		  vector <stTrnsferLogRecord> TransferRecordData;
		  fstream MyFile;

		  MyFile.open(FileName, ios::in);

		  if (MyFile.is_open()) {

			  string line;
 		  stTrnsferLogRecord TransferRecord;

			  while (getline(MyFile, line))
			  {
				  TransferRecord = _ConvertLineToLgoinRecored(line);
				  TransferRecordData.push_back(TransferRecord);
			  }
			  MyFile.close();
		  }
		  return TransferRecordData;
	  }

};




