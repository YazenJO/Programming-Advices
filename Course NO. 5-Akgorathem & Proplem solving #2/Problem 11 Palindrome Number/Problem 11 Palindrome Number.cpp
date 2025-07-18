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
int  ReverseNumber(int number) {

    int Reminder = 0, Number2 = 0;
    while (number > 0) {

        Reminder = number % 10;
        number = number / 10;
        Number2 = (Number2 * 10) + Reminder;

    }
    return Number2;
}

int ReverseNumber2(int number) {

    int Reminder = 0, Number2 = 0;
    while (number > 0) {

        Reminder = number % 10;
        number = number / 10;
        Number2 = (Number2 * 10) + Reminder;

    }
    return Number2;
}
void PrintIfPalindrome(int number) {
    if (ReverseNumber2(ReverseNumber(number)) == ReverseNumber(number))
        cout << "Yes,it is a Palindrome Number ";
    else
        cout << "No,it isNot a Palindrome Number ";


}

int main()
{
    int store[10];

    PrintIfPalindrome(ReadAPositiveNumber("Enter a Number"));


}




