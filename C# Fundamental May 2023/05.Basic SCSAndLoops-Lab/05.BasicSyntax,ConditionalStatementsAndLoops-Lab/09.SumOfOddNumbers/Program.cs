namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOddNumbers = 0;
            int currentNumber = 1;

            for (int i = 1; i <= n; i++)
            {
                if (currentNumber % 2 != 0)
                {
                    Console.WriteLine(currentNumber);
                    sumOddNumbers += currentNumber;
                }
                currentNumber += 2;
            }
            Console.WriteLine($"Sum: {sumOddNumbers}");
        }
    }
}