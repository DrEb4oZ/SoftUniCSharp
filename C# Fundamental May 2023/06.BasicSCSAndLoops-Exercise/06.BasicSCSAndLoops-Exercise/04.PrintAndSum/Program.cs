namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int finalNumber = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = startNumber; i <= finalNumber; i++)
            {
                Console.Write($"{i} ");
                totalSum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}