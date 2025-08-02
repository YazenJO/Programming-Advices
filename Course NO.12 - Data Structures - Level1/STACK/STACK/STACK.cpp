#include <iostream>
#include <stack>
#include <vector>
using namespace std;
int main()
{
	stack <int>Numbers;
	stack <int>Numbers2;
	vector <int>VNumbers;	

	Numbers.push(10);
	Numbers.push(20);
	Numbers.push(30);
	Numbers.push(40);
	Numbers.push(50);
	 

	Numbers2.push(60);
	Numbers2.push(70);
	Numbers2.push(80);
	Numbers2.push(90);

	Numbers.swap(Numbers2);
	cout << '\n' << " Stack 1 : ";
	while (!Numbers.empty())
	{
		cout << Numbers.top()<<" ";
		Numbers.pop();
	}
	cout << '\n' << " Stack 2 : ";
	while (!Numbers2.empty())
	{
		cout << Numbers2.top() << " ";
		Numbers2.pop();
	}


	system("pause >0");
	return 0;
}

