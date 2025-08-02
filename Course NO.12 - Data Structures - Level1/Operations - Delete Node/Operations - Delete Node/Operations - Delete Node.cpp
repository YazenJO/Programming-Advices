	#include <iostream>
	using namespace std;
	class Node {
	private:
	public:
		int value;
		Node* next;
	};
	void InsertAtTheEnd(Node*& head, int Value) {
		Node* new_node = new Node();
		new_node->value = Value;
		new_node->next = NULL;
		if (head == NULL)
		{
			head = new_node;
			return;
		}
		Node* LastNode = head;
		while (LastNode->next != NULL)
		{
			LastNode = LastNode->next;
		}
		LastNode->next = new_node;
		return;

	}
	void DeleteNode(Node*& head, int Value) {
		Node* Current = head;
		Node* Prev = head;
		if (head==NULL)
		{
			return;
		}
		if (Current->value==Value)
		{
			head = Current->next;
			delete Current;
			return;
		}
		while (Current != NULL && Current->value != Value)
		{
			Prev = Current;
			Current=Current->next;
		}
		if (Current == NULL)return;
		Prev->next = Current->next;
		delete Current;
	}
	void DeleteFirstNode(Node*& head) {
		Node* Current = head;

		if (head == NULL)
		{
			return;
		}
			head = Current->next;
			delete Current;
			return;





	}
	void DeleteLastNode(Node*& head) {
		Node* Current = head;
		Node* Prev = head;
		if (head == NULL)
		{
			return;
		}
		if (Current->next==NULL)
		{
			head = NULL;
			delete Current;
			return;

		}
		while (Current != NULL && Current->next != NULL) {
			Prev = Current;
			Current = Current->next;
		}
		Prev->next = NULL;
		delete Current;



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
		Node* Head =NULL;		 
		InsertAtTheEnd(Head, 1);
		InsertAtTheEnd(Head, 2);
		InsertAtTheEnd(Head, 3);	
		InsertAtTheEnd(Head, 4);
		InsertAtTheEnd(Head, 5);
		DeleteLastNode(Head);
		PrintList(Head);

		system("pause>0");
	}
