using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOneOOP;

static class BookingHelper
{
    private static int _bookingCounter = 0;

    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
    {
        double total = numberOfTickets * pricePerTicket;

        if (numberOfTickets >= 5)
            return total * 0.90; // 10% discount

        return total;
    }
    public static string GenerateBookingReference()
    {
        _bookingCounter++;
        return $"BK-{_bookingCounter}";
    }
}
