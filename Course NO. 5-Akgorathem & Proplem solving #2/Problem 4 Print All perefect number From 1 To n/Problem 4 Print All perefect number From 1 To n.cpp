#include <iostream>
using namespace std;

short ReadAPositiveNumber(string Massage) {
    short num;
    do {
        cout << Massage<<"\n";
        cin >> num;

    } while (num < 0);
    return num;
}
bool IsPerfect(short Num) {
    int sum = 0;
    for (int i = 1; i < Num; i++) {
        if (Num % i == 0) {
            sum += i;

        }


    }
    return (sum==Num);



}
void PrintAllPerfectNumberInRange(short From, short To) {
    for (int i = From; i <= To; i++) {
        if (IsPerfect(i)) {
            cout << i << "\n";
        }

    }
}

int main()
{
    short From = ReadAPositiveNumber("Enter The First Number ");
    short To = ReadAPositiveNumber("Enter The Last Number ");

    PrintAllPerfectNumberInRange(From, To);

    return 0;
}