#include <iostream>
#include "clsDbLinkedList.h"
using namespace std;
int main()
{
    clsDbLinkedList <int> MydblLinkedList;
    MydblLinkedList.InsertAtBeginning(4);//3
    MydblLinkedList.InsertAtBeginning(3);//2
    MydblLinkedList.InsertAtBeginning(2);//1
    MydblLinkedList.InsertAtBeginning(1);//0
    MydblLinkedList.InsertAfter(1, 500);
    MydblLinkedList.PrintList();
    cout << "  \nThe (3)Item   " << MydblLinkedList.GetItem(3);
    system("pause>0");
}

