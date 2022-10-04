namespace _05_base
{
    internal class Program
    {
        static string getFormatedText(int period)
        {
            return period <= 1 ? "month" : "months";
        }

        static float getDeposit(float deposit, int P)
        {
            return (deposit * P) / 100;
        }

        static bool Check(string? num)
        {
            if (int.TryParse(num, out int value))
                return Convert.ToInt16(num) > 0 && Convert.ToInt16(num) < 25;
            return false;
        }

        static void Main(string[] args)
        {
            float deposit = 10000;
            string? P = Console.ReadLine();

            if (!Check(P))
                return;

            int period = 0;
            while (deposit < 11000)
            {
                deposit += getDeposit(deposit, Convert.ToInt16(P));
                period++;
                Console.WriteLine(deposit);
            }

            Console.WriteLine($"Deposit = {deposit}; In {period} {getFormatedText(period)}");
        }
    }
}