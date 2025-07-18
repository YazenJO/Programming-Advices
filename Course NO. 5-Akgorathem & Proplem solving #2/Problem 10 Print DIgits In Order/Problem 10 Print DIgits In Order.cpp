#include <iostream>
using namespace std;

int size = 0;
int ReadAPositiveNumber(string Massage) {
    int num;
    do {
        cout << Massage << "\n";
        cin >> num;

    } while (num < 0);
    return num;
}

void PrintArray(int Digits[10]) {


    for (int i = ::size - 1; i >= 0; i--) {
        cout << Digits[i] << "\n";


    }

}
int GetDigits(int number) {

    /*//int Remainder = 0;
    //int i = 0;
    //for (;Number > 0;i++){//1234

    //    store[i] = Number % 10;
    //    Number = Number / 10;
    //    ::size++;
    //}
    //return store[10];*/

    int Reminder = 0, Number2 = 0;
    while (number > 0) {

        Reminder = number % 10;
        number = number / 10;
        Number2 = (Number2 * 10) + Reminder;

    }
    return Number2;
}

void ReverseNumber(int number) {

    int Reminder = 0, Number2 = 0;
    while (number > 0) {

        Reminder = number % 10;
        cout << Reminder << endl;
        number = number / 10;
        Number2 = (Number2 * 10) + Reminder;

    }
    
}


int main()
{    
    int store[10];

   ReverseNumber(GetDigits(ReadAPositiveNumber("Enter a Number")));

   //PrintArray( store);
   
}