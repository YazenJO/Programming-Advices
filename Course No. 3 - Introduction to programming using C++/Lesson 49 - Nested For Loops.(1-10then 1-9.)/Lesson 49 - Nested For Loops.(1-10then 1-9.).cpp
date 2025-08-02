#include <iostream>
using namespace std;
void number() {
	for (int i = 10; i > 0; i--) {
		for (int j = 1; j <= i; j++) {

			cout << j;


		}
		cout << '\n';
	}
}
int main()
{
	number();
}

