#include <iostream>
#include <vector>
using namespace std;


int main()
{

	vector <int> vNumbers{ 1,2,3,4,5 };
	cout << vNumbers.at(5)<<endl;
	
	for (int &i : vNumbers) {//we put By refrance bcs if varibale copy each value in vector the program will be slower so we make the varibale refrance to the value so it will not store or copy any value and our program will be faster  
		cout << i;

	}
	return 0;
}
