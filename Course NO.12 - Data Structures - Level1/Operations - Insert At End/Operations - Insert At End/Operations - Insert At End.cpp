#include <iostream>
using namespace std;
class Node {
private:
public:
	int value;
	Node* next;
};
void InsertAtTheBeginng(Node*& head, int value) {
	Node* new_node = new Node();

	new_node->value = value;
	new_node->next = head;

	head = new_node;


}
void InsertAtTheEnd(Node*& head, int Value) {
	Node* new_node = new Node();
	new_node->value = Value;
	new_node->next = NULL;
	if (head==NULL)
	{
		head = new_node;
		return;
	}
	Node* LastNode = head;
	while (LastNode ->next!=NULL)
	{
		LastNode = LastNode->next;
	}
	LastNode->next = new_node;
	return;

}
void PrintList(Node* head) {
	while (head != NULL)
	{
		cout << head->value << " ";
		head = head->next;
	}



}
int main()
{
	Node* Head=NULL;

	InsertAtTheEnd(Head, 1);
	InsertAtTheEnd(Head, 2);
	InsertAtTheEnd(Head, 3);
	PrintList(Head);

	system("pause>0");
}
