//#pragma once
//#include <iostream>
//#include "clsDate.h"
//#include <queue>
//#include <stack>
//using namespace std;
//class clsQueueLine
//{
//private:
//	
//	string _Prefix = "";
//	short _Min = 0;
//	short _ServedCliets = 0;
//	short _NumberOfTickets = 0;
//	short TotalClients = 0;
//public:
//	class Tikcet {
//	private:
//	
//	public:
//		string TikcetNumber = "";
//		short TotalTikcet = 0;
//		short ServeTime = 0;
//		short WaitingClients = 0;
//		string Date="";
//
//	};
//	queue <Tikcet> TikitsList;
//
//	clsQueueLine(string Prefix, short Min) {
//		
//		_Prefix = Prefix;
//		_Min = Min;
//	}
//	void PrintTicketInfo(Tikcet Tickit) {
//		cout << "\n\n\t\t\t\t\t_______________________________";
//		cout << "\n\n\t\t\t\t\t\t     " << Tickit.TikcetNumber<<"\n\n";
//		cout << "\t\t\t\t\t     "<< Tickit.Date;
//		cout << "\n\t\t\t\t\t     "<<"Waiting Clients = "<< Tickit.WaitingClients;
//		cout << "\n\t\t\t\t\t\t"<<"Serve Time In \n";
//	    cout << "\t\t\t\t\t\t" << Tickit.ServeTime << "  Minutes.";
//		cout << "\n\t\t\t\t\t_______________________________";
//
//
//
//
//	}
//
//	void IssueTicket() {
//		Tikcet Ticket;
//		_NumberOfTickets++;
//		TotalClients++;
//		Ticket.Date =clsDate::getCurrentTimeString() ;
//		Ticket.WaitingClients+= _NumberOfTickets;
//		Ticket.TikcetNumber = _Prefix + to_string(_NumberOfTickets);
//		Ticket.ServeTime = _ServedCliets +((Ticket.WaitingClients -1) * _Min);
//		TikitsList.push(Ticket);
//	}
//	void PrintInfo() {
//		cout << "\t\t\t\t\t_______________________________";
//		cout << "\n\n\t\t\t\t\t\t  " << "Queue Info";
//		cout << "\n\t\t\t\t\t_______________________________\n\n";
//		cout << "\t\t\t\t\tPerfix     = " << _Prefix;
//		cout << "\n\t\t\t\t\tToltal Tickets = " << TotalClients;
//		cout << "\n\t\t\t\t\tServed Clients =  " << _ServedCliets;
//		cout << "\n\t\t\t\t\tWating Clients =  " << _NumberOfTickets;
//		cout << "\n\t\t\t\t\t_______________________________\n\n";
//
//
//	}
//	void PrintTicketsLineRTL() {
//		queue< Tikcet> tempQueue = TikitsList;
//		cout << "\n\n\t\t\t  " << "TicketList:  ";
//		while (!tempQueue.empty()) {
//			cout << tempQueue.front().TikcetNumber << " -->  ";
//			tempQueue.pop();
//		}
//
//	}
//	void PrintTicketsLineLTR() {
//		queue< Tikcet> tempQueue = TikitsList;
//		stack< Tikcet> Reverse ;
//		cout << "\n\n\t\t\t  " << "TicketList:  ";
//		while (!tempQueue.empty()) {
//			Reverse.push(tempQueue.front());
//			tempQueue.pop();
//		}
//		while (!Reverse.empty()) {
//			cout << Reverse.top().TikcetNumber << " <--  ";
//			Reverse.pop();
//		}
//
//
//	}
//	void PrintAllTickets() {
//		queue< Tikcet> tempQueue = TikitsList;
//		cout << "\n\n\t\t\t\t\t\t" << "...Tickets... ";
//		while (!tempQueue.empty()) {
//			PrintTicketInfo(tempQueue.front());
//			tempQueue.pop();
//		}
//
//
//	}
//	void ServeNextClient() {
//		_ServedCliets++;
//		_NumberOfTickets--;
//		TikitsList.pop();
//	}
//};
//
#pragma once

#include <iostream>
#include "clsDate.h"
#include "queue"
#include "stack"

using namespace std;

class clsQueueLine
{

private:

    short _TotalTickets = 0;
    short _AverageServeTime = 0;
    string _Prefix = "";

    class clsTicket
    {
    private:

        short _Number = 0;
        string _Prefix;
        string _TicketTime;
        short _WaitingClients = 0;
        short _AverageServeTime = 0;
        short _ExpectedServeTime = 0;

