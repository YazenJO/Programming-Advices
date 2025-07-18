#include <iostream>
#include <iomanip>
using namespace std;

void MultipleNumbers() {
	for (int i = 1; i <= 10; i++) {
		if (i < 10) {
			cout << i << setw(3) << "|" << "\t";
		}
		else
			cout << i << setw(2) << "|" << "\t";
		for (int j = 1; j <= 10; j++) {
			cout << i * j << "\t";




		}
		

		cout <<"\n";

	}
}
void Print_() {
	cout << "\n";
	for (int i = 1; i <= 17; i ++ ) {

		cout << "-----";

	}


	cout << "\n";
}
void PrintUpperCounter() {
	int counter = 1;
	while (counter <= 10) {
		cout << "\t" << counter;

		counter++;
	 }
		 
		 


} 
int main()
{
	cout << "\t\t\tMultiplication Table From 1 To 10 \n" << endl;
	PrintUpperCounter();
	Print_();
	MultipleNumbers();
	
}

