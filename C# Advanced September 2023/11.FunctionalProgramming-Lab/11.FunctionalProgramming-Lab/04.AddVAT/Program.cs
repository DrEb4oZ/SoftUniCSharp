namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            foreach (double price in prices)
            {
                Console.WriteLine($"{AddVAT(price):f2}");
            }
        }

        static double AddVAT(double price)
        {
            return price * 1.2;
        }
    }
}