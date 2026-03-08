using MovieTicketBooking;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaTicketBooking;

class StandardTicket : Ticket
{
    public string SeatNumber { get; set; }

    public StandardTicket(string movieName, decimal price, string seatNumber)
        : base(movieName, price)
    {
        SeatNumber = seatNumber;
    }

    public override string ToString()
    {
        return base.ToString() + $" | Seat: {SeatNumber}";
    }
}
