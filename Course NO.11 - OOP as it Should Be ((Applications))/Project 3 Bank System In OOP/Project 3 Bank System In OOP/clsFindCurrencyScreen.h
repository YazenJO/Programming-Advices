#pragma once
#include "clsScreen.h"
#include"clsCurrency.h"
#include "clsInputValidate.h"
#include<iomanip>
class clsFindCurrencyScreen:protected clsScreen
{
private:
    static void _PrintClientRecordLine(clsCurrency Currency)
    {
        cout << "\nCurrency Card:\n";
        cout << "_____________________________\n";
        cout << "\nCountry    : " << Currency.Country();
        cout << "\nCode       : " << Currency.CurrencyCode();
        cout << "\nName       : " << Currency.CurrencyName();
        cout << "\nRate(1$) = : " << Currency.Rate();

        cout << "\n_____________________________\n";


    }
    static clsCurrency _FindByCode() {
        string Code;
        cout << "\n\nPlease Enter CurrencyCode: ";
        cin >> Code;
        return (clsCurrency::FindByCode(Code));
    }
    static clsCurrency _FindByCountry() {
        string Country;
        cout << "\n\nPlease Enter Currency Name: ";
        cin >> Country;
        return (clsCurrency::FindByCountry(Country));

    
    }
    static void _ShowResult(clsCurrency Currancy) {
        if (!Currancy.IsEmpty())
        {
            cout << "\nCurrency Found :-)\n";
            _PrintClientRecordLine(Currancy);
        }
        else
        {
            cout << "\nCurrency Was not Found :-(\n";
            
        }

       

    
    }
public:
    static void FindCuttencyScreen() {
        short Choice;

        _DrawScreenHeader("\tFind Currancy Screen");
        cout << "\nFind By [1] Code or [2] Country ?  ";

        Choice = clsInputValidate::ReadIntNumberBetween(1, 2);
        if (Choice == 1)
        {
            clsCurrency Currency = _FindByCode();
            _ShowResult(Currency);
        }
        else
        {
            clsCurrency Currency = _FindByCountry();
            _ShowResult(Currency);
        }




    }

};

