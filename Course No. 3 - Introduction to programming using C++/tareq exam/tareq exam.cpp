#include <iostream>
using namespace std;
int main()
{
	short n;
	cout << "numbers of stars u want " << endl;
	cin >> n;
	for (int i = n; i >= 1; i--) { 
		
		for (int j = i; j >= 1; j--) { 
			
			cout << '*'; 
		}  cout << "\n";

	}
	
	cout << "\n";

}