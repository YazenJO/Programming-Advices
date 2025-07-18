#pragma once
#include <iostream>
using namespace std;
template <class T>
class clsDynamicArray
{
private :
	int _Size=0;
	T* _TempArray;
public:
	T *OriginalArray;
	clsDynamicArray(int Size=0) {
		if (Size <0)
		{
			Size = 0;
			return;
		}
		_Size = Size;

		OriginalArray = new T[_Size];
	}
	~clsDynamicArray() {
		delete [] OriginalArray;
	}
	bool SetItem(int index, T value) {
		if (index >=_Size ||index <0)
		{
			return false;
		}
		OriginalArray[index] = value;
		return true;
	}
	bool IsEmpty() {
			return((_Size == 0)?true:false);
	}
	int Size() {
		return _Size;
	}
	void PrintList() {
		for (short i = 0; i < _Size; i++)
		{
			cout << OriginalArray[i] << "  ";
		}

	}
	void ReSize(int NewSize) {
		if (NewSize<0)
		{
			NewSize = 0;
		}
		_TempArray = new T[NewSize ];
		if (NewSize<_Size)
		{
			_Size = NewSize;
		}
		for (short i = 0; i < NewSize; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}
		_Size = NewSize;
		delete[] OriginalArray;
		OriginalArray = _TempArray;
	}
	T GetItem(int Index) {

		return (OriginalArray[Index]);


	}
	void Reverse() {
		short S = Size();
		_TempArray = new T[_Size];
		if (_Size==0||_Size==1)
		{
			return ;
		}
		for (int i = 0; i < S; i++)
		{
			_TempArray[i] = OriginalArray[S-i-1];
		}
		delete[]OriginalArray;
		OriginalArray = _TempArray;


	}
	void Clear() {
		_Size = 0;
		_TempArray = new T[0];
		delete[] OriginalArray;
		OriginalArray = _TempArray;
	}
	//bool DeleteItemAt(short Index) {
	//	if (_Size < 0)
	//	{
	//		return false;
	//	}
	//	_TempArray = new T[_Size-1];
	//	short counter=0;
	//	for (short i = 0; i < _Size; i++)
	//	{
	//		if (i == Index)
	//		{
	//			i++;
	//		}
	//		_TempArray[counter] = OriginalArray[i];
	//		 
	//		counter++;
	//	}
	//	_Size--;
	//	delete[] OriginalArray;
	//	OriginalArray = _TempArray;
	//	return true;
	//}
	bool DeleteItemAt(int index)
	{

		if (index >= _Size || index < 0)
		{
			return false;
		}

		_Size--;

		_TempArray = new T[_Size];

		//copy all before index
		for (int i = 0; i < index; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}

		//copy all after index
		for (int i = index + 1; i < _Size + 1; i++)
		{
			_TempArray[i - 1] = OriginalArray[i];
		}

		delete[] OriginalArray;
		OriginalArray = _TempArray;
		return true;

	}
	bool DeleteFirstItem() {
		return DeleteItemAt(0);


	}
	bool DeleteLastItem() {
		return DeleteItemAt(_Size-1);


	}
	int Find(T value) {
		int Sizee = Size();
		for (int i = 0; i < Sizee; i++)
		{
			if (OriginalArray[i]== value)
			{
				return i;
			}
		}
		return -1;

	}
	bool DeleteItem(T Value) {
		int Index = Find(Value);
		if (Index == -1)
			return -1;

		
		return (DeleteItemAt(Index));

	}
	bool InsertAt(int Index, T Value) {
		if (Index > _Size || Index < 0)
		{
			return false;
		}

		_Size++;
		_TempArray = new T[_Size];
		for (int i = 0; i < Index; i++)
		{
			_TempArray[i] = OriginalArray[i];
		}
		_TempArray[Index] = Value;
		for (int i = Index ; i < _Size-1; i++)
		{
			_TempArray[i+1] = OriginalArray[i];
		}
		delete[] OriginalArray;
		OriginalArray = _TempArray;
		return true;

	}
	bool InsertAtBeginning(T Value) {
		if (_Size==0)
		{
			return false;
		}
		return(InsertAt(0, Value));

	}
	bool InsertBefore(int Index, T Value) {
		if (Index > _Size || Index < 0)
		{
			return false;
		}

		if (Index==0)
		{
			return (InsertAtBeginning(Value));
		}

		return(InsertAt(Index-1, Value));



	}
	bool InsertAfter(int Index, T Value) {
		if (Index > _Size || Index < 0)
		{
			return false;
		}

		return(InsertAt(Index+1 , Value));




	}
	bool InsertAtEnd(T Value) {
		return (InsertAt(_Size, Value));

	}
};

