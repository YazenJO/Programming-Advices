//#include <iostream>
//#include "clsPerson.h"
//#include "clsEmployee.h"
//using namespace std;
//
//int main()
//
//{
//
//    clsEmployee Employee1(10, "Mohammed", "Abu-Hadhoud", "A@a.com", "8298982", "CEO", "ProgrammingAdvices", 5000);
//
//    Employee1.Print();
//
//    system("pause>0");
//    return 0;
//}

//ProgrammingAdivces.com
//Mohammed Abu-Hadhoud
#include<iostream>
#include<vector>

using namespace std;

class clsA
{
	
public:
	//Parametarized Constructor
	int objectNumber = 0;
	clsA(int value)
	{
		x = value;
		
	}

	int x;

	void Print()
	{
		cout << "The value of x=" << x << endl;
		cout << "objectNumber = " << objectNumber << endl;
	}

};


int main()

{

	vector <clsA> v1;
	short NumberOfObjects = 5;

	// inserting object at the end of vector
	for (int i = 0; i < NumberOfObjects; i++)
	{
		v1.push_back(clsA(i));
		v1[i].objectNumber += i * 10;
		
	}

	// printing object content
	for (int i = 0; i < NumberOfObjects; i++)
	{
		v1[i].Print();

	}

	system("pause>0");

}

