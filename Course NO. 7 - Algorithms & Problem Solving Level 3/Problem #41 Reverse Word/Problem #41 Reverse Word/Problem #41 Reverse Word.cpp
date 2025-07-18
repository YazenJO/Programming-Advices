#include <iostream>
#include <vector>
#include <string>
using namespace std;
string  ReadString() {
	string S1;     
	cout << "Please Enter Your String?\n"; 
	getline(cin, S1); return S1;
}
vector <string> SplitString(string S1, string Delim) {
	vector<string> vString; short pos = 0; string sWord;// define a string variable  // use find() function to get the position of the delimiters 
	while ((pos = S1.find(Delim)) != std::string::npos)  
	{        
		sWord =S1.substr(0, pos); // store the word   
		if (sWord !="")        
		{           
			vString.push_back(sWord);   
		} 
		S1.erase(0, pos + Delim.length());/* erase() until positon and move to next word. */  
	} if (S1!="") 
	{       
		vString.push_back(S1); // it adds last word of the string. 
	} 
	return vString; 
} 
string ReverseString(string S1) {
	string ReverseWord = "";
	vector <string> StringWords = SplitString(S1, " ");
	
	for (int i = StringWords.size()-1; i >= 0; i--) {
		ReverseWord += (string)StringWords[i]+" ";
	
	}




	return ReverseWord;

}
string ReverseStringUsingIterator(string S1) {
	string S2 = "";
	vector <string> StringWords = SplitString(S1, " ");
	vector <string>::iterator it = StringWords.end();
	while (it != StringWords.begin())
	{
		--it;
		S2 += *it + " ";
		
	}



	return (S2.substr(0,S2.length()-1));

}
int main()
{
	string S1 = "Yazen Bilal";
	
	
	
	cout << S1 << endl;
	cout << ReverseStringUsingIterator(S1);
	

}

