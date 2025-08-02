#pragma once
#include <iostream>
#include "clsMystack.h"
using namespace std;

class clsMyString
{
private:
	string _Value = "";
	clsMystack <string> _Undo;
	clsMystack <string> _Rendo;

public:

	void setValue(string newValue) {
		_Undo.push(_Value);

		_Value = newValue;

	}
	string getValue()  { 
		return _Value;
	}
	__declspec(property(get = getValue, put = setValue))string Value;

	void Undo() {
		_Rendo.push(_Value);
		_Value = _Undo.Top();

		_Undo.pop();
		if (_Undo.Size()==0)
		{
			_Value = "";
			return;
		}
	}
	void Redo() {
		_Undo.push(_Value);
		_Value = _Rendo.Top();

		_Rendo.pop();

	}
};

