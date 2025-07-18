#include <iostream>
using namespace std;

int Sum(int a, int b, int c = 0, int d = 0) {


	return (a + b + c + d);




}
int main()
{

	cout << Sum(10, 20)<<'\n';
	cout << Sum(10, 20, 30);
}
