namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal gBP = decimal.Parse(Console.ReadLine());
            decimal uSD = gBP * 1.31m;

            Console.WriteLine($"{uSD:f3}");
        }
    }
}