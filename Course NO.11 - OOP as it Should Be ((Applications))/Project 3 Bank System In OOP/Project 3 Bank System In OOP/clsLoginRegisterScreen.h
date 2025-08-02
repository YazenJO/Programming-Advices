#pragma once
#include "clsUser.h"
#include "clsScreen.h"
#include <iostream>
#include <iomanip>
#include "clsString.h"
#include "clsGlobal.h"
using namespace std;

class clsLoginRegisterScreen :protected clsScreen
{
private :
    static void PrintLoginRegesterLine(clsUser::stLoginRegisterRecord LogineLine)
    {
     
        cout << setw(8) << left << "" << "| " << setw(35) << left << LogineLine.DateTime;
        cout << "| " << setw(20) << left << LogineLine.UserName;
        cout << "| " << setw(20) << left << LogineLine.PassWord;
        cout << "| " << setw(10) << left << LogineLine.Permisstion;

    }

public:
    static void ShowLoginRegisterList()
    {
        if (!clsScreen::CheckAccesRights(clsUser::enPermissions::pLoginRegister))
        {
            return;
        }


        vector <clsUser::stLoginRegisterRecord> vLoginRegisrer=clsUser::LoadLoginRigsterData("LoginRegister.txt");
        string Title = "\t  Login Register Screen";
        string SubTitle = "\t    (" + to_string(vLoginRegisrer.size()) + ") Client(s).";

        _DrawScreenHeader(Title, SubTitle);


        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_________________________________________\n" << endl;


        cout << setw(8) << left << "" << "| " << left << setw(35) << "Date/Time";
        cout << "| " << left << setw(20) << "UserName";
        cout << "| " << left << setw(20) << "Password";
        cout << "| " << left << setw(10) << "Permissions";
        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_________________________________________\n" << endl;


        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_________________________________________\n" << endl;

        if (vLoginRegisrer.size() == 0)
            cout << "\t\t\t\tNo Clients Available In the System!";
        else

            for (clsUser::stLoginRegisterRecord &L : vLoginRegisrer)
            {

                PrintLoginRegesterLine(L);
                cout << endl;
            }

        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_________________________________________\n" << endl;

    }

};

