using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOneOOP;

class Cinema
{
    private Ticket[] _tickets = new Ticket[20];

    // a. Index-based get/set
    public Ticket this[int index]
    {
        get
        {
            if (index < 0 || index >= _tickets.Length)
                return null;
            return _tickets[index];
        }
        set
        {
            if (index < 0 || index >= _tickets.Length)
                return;
            _tickets[index] = value;
        }
    }

    // b. Get ticket by movie name
    public Ticket GetMovieByName(string movieName)
    {
        foreach (Ticket ticket in _tickets)
        {
            if (ticket != null && ticket.MovieName == movieName)
                return ticket;
        }
        return null;
    }

    // c. Add ticket to first available slot
    public bool AddTicket(Ticket t)
    {
        for (int i = 0; i < _tickets.Length; i++)
        {
            if (_tickets[i] == null)
            {
                _tickets[i] = t;
                return true;
            }
        }
        return false;
    }
    public static int TotalTicketsSold()
    {
        return Ticket.TicketCounter; // reads the static counter from Ticket class
    }
}
