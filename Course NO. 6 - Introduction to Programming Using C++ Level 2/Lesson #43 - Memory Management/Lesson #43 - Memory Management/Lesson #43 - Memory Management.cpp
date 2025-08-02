#include <iostream>
using namespace std;
int main()
{
	int* ptrx;
	float* ptry;

	ptrx = new int;
    ptry = new float;

	*ptrx = 10;
	*ptry = 15.4;

	cout << *ptrx << endl;
	cout << *ptry << endl;

	delete ptrx;
	delete ptry;

}

