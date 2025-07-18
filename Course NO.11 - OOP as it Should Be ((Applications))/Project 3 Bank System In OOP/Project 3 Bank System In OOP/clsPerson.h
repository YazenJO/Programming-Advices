#pragma once
#include <iostream>
using namespace std;
class clsPerson
{
private:
	string _FirstName;
	string _LastName;
	string _email;
	string _phone;

public:
	clsPerson(string FirstName, string LastName, string email, string phone) {

		_FirstName = FirstName;
		_LastName = LastName;
		_email = email;
		_phone = phone;

	}
	void SetFirstName(string FirstName) {

		_FirstName = FirstName;

	}
	string GetFirstName() {
		return _FirstName;
	}
    __declspec(property(get = GetFirstName, put = SetFirstName))string FirstName;

    void SetLastName(const string& lastName) {
        _LastName = lastName;
    }
   
    // Getter for _LastName
    string GetLastName()  {
        return _LastName;
    }
    __declspec(property(get = GetLastName, put = SetLastName))string LastName;

    string FullName() {

        return (FirstName + " " + LastName);
    }
    // Setter for _email
    void SetEmail( string email) {
        _email = email;
    }

    // Getter for _email
    string GetEmail()  {
        return _email;
    }
    __declspec(property(get = GetEmail, put = SetEmail))string Email;
    // Setter for _phone
    void SetPhone(string phone) {
        _phone = phone;
    }

    // Getter for _phone
    string GetPhone() const {
        return _phone;
    }

    __declspec(property(get = GetPhone, put = SetPhone))string Phone;
};

