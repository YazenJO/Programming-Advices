#include <iostream>
using namespace std;

void ReadArrayData(short Arr1[100],short &length) {
	cout << "How many numbers u want fron 1 - 100\n";
	cin >> length;
	
	for (int i = 0; i <= length-1 ; i++) {

		cout << "Please enter number " << '[' << i + 1 << ']' << endl;
		cin >> Arr1[i];

		
	}


}
void PrintArrayData(short Arr1[100],short length) {
	
	for (int i = 0; i <= length - 1; i++) {
		cout << " Number " << '[' << i + 1 << "] :" <<Arr1[i]<< endl;

	}
	
	
}
int CalacluteSum(short Arr1[100],short length) {
	int Sum = 0;
	for (int i = 0; i <= length-1; i++) {

		Sum += Arr1[i];

	}
	return Sum;
}
int main()
{
	short Arr1[100], length = 0,Sum1;

   ReadArrayData(Arr1, length);
   PrintArrayData(Arr1, length);
   Sum1 = CalacluteSum(Arr1, length);
   cout << "********************************\n";
   cout <<"The Sum is : " << Sum1 << endl;
   cout <<"The avg is : " << Sum1 / length;




}