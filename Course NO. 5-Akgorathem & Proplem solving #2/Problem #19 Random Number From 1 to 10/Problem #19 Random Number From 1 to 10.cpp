#include <iostream>
#include<cstdlib>
using namespace std;
enum a{1,4,10 };
int Randomthings(int From, int To) {
	int randNum = rand() % (To - From + 1) + From;


	return randNum;

}
int main()
{
	srand((unsigned)time(NULL));

	cout<<RandomNumber(1, 10)<<endl;
	cout << RandomNumber(1, 10) << endl;
	cout << RandomNumber(1, 10) << endl;
	cout << RandomNumber(1, 10) << endl;
}

