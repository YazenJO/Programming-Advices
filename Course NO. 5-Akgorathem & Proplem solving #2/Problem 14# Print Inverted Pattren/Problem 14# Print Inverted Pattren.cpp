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
void PrintInvertedletterpattern(int Number) {
    for (int i = Number; i > 0; i--) {

        for (int j = i; j > 0; j--) {
            cout << char(i+64);

        }


        cout << "\n";


    }





}

int main()
{
    PrintInvertedletterpattern(ReadAPositiveNumber("Please Enter A positive Number ?"));
}