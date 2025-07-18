#include <iostream>
using namespace std;
int main() {
	const int Option_One = 1 << 0; // 1
	const int Option_Two = 1 << 1; // 2
	const int Option_Three = 1 << 2; // 4
	const int Option_Four = 1 << 3; // 8
	const int Option_Five = 1 << 4; // 16
	const int Option_Six = 1 << 5; // 32
	const int Option_Seven = 1 << 6; // 64

	int primsstions = 0;
	primsstions |= Option_One;
	primsstions |= Option_Five;
	primsstions |= Option_Six;
	cout << (primsstions& Option_Five);
    
}
