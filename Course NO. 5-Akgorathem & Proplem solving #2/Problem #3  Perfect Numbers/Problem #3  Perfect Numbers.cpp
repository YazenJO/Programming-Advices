#include <iostream>
using namespace std;

enum PerfectOrNot { NotPerfect = 0 , Perfect = 1};
short ReadAPositiveNumber(string Massage) {
    short num;
    do {
        cout << "Enter A Number\n";
        cin >> num;

    } while (num < 0);
    return num;
}
PerfectOrNot IsPerfect(short Num) {
    short sum = 0;
   // int N = Num / 2;
    for (int i = 1; i <= Num; i++) { 
        if (Num % i == 0)
            sum+=i;
        if (sum == Num)
            return PerfectOrNot::Perfect;
    }
    
    return PerfectOrNot::NotPerfect;

}
void PrintResult(short Num) {
    
        if (IsPerfect(Num) == PerfectOrNot::Perfect)
            cout << "Its perfect ";
        else 
            cout << " Notperfect ";
}

int main()
{
   
    PrintResult(ReadAPositiveNumber("Enter num"));
}

