#include <iostream>
using namespace std;

class clsCalculater
{
private:
	float _result=0;
	float _LastNumber;
	enum Operators
	{
		eClear=0,eAdd=1,eSubstract=2,eDivide=3,eMultiply=4
	};
	Operators _Op;
	void PrintOperatorName() {
		switch (_Op)
		{
		case clsCalculater::eClear:
			cout << "Result After Clear " << _LastNumber << " is :";
			break;
		case clsCalculater::eAdd:
			cout << "Result After Adding " << _LastNumber << " is :";
			break;
		case clsCalculater::eSubstract:
			cout << "Result After Substract " << _LastNumber << " is :";
			break;
		case clsCalculater::eDivide:
			cout << "Result After Divide " << _LastNumber << " is :";
			break;
		case clsCalculater::eMultiply:
			cout << "Result After Multiply " << _LastNumber << " is :";
			break;
		default:
			break;
		}



	}
public:
	void Clear() {
		_result = 0;
		_Op = eClear;
	}
	void Add(float Number) {
		_LastNumber = Number;
		_result += Number;
		_Op = eAdd;
	}
	void Substract(float Number) {
		_LastNumber = Number;
			_result -= Number;
			_Op = eSubstract;
	}
	void Divide(float Number) {
		_LastNumber = Number;
		_result /= Number;
		_Op = eDivide;
	}
	void Multiply(float Number) {
		_LastNumber = Number;
		_result *= Number;
		_Op = eMultiply;
	}
	void PrintResult() {
		PrintOperatorName();
		cout << _result << "\n";
	}
	void GetFinalResult() {
		cout << _result << "\n";
	
	};
};

int main()
{
	clsCalculater Calculater1;
	Calculater1.Add(10);
	Calculater1.PrintResult();

	Calculater1.Clear();
	
	Calculater1.Add(200);
	Calculater1.PrintResult();

	Calculater1.Divide(10);
	Calculater1.PrintResult();
}

