#pragma once
#include<iostream>
#include<cmath>
using namespace std;


 namespace test{
	 void PrintATwoDArray(int arr[10][10]) {
		 for (int i = 0; i < 10; i++) {

			 for (int j = 0; j < 10; j++) {

				 printf("%0*d ", 2, arr[i][j]);
				// cout << arr[i][j] << " ";


			 }
			 cout << "\n";


		 }






	 }




}