using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOneOOP;

internal class Ticket
{
    private string _movieName;
    private double _price;
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
    public TicketType TicketType { get; set; }
    public Seat Seat { get; set; }
    //Price : must be greater than 0. If an invalid value is set, keep the previous value
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

    public double PriceAfterTax => _price * 1.14;

    private static int _ticketCounter = 0;
    public static int TicketCounter => _ticketCounter;

    //Add a ‘TicketId’ property. Each ticket gets a unique ID automatically when created
    //(increment `ticketCounter` in the constructor and assign it to the ID).
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
