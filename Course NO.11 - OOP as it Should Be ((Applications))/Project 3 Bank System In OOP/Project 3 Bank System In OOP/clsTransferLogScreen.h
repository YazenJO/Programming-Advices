#pragma once
#include <iostream>
#include "clsScreen.h"
#include <iomanip>
#include "clsString.h"
#include "clsGlobal.h"
#include "clsBankClient.h"

using namespace std;

class clsTransferLogScreen :public clsScreen
{
private:
    static void PrintTransferLogRecordLine(clsBankClient::stTrnsferLogRecord TransferLogRecord)
    {

        cout << setw(8) << left << "" << "| " << setw(23) << left << TransferLogRecord.DateTime;
        cout << "| " << setw(8) << left <<TransferLogRecord.SourceAccountNumber;
        cout << "| " << setw(8) << left <<TransferLogRecord.DestinationAccountNumber;
        cout << "| " << setw(8) << left << TransferLogRecord.Amount;
        cout << "| " << setw(10) << left << TransferLogRecord.srcBalanceAfter;
        cout << "| " << setw(10) << left << TransferLogRecord.destBalanceAfter;
        cout << "| " << setw(8) << left << TransferLogRecord.UserName;


    }

public:
    static void TransferLogScreen(){
    vector <clsBankClient::stTrnsferLogRecord> TransferRecord = clsBankClient::LoadTransferRecordData("TransferLog.txt");
    string Title = "\t  Transfer Log List Screen";
    string SubTitle = "\t    (" + to_string(TransferRecord.size()) + ") Record(s).";

    _DrawScreenHeader(Title, SubTitle);


    cout << setw(8) << left << "" << "\n\t_______________________________________________________";
    cout << "_________________________________________\n" << endl;

    cout << setw(8) << left << "" << "| " << left << setw(23) << "Date/Time";
    cout << "| " << left << setw(8) << "s.Acct";
    cout << "| " << left << setw(8) << "d.Acct";
    cout << "| " << left << setw(8) << "Amount";
    cout << "| " << left << setw(10) << "s.Balance";
    cout << "| " << left << setw(10) << "d.Balance";
    cout << "| " << left << setw(8) << "User";

    cout << setw(8) << left << "" << "\n\t_______________________________________________________";
    cout << "_________________________________________\n" << endl;


    if (TransferRecord.size() == 0)
        cout << "\t\t\t\tNo Clients Available In the System!";
    else

        for (clsBankClient::stTrnsferLogRecord& T : TransferRecord)
        {

            PrintTransferLogRecordLine(T);
            cout << endl;
        }

    cout << setw(8) << left << "" << "\n\t_______________________________________________________";
    cout << "_________________________________________\n" << endl;

    }


};

