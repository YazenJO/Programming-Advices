#include <iostream>
using namespace std;

int ReadAPositiveNumber(string Massage) {
    int num;
    do {
        cout << Massage << "\n";
        cin >> num;

    } while (num < 0);
    return num;
}


int GetFrequancy(int Number, int Digit) {////3
    int Remainder = 0, frequancy = 0;
    while (Number > 0)
    {
        Remainder = Number % 10;
        Number = Number / 10;

        if (Digit == Remainder)
            frequancy++;
       
    }
    return frequancy;
}

int main()
{
  
    cout<<GetFrequancy(ReadAPositiveNumber("a"),5);
   
   
}

