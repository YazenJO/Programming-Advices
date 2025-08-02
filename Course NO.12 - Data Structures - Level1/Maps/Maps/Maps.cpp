#include <iostream>
#include<map>
using namespace std;

int main()
{
	map <string, int >Studants;
	Studants["Ahmed"] = 95;
	Studants["Tareq"] = 99;
	Studants["Khalid"] = 85;

	for (const auto &S: Studants)
	{
		cout << S.first << "  " << S.second << endl;
	}
	string StudantName = "Tareq";
	if (Studants.find(StudantName)!=Studants.end())
	{
		cout << StudantName << "'s grade : " << Studants[StudantName]<<"\n";
	}
}

