#include <iostream>
using namespace std; 

//proplem 11

//enum enIsAccept { No = 0, Yes = 1 };
//
//enIsAccept isAccept(int Mark) {
//	
//		if (Mark >= 50)
//			return enIsAccept::Yes;
//		else
//			return enIsAccept::No;
//		
//	}
//void PrintResult(enIsAccept result) {
//	if (result== enIsAccept::Yes)
//		cout << "Pass :)\n";
//	else
//		cout << "Fail :(\n";
//}
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
//	float Num[3],avg;
//	 ReadNumbers(Num);
//	cout << calculateAvg(Num)<<endl;
//	avg = calculateAvg(Num);
//	
//	PrintResult(isAccept(avg));
//
//
//		return 0;
//}

//proplem 12

//float ReadNumbers(float Num[2]) {
//	
//	int i = 0;
//	for (; i < 2; i++) {
// 
//		cin >> Num[i];
//	}
//
//	return Num[i];
//}
//float GetMaxNUm(float Num[2]) {
//	int i = 0;
//	int max  =Num[i];
//	for (; i < 2; i++) {
//		if (max <= Num[i])
//			max = Num[i];
//	}
//	return max;
//}
//int main() {
//	float Num[2];
//	ReadNumbers(Num);
//	cout << GetMaxNUm(Num);
//
//
//
//
//	return 0;
//}

//proplem 13-14

//float ReadNumbers(float Num[2]) {
//	
//	int i = 0;
//	for (; i < 2; i++) {
// 
//		cin >> Num[i];
//	}
//
//	return Num[i];
//}
//void SwapNumbers(float Num[2]){
//	float a;
//	a = Num[0];
//	Num[0] = Num[1];
//	Num[1] = a;
//
//}
//void PrintSwaap(float Num[2]) {
//	for (int i = 0; i < 2; i++)
//		cout << Num[i]<<'\n';
//
//
//
//
//}
//int main() {
//	float Num[2];
//	ReadNumbers(Num);
//	SwapNumbers(Num);
//	PrintSwaap(Num);
//
//	return 0;
//}

//proplem 15

//float ReadNumbers(float Num[2]) {
//    cout << "Ener Width And Lengh\n";
// 	int i = 0;
// 	for (; i < 2; i++) {
//  
// 		cin >> Num[i];
// 	}
// 
// 	return Num[i];
// }
//float CalculateAreaOfRectangle(float Num[2]) {
//
//    return Num[0] * Num[1];
//
//}
//int main() {
//    float Num[2];
//    ReadNumbers(Num);
//    cout<<CalculateAreaOfRectangle(Num);
//
//    return 0;
//}


