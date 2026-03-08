using CinemaTicketBooking;
using MovieTicketBooking;

namespace AssignmentOneOOP;

internal class Program
{
    static void Main()
    {
        Cinema cinema = new Cinema();
        cinema.OpenCinema();

        // b. Create one of each ticket type (hardcoded)
        StandardTicket t1 = new StandardTicket("Inception", 120m, "A-5");
        VIPTicket t2 = new VIPTicket("Avengers", 200m, true);
        IMAXTicket t3 = new IMAXTicket("Dune", 180m, false);

        cinema.AddTicket(t1);
        cinema.AddTicket(t2);
        cinema.AddTicket(t3);

        // c. Print all tickets
        Console.WriteLine();
        cinema.PrintAllTickets();

        // Statistics
        Console.WriteLine("\n========== Statistics ==========");
        Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");
        Console.WriteLine(BookingHelper.GenerateBookingReference());
        Console.WriteLine(BookingHelper.GenerateBookingReference());

        // d. Close Cinema
        Console.WriteLine();
        cinema.CloseCinema();
    }
}