#pragma once
#include <iostream>
#include<string>
#include<vector>
#include<fstream>
using namespace std;
namespace MyFileLib {
	void LoadFromFileToVector(string FileName, vector <string>& VfileContent) {
		fstream MyFile;
		MyFile.open(FileName, ios::in);
		if (MyFile.is_open())
		{
			string line;
			while (getline(MyFile, line)) {



				VfileContent.push_back(line);


			}
			MyFile.close();
		}

	}
	void SaveVectorToFile(string FileName, vector <string>& VfileContent) {
		fstream	MyFile;
		MyFile.open(FileName, ios::out);
		if (MyFile.is_open())
		{
			for (string& line : VfileContent) {
				if (line != "")
				{
					MyFile << line << endl;
				}
			}
			MyFile.close();
		}
	}
	void DeleteContentFromTheFile(string FileName, string record) {
		vector <string> vFileContent;
		LoadFromFileToVector(FileName, vFileContent);
		for (string& line : vFileContent) {
			if (line == record)
			{
				line = "";
			}
		}
		SaveVectorToFile(FileName, vFileContent);




	}
	void PrintFileContent(string FileName) {
		fstream MyFile;
		MyFile.open(FileName, ios::in);
		if (MyFile.is_open())
		{
			string line;
			while (getline(MyFile, line))
			{
				cout << line << endl;

			}
			MyFile.close();
		}




	}

}
