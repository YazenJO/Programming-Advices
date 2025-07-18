#include <iostream>
using namespace std;
struct stInfo {
	string Name;
	short Age;

};
int main()
{
	/*int a = 0;
	cout << a;
	cout << "\n" << &a;
	int* p = &a;

	cout << "\n" << p;
	cout << "\n" << &p;
	*p = 4;
	a = 5;
	cout << "\n" << *p;*/

	/*int arr[4] = { 10,20,30,40 };
	int* p = arr;
	for (int i = 0; i < 4; i++) {

		cout << *(p + i) << endl;

	}*/
	/*stInfo S, *ptr;
	S.Name = "Yazen Bilal";
	S.Age = 19;
	cout << S.Name << endl;
	cout << S.Age << endl;
	ptr = &S;
	cout << "\nUsing Pointers\n" << endl;
	cout << ptr->Name << endl;
	cout <<		ptr->Age << endl;*/

 void * ptr;
 float f1 = 10.5;
 int x = 50;  
 ptr = &f1;  
 cout << ptr <<endl; 
 cout << *(float*)ptr << endl;
	/*ptr = &x; 
	cout << ptr << endl;  
	cout << *(static_cast<int*>(ptr)) << endl;*/
	return 0; 
}


