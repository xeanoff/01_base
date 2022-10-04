using System;

namespace _04_base
{
    internal class Program
    {

        public static bool isInt(string s) { return int.TryParse(s, out int value); }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            string? num = Console.ReadLine();
            if (!isInt(num!))
                return;
            Console.WriteLine(Convert.ToInt64(Reverse(num!)));
        }
    }
}