#include <iostream>
using namespace std;

int size = 0;

short ReadAPositiveNumber(string Massage) {
    short num;
    do {
        cout <<Massage <<"\n";
        cin >> num;

    } while (num < 0);
    return num;
}
short GetDigits(short Num,short store[]) {
   
    short i = 0;
    short N = Num;
    for (; Num > 0 ; i++) {

         store[i]= Num % 10;
         ::size++;
         Num = Num / 10;
    }
    return store[i];
}
void PrintDigitsInReservedOrder(short store[]) {
    
    for (int i = 0; i < ::size ; i++) {

        cout << store[i];
        
    }

   // cout << store[3] << endl;

}
int main()
{
    short store[10];
    GetDigits(ReadAPositiveNumber("öEnter A Number"), store);
    PrintDigitsInReservedOrder(store);
}

