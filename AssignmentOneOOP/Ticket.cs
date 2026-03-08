using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOneOOP;

internal class Ticket
{
    public string MovieName { get; set; }     
    public TicketType TicketType { get; set; }
    public Seat Seat { get; set; }
    private double _price { get; set; }

    public Ticket(string movieName, TicketType type, Seat seat, double price)
    {
        MovieName = movieName;
        TicketType = type;
        Seat = seat;
        _price = price;
    }

    public Ticket(string movieName) : this(movieName, TicketType.Standard, new Seat(), 50)
    {

    }

    public double CalcTotal(double taxPercent)
    {
        return _price + (_price * taxPercent / 100);
    }
    public double ApplyDiscount(ref double discount)
    {
        if (discount > 0 && discount <= _price)
        {
            _price -= discount;
            discount = 0;
        }
    }

    public void PrintTicket(double taxPercent)
    {
        Console.WriteLine($"Movie Name          : {MovieName}");
        Console.WriteLine($"TicketType          : {TicketType}");
        Console.WriteLine($"Seat                : {Seat}");
        Console.WriteLine($"Price               : {_price}");
        Console.WriteLine($"Total ({taxPercent}% tax   : {CalcTotal(taxPercent)}");
    }

    public void PrintTicket()
    {
        Console.WriteLine($"Discount Before     : {MovieName}");
        Console.WriteLine($"Discount After      : {MovieName}");
        Console.WriteLine($"Movie Name          : {MovieName}");
        Console.WriteLine($"TicketType          : {TicketType}");
    }
}
