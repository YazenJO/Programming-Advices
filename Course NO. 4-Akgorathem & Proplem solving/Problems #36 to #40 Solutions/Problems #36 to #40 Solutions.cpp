#include <iostream>
using namespace std;

//proplem 36

//struct stNumberandOp {
//	float num1, num2;
//	string Opreation;
//};
//stNumberandOp ReadData() {
//	stNumberandOp n;
//	cout << "Enter Number 1 \n";
//	cin >> n.num1;
//
//	cout << "Enter Number 2 \n";
//	cin >> n.num2;
//
//	cout << "Enter Operation +,-,*,/ \n";
//	cin >> n.Opreation;
//
//	return n;
//}
//float CalcualteOpration(stNumberandOp Op) {
//	if (Op.Opreation == "+") 
//		return Op.num1 + Op.num2;
//	else if(Op.Opreation=="-")
//		return Op.num1 - Op.num2;
//	else if (Op.Opreation == "*")
//		return Op.num1 * Op.num2;
//	else if (Op.Opreation == "/")
//		return Op.num1 / Op.num2;
//}
//
//int main()
//{
//	cout<<CalcualteOpration(ReadData());
//}

//problem 37

//short ReadNumber() {
//	short num;
//	cout << "Enter a number\n";
//	cin >> num;
//
//	return num;
//}
//short SumNumbers(short Num) {
//	short sum = 0;
//	do {
//		if (Num != -99) {
//			sum += Num;
//			Num = ReadNumber();
//		}
//		else
//			break;
//
//
//	} while (Num != -99);
//	return sum;
//}
//int main() {
//	
//	cout<<SumNumbers(ReadNumber());
//
//}

//problem 40

//float ReadAPositiveNumber(string Massage ) {
//	short num;
//	do {
//		cout << "Enter A Number\n";
//		cin >> num;
//
//	} while (num < 0);
//		return num;
//}
//float CalculateServiceFee(float Num){
//	return (Num * 0.1+Num);
//}
//float CalculateSaleseTax(float Num) {
//	return (Num * 0.16+Num);
//}
//int main() {
//	float num = ReadAPositiveNumber("Enter BillValue");
//	cout << CalculateSaleseTax(CalculateServiceFee(num));
//
//
//
//
//
//
//}