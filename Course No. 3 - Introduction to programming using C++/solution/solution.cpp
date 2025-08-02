
#include <iostream>
#include <string>
using namespace std;

int GetLastPart(int number) {

    int reminder = 0;
    while (number >= 1) {

        reminder = number % 10;
        number = number / 10;
        return reminder;

    }


}


int GetTheFactorial(int number) {

    int factorial = 1;
    for (int i = number; i > 1 ; i--)
    {

        factorial *= i;

    }
    return factorial;
}


void PrintTheFactorialForTwoNumbers(int number) {

    int Number1 = GetLastPart(number);
    number /= 10;
    int Number2 = GetLastPart(number);
    
    if (Number1 > Number2) {
        for (int i = Number2 + 1 ; i < Number1; i++) {


            cout << "The Factorial of number " << i << " Is : " << GetTheFactorial(i) << endl;

        }
    }

    else
    {

        for (int i = Number1 + 1 ; i < Number2; i++) {


            cout << "The Factorial of number " << i << " Is : " << GetTheFactorial(i) << endl;

        }

    }

}


int main()
{
    int num;
    cin >> num;


    PrintTheFactorialForTwoNumbers(num);

}


