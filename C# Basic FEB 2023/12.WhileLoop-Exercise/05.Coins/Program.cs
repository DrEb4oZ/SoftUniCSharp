using System;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sum = decimal.Parse(Console.ReadLine());
            int countCoin = 0;
            while (sum > 0)
            {
                if (sum >= 2m)
                {
                    sum -= 2m;
                }
                else if (sum >= 1m)
                {
                    sum -= 1;
                }
                else if (sum >= 0.50m)
                {
                    sum -= 0.50m;
                }
                else if (sum >= 0.20m)
                {
                    sum -= 0.20m;
                }
                else if (sum >= 0.10m)
                {
                    sum -= 0.10m;
                }
                else if (sum >= 0.05m)
                {
                    sum -= 0.05m;
                }
                else if (sum >= 0.02m)
                {
                    sum -= 0.02m;
                }
                else if (sum >= 0.01m)
                {
                    sum -= 0.01m;
                }
                countCoin++;
            }
            Console.WriteLine(countCoin);
        }
    }
}
