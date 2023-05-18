using System;

namespace _08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            for (int i = 0; i < numberCount; i+=1)
            {
                int numberInput = int.Parse(Console.ReadLine());
                if (numberInput > maxNumber)
                {
                    maxNumber = numberInput;
                }
                if (numberInput < minNumber)
                {
                    minNumber = numberInput;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
