#include <iostream>
#include<vector>
#include<fstream>
#include<string>

using namespace std;
void SaveVectorToFile(string FileName, vector <string> &VFileContent) {
	fstream MyFile;

	MyFile.open(FileName, ios::out);


	

	if(MyFile.is_open())
	{
		
		for (string &line:VFileContent)
		{

		
			if (line !="")
			{
				MyFile << line << endl;
			}
				



		}
		MyFile.close();
	}


}
int main()
{
	vector <string> VFileContent{"Yazen","Tareq","Lama"};
	SaveVectorToFile("MyFile.txt", VFileContent);
}
