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
void PrintInvertedpattern(int Number) {
    for (int i = 1; i <= Number; i++) {

        for (int j = i; j > 0; j--) {
            cout << char(i+64);

        }


        cout << "\n";


    }





}

int main()
{
    PrintInvertedpattern(ReadAPositiveNumber("Please Enter A positive Number ?"));
}



