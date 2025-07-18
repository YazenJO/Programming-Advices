#pragma once
#include <iostream>
using namespace std;

template <class T>
class clsDbLinkedList
{
protected:
    int _Size = 0;

public:
    class Node
    {

    public:
        T value;
        Node* next;
        Node* prev;
    };
    Node* head = NULL;
    void InsertAtBeginning(T value) {
        Node* new_node = new Node();

        new_node->value = value;
        new_node->prev = NULL;
        new_node->next = head;
        if (head != NULL)
        {
            head->prev = new_node;

        }
        head = new_node;



        _Size++;

    }
    Node* Find(T Value)
    {
        Node* Current = head;

        while (Current != NULL) {

            if (Current->value == Value)
                return Current;


            Current = Current->next;
        }

        return NULL;


    }
    void InsertAfter(Node*& Head, T Value) {
        Node* new_node = new Node();
        new_node->value = Value;

        new_node->next = Head->next;
        new_node->prev = Head;
        if (Head->next != NULL)
        {
            Head->next->prev = new_node;// If yes, set the previos points to the new node we created

        }
        Head->next = new_node;

        _Size++;
    }
    void InsertAtEnd(T Value) {
        Node* new_node = new Node();
        new_node->value = Value;
        new_node->next = NULL;
        if (head == NULL)//if the linked list is empty 
        {
            new_node->prev = NULL;
            head = new_node;
        }
        else
        {
            Node* Current = head;
            while (Current->next != NULL)
            {
                Current = Current->next;
            }
            Current->next = new_node;
            new_node->prev = Current;
        }


        _Size++;
    }
    void DeleteNode(Node*& NodeWantToDelete) {
        if (head == NULL || NodeWantToDelete == NULL)
        {
            return;
        }
        if (head == NodeWantToDelete)
        {
            head = NodeWantToDelete->next;
        }
        if (NodeWantToDelete->next != NULL)
        {
            NodeWantToDelete->next->prev = NodeWantToDelete->prev;
        }
        if (NodeWantToDelete->prev != NULL)
        {
            NodeWantToDelete->prev->next = NodeWantToDelete->next;
        }
        delete NodeWantToDelete;

        _Size--;
    }
    void DeleteFirstNode() {
        if (head == NULL)
        {
            return;
        }
        Node* temp = head;
        head = head->next;
        if (head != NULL) {
            head->prev = NULL;
        }
        delete temp;


        _Size--;
    }
    void DeleteLastNode() {
        if (head == NULL)//if the linked list is empty 
        {
            return;
        }
        if (head->next == NULL)
        {
            delete head;
            head = NULL;
            _Size--;
            return;

        }
        Node* Current = head;
        while (Current->next != NULL)
        {
            Current = Current->next;
        }
        Current->prev->next = NULL;
        delete Current;

        _Size--;
    }
    void PrintNodeDetails()
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
    void PrintList()
    {
        Node* Current = head;
        cout << "NULL <--> ";
        while (Current != NULL) {
            cout << Current->value << " <--> ";
            Current = Current->next;
        }
        cout << "NULL";

    }
    int Size() {
        return _Size;
    }
    bool IsEmpty() {
        return (_Size == 0);
    }
    void Clear() {
      
        while (_Size > 0)
        {
            DeleteFirstNode();
        }
    }
    void Reverse() {
        Node* Temp = NULL;
        Node* Current = head;

        if (_Size == 0 || _Size == 1)
        {
            return;
        }
        while (Current != NULL) {
            Temp = Current->prev;
            Current->prev = Current->next;
            Current->next = Temp;

            Current = Current->prev;
        }
        if (Temp != NULL)
            head = Temp->prev;//start the linked list reversly
    }
    Node* GetNode(int NumberOfNode) {
        Node* Current = head;
        if (NumberOfNode>=_Size-1|| NumberOfNode<0)
        {
            return NULL;
        }
        for (short i = 0; i < NumberOfNode; i++)
        {
           Current= Current->next;
        }

        return Current;

    }
    T GetItem(int Index) {
        Node* N1 = GetNode(Index);
        if (N1==NULL)
        
            return NULL;
        
        else
        
            return (N1->value);

        

    }
    bool UpdateItem(int Index, int NewValue) {
        Node* NodeWantToUpdate = GetNode(Index);
        if (NodeWantToUpdate!=NULL)
        {
            NodeWantToUpdate->value = NewValue;
            return true;

        }
        else
        {
            return false;
        }

    }
    bool InsertAfter(int Index, T Value) {
        Node* New_node = GetNode(Index);
        if (New_node != NULL)
        {
            InsertAfter(New_node, Value);
            _Size++;
            return true;
        }
        else
        
            return false;
        
        
    }

};

