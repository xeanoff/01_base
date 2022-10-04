namespace _01_base
{
    internal class Program
    {
        static void Main()
        {
            int spaces = 0;
            string? line;

            do
            {
                line = Console.ReadLine();
                foreach (char c in line!)
                {
                    if (c == ' ')
                        spaces++;
                }
            } while (line != ".");
            Console.WriteLine($"end! spaces = {spaces}");
        }
    }
}
