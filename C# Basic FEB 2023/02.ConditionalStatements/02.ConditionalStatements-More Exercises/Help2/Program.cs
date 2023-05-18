using System;

namespace Help2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                string word = Console.ReadLine();

                double busPrice = n * 0.09;
                double trainPrice = n * 0.06;
                double taxiPriceDay = 0.7 + (n * 0.79);
                double taxiPricenight = 0.7 + (n * 0.90);

                if (n <= 19)
                {
                    if (word == "day")
                    {
                        Console.WriteLine($"{taxiPriceDay:f2}");
                    }

                    else if (word == "night")
                    {
                        Console.WriteLine($"{taxiPricenight:f2}");
                    }
                }
                else if (n <= 99)
                {
                    if (busPrice < taxiPriceDay == true)
                    {
                        Console.WriteLine($"{busPrice:F2}");
                    }
                    else
                    {
                        if (word == "day")
                        {
                            Console.WriteLine($"{taxiPriceDay:f2}");
                        }
                        else if (word == "night")
                        {
                            Console.WriteLine($"{taxiPricenight:f2}");
                        }
                    }
                }
                else if (n >= 100)
                {
                    if (trainPrice < taxiPriceDay == true && trainPrice < busPrice == true)
                    {
                        Console.WriteLine($"{trainPrice:F2}");
                    }
                    else if (busPrice < taxiPriceDay == true && busPrice < taxiPricenight == true)
                    {
                        Console.WriteLine($"{busPrice}");
                    }
                    else
                    {
                        if (word == "day")
                        {
                            Console.WriteLine($"{taxiPriceDay:f2}");
                        }
                        else if (word == "night")
                        {
                            Console.WriteLine($"{taxiPricenight:f2}");
                        }
                    }
                }
            }
        }
    }
}
