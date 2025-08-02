#include <iostream>
#include <iomanip>
using namespace std;
int main()
{
	short num=0;
	cout << "Enter The number of studants\n";
	cin >> num;

	float* ptr;
	ptr = new float[num];
	for (int i = 0; i < num; i++) {
		printf("Student Number %d\n", i + 1);
		cin >> *(ptr + i);

	}

	cout << "The Marks Of Studants\n";
	for (int i = 0; i < num; i++) {
		printf("\nThe Mark of Studant %d = %f\n", i + 1,  *(ptr + i));
		
			
	}
	delete [] ptr;
	return 0;
}

