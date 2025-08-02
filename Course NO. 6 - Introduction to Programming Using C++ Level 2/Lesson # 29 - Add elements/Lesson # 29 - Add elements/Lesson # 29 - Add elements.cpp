#include <iostream>
#include <vector>
using namespace std;

void ReadVector(vector <int>& vec) {
	char WanttoReadMore='y';
	int number=0;
	
	while (WanttoReadMore=='Y'|| WanttoReadMore == 'y')
	{
		cout << "Enter A Number\n";
		cin >> number;
		vec.push_back(number);
		cout << "Want to Add more  (Y/N)?\n";
		cin >> WanttoReadMore;
		
	}
}
void PrintVector(vector <int>&vec) {
	cout << "The Numbers is = ";
	for (int& n : vec) {

		printf(" %d ", n);

	}
}

int main()
{
	
	
	vector <int> vNumbers;
	
	
	ReadVector(vNumbers);
	PrintVector(vNumbers);
		
		
}