    public:
        clsTicket(string Prefix, short Number, short WaitingClients, short AverageServeTime)
        {

            _Number = Number;
            _TicketTime = clsDate::GetSystemDateTimeString();
            _Prefix = Prefix;
            _WaitingClients = WaitingClients;
            _AverageServeTime = AverageServeTime;
        }

        string Prefix()
        {
            return _Prefix;

        }
        short Number()
        {
            return _Number;
        }

        string FullNumber()
        {
            return _Prefix + to_string(_Number);
        }

        string TicketTime()
        {
            return _TicketTime;
        }

        short WaitingClients()
        {
            return _WaitingClients;
        }

        short ExpectedServeTime()
        {
            return _AverageServeTime * _WaitingClients;
        }

        void Print()
        {
            cout << "\n\t\t\t  _______________________\n";
            cout << "\n\t\t\t\t    " << FullNumber();
            cout << "\n\n\t\t\t    " << _TicketTime;
            cout << "\n\t\t\t    Wating Clients = " << _WaitingClients;
            cout << "\n\t\t\t      Serve Time In";
            cout << "\n\t\t\t       " << ExpectedServeTime() << " Minutes.";
            cout << "\n\t\t\t  _______________________\n";


        }
    };

public:

    queue <clsTicket> QueueLine;

    clsQueueLine(string Prefix, short AverageServeTime)
    {
        _Prefix = Prefix;
        _TotalTickets = 0;
        _AverageServeTime = AverageServeTime;
    }



    void IssueTicket()
    {
        _TotalTickets++;
        clsTicket Ticket(_Prefix, _TotalTickets, WaitingClients(), _AverageServeTime);
        QueueLine.push(Ticket);

    }

    int WaitingClients()
    {
        return QueueLine.size();

    }


    string WhoIsNext()
    {
        if (QueueLine.empty())
            return "No Clients Left.";
        else
            return QueueLine.front().FullNumber();

    }

    bool ServeNextClient()
    {
        if (QueueLine.empty())
            return false;


        QueueLine.pop();

        return true;

    }

    short ServedClients()
    {
        return _TotalTickets - WaitingClients();
    }

    void PrintInfo()
    {
        cout << "\n\t\t\t _________________________\n";
        cout << "\n\t\t\t\tQueue Info";
        cout << "\n\t\t\t _________________________\n";
        cout << "\n\t\t\t    Prefix   = " << _Prefix;
        cout << "\n\t\t\t    Total Tickets   = " << _TotalTickets;
        cout << "\n\t\t\t    Served Clients  = " << ServedClients();
        cout << "\n\t\t\t    Wating Clients  = " << WaitingClients(); ;
        cout << "\n\t\t\t _________________________\n";
        cout << "\n";

    }

    void PrintTicketsLineRTL()
    {

        if (QueueLine.empty())
            cout << "\n\t\tTickets: No Tickets.";
        else
            cout << "\n\t\tTickets: ";

        //we copy the queue in order not to lose the original
        queue <clsTicket> TempQueueLine = QueueLine;


        while (!TempQueueLine.empty())
        {
            clsTicket Ticket = TempQueueLine.front();

            cout << " " << Ticket.FullNumber() << " <-- ";

            TempQueueLine.pop();
        }

        cout << "\n";

    }

    void PrintTicketsLineLTR()
    {
        if (QueueLine.empty())
            cout << "\n\t\tTickets: No Tickets.";
        else
            cout << "\n\t\tTickets: ";

        //we copy the queue in order not to lose the original
        queue <clsTicket> TempQueueLine = QueueLine;
        stack <clsTicket> TempStackLine;

        while (!TempQueueLine.empty())
        {
            TempStackLine.push(TempQueueLine.front());
            TempQueueLine.pop();
        }

        while (!TempStackLine.empty())
        {
            clsTicket Ticket = TempStackLine.top();

            cout << " " << Ticket.FullNumber() << " --> ";

            TempStackLine.pop();
        }
        cout << "\n";
    }


    void PrintAllTickets()
    {

        cout << "\n\n\t\t\t       ---Tickets---";

        if (QueueLine.empty())
            cout << "\n\n\t\t\t     ---No Tickets---\n";

        //we copy the queue in order not to lose the original
        queue <clsTicket> TempQueueLine = QueueLine;


        while (!TempQueueLine.empty())
        {
            TempQueueLine.front().Print();
            TempQueueLine.pop();
        }

    }


};

