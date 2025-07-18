#include <iostream>
#include<string>
using namespace std;

struct counts {
	short PlayerWons = 0;
	short ComputerWons = 0;
	short DrawTimes = 0;


};
enum Types{ Stone=1,  Paper=2,  Scissors=3 };
int ReadAPositiveNumber(string Massage) {
	int num;
	do {
		cout << Massage << "\n";
		cin >> num;

	} while (num < 0);
	return num;
}
int RandomNumbers(int From, int To) {
	int randNum = rand() % (To - From + 1) + From;


	return randNum;

}
Types ComputerChoice() {

	int ComputerChoice= RandomNumbers(1, 3);

	return Types(ComputerChoice);
	
}
string enumTranslater(Types Choices) {
	switch (Choices)
	{
	case Stone:
		return "Stone";
		break;
	case Paper:
		return "Paper";
		break;
	case Scissors:
		return "Scissors";
		break;
	
	}
}
void WinnerAfterRounds(counts count) {

	if (count.PlayerWons > count.ComputerWons) {
		cout << "[ Player ]";
	}
	else if (count.PlayerWons < count.ComputerWons) {

		cout << "[ Computer ]";

	}
	else {
		cout << " [ No Winner ]";


	}
	cout << "\n_____________________________________________\n";
}
void WinnerAftereachRound(char winnir) {

	if (winnir=='P') {
		cout << "[ Player ]";
	}
	else if (winnir == 'C') {

		cout << "[ Computer ]";

	}
	else {
		cout << " [ No Winner ]";


	}
	
}
void AfterEachRoundMenu(int i, Types MyChoice, Types ComputerChoise,counts count,char sympol) {

	cout << "\n_____________ Round [" << i << "]___________\n";

	cout << "\nPlayer 1 Choise :" << enumTranslater(MyChoice);
	cout << "\n\nComputerChoise:" << enumTranslater(ComputerChoise);
	cout << "\n\nRound Winner  :";
	WinnerAftereachRound(sympol);
	cout << "\n_____________________________________________\n";
}
void StartGame(int NumberOfRounds, counts &Counttype) {
	int MyChoise;
	char WinnerSympol;
	Types UserChoice;
	Types Computer; 
	for (int i = 1; i <= NumberOfRounds; i++)
	{
		
		cout << "Round [" << i << "] begins:\n";
		MyChoise = ReadAPositiveNumber("Your Choice : [1] : Stone, [2] : Paper, [3] : Scissors ? ");
		Computer= ComputerChoice();
		UserChoice = Types(MyChoise);
		if (MyChoise == Types::Stone && Computer == Types::Paper) {
			system("color 4F");
			cout << "\a";
			WinnerSympol = 'C';
			Counttype.ComputerWons++;
			AfterEachRoundMenu(i, UserChoice, Computer, Counttype, WinnerSympol);
		}
		else if (MyChoise == Types::Stone && Computer == Types::Scissors) {

			system("color 2F");//won
			WinnerSympol = 'P';
			Counttype.PlayerWons++;
			AfterEachRoundMenu(i, UserChoice, Computer, Counttype, WinnerSympol);

		}
		else if (MyChoise == Types::Paper && Computer == Types::Stone) {

			system("color 2F");//won
			WinnerSympol = 'P';
			Counttype.PlayerWons++;
			AfterEachRoundMenu(i, UserChoice, Computer, Counttype, WinnerSympol);

		}
		else if (MyChoise == Types::Paper && Computer == Types::Scissors) {
			system("color 4F");
			cout << "\a";
			WinnerSympol = 'C';
			Counttype.ComputerWons++;
			AfterEachRoundMenu(i, UserChoice, Computer, Counttype, WinnerSympol);

		}
		else if (MyChoise == Types::Scissors && Computer == Types::Stone) {
			system("color 4F");
			cout << "\a";
			WinnerSympol = 'C';
			Counttype.ComputerWons++;
			AfterEachRoundMenu(i, UserChoice, Computer, Counttype, WinnerSympol);

		}
		else if (MyChoise == Types::Scissors && Computer == Types::Paper) {


			system("color 2F");//won
			WinnerSympol = 'P';

			Counttype.PlayerWons++;
			AfterEachRoundMenu(i, UserChoice, Computer, Counttype, WinnerSympol);
		}
		else if (MyChoise == Computer) {

			system("color 6F");
			WinnerSympol = 'N';
			Counttype.DrawTimes++;
			AfterEachRoundMenu(i, UserChoice, Computer, Counttype, WinnerSympol);


		}
	}






}
void GameOverMenu(int NumberOfRounds, counts count) {
	
	cout << "\n\n";
		cout << "\t\t__________________________________________________\n\n";
		cout << "\t\t\t     +++ G a m e  O v e r +++\n";
		cout << "\t\t__________________________________________________\n\n";
		cout << "\t\t_________________[ Game Results ]_________________\n";

		cout << "\t\tGame Rounds\t: " << NumberOfRounds <<"\n";
		cout << "\t\tPlayer won times   : " << count.PlayerWons<<"\n";
		cout << "\t\tComputer won times   : " << count.ComputerWons <<"\n";
		cout << "\t\tDraw times\t : " << count.DrawTimes <<"\n";
		cout << "\t\tFinal Winner  : ";
		WinnerAfterRounds(count);
}
void WantToPlayAgain();

int main()
{
	srand((unsigned)time(NULL));

	counts Cnt;
	int NumberOfRounds = ReadAPositiveNumber("How Many Round u want ?");
	StartGame( NumberOfRounds, Cnt);
	GameOverMenu(NumberOfRounds, Cnt);
	WantToPlayAgain();
	return 0;
}
void WantToPlayAgain()
{
	char PlayAgainChoice;
	cout << "Do u want To Play Again Y/N ?";
	cin >> PlayAgainChoice;
	switch (PlayAgainChoice)
	{
	case 'Y':
		system("color 0F");
		main();
		
		break;
	case'y':
		system("color 0F");
			main();
			
			break;
	default:
		break;
	}

} 
