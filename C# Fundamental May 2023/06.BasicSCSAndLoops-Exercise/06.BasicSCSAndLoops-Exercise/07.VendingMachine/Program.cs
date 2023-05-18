namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coinInsert = Console.ReadLine();
            double totalSum = 0;

            while (coinInsert != "Start")
            {
                double currentCoin = double.Parse(coinInsert);
                if (currentCoin == 0.1 || currentCoin == 0.2 || currentCoin == 0.5 || currentCoin == 1 || currentCoin == 2)
                {
                    totalSum += currentCoin;
                }

                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }

                coinInsert = Console.ReadLine();
            }

            string productToBuy = Console.ReadLine();
            while (productToBuy != "End")
            {
                if (productToBuy == "Nuts")
                {
                    if (totalSum >= 2)
                    {
                        totalSum -= 2.00;
                        Console.WriteLine($"Purchased {productToBuy.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                else if (productToBuy == "Water")
                {
                    if (totalSum >= 0.70)
                    {
                        totalSum -= 0.70;
                        Console.WriteLine($"Purchased {productToBuy.ToLower()}");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }

                else if (productToBuy == "Crisps")
                {
                    if (totalSum >= 1.50)
                    {
                        totalSum -= 1.50;
                        Console.WriteLine($"Purchased {productToBuy.ToLower()}");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }

                else if (productToBuy == "Soda")
                {
                    if (totalSum >= 0.80)
                    {
                        totalSum -= 0.80;
                        Console.WriteLine($"Purchased {productToBuy.ToLower()}");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");

                    }

                }

                else if (productToBuy == "Coke")
                {
                    if (totalSum >= 1.00)
                    {
                        totalSum -= 1.00;
                        Console.WriteLine($"Purchased {productToBuy.ToLower()}");
                    }

                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                productToBuy = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalSum:f2}");
        }
    }
}