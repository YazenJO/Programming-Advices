#pragma once
#include <iostream>
#include "clsDynamicArray.h"
using namespace std;
template <class T>
class clsMyQueueArr
{
private:
	clsDynamicArray <int> MyQueueArr;
public:
	void push(T Value) {
		MyQueueArr.InsertAtEnd(Value);

	}
	void Print() {
		MyQueueArr.PrintList();
	}
	int Size() {
		return MyQueueArr.Size();
	}
	T front() {
		return (MyQueueArr.GetItem(0));

	}
	T back() {
		return (MyQueueArr.GetItem(MyQueueArr.Size() - 1));

	}
	void pop() {
		MyQueueArr.DeleteFirstItem();

	}
	T GetItem(int Index) {

		return(MyQueueArr.GetItem(Index));


	}
	void Reverse() {

		MyQueueArr.Reverse();
	}
	bool UpdateItem(int Index, int value) {

		return (MyQueueArr.UpdateItem(Index, value));

	}
	bool InsertAfter(int index, int value) {
		return (MyQueueArr.InsertAfter(index, value));

	}
	void InsertAtFront(int value) {

		MyQueueArr.InsertAtBeginning(value);
	}
	void InsertAtBack(int value) {
		(MyQueueArr.InsertAtEnd(value));
	}
	void Clear() {
		MyQueueArr.Clear();
	}
};



