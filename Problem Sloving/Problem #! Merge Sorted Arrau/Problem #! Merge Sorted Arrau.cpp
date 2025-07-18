#include <iostream>
#include <vector>
using namespace std;


void merge(vector<int>& nums1, int m, vector<int>& nums2, int n) {
	int counter = 0;
	for (int  i = m+1; i < nums1.size(); i++)
	{
		if (nums1[i]==0 && counter<=n)
		{
			nums1[i] = nums2[counter];
			counter++;
		}
		

	}
	

}
int main()
{
		
}

