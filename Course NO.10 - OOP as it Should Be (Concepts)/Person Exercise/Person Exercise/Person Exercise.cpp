#include <iostream>
using namespace std;

class clsPerson {
private:
	int _ID;
	string _FirstName;
	string _LastName;
	string _email;
	string _PhoneNumber;
	string _SubjectOfMail;
	string _BodyOFMail;
	string _SMSMasage;
public:
	clsPerson(int ID, string FirstName, string LastName, string email, string PhoneNumber) {
		_ID=ID ;
		_FirstName=FirstName ;
		_LastName=LastName  ;
		_email=email  ;
		_PhoneNumber=PhoneNumber ;
	}

	int ID() { return _ID; };
	string FirstName() { return _FirstName; };
	string LastName() { return _LastName; }
	string email() { return _email; }
	string PhoneNumber() { return _PhoneNumber; }
	void SendEmail(string Subject, string Body) {
		cout << "\n\nThe Following Massage sent sucessfully to email :" << _email;
		cout << "\nSubject: " << Subject;
		cout << "\nBody: " << Body;
		Subject = _SubjectOfMail;
		Body = _BodyOFMail;


	}
	void SetID(int ID) {
		_ID = ID;
	}
	void setFirstName(string firstName) {
		_FirstName = firstName;
	}
	void setLastName(string lastName) {
		_LastName = lastName;
	}
	void setEmail(string email) {
		_email = email;
	}
	void setPhoneNumber(string phoneNumber) {
		_PhoneNumber = phoneNumber;
	}
	string FullName() {
		return( _FirstName + " " + _LastName);
	}
	void Print() {
		cout << "\nInfo: \n";
		cout << "\n-------------------\n";
		cout << "ID       :" << _ID;
		cout << "\nFirstName:" << FirstName();
		cout << "\nLastName :"<< LastName();
		
		cout << "\nFullName :"<< FullName();
		
		cout << "\nEmail    :" << email();
		cout << "\nPhone    :" << PhoneNumber();
		cout << "\n-------------------\n";
	
	
	
	}
	void SendSMS(string Massage) {
		cout << "\n\nThe Following SMS sent sucessfully to Phone :" << PhoneNumber();
		cout << "\n" << Massage;


	}
};

int main()
{
	clsPerson Person1(10, "Mohammed", "Abu_Hadhoud", "bilalabusharkh5@gmail.com", "0775855509");
	Person1.Print();

	Person1.SendEmail("Hi","How are you ?");
	Person1.SendSMS("How are your ?");

	system("pause>0");
	return 0;

}

