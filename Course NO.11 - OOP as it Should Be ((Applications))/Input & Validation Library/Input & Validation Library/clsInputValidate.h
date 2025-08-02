#pragma once
#include <iostream>
#include "clsDate.h"
class clsInputValidate
{
public:
	static bool IsNumberBetween(short TheNumber, short FirstNumber, short LstNumber) {

		return (TheNumber >= FirstNumber && TheNumber <= LstNumber ? true : false);
	}
	static bool IsNumberBetween(int TheNumber, int FirstNumber, int LstNumber) {

		return (TheNumber >= FirstNumber && TheNumber <= LstNumber ? true : false);
	}
	static bool IsNumberBetween(float TheNumber, float FirstNumber, float LstNumber) {
		
		return (TheNumber >= FirstNumber && TheNumber <= LstNumber ? true : false);
	}
	static bool IsDateBetween(clsDate TheDate, clsDate FirstDate, clsDate LastDate) {
		if (!clsDate::IsDate1BeforeDate2(FirstDate, LastDate))
			clsDate::SwapDates(FirstDate, LastDate);

		return ((clsDate::IsDate1AfterDate2(TheDate, FirstDate) || clsDate::IsDate1EqualDate2(TheDate, FirstDate)) &&
			(clsDate::IsDate1BeforeDate2(TheDate, LastDate) || clsDate::IsDate1EqualDate2(TheDate, LastDate)) ? true : false);


	}
	static int ReadIntNumber(string ErrorMassage= "Invalid Number ,Enter again:\n") {
		int Num;
		cin >> Num;
		while (cin.fail())
		{
		
			cin.clear();
			cin.ignore(numeric_limits<streamsize>::max(),'\n');
			cout << ErrorMassage << endl;
			cin >> Num;
		}
			
		return Num;


	}
	static double ReadDblNumber(string ErrorMassage= "Invalid Number ,Enter again:\n"){
		double Num;
		cin >> Num;
		while (cin.fail())
		{

			cin.clear();
			cin.ignore();
			cout << ErrorMassage << endl;
			cin >> Num;
		}

		return Num;


	}
	static int ReadIntNumberBetween(int FirstNumber, int LastNumber, string ErrorMassage= "Invalid Number ,Enter again:\n") {
		int Number = ReadIntNumber(ErrorMassage);
		while(!IsNumberBetween(Number, FirstNumber, LastNumber))
		{
			cout << ErrorMassage;
			Number = ReadIntNumber(ErrorMassage);
		}

		return Number;
	}
	static double ReadDblNumberBetween(float FirstNumber, float LastNumber, string ErrorMassage="Invalid Number ,Enter again:\n") {
		double Number = ReadIntNumber(ErrorMassage);
		while (!IsNumberBetween(Number, FirstNumber, LastNumber))
		{
			cout << ErrorMassage;
			Number = ReadDblNumber(ErrorMassage);
		}

		return Number;
	}
	static bool isValideDate(clsDate Date) {

		return (clsDate::IsValidDate(Date));


	}

};

