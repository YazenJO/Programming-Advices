#include <iostream>
#include<string>
using namespace std;
//proplem 6 

//struct  stNames {
//	string firstName;
//	string LastName;
//};
//stNames ReadFirstName() {
//	stNames info;
//	cout << "Enter your first Name \n";
//	cin >> info.firstName;
//	return info;
//}
//stNames ReadLastName(stNames info) {
//	cout << "Enter your first Name \n";
//	cin >> info.LastName;
//	return info;
//}
//void PrintFullNAme(stNames info) {
//
//	cout << "Your FUll name is \n";
//	cout << info.firstName << " " << info.LastName << endl;
//
//
//
//
//}
//int main()
//{
//	PrintFullNAme(ReadLastName(ReadFirstName()));
//}
//

//proplem 7

//float ReadNumber() {
//	int num;
//	cout << "Enter A num\n";
//	cin >> num;
//	return num;
//}
//float GetTHehalf(float num) {
//
//	return num / 2;
//}
//
//int main() {
//
//	cout<<GetTHehalf(ReadNumber());
//
//
//
//	return 0;
//}
 
//proplem 8


//enum enIsAccept {No=0,Yes=1};
//int ReadMArk() {
//	int Mark;
//	cout << "Enter a mark\n" << endl;
//	cin >> Mark;
//
//	return Mark;
//}
//enIsAccept isAccept(int Mark){
//	if (Mark >= 50)
//		return enIsAccept::Yes;
//	else
//		return enIsAccept::No;
//	
//}
//void PrintResult(enIsAccept result) {
//	if (result== enIsAccept::Yes)
//		cout << "Pass :)\n";
//	else
//		cout << "Fail :(\n";
//}
//int main() {
//	PrintResult(isAccept(ReadMArk()));
//}

//proplem 9

//float ReadNumbers(float Num[3]) {
//	
//	int i = 0;
//	for (; i < 3; i++) {
//		cin >> Num[i];
//	}
//
//	return Num[i];
//}
//float calculateSum(float Num[]) {
//	
//	int sum=0;
//	for (int i = 0; i < 3; i++) {
//		sum += Num[i];
//
//
//	}
//
//	return sum;
//}
//int main() {
//	float Num[3];
//	 ReadNumbers(Num);
//	cout << calculateSum(Num);
//
//
//		return 0;
//}

///proplem 10

//float ReadNumbers(float Num[3]) {
//	
//	int i = 0;
//	for (; i < 3; i++) {
//		cin >> Num[i];
//	}
//
//	return Num[i];
//}
//float calculateAvg(float Num[]) {
//	
//	int Avg=0;
//	for (int i = 0; i < 3; i++) {
//		Avg += Num[i];
//
//
//	}
//
//	return Avg/3;
//}
//int main() {
//	float Num[3];
//	 ReadNumbers(Num);
//	cout << calculateAvg(Num);
//
//
//		return 0;
//}
