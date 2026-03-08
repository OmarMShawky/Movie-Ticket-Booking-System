using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOneOOP;

internal struct Seat
{
    public char Row;
    public int Number;

    public Seat()
    {
        Row = 'A';
        Number = 1;
    }
    public Seat(char row, int number)
    {
        Row = row;
        Number = number;
    }
    public override string ToString() => $"{Row}{Number}";
}
