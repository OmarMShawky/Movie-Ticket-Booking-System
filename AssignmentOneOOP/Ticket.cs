using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOneOOP;

internal class Ticket
{
    public string MovieName;
    public TicketType TicketType;
    public Seat Seat;
    private double _price;

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
        return _price;
    }

    public void PrintTicket(double taxPercent)
    {
        Console.WriteLine($"Movie Name          : {MovieName}");
        Console.WriteLine($"TicketType          : {TicketType}");
        Console.WriteLine($"Seat                : {Seat}");
        Console.WriteLine($"Price               : {_price}");
        Console.WriteLine($"Total ({taxPercent}% tax   : {CalcTotal(taxPercent)}");
    }

    public void PrintTicketBasic()
    {
        Console.WriteLine($"Movie : {MovieName}");
        Console.WriteLine($"Type  : {TicketType}");
        Console.WriteLine($"Seat  : {Seat}");
        Console.WriteLine($"Price : {_price:F2}");
    }
}
