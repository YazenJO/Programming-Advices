#pragma once
#include <iostream>
#include "clsMyQueue.h"
using namespace std;
template <class T>
class clsMystack :public clsMyQueue <T>
{
public:
	void push(T value) {

		clsMyQueue <T>::InsertAtFront(value);
	}
	T Top() {
		return clsMyQueue <T>::front();
	}
	T Bottom() {
		return clsMyQueue<T>::back();
	}
};

