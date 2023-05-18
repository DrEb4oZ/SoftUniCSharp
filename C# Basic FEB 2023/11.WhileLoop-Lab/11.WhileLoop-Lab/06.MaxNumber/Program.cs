using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int maxNumber = int.MinValue;
            while (number != "Stop")
            {
                int currentNumber = int.Parse(number);
                if (maxNumber < currentNumber)
                {
                    maxNumber = currentNumber;
                }
                number = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
        }
    }
}
