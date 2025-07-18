#include <iostream>
#include <string>
#include <cmath>
using namespace std;

short size = 0;

short ReadAPositiveNumber(string Massage) {
    short num;
    do {
        cout << Massage << "\n";
        cin >> num;

    } while (num < 0);
    return num;
}
short GetDigits(short Num, short store[]) {

    short i = 0;
    short N = Num;
    for (; Num > 0; i++) {

        store[i] = Num % 10;
        ::size++;
        Num = Num / 10;
    }
    return store[i];
}

short GetDigits(short Number) {

    return Number % 10;

}

//void PrintDigitsInReservedOrder(short store[]) {
//
//    for (int i = 0; i < ::size; i++) {
//        ::size=::size/::size*
//        cout << store[i];
//      
//    }
//
//    // cout << store[3] << endl;
//
//}
void PrintOfDigits(short Number) {
    short Remainder = 0;
    while (Number > 0)
    {
        Remainder = Number % 10;
        Number = Number / 10;
        cout << Remainder;
    }
   
}
int ReverseDigits(short number) {
   /* int Reminder = 0,Number2=0;
    while (number > 0) {
        Reminder = number % 10;
        number = number / 10;
        Number2 = (Number2 * 10) + Reminder;
        
    }
    return Number2;*/
    string Temp = to_string(number);
    short Length = Temp.length();
    int Result = 0;
    for (int i = Length ; i > 0; i--) {

        Result += GetDigits(number) * pow(10, i);
        number /= 10;

    }
    return Result /10 ;


}




int main()
{
    /*short storage[10];
    GetDigits(ReadAPositiveNumber("Enter A Number"), storage);
    PrintDigitsInReservedOrder(storage);*/
    cout<< ReverseDigits(ReadAPositiveNumber("a"));
}

