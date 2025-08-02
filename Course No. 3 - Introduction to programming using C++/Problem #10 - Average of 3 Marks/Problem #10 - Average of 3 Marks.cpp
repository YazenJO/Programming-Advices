#include <iostream>
using namespace std;

int main()
{
	short M1 = 0, M2 = 0, M3 = 0, sum = 0;
	cout << "Enter a three numbers " << endl;
	cin >> M1 >> M2 >> M3;

	sum = M1 + M2 + M3;
	cout << "The avarge is :" << sum / 3 << endl;
}

