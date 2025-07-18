#include <iostream>
#include <vector>
#include<string>
using namespace std;
struct stDate {
    short Year;
    short Month;
    short Day;
};
vector<string> SplitString(string S1, string Delim="/") {
	vector<string> vString;
	short pos = 0;
	string sWord = ""; // define a string variable  // use find() function to get the position of the delimiters  
	while ((pos = S1.find(Delim)) != std::string::npos) {
		sWord = S1.substr(0, pos); // store the word  
		if (sWord != "") {
			vString.push_back(sWord);
		} 
		S1.erase(0, pos + Delim.length());
	}
	if (S1 != "") {
		vString.push_back(S1); // it adds last word of the string. 
	}
	return vString;
}
string JoinString(vector <string> S1, string demin="/") {
	string Word = "";
	short VSize = S1.size();
	short countert = 0;
	for (string& sword : S1) {
		countert++;
		if (countert == VSize)

			Word += sword;

		else
			Word += sword + demin;
	}


	return Word;

}
stDate StringToDate(string S1) {
	vector<string>DateRecord= SplitString(S1);
	stDate Date;
	
	Date.Day = stoi(DateRecord[0]);
	Date.Month = stoi(DateRecord[1]);
	Date.Year = stoi(DateRecord[2]);


	return Date;
}
string DateToString(stDate Date) {
	vector <string> S1;
	S1.push_back(to_string(Date.Day)) ;
	S1.push_back(to_string(Date.Month));
	S1.push_back(to_string(Date.Year));
	return JoinString(S1);
}
int main()
{
	string DateInString;
	stDate Date;
	cout << "Enter Date dd/mm/yyyy? ";
	getline(cin, DateInString);
	Date=StringToDate(DateInString);
	cout << "\n\nDay:" << Date.Day;
	cout << "\nMonth:" << Date.Month;
	cout << "\nYear:" << Date.Year;

	cout << "\n\nYou Enterd: " << DateToString(Date);
}
