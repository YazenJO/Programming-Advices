#include <iostream>
#include<cmath>
using namespace std;

//problem 31

//short ReadNumbers() {
//	short num;
//
//	cout << "Enter A Number \n";
//	cin >> num;
//
//
//
//	return num;
//}
//short Power2OfNumber(short num) {
//
//	return (pow(num, 2));
//}
//short Power3OfNumber(short num) {
//
//	return (pow(num, 3));
//}
//short Power4OfNumber(short num) {
//
//	return (pow(num, 4));
//}
//int main()
//{
//	int n = ReadNumbers();
//	cout<<" THe Power 2  : " <<Power2OfNumber(n)<<'\n';
//	cout<<" THe Power 3  : " <<Power3OfNumber(n)<<'\n';
//	cout<<" THe Power 4  : " <<Power4OfNumber(n)<<'\n';
//}

//problem 32

//void ReadData(int& n, int& m) {
//	cout << "Enter The Number : \n";
//	cin >> n;
//
//	cout << "Enter The Power : \n";
//	cin >> m;
//}
//short GetPowerMOfN(int n,int m) {
//	int result = 1;
//	for (int i = 0; i < m; i++) {
//		
//		result *= n;
//	}
//	return result;
//
//
//
//
//}
//int main() {
//	int n, m;
//
//	ReadData(n, m);
//	cout<<GetPowerMOfN(n, m);
//
//
//
//
//
//
//
//}

//problem 33

//short ReadAPostiveGrade(int from,int To,string Massage) {
//	short grade;
//	do {
//		cout << Massage << endl;
//		cin >> grade;
//	} while (grade < from|| grade>To);
//	return grade;
//}
//
//char GetGradeletter(short grade) {
//	switch (grade/10)
//	{
//	case 10:
//	case 9:
//		return 'A';
//		break;
//	case 8:
//		return'B';
//		break;
//	case 7:
//		return 'C';
//		break;
//	case 6:
//		return 'D';
//		break;
//	case 5:
//		return 'C';
//		break;
//	case 4:
//	case 3:
//	case 2:
//	case 1:
//	case 0:
//		return 'F';
//			break;
//	}
//	
//
//
//
//
//
//
//}
//int main() {
//
//	cout<<GetGradeletter(ReadAPostiveGrade(0,100,"Enter A Grade From 0 To 100 : "));
//
//
//}


//problem 34 

//float ReadToralSales() {
//	float totalSales;
//	cout << "Enter your total sales\n";
//
//	cin >> totalSales;
//
//
//	return totalSales;
//}
//float GetComissionPercentage(float TotalSales) {
//	if (TotalSales >= 1000000)
//		return 0.01;
//	else if (TotalSales >= 500000)
//		return 0.02;
//	else if (TotalSales >= 100000)
//		return 0.03;
//	else if (TotalSales >= 50000)
//		return 0.05;
//	else
//		return 0.00;
//}
//float CalculateCommission(float num) {
//
//	return GetComissionPercentage(num) * num;
//
//
//
//}
//int main() {
//
//
//	cout << CalculateCommission(ReadToralSales());
//
//	return 0;
//}

//proplem 35

//struct totalTypes {
//	float total_pennys, total_dollars;
//};
//struct stsignType {
//	short Nickels = 0;
//	short Dimes = 0;
//	short Quarters = 0;
//	short Dollars = 0;
//	short penny = 1;
//
//	totalTypes total;
//
//
//
//};
//
//stsignType ReadData() {
//	stsignType Type;
//	cout << "Enter pennys" << endl;
//	cin >> Type.penny;
//
//	cout << "Enter Nickels \n";
//	cin >> Type.Nickels;
//
//	cout << "Enter Dimes \n";
//	cin >> Type.Dimes;
//
//	cout << "Enter Quarters \n";
//	cin >> Type.Quarters;
//
//	cout << "Enter Dollars \n";
//	cin >> Type.Dollars;
//
//	return Type;
//}
//void CalaculateTypesTopennys(stsignType &Type) {
//	Type.Nickels = Type.penny * 5;
//    Type.Dimes = Type.penny * 10;
//    Type.Quarters =  Type.penny * 25;
//    Type.Dollars = Type.penny * 100;
//}
//float CalculateTotalPennys(stsignType &t) {
//	return t.total.total_pennys = t.Dimes + t.Nickels + t.Quarters + t.Dollars + t.penny;
//}
//float CalculateTotalDollars(stsignType &t) {
//	return t.total.total_dollars = t.total.total_pennys / 100;
//}
//int main() {
//	stsignType Type = ReadData();
//	 CalaculateTypesTopennys(Type);
//	 cout << "Pennies :" << CalculateTotalPennys(Type)<<"\n";
//	 cout << "dollars :" << CalculateTotalDollars(Type);
//
//
//
//
//
//
//}

