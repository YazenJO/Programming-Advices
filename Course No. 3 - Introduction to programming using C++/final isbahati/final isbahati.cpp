#include <iostream>
using namespace std;
void MaximumMArk(short Arr1[5]) {
	short min = 100, max = 0;
	for (int i = 0; i <= 4; i++) {
		if (Arr1[i] < min) {
			min = Arr1[i];
		}
		else if (Arr1[i] > max) {

			max = Arr1[i];
		}


		}
	cout << "The Highest mark is " << max << endl;
	cout << "The lowest mark is " << min <<'\n' << endl;


	}
void ShowMainScreen() {
	cout << "     *******************************************************" << endl;
	cout << "     **                                                   **" << endl;
	cout << "     **              Isbagaji Man Programe                **" << endl;
	cout << "     *******************************************************" << endl;

}
void NumberOfPassedStudants(short Arr1[5],char Arr2[5]) {
	short p=0;
	for (int i = 0; i <= 4; i++) {
		if (Arr1[i] >= 50) {
			Arr2[i] = 'P';
			p++;
		}
		else {
			Arr2[i] = 'F';
		}
	
	}
	
	cout << "The Number of Passed Studant " << p << endl;


}
void studantMark(short Arr1[5]) {
	for (int i = 0; i <= 4; i++) {
		cout << "Enter the mark of marks for student " << "{" << i + 1 << "}" << endl;
		cin >> Arr1[i];
	  
	}
	
}
void AvrgCalculate(short Arr1[5]) {
	short sum = 0;
	int i = 0;
	for (; i <= 4; i++) {
		sum += Arr1[i];
	}
	
	cout <<"The avg is = " << sum / i<<"\n";
}
void PassORFailstudant(short Arr1[5], char Arr2[5]) {
	for (int i = 0; i <= 4; i++) {
		cout << "Studant Number " << '(' << i + 1 << ')' << "    " << "Mark : " << Arr1[i] << "     " << Arr2[i] << endl;




	 }


}
void AllInOne(short Arr1[5], char Arr2[5]) {
	ShowMainScreen();
	studantMark(Arr1);
	cout << '\n';
	AvrgCalculate(Arr1);
	NumberOfPassedStudants(Arr1, Arr2);
	MaximumMArk(Arr1);
	PassORFailstudant(Arr1, Arr2);



}
int main()
{
	short Arr1[5];
	char Arr2[5];
	AllInOne(Arr1,Arr2);
	cout<<system("color 4F");
}

