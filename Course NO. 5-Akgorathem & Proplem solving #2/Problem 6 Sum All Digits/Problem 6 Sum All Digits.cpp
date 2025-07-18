#include <iostream>
using namespace std;

int size = 0;
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
short SumDigits(short store[]) {
    short sum = 0;
    for (int i = 0; i < ::size; i++) {

        sum += store[i];



    }

    return sum;



}
int SumOfDigits(int Number) {
    int Sum = 0, Remainder = 0;
    while (Number > 0)
    {
        Remainder = Number % 10;
        Number = Number / 10;
        Sum = Sum + Remainder;
    }
    return Sum;
}



int main()
{
    short storage[10];
    GetDigits(ReadAPositiveNumber("Enter A num"), storage);
    cout<<SumDigits(storage);
   
}

