
#include <iostream>
#include <string>
using namespace std;


short GetNearestGasStation( int Positoins[] , int CarPosition , int size) {

    int MinimumDistance = CarPosition - Positoins[0];
    int temp = 0;
    int position = 0;
    for (int i = 0; i < size; i++) {

        temp = CarPosition - Positoins[i];
        if (temp < MinimumDistance && temp >=0) {
            position = i;
            MinimumDistance = temp;
        }

    }


    return MinimumDistance;

}



int main()
{
    int Locations[] = { 10 , 20 , 30 , 40 , 50 , 60 };

    cout << GetNearestGasStation(Locations, 35 , 6) << endl;

    return 0;
}

