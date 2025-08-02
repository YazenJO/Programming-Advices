#include<iostream>
using namespace std;
bool isNmberPositive(int num) {

	
	return ((num >= 0) ?  1 :  0);



}
string IsPositiveZeroNegative(int num) {


	 return ((num > 0) ? "Positive" : (num == 0) ? "Zero" : "Negative");


}
int main() { 
	int num=0;
	cin >> num;
	cout<<IsPositiveZeroNegative(num);
	   
} 