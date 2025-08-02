#include <iostream>
using namespace std;
class Node {
private:
public:
	int value;
	Node* next;
};
void InsertAtTheBeginng(Node* & head, int value) {
	Node* new_node = new Node();

	new_node->value = value;
	new_node->next = head;

	head = new_node;


}
Node* Find(Node* Head, int Value) {
	while (Head!=NULL)
	{
		if (Head->value == Value)
			return Head;
		Head = Head->next;
	}
	return NULL;

}
void InsertAfter(Node* prev_node, int Value) {
	if (prev_node==NULL)
	{
		cout << "the given previous node cannot be Null";
		return;
	}
	Node* new_node = new Node();
	new_node->value = Value;
	new_node->next = prev_node->next;
	prev_node->next = new_node;
}
void PrintList(Node* head) {
	while (head!=NULL)
	{
		cout << head->value <<" ";
		head = head->next;
	}



}
int main()
{
	Node* Head = NULL;
	InsertAtTheBeginng(Head, 1);
	InsertAtTheBeginng(Head, 2);
	InsertAtTheBeginng(Head, 3);
	InsertAtTheBeginng(Head, 4);
	InsertAtTheBeginng(Head, 5);


	Node* N1 = NULL;
	N1=Find(Head, 2);
	InsertAfter(N1, 200);
	PrintList(Head);

	if (N1==NULL)
	{
		cout << "\tThe Element Not Found :(";
	}
	else
	{
		cout << "\nThe Element Found :)";
	}
	system("pause>0");
}
