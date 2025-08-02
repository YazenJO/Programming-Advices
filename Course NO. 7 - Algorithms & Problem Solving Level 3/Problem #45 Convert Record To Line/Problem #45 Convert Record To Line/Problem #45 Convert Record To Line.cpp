#include <iostream>
#include <string>
#include <vector>
using namespace std;
struct Info {
	string AccountNumber ;
	string PinCode;
	string Name;
	string PhoneNumber ;
	double AccountBalacne ;
	
};
Info ReadNEWClient() {
	Info Client;
	cout << "Enter Account Number? "; 
	getline(cin, Client.AccountNumber);
	cout << "Enter PinCode? ";   
	getline(cin, Client.PinCode);   
	cout << "Enter Name? ";    
	getline(cin, Client.Name);  
	cout << "Enter Phone? ";   
	getline(cin, Client.PhoneNumber);
	cout << "Enter AccountBalance? "; 
	cin >> Client.AccountBalacne;
	 return Client;
}
string ConvertRecordToLine(Info Client, string Seperator="#///#") {
	string Line;
	Line += Client.AccountNumber + Seperator;
	Line += Client.PinCode + Seperator;
	Line += Client.Name + Seperator;
	Line += Client.PhoneNumber + Seperator;
	Line +=  to_string(Client.AccountBalacne) + Seperator;


	return Line;



}

int main()
{
	Info Client;
	Client = ReadNEWClient();
	cout << ConvertRecordToLine(Client);
	
}
