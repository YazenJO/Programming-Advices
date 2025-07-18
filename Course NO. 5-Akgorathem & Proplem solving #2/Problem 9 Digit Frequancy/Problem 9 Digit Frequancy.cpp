#include <iostream>
#include <string>
using namespace std;


int ReadAPositiveNumber(string Massage) {
    int num;
    do {
        cout << Massage << "\n";
        cin >> num;

    } while (num < 0);
    return num;
}

int GetDigit(int Number) {
    return Number % 10;

};

bool IsExist(char Digit , string Number) {

    for (int i = 0; i < Number.length();i++ ) {

        if (Digit == Number[i])
            return true;

    }
    return false;
}


int GetFrequancyForEachDigit(string Number , char c) {
    int counter = 0;
    for (int i = 0; i < Number.length(); i++) {

        if (c == Number[i])
            counter++;
    }
    return counter;
}

void GetFrequancy(int Number) {
  /*  int Remainder = 0, frequancy = 0;
    short counter = 0;
    while (Number > 0)
    {
        Remainder = Number % 10;

        if (Digit == Remainder && !IsExist(Digit)) {
            frequancy++;
        }
            
        counter++;
        Number = Number / 10;
    }
    return frequancy;*/

    string sNumber = to_string(Number);
    string FreqNumbers = "";
    char c;
    int Frequency = 0;
    for (int i = 0; i < sNumber.length();i++) {
        c = sNumber[i];
        Frequency = GetFrequancyForEachDigit(sNumber, c);
        if (!IsExist(c, FreqNumbers)) {
            cout << "Freq For Number [" << sNumber[i] << "] is : " << Frequency << endl;
            FreqNumbers += c;
        }


    }



}

//void GetFrequancyForEachDigitINNUmber(int Number) {
//    /*int Digit,f;
//    do
//    {
//        Digit = GetDigit(Number);
//        f = GetFrequancy(Number, Digit);
//        cout << "The Digit " << Digit;
//        if (Digit != GetDigit(Number / 10)) {
//           
//            cout <<"  The Frequance is " << GetFrequancy(Number, Digit)<<" Time's\n";
//        }
//       
//
//        Number = Number / 10;
//        
//
//        
//    } while (Number>0);*/
//
//
//    while (Number > 0)
//    {
//
//        int Digit = GetDigit(Number);
//
//        cout <<"Frequincy of Number [" << Digit<<"] is : "<< GetFrequancy(Number, Digit) << endl;
//        Number /= 10;
//
//    }
//
//
//}
int main()
{
   // GetFrequancyForEachDigitINNUmber(ReadAPositiveNumber("Enter A Number : "));

    GetFrequancy(ReadAPositiveNumber("Enter A Number : "));

}

