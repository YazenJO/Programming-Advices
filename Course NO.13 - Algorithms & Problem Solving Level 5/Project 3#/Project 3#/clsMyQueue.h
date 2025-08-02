#pragma once
#include <iostream>
#include "clsDbLinkedList.h"
using namespace std;
template <class T>
class clsMyQueue
{
private:
	clsDbLinkedList <T> _MyQueue;


public:

	void push(T value) {
		_MyQueue.InsertAtEnd(value);
	}
	void Print() {
		_MyQueue.PrintList();


	}
	int Size() {
		return _MyQueue.Size();
	}
	T front() {
		return (_MyQueue.GetItem(0));

	}
	T back() {
		return (_MyQueue.GetItem(_MyQueue.Size() - 1));

	}
	void pop() {
		_MyQueue.DeleteFirstNode();

	}
	T GetItem(int Index) {

		return(_MyQueue.GetItem(Index));


	}
	void Reverse() {

		_MyQueue.Reverse();
	}
	bool UpdateItem(int Index, int value) {

		return (_MyQueue.UpdateItem(Index, value));

	}
	bool InsertAfter(int index, int value) {
		return (_MyQueue.InsertAfter(index, value));

	}
	void InsertAtFront(int value) {

		_MyQueue.InsertAtBeginning(value);
	}
	void InsertAtBack(int value) {
		(_MyQueue.InsertAtEnd(value));
	}
	void Clear() {
		_MyQueue.Clear();
	}
};

/*Key Difference Between "Inheritance" & "Composition"

#Inheritance represents an "is-a" relationship.

*Example: A Student is a Person. An Employee is a Person. This means that the Student and Employee classes inherit from the Person class.

*You would not say "a Student has a Person" because it is not a meaningful statement in this context.


#Composition represents a "has-a" relationship.

*Example: A Person has a Face and a Body. A Car has an Engine and Wheels.

*You would not say "a Person is a Face" because it doesn't make sense. Instead, a Person is composed of a Face, Body, etc.


###Explanation:

#Inheritance ("is-a"):

Used when you need to create a new class that is a type of an existing class.
Establishes a parent-child relationship.
Example: Student and Employee are types of Person.


#Composition ("has-a"):

Used when you need to create a class that contains objects of other classes.
Establishes a whole-part relationship.
Example: A Car contains objects like Engine and Wheel.

____________________________________________________________________________________________________
In summary, inheritance is about creating a hierarchy between classes based on shared characteristics, while composition is about building complex types by combining objects.*/

