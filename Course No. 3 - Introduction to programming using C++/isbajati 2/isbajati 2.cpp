#include <iostream>
#include <iomanip>
using namespace std;

int ReadNumber(string title) {

    int Number = 0;
    cout << title;
    cin >> Number;
    return Number;

}

bool is_prime(int number) {
    if (number <= 1) {
        return false;
    }
    for (int i = 2; i <= sqrt(number); ++i) {
        if (number % i == 0) {
            return false;
        }
    }
    return true;
}

void PrinttPrimeNumbersBetween(int To , int From) {

    for (int i = From; i < To; i++) {
        if (is_prime(i))
            cout << i << endl;

    }

}

int main() {


    PrinttPrimeNumbersBetween(ReadNumber("Enter To Number : ") , ReadNumber("Enter From Number : "));


}