using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOneOOP;

static class BookingHelper
{
    private static int _bookingCounter = 0;
    public static string GenerateBookingReference()
    {
        _bookingCounter++;
        return $"BK-{_bookingCounter}";
    }
}