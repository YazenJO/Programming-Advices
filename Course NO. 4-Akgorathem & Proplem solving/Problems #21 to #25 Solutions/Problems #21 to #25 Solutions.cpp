#include <iostream>
using namespace std;
const float Pi = 3.14159265359;


//proplem 21 

//float ReadNumbers(float Num[1]) {
//	 
//    cout << "Ener d\n";
//		int i = 0;
//		for (; i < 1; i++) {
//	
//			cin >> Num[i];
//		}
//	
//		return Num[i];
//			 }
//	float AreaOfrectange(float Num[1]) {
//			    float area;
//				area = ((pow(Num[0], 2) / (4 * Pi)));
//			    return area;
//			}
//	int main() {
//	    float Num[2];
//		ReadNumbers(Num);
//		cout << AreaOfrectange(Num);
//	   
//	    return 0;
//	}

//proplem 25 

float  ReadNumbers() {
	float Num;

	cin >> Num;

	return Num;
}
void ReadUntilageBetween(float Num) {

	while (Num <= 18 || Num >= 45)
		Num = ReadNumbers();
	



}
int main() {


	ReadUntilageBetween(ReadNumbers());

}

	

