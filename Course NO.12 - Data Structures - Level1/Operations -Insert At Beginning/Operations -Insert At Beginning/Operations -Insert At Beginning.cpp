#include <iostream>
using namespace std;
class Node {

private:
public:
    int value;
    Node* next;
    Node* prev;

};
void InstertAtTheBeginning(Node*& Head, int value) {
    Node* new_node = new Node();
    new_node->value = value;
    new_node->prev = NULL;
    new_node->next = Head;
    if (Head!=NULL)
    {
        Head->prev = new_node;

    }
    Head = new_node;





}
Node* Find(Node* head, int Value)
{

    while (head != NULL) {

        if (head->value == Value)
            return head;


        head = head->next;
    }

    return NULL;


}
void InsertAfter(Node*& Head, int Value) {
    Node* new_node = new Node();
    new_node->value = Value;
   
        new_node->next = Head->next;
        new_node->prev = Head;
        if (Head->next!=NULL)
        {
            Head->next->prev = new_node;// If yes, set the previos points to the new node we created

        }
    Head->next = new_node;
    
}
void InsertAtEnd(Node*& Head, int Value) {
    Node* new_node = new Node();
    new_node->value = Value;
    new_node->next = NULL;
    if (Head==NULL)//if the linked list is empty 
    {
        new_node->prev = NULL;
        Head = new_node;
    }
    else
    {
        Node* Current = Head;
        while (Current->next != NULL)
        {
            Current = Current->next;
        }
        Current->next = new_node;
        new_node->prev = Current;
    }
    

}
void DeleteNode(Node*& Head, Node*& NodeWantToDelete) {
    if (Head==NULL||NodeWantToDelete==NULL)
    {
        return;
    }
    if (Head==NodeWantToDelete)
    {
        Head = NodeWantToDelete->next;
    }
    if (NodeWantToDelete->next!=NULL)
    {
        NodeWantToDelete->next->prev = NodeWantToDelete->prev;
    } 
    if (NodeWantToDelete->prev!=NULL)
    {
        NodeWantToDelete->prev->next = NodeWantToDelete->next;
    } 
    delete NodeWantToDelete;

}
void DeleteFirstNode(Node*& Head) {
    if (Head==NULL)
    {
        return;
    }
    Node* temp = Head;
    Head = Head->next;
    if (Head != NULL) {
        Head->prev = NULL;
    }
    delete temp;


}
void DeleteLastNode(Node*& Head) {
    if (Head == NULL)//if the linked list is empty 
    {
        return;
    }
    if (Head->next==NULL) 
    {
        delete Head;
        Head = NULL;
        return;

    }
    Node* Current = Head;
    while (Current->next != NULL)
    {
        Current = Current->next;
    }
    Current->prev->next = NULL;
    delete Current;

}
void PrintNodeDetails(Node* head)
{

    if (head->prev != NULL)
        cout << head->prev->value;
    else
        cout << "NULL";

    cout << " <--> " << head->value << " <--> ";

    if (head->next != NULL)
        cout << head->next->value << "\n";
    else
        cout << "NULL";

}
// Print the linked list
void PrintListDetails(Node* head)

{
    cout << "\n\n";
    while (head != NULL) {
        PrintNodeDetails(head);
        head = head->next;
    }
}

// Print the linked list
void PrintList(Node* head)

{
    cout << "NULL <--> ";
    while (head != NULL) {
        cout << head->value << " <--> ";
        head = head->next;
    }
    cout << "NULL";

}

int main()
{
    Node* Head = NULL;
    InstertAtTheBeginning(Head, 5);
    InstertAtTheBeginning(Head, 4);
    InstertAtTheBeginning(Head, 3);
    InstertAtTheBeginning(Head, 2);
    InstertAtTheBeginning(Head, 1);
    //Node* N1 = Find(Head, 3);
    //DeleteNode(Head, N1);
    DeleteLastNode(Head);
    PrintList(Head);
    PrintListDetails(Head);

}