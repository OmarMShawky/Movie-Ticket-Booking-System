using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTicketBooking;

internal class Projector
{
    public void Start() => Console.WriteLine("Projector started.");
    public void Stop() => Console.WriteLine("Projector stopped.");
}

internal class Ticket
{
    private string _movieName;
    public string MovieName
    {
        get
        {
           return _movieName;
        }
        set
        {
            if(!String.IsNullOrEmpty(value))
                _movieName = value;
        }
    }
    private double _price;
    public double Price
    {
        get
        {
            return _price;
        }
        set
        {
            if (value > 0)
                _price = value;

            Price = _price;
        }
    }
    public TicketType TicketType { get; set; }
    public Seat Seat { get; set; }

    public double PriceAfterTax => _price * 1.14;

    private static int _ticketCounter = 0;
    public static int TicketCounter => _ticketCounter;

    public int TicketId {  get; private set; }
    public Ticket(string movieName, TicketType type, Seat seat, double price)
    {
        _ticketCounter++;
        TicketId = _ticketCounter;
        MovieName = movieName;
        TicketType = type;
        Seat = seat;
        _price = price;
    }

    public Ticket(string movieName) : this(movieName, TicketType.Standard, new Seat(), 50)
    {

    }

    public override string ToString()
    {
        return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
    }

    public static int GetTotalTickets() => _ticketCounter;

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

    public int GetTotalTicketsSold() => TicketCounter;
}
