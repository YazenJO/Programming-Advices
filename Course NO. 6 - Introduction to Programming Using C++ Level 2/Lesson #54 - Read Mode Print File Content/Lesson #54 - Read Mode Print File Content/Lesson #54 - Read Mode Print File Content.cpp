#include <iostream>
#include<fstream>
#include<string>
using namespace std;

void PrintFileContant(string FileName) {
	
	fstream MyFile;
	MyFile.open(FileName, ios::in);
		
		if (MyFile.is_open()) {
			string line;
			while (getline(MyFile,line))//Read The line And Store it IN the string "line"
			{
				cout << line<<'\n';
			}

			MyFile.close();



		}


}
int main()
{
	fstream MyFile;
	MyFile.open("MyFile.txt", ios::app);
	MyFile << "aaaaa\n";
	
	PrintFileContant("MyFile.txt");
}

