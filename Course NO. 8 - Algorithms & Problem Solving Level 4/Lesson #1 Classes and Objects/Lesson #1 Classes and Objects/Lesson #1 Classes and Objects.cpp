#include <iostream>
using namespace std;
class clsPerson
{
public:
	string FirstName;
	string LastName;
	string FullName() {
		return FirstName + LastName;
	}

private:
	int x;

};

int main()
{
	clsPerson Person1;
	Person1.FirstName = "Yazen ";
	Person1.LastName = "Abu - Sharkh";
	cout << Person1.FullName();
	
}

