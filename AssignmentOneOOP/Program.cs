namespace AssignmentOneOOP;

internal class Program
{
    static void Main()
    {
        Cinema cinema = new Cinema();

        Console.WriteLine("========== Ticket Booking ==========");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter data for Ticket {i + 1}:");

            Console.Write("Movie Name: ");
            string movieName = Console.ReadLine();

            Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
            TicketType type = (TicketType)int.Parse(Console.ReadLine());

            Console.Write("Seat Row (A-Z): ");
            char row = char.ToUpper(Console.ReadLine().Trim()[0]);

            Console.Write("Seat Number: ");
            int seatNumber = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            Ticket ticket = new Ticket(movieName, type, new Seat(row, seatNumber), price);
            cinema.AddTicket(ticket);
        }

        
        Console.WriteLine("\n========== All Tickets ==========");
        for (int i = 0; i < 3; i++)
        {
            Ticket t = cinema[i];
            Console.WriteLine($"Ticket #{t.TicketId} | {t.MovieName} | {t.TicketType} | Seat: {t.Seat.Row}-{t.Seat.Number} | Price: {t.Price} EGP | After Tax: {t.PriceAfterTax} EGP");
        }

        
        Console.WriteLine("\n========== Search by Movie ==========");
        Console.Write("Enter movie name to search: ");
        string searchName = Console.ReadLine();

        Ticket found = cinema.GetMovieByName(searchName);
        if (found != null)
            Console.WriteLine($"Found: Ticket #{found.TicketId} | {found.MovieName} | {found.TicketType} | Seat: {found.Seat.Row}-{found.Seat.Number} | Price: {found.Price} EGP");
        else
            Console.WriteLine("Ticket not found.");

        
        Console.WriteLine("\n========== Tickets Sold ==========");
        Console.WriteLine($"Total Tickets Sold: {Cinema.TotalTicketsSold()}");

        
        Console.WriteLine("\n========== Booking References ==========");
        Console.WriteLine(BookingHelper.GenerateBookingReference());
        Console.WriteLine(BookingHelper.GenerateBookingReference());

        
        Console.WriteLine("\n========== Group Discount ==========");
        double groupTotal = BookingHelper.CalcGroupDiscount(5, 80);
        Console.WriteLine($"Group of 5 tickets at 80 EGP each:");
        Console.WriteLine($"Total after 10% discount: {groupTotal} EGP");
    }
}