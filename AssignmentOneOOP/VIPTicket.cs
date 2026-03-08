using MovieTicketBooking;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketBooking;

class VIPTicket : Ticket
{
    public bool LoungeAccess { get; set; }
    public decimal ServiceFee { get; private set; } = 50;

    public VIPTicket(string movieName, decimal price, bool loungeAccess)
        : base(movieName, price)
    {
        LoungeAccess = loungeAccess;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP";
    }
}
