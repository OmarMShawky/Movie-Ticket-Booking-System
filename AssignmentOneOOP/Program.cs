namespace AssignmentOneOOP
{
    internal class Program
    {
        static void Main()
        {
            const double TAX_PERCENT = 14;

            // --- Read input ---
            Console.Write("Enter Movie Name: ");
            string movieName = Console.ReadLine();

            Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            TicketType type = (TicketType)int.Parse(Console.ReadLine());

            Console.Write("Enter Seat Row (A, B, C...): ");
            char row = char.ToUpper(Console.ReadLine().Trim()[0]);

            Console.Write("Enter Seat Number: ");
            int seatNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Amount: ");
            double discount = double.Parse(Console.ReadLine());

            // --- Build ticket ---
            Seat seat = new Seat(row, seatNumber);
            Ticket ticket = new Ticket(movieName, type, seat, price);

            // --- Print ticket info ---
            Console.WriteLine();
            Console.WriteLine("===== Ticket Info =====");
            ticket.PrintTicket(TAX_PERCENT);

            // --- Apply discount and print result ---
            double discountBefore = discount;
            ticket.ApplyDiscount(ref discount);

            Console.WriteLine();
            Console.WriteLine("===== After Discount =====");
            Console.WriteLine($"Discount Before : {discountBefore:F2}");
            Console.WriteLine($"Discount After  : {discount:F2}");
            ticket.PrintTicketBasic();
        }
    }
}
            //const double taxPercent = 14;

            //Console.WriteLine("Enter Movie Name");
            //var movieName = Console.ReadLine();

            //Console.WriteLine("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX )");
            //TicketType type = (TicketType)int.Parse(Console.ReadLine());
            

            //Console.WriteLine("Enter Seat Row (A, B, C...):");
            //var row = Char.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Seat Number");
            //var number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Price: ");
            //double price = double.Parse(Console.ReadLine());

            //Console.Write("Enter Discount Amount: ");
            //double discount = double.Parse(Console.ReadLine());

            //Seat seatLocation = new Seat(row, number);

            //Ticket ticket = new Ticket(movieName, type, seatLocation, price);

            //Console.WriteLine();
            //Console.WriteLine("============ Ticket Info ============");
            //ticket.PrintTicket(taxPercent);

            //double discountBefore = discount;
            //ticket.ApplyDiscount(ref discount);

            //Console.WriteLine();
            //Console.WriteLine("//============ After Discount ============");
            //Console.WriteLine($"Discount Before : {discountBefore:F2}");
            //Console.WriteLine($"Discount After  : {discount:F2}");
            //ticket.PrintTicketBasic();