#include <iostream>
using namespace std;

int ReadNumber() {
	int num;
	cout << "Enter A Number : \n";
	cin >> num;
	while (cin.fail())
	{
		cin.clear();
		cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
		cout << "Invalid Input\n";
		cin >> num;


	

	}

	return num;



}
int main()
{
	
	//ReadNumber();
	cout << "The result " << (19 | 25);//bitwas &// |

}

