#pragma once
#include "clsScreen.h"
#include "clsCurrency.h"
#include "iomanip"

class clsCurrenyListScreen :protected clsScreen
{
private:
    static void PrintClientRecordLine(clsCurrency Currancy)
    {

        cout << setw(8) << left << "" << "| " << setw(30) << left << Currancy.Country();
        cout << "| " << setw(8) << left << Currancy.CurrencyCode();
        cout << "| " << setw(45) << left << Currancy.CurrencyName();
        cout << "| " << setw(10) << left << Currancy.Rate();

    }
public:


    static void ShowCurrencyList()
    {

        vector <clsCurrency> vCurrencies = clsCurrency::GetCurrenciesList();
        string Title = "\t  Currencies List Screen";
        string SubTitle = "\t    (" + to_string(vCurrencies.size()) + ") Currency(s).";

        _DrawScreenHeader(Title, SubTitle);


        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_________________________________________\n" << endl;

        cout << setw(8) << left << "" << "| " << left << setw(30) << "Country";
        cout << "| " << left << setw(8) << "Code";
        cout << "| " << left << setw(45) << "Name";
        cout << "| " << left << setw(10) << "Rate/(1$)";

        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_________________________________________\n" << endl;

        if (vCurrencies.size() == 0)
            cout << "\t\t\t\tNo Clients Available In the System!";
        else

            for (clsCurrency Currency : vCurrencies)
            {

                PrintClientRecordLine(Currency);
                cout << endl;
            }

        cout << setw(8) << left << "" << "\n\t_______________________________________________________";
        cout << "_________________________________________\n" << endl;

    }

};

