namespace _01.SignОfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumberSignOr0(number);
        }

        static void PrintNumberSignOr0(int numberCheck)
        {
            if (numberCheck > 0)
            {
                Console.WriteLine($"The number {numberCheck} is positive.");
            }
            else if (numberCheck < 0)
            {
                Console.WriteLine($"The number {numberCheck} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {numberCheck} is zero.");
            }
        }
    }
}