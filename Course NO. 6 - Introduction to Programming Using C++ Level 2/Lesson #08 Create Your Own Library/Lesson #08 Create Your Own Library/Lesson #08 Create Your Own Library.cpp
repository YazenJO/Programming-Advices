#include <iostream>
#include"MyLib.h";
#include"Header.h";
using namespace std;
using namespace MyLib;
//the Rec is to not use usin namespace on your librarys bcs sometimes u might have two similar name functions :)
int main()
{
	MyLib::Test();
	
	cout<<MyLib::SumTwoNumbers(1, 2);
	return 0;

}

