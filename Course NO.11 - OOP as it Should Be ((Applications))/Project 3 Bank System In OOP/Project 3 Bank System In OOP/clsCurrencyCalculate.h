#pragma once
#include "clsCurrency.h"
#include "clsScreen.h"


class clsCurrencyCalculate :protected clsScreen
{
private:
    static void _PrintCurrency(clsCurrency Currency,string Massage)
    {
        cout << Massage;
        cout << "\n\nCurrency Card:\n";
        cout << "_____________________________\n";
        cout << "\nCountry    : " << Currency.Country();
        cout << "\nCode       : " << Currency.CurrencyCode();
        cout << "\nName       : " << Currency.CurrencyName();
        cout << "\nRate(1$) = : " << Currency.Rate();

        cout << "\n_____________________________\n";


    }
    static clsCurrency ReadCurrency(string Massage) {
        string CurrencyCode = "";


        cout << Massage;
        CurrencyCode = clsInputValidate::ReadString();

        while (!clsCurrency::IsCurrencyExist(CurrencyCode))
        {
            cout << "\nCurrency is not found, choose another one: ";
            CurrencyCode = clsInputValidate::ReadString();
        }
        clsCurrency Curreny = clsCurrency::FindByCode(CurrencyCode);


        return Curreny;
    }
    static void _PrintCalculationsResults(float Amount, clsCurrency Currency1, clsCurrency Currency2)
    {

        _PrintCurrency(Currency1, "Convert From:");

        float AmountInUSD = Currency1.ConvertToUSD(Amount);

        cout << Amount << " " << Currency1.CurrencyCode()
            << " = " << AmountInUSD << " USD\n";

        if (Currency2.CurrencyCode() == "USD")
        {
            return;
        }

        cout << "\nConverting from USD to:\n";

        _PrintCurrency(Currency2, "To:");

        float AmountInCurrrency2 = Currency1.ConvertToOtherCurrency(Amount, Currency2);

        cout << Amount << " " << Currency1.CurrencyCode()
            << " = " << AmountInCurrrency2 << " " << Currency2.CurrencyCode();

    }

public:
    static void  CurrencyCalculate() {
        float  Amount;
        char Again = 'y';
        string CurrencyCode = "";
        while (tolower(Again) =='y')
        {
           system("cls");

            _DrawScreenHeader("\tConvert Currancy Exvhange Screen");
            clsCurrency CurrenyF = ReadCurrency("\nPlease Enter Currency 1 Code: ");

            clsCurrency CurrenyT = ReadCurrency("\nPlease Enter Currency 2 Code: ");

            cout << "\nEnter Amount Exchange : ";
            Amount = clsInputValidate::ReadfloatNumber();

            _PrintCalculationsResults(Amount, CurrenyF, CurrenyT);

            cout << "\n\nDo u Want To Perfrom another calculation ? y/n ? ";
            cin >> Again;
        }
    }

};

