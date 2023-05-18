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
                bool isPrime = true;
                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i <= currentNumber - 1 && isPrime; i++)
                    {
                        if (currentNumber % i == 0)
                        {
                            isPrime = false; ;
                        }
                    }
                    if (isPrime)
                    {
                        sumPrime += currentNumber;
                    }
                    else
                    {
                        sumNonPrime += currentNumber;
                    }
                }
                number = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
