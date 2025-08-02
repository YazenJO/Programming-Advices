#include <iostream>
using namespace std;
enum enQuestionsLevels {easy = 1,mid=2,hard=3,mix=4};
enum enTheOperation{Add=1,Sub=2,Mul=3,Div=4,Mix=5};
int WinCounter = 0;
int LossCounter = 0;
short Awnser = 1;
struct GameRules {
	short Num1 = 0;
	short Num2 = 0;
	char Opreation = 'c';
	int Awnser = 0;
	short PlayerAwnser;
	short NumberOfRound=0;
	short CoounterOfCorrect = 0;
	short CounterOfFails = 0;


};
short ReadAPositiveNumber(string Massage) {
	short num;
	do {
		cout << Massage << "\n";
		cin >> num;

	} while (num < 0);
	return num;
}
enQuestionsLevels GameQuestionLevel(short Number) {
	enQuestionsLevels level;
	level = enQuestionsLevels(Number);
	return level;

}
void ReadGameLevel(enQuestionsLevels& level) {

	level = GameQuestionLevel(ReadAPositiveNumber("Enter The Questions Level [1] Easy ,[2] Mid ,[3] Hard,[4] Mix ?"));


}
enTheOperation GameOperation(short Number) {

	enTheOperation Operation;
	Operation = enTheOperation(Number);
	return Operation;





}
void ReadGameOpration(enTheOperation &Opreation) {

	Opreation = GameOperation(ReadAPositiveNumber("Enter The Operation [1] Add ,[2] Sub ,[3] Mul ,[4] Div,[5] Mix ? "));


}
int RandomNumbers(int From, int To) {
	int randNum = rand() % (To - From + 1) + From;


	return randNum;

}
enQuestionsLevels MixLevelCase(enQuestionsLevels &level) {
	level = enQuestionsLevels(RandomNumbers(1, 3));
	return level;


}
int GetRandomNumberForEachLevel(enQuestionsLevels level) {
	if (level== enQuestionsLevels::mix)
	{
		MixLevelCase(level);
	}
		switch (level)
		{
		case easy:
			return RandomNumbers(1, 10);
			break;
		case mid:
			return RandomNumbers(10, 50);
			break;
		case hard:
			return RandomNumbers(50, 99);
			break;
		default:
			break;
		}

	




}
enTheOperation MixOpreationCase(enTheOperation& level) {
	level = enTheOperation(RandomNumbers(1, 4));
	return level;




}
char GetGameOprationforEachLevel(enTheOperation& Opreation) {
	if (Opreation == enTheOperation::Mix)
	{
		MixOpreationCase(Opreation);
	}
	switch (Opreation)
	{
	case Add:
		return '+';
		break;
	case Sub:
		return '-';
		break;
	case Mul:
		return '*';
		break;
	case Div:
		return '/';
		break;

	default:
		break;
	}



}
void BuildGameQustions(enQuestionsLevels level, enTheOperation Opreation, GameRules &game) {
	
	game.Num1 = GetRandomNumberForEachLevel(level);
	
	game.Num2= GetRandomNumberForEachLevel(level);
	game.Opreation = GetGameOprationforEachLevel(Opreation);
	

	

}
void QuestionsAnswer(GameRules &game) {
	switch (game.Opreation)
	{
	case '+':
		game.Awnser = game.Num1 + game.Num2;
		break;
	case '-':
		game.Awnser = game.Num1 - game.Num2;
		break;
	case '*':
		game.Awnser = game.Num1 * game.Num2;
		break;
	case '/':
		game.Awnser = game.Num1 / game.Num2;
		break;
	default:
		break;
	}



}
void QuestionsAnswerToGlobalV(GameRules& game,short &Awnser) {
	switch (game.Opreation)
	{
	case '+':
		Awnser = game.Num1 + game.Num2;
		break;
	case '-':
		Awnser = game.Num1 - game.Num2;
		break;
	case '*':
		Awnser = game.Num1 * game.Num2;
		break;
	case '/':
		Awnser = game.Num1 / game.Num2;
		break;
	default:
		break;
	}



}
void PrintGameQuestions(GameRules &game) {
	
	cout << game.Num1 << '\n';
	cout <<"\t" << game.Opreation << '\n';
	cout << game.Num2 << '\n';
	




}
bool CheckPlayerAwnser(GameRules game) {
	QuestionsAnswer( game);
	return (game.PlayerAwnser == game.Awnser);
	

}
void PrintPlayerAwnserResult(bool Check, GameRules &game) {
	
	if (Check) {
		system("color 2F");
		cout << "Correct Answer :)\n";
		WinCounter++;
	}
	else
	{
		system("color 4F");
		cout << "Wrong Awnser :(\n";
		QuestionsAnswerToGlobalV(game, Awnser);
		cout << "The Correct Awnser Is : " << Awnser<<"\n";
		LossCounter++;
	}




}
void RepeatGame() {
	system("cls");
	system("color 0F");


}
char DoUWantToPlayAgain(char &WantToplayAgain){
	cout << "\n Do u Want To Play Again (Y/N) ?";
	cin >> WantToplayAgain;
	return WantToplayAgain;
}
void Tabs(short Number) {
	for (int i = 1; i <= Number; i++) {
		cout << '\t';
	}
}
void CheckFinalResult(GameRules game) {
	if (WinCounter > LossCounter)
	{
		system("color 2F");
		cout << "------------------------------\n";
		cout << "Final Result is Pass :) \n";
		cout << "------------------------------\n";
	}
	else
	{
		system("color 4F");
		cout << "------------------------------\n";
		cout << "Final Result is Fail :( \n";
		cout << "------------------------------\n";
	}


}
string PrintLevel(enQuestionsLevels level) {
	if (level == 1)
		return "Easy";
	else if (level == 2)
		return "Mid";
	else if (level == 3)
		return "Hard";
 else if (level == 4)
		return "Mix";

}
string PrintQuestionType(enTheOperation Opreation) {
	if (Opreation == 1)
		return "Add";
	else if (Opreation == 2)
		return "Sub";
	else if (Opreation == 3)
		return "Mul";
	else if (Opreation == 4)
		return "Div";
	else if (Opreation == 5)
		return "Mix";

}
void PrintTheFinalResults(GameRules game, enQuestionsLevels level, enTheOperation Opreation) {
	
	CheckFinalResult(game);
	cout << endl << "Number of questoin is     : " <<game.NumberOfRound<< endl;
	cout << "Questoin level            : " << PrintLevel(level) << endl;
	cout << "Questoin Type             : " << PrintQuestionType(Opreation) << endl;
	cout << "Number Of Right Answers   :" << WinCounter << endl;
	cout << "Number Of Wrong Answers   :" << LossCounter << endl;
	cout << "_____________________________________" << endl << endl;



};
void startgame(short NumberOfRounds, enQuestionsLevels level, enTheOperation &Opreation) {
	
	GameRules game;
	for (int Round = 1; Round <= NumberOfRounds; Round++)
	{

		cout << "Question [" << Round << "/" << NumberOfRounds << "]\n";
		BuildGameQustions(level, Opreation,game);
		PrintGameQuestions(game);
		cout << "___________________\n";
		game.PlayerAwnser = ReadAPositiveNumber(" ");

		PrintPlayerAwnserResult(CheckPlayerAwnser(game), game);
		
	}
	
}
void PlayGame() {
	GameRules game;
	char WantToPlayAgain = 'Y';
	enQuestionsLevels level;
	enTheOperation Opreation;
	do{
		
		RepeatGame();
		
		game.NumberOfRound = ReadAPositiveNumber("Enter The Number Of Rounds ");
		ReadGameLevel(level);
		ReadGameOpration(Opreation);
		startgame(game.NumberOfRound, level, Opreation);
		PrintTheFinalResults(game, level, Opreation);
		DoUWantToPlayAgain(WantToPlayAgain);


	} while (WantToPlayAgain=='Y'||WantToPlayAgain=='y');






}

int main()
{
	srand((unsigned)time(NULL));
	GameRules game;
	
	PlayGame();
	
}
