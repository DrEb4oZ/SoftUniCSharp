using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sumPrime = 0, sumNonPrime = 0;

            while (number != "stop")
            {
                int currentNumber = int.Parse(number);
                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int countControlNumber = 0;
                    for (int i = 1; i <= currentNumber; i++)
                    {
                        int controlNumber = currentNumber % i;
                        if (controlNumber == 0)
                        {
                            countControlNumber++;
                        }
                    }
                    if (countControlNumber > 2)
                    {
                        sumNonPrime += currentNumber;
                    }
                    else
                    {
                        sumPrime += currentNumber;
                    }
                }
                number = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
