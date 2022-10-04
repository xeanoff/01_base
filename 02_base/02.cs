class Ticket
{
    string ticket;
    public Ticket(string _ticket)
    {
        ticket = _ticket;
    }
    public bool Check() { return ticket.Length % 2 == 0 && int.TryParse(ticket, out int value); }
    public bool isLucky()
    {
        string _ = ticket.Substring(0, ticket.Length / 2);
        string __ = ticket.Substring(ticket.Length / 2, ticket.Length - ticket.Length / 2);

        int[] sum = { 0, 0 };

        foreach (char c in _)
        {
            sum[0] += Convert.ToInt16(c - '0');
        }
        foreach (char c in __)
            sum[1] += Convert.ToInt16(c.ToString());

        return sum[0] == sum[1];
    }
}

namespace _02_base
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string? _ticket = Console.ReadLine();

            Ticket ticket = new Ticket(_ticket!);

            if (!ticket.Check())
                return;

            Console.WriteLine($"is ticket lucky = {ticket.isLucky()}");

        }
    }
}