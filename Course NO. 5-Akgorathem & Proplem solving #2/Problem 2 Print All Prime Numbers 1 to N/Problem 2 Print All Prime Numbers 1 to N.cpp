#include <iostream>
using namespace std;

enum PrimeOrNot{Prime=1, NotPrime = 0};
short ReadAPositiveNumber(string Massage) {
    		short num;
    		do {
    			cout << "Enter A Number\n";
    			cin >> num;
    	
    		} while (num < 0);
    			return num;
    	}
PrimeOrNot IsPrime(short Num) {
    
    for (int i = 2; i < Num; i++) {
        if (Num % i == 0)
            return PrimeOrNot::NotPrime;
    }
    return PrimeOrNot::Prime;
}
void PrintAllPrimeNumberFromNtoN(short From,short To) {
    if (From < To) {
        for (int i = From; i < To; i++) {

            if (IsPrime(i) == PrimeOrNot::Prime)
                cout << i << " :is Prime \n";
        }
    }
    else if (From > To) {

        for (int i = To; i < From; i++) {

            if (IsPrime(i) == PrimeOrNot::Prime)
                cout << i << " :is Prime \n";
        }
    }
    else if (From = To)
        cout << "Enter Two Difrrent Numbers\n";

}

int main()
{
    short From = ReadAPositiveNumber("Enter From Number ");
    short To = ReadAPositiveNumber("Enter To Number");
    PrintAllPrimeNumberFromNtoN(From, To);
}











