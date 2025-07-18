#pragma once
#include<iostream>
using namespace std;

namespace MyArrLib {
	enum enCharType { SamallLetter = 1, CapitalLetter = 2, SpecialCharacter = 3, Digit = 4 };
	
		int MaxNumberInArray(int arr[100], int arrLength)
		{
			int Max = 0;
			for (int i = 0; i < arrLength; i++)
			{
				if (arr[i] > Max)
				{
					Max = arr[i];
				}
			}
			return Max;
		}

		int MinNumberInArray(int arr[100], int arrLength)
		{
			int Min = 0;
			Min = arr[0];
			for (int i = 0; i < arrLength; i++)
			{
				if (arr[i] < Min)
				{
					Min = arr[i];
				}
			}
			return Min;
		}
		int SumArray(int arr[100], int arrLength)
		{
			int Sum = 0;
			for (int i = 0; i < arrLength; i++)
			{
				Sum += arr[i];
			}
			return Sum;
		}
		float ArrayAverage(int arr[100], int arrLength)
		{
			return (float)SumArray(arr, arrLength) / arrLength;
		}
		void CopyArray(int arrSource[100], int arrDestination[100], int arrLength)
		{
			for (int i = 0; i < arrLength; i++)
				arrDestination[i] = arrSource[i];



		}
		bool isPrime(int Number)
		{
			int M = round(Number / 2);
			for (int Counter = 2; Counter <= M; Counter++)
			{
				if (Number % Counter == 0)
					return 0;
			}
			return 1;
		}
		void CopyOnlyPrimeNumbers(int arrSource[100], int arrDestination[100], int arrLength, int& arr2Lenght)
		{
			int Counter = 0;
			for (int i = 0; i < arrLength; i++)
			{
				if (isPrime(arrSource[i]))
				{
					arrDestination[Counter] = arrSource[i];
					Counter++;
				}
			}
			arr2Lenght = --Counter;
		}
		short FindNumberPositionInArray(int Number, int arr[100], int arrLength)
		{
			/*This function will search for a number in array and return its
			index,
			or return -1 if it does not exists*/
			for (int i = 0; i < arrLength; i++)
			{
				if (arr[i] == Number)
					return i;// and return the index
			}
			//if you reached here, this means the number is not found
			return -1;







		}
		bool IsNumberInArray(int Number, int arr[100], int arrLength)
		{
			return FindNumberPositionInArray(Number, arr, arrLength) != -1;
		}
		void PrintFoundOrNotFound(int Number, int arr[100], int arrLength)
		{
			cout << "\nNumber you are looking for is: " << Number << endl;
			if (!IsNumberInArray(Number, arr, arrLength))
				cout << "No, The number is not found :-(\n";
			else
			{
				cout << "Yes, it is found :-)\n";
			}
		}
		void ReadArray(int arr[100], int& arrLength)
		{
			cout << "\nEnter number of elements:\n";
			cin >> arrLength;
			cout << "\nEnter array elements: \n";
			for (int i = 0; i < arrLength; i++)
			{
				cout << "Element [" << i + 1 << "] : ";
				cin >> arr[i];
			}
			cout << endl;
		}
		void PrintArray(int arr[100], int arrLength)
		{
			for (int i = 0; i < arrLength; i++)
				cout << arr[i] << " ";
			cout << "\n";
		}
		int RandomNumberforarr(int From, int To)
		{
			//Function to generate a random number
			int randNum = rand() % (To - From + 1) + From;
			return randNum;
		}
		void FillArrayWithRandomNumbers(int arr[100], int arrLength)
		{
			for (int i = 0; i < arrLength; i++)
				arr[i] = RandomNumberforarr(1, 100);
		}	
		void SumOf2Arrays(int arr1[100], int arr2[100], int arrSum[100], int arrLength)
		{
			for (int i = 0; i < arrLength; i++)
			{
				arrSum[i] = arr1[i] + arr2[i];
			}
		}
		void SwapNumbersforarr(int& A, int& B)
		{
			int Temp;
			Temp = A;
			A = B;
			B = Temp;
		}
		void CopyArrayInReverseOrder(int arrSource[100], int arrDestination[100], int arrLength)
		{
			for (int i = 0; i < arrLength; i++)
				arrDestination[i] = arrSource[arrLength - 1 - i];
		}
		void ShuffleArray(int arr[100], int arrLength)
		{
			for (int i = 0; i < arrLength; i++)
			{
				SwapNumbersforarr(arr[RandomNumberforarr(1, arrLength) - 1], arr[RandomNumberforarr(1, arrLength) - 1]);
			}
		}
		char GetRandomCharacter(enCharType CharType)
		{
			switch (CharType)
			{
			case  enCharType::SamallLetter:
			{
				return char(RandomNumberforarr(97, 122));
				break;
			}
			case enCharType::CapitalLetter:
			{
				return char(RandomNumberforarr(65, 90));
				break;
			}
			case enCharType::SpecialCharacter:
			{
				return char(RandomNumberforarr(33, 47));
				break;
			}
			case enCharType::Digit:
			{
				return char(RandomNumberforarr(48, 57));
				break;
			}
			}
		}
		void FillArrayWithGeneratedKeys(string store[], int Number, short longOfKey, short length) {
			for (int k = 1; k <= Number; k++) {

				for (int i = 1; i <= longOfKey; i++) {

					for (int j = 1; j <= length; j++) {

						store[k - 1] += GetRandomCharacter(enCharType::CapitalLetter);



					}


					if (i != longOfKey)
						store[k - 1] += "-";
				}

			}



		}
		void PrintStringArray(string arr[100], int arrLength)
		{
			cout << "\nArray elements:\n\n";
			for (int i = 0; i < arrLength; i++)
			{
				cout << "Array[" << i << "] : ";
				cout << arr[i] << "\n";
			}
			cout << "\n";
		}
		void AddArrayElement(int Number, int arr[100], int& arrLength)
		{
			//its a new element so we need to add the length by 1
			arrLength++;
			arr[arrLength - 1] = Number;
		}
		void CopyOddNumbers(int arrSource[100], int arrDestination[100], int arrLength, int& arrDestinationLength)
		{
			for (int i = 0; i < arrLength; i++)
				if (arrSource[i] % 2 != 0)
				{
					AddArrayElement(arrSource[i], arrDestination,
						arrDestinationLength);
				}



		}
		void FillArrayHardCoded(int arr[100], int& arrLength)
		{
			// Hard coded array elements
			arrLength = 10;
			arr[0] = 10;
			arr[1] = 10;
			arr[2] = 10;
			arr[3] = 50;
			arr[4] = 50;
			arr[5] = 70;
			arr[6] = 70;
			arr[7] = 70;
			arr[8] = 70;
			arr[9] = 90;
		}
		void CopyDistinctNumbersToArray(int arrSource[100], int arrDestination[100], int SourceLength, int& DestinationLength)
		{
			for (int i = 0; i < SourceLength; i++)
			{
				if (!IsNumberInArray(arrSource[i], arrDestination,DestinationLength))
				{
					AddArrayElement(arrSource[i], arrDestination,DestinationLength);
				}
			};
		}
		void SumOf2Arrays(int arr1[100], int arr2[100], int arrSum[100], int arrLength)
		{
			for (int i = 0; i < arrLength; i++)
			{
				arrSum[i] = arr1[i] + arr2[i];
			}
		}
		int TimesRepeated(int Number, int arr[100], int arrLength)
		{
			int count = 0;
			for (int i = 0; i <= arrLength - 1; i++)
			{
				if (Number == arr[i])
				{
					count++;
				}
			}
			return count;
		}
		
}