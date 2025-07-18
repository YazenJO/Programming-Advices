#pragma once
#include "clsCurrency.h"
#include "clsScreen.h"

class clsUpdateCurrencyScreen:protected clsScreen
{
private:
    static void _PrintCurrency(clsCurrency Currency)
    {
        cout << "\nCurrency Card:\n";
        cout << "_____________________________\n";
        cout << "\nCountry    : " << Currency.Country();
        cout << "\nCode       : " << Currency.CurrencyCode();
        cout << "\nName       : " << Currency.CurrencyName();
        cout << "\nRate(1$) = : " << Currency.Rate();

        cout << "\n_____________________________\n";


    }

    
public:
    static void UpdateCurrencyRate() {
        char Awnser;
        string CurrencyCode = "";
        _DrawScreenHeader("\tUpdate Currancy Screen");
       

        cout << "\nPlease Enter Currency Code: ";
        CurrencyCode = clsInputValidate::ReadString();

        while (!clsCurrency::IsCurrencyExist(CurrencyCode))
        {
            cout << "\nCurrency is not found, choose another one: ";
            CurrencyCode = clsInputValidate::ReadString();
        }
        clsCurrency Curreny = clsCurrency::FindByCode(CurrencyCode);
        _PrintCurrency(Curreny);
        cout << "\nAre You Sure You Want To Update The Rate Of This Curreny y/n? ";
        cin >> Awnser;
        if (tolower(Awnser)=='y')
        {
            float Rate;
            cout << "\nUpdate Currency Rate : ";
            cout << "\n_____________________";
            cout << "\n\nEnter New Rate :";
            Rate = clsInputValidate::ReadfloatNumber();
            Curreny.UpdateRate(Rate);
            cout << "\nCurrency Rate Updated Succefully :-)\n";
            _PrintCurrency(Curreny);
        }
        else
        {
            return;
        }
    }
};

