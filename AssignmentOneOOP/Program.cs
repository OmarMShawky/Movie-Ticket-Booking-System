namespace AssignmentOneOOP
{
    internal class Program
    {
        static void Main()
        {
            const double taxPercent = 14;

            Console.WriteLine("Enter Movie Name");
            var movieName = Console.ReadLine();

            Console.WriteLine("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX )");
            TicketType type = (TicketType)int.Parse(Console.ReadLine());
            

            Console.WriteLine("Enter Seat Row (A, B, C...):");
            var row = Char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Seat Number");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Amount: ");
            double discount = double.Parse(Console.ReadLine());

            Seat seatLocation = new Seat(row, number);

            Ticket ticket = new Ticket(movieName, type, seatLocation, price);


            Console.WriteLine("============ Ticket Info ============");

            ticket.PrintTicket(taxPercent);

            double discountBefore = discount;
            ticket.ApplyDiscount(ref discount);

            Console.WriteLine();
            Console.WriteLine("//============ After Discount ============");
            Console.WriteLine($"Discount Before : {discountBefore:F2}");
            Console.WriteLine($"Discount After  : {discount:F2}");
            ticket.PrintTicket();
        }
    }
}
