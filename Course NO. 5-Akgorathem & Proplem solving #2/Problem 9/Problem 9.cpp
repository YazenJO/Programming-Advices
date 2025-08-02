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
void GetFrequancyForEachDigit(int Number) {
    for (int i = 0; i <= 9; i++) {

        if (GetFrequancy(Number, i) != 0) {
            cout << "The Digit is : " << i;
            cout << " The Frequancy : " << GetFrequancy(Number, i)<<endl;

        }


    }


}
int main()
{
    GetFrequancyForEachDigit(ReadAPositiveNumber("a"));
}

