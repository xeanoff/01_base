namespace _03_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            while (a != b + 1)
            {
                for (int i = 1; i <= a; i++)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
                a++;
            }
        }
    }
}
