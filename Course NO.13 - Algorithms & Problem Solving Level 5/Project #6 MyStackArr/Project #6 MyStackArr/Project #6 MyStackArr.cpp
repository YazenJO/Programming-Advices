//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

#include <iostream>
#include "clsMyStackArr.h"

using namespace std;

int main()
{

    clsMyStackArr <int> MyStack;

    MyStack.push(10);
    MyStack.push(20);
    MyStack.push(30);
    MyStack.push(40);
    MyStack.push(50);


    cout << "\nStack: \n";
    MyStack.Print();

    cout << "\nStack Size: " << MyStack.Size();
    cout << "\nStack Top: " << MyStack.Top();
    cout << "\nStack Bottom: " << MyStack.Bottom();

    MyStack.pop();

    cout << "\n\nStack after pop() : \n";
    MyStack.Print();


    cout << "\n\n Item(2) : " << MyStack.GetItem(2);


    MyStack.Reverse();
    cout << "\n\nStack after reverse() : \n";
    MyStack.Print();


    MyStack.UpdateItem(2, 600);
    cout << "\n\nStack after updating Item(2) to 600 : \n";
    MyStack.Print();


    MyStack.InsertAfter(2, 800);
    cout << "\n\nStack after Inserting 800 after Item(2) : \n";
    MyStack.Print();



    MyStack.InsertAtFront(1000);
    cout << "\n\nStack after Inserting 1000 at top: \n";
    MyStack.Print();


    MyStack.InsertAtBack(2000);
    cout << "\n\nStack after Inserting 2000 at bottom: \n";
    MyStack.Print();


    MyStack.Clear();
    cout << "\n\nStack after Clear(): \n";
    MyStack.Print();

    system("pause>0");

}