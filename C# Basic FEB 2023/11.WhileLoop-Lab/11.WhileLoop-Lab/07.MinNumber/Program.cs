using System;

namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int minNumber = int.MaxValue;
            while (number != "Stop")
            {
                int currentNumber = int.Parse(number);
                if (minNumber > currentNumber)
                {
                    minNumber = currentNumber;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
