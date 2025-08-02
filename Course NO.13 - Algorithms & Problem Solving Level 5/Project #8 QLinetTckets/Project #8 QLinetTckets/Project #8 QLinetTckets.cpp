#include <iostream>
#include "clsQueueLine.h"
using namespace std;
int main()
{
	clsQueueLine PayBillsQueue("A0", 10);
	PayBillsQueue.IssueTicket();
	PayBillsQueue.IssueTicket();
	PayBillsQueue.IssueTicket();
	PayBillsQueue.IssueTicket();
	PayBillsQueue.IssueTicket();

	PayBillsQueue.PrintInfo();

	PayBillsQueue.PrintTicketsLineRTL();
	PayBillsQueue.PrintTicketsLineLTR();
	
	PayBillsQueue.PrintAllTickets();
	PayBillsQueue.ServeNextClient();
	cout << "Subscriptions Queue Info :\n\n";
	PayBillsQueue.PrintInfo();

}
