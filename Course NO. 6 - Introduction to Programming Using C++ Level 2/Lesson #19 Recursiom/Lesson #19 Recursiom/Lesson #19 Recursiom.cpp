#include <iostream>
using namespace std;

void PrintNubmers(int n, int m) {

	if (n <= m) {
		cout << n << endl;
		PrintNubmers(n + 1, m);


	}


}
void PrintNubmersbyReverseInrecartion(int n, int m) {

	if (n >= m) {
		cout << n << endl;
		PrintNubmers(n - 1, m);


	}


}
void CalulatePowerInRecartion(int number, int power,int &store) {
	
	if (power>0)
	{
		
		store *= number;
		CalulatePowerInRecartion(number, power - 1, store);
		




	}



	
	
}
int main()
{
	int store = 1;
	CalulatePowerInRecartion(2, 4, store);
	cout << store;
}

