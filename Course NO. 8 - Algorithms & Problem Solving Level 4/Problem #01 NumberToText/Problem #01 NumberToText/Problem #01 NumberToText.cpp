#include <iostream>
#include <string>

using namespace std;

// Function to convert a single digit to its text equivalent
string digitToText(int digit) {
    static string belowTwenty[] = { "", "One", "Two", "Three", "Four", "Five",
                                  "Six", "Seven", "Eight", "Nine", "Ten",
                                  "Eleven", "Twelve", "Thirteen", "Fourteen",
                                  "Fifteen", "Sixteen", "Seventeen", "Eighteen",
                                  "Nineteen" };
    static string belowHundred[] = { "", "", "Twenty", "Thirty", "Forty", "Fifty",
                                   "Sixty", "Seventy", "Eighty", "Ninety" };

    if (digit < 20)
        return belowTwenty[digit];
    else
        return belowHundred[digit / 10] + " " + belowTwenty[digit % 10];
}

// Recursive function to convert any number to text
string numberToText(int num) {
    if (num == 0)
        return "Zero";

    string result;
    if (num < 0)
        result = "Negative ";
    else
        result = "";

    num = abs(num);

    if (num < 100)
        result += digitToText(num);
    else if (num < 1000)
        result += digitToText(num / 100) + " Hundred " + numberToText(num % 100);
    else if (num < 1000000)
        result += numberToText(num / 1000) + " Thousand " + numberToText(num % 1000);
    else if (num < 1000000000)
        result += numberToText(num / 1000000) + " Million " + numberToText(num % 1000000);
    else
        result += numberToText(num / 1000000000) + " Billion " + numberToText(num % 1000000000);

    return result;
}

int main() {
    int number;

    cout << "Enter a number: ";
    cin >> number;

    cout << "Number in words: " << numberToText(number) << endl;

    return 0;
}
