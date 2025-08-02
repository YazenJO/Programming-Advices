#include <iostream>
#include <vector>
#include "clsInputValidate.h"
#include "clsBankClient.h"
#include <iomanip>
#include "clsUtil.h"
#include "clsMainScreen.h"
#include "clsLoginScreen.h"
using namespace std;


int main()
{
	
	
	
	while (true)
	{
		if (!clsLoginScreen::LoginScreen())
		{
			break;
		}
		

	}
	system("pause>0");
	return 0;

} 
