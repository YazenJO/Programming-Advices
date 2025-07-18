#include <iostream>
using namespace std;
char ReadAChar(string masssage) {
	char ch = ' ';
	cout << masssage << '\n';
	cin >> ch;
	return ch;
}
bool isvowel(char ch) {
	tolower(ch);
	return (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');
}
int main()
{
	
}
