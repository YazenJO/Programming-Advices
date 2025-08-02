#include <iostream>
using namespace std;
short ReadMark() {
	short Mark;
	cout << "Enter The Mark" << endl;
	cin >> Mark;

	return Mark;

}
bool PassOrFail(short Mark) {
	if (Mark >= 50)
		return true;
	return false;



}
void PrintResult(bool PassOrFailResult) {
	if (PassOrFail)
		cout << "Pass" << endl;
	else
		cout << "Fail" << endl;


}


int main()
{
	PrintResult(PassOrFail(ReadMark()));
}
