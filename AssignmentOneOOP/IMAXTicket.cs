using MovieTicketBooking;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketBooking;

class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movieName, decimal price, bool is3D)
        : base(movieName, is3D ? price + 30 : price)  // price adjusted before passing to base
    {
        Is3D = is3D;
    }

    public override string ToString()
    {
        return base.ToString() + $" | IMAX 3D: {(Is3D ? "Yes" : "No")}";
    }
}
