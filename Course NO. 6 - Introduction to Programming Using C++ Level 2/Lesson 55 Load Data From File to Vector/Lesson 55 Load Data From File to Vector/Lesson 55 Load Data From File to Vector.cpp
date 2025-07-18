#include <iostream>
#include<vector>
#include<fstream>
#include<string>
using namespace std;

void LoadVectorToFile(string FileName, vector <string>& VFileContent) {
	fstream MyFile;
	MyFile.open(FileName, ios::in);
	if (MyFile.is_open())
	{
		string line;
		while (getline(MyFile,line))
		{
			VFileContent.push_back(line);
		}
		MyFile.close();
	}
}
int main()
{
	
	vector <string> VFileContent;
	LoadVectorToFile("MyFile.txt", VFileContent);

	
	
}

