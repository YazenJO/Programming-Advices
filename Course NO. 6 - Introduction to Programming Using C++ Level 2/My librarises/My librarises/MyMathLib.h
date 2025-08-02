#pragma once
#include<iostream>
#include<cmath>
using namespace std;

namespace MyMathLib {
	bool isPerfectNumber(int Number)
	{
		int Sum = 0;
		for (int i = 1; i < Number; i++)
		{
			if (Number % i == 0)
				Sum += i;
		}
		return Number == Sum;
	}
	void PrintPerfectNumbersFrom1ToN(int Number)
	{
		for (int i = 1; i <= Number; i++)
		{
			if (isPerfectNumber(i))
			{
				cout << i << endl;
			}
		}
	}
	int ReverseNumber(int Number)
	{
		int Remainder = 0, Number2 = 0;
		while (Number > 0)
		{
			Remainder = Number % 10;
			Number = Number / 10;
			Number2 = Number2 * 10 + Remainder;
		}
		return Number2;
	}
	bool IsPalindromeNumber(int Number)
	{
		return Number == ReverseNumber(Number);
	}
	int SumOfDigits(int Number)
	{
		int Sum = 0, Remainder = 0;
		while (Number > 0)
		{
			Remainder = Number % 10;
			Number = Number / 10;
			Sum = Sum + Remainder;
		}
		return Sum;
	}

	

}


