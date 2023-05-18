namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double startBalance = double.Parse(Console.ReadLine());
            double currentBalance = startBalance;
            string gameToPurchace = Console.ReadLine();
            double totalMoneySpent = 0;
            bool isMoneyEnough = true;

            while (gameToPurchace != "Game Time" && isMoneyEnough)
            {
                switch (gameToPurchace)
                {
                    case "OutFall 4":
                        if (currentBalance >= 39.99)
                        {
                            Console.WriteLine($"Bought {gameToPurchace}");
                            currentBalance -= 39.99;
                            totalMoneySpent += 39.99;
                        }

                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                            break;
                    case "CS: OG":
                        if (currentBalance >= 15.99)
                        {
                            Console.WriteLine($"Bought {gameToPurchace}");
                            currentBalance -= 15.99;
                            totalMoneySpent += 15.99;
                        }

                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Zplinter Zell":
                        if (currentBalance >= 19.99)
                        {
                            Console.WriteLine($"Bought {gameToPurchace}");
                            currentBalance -= 19.99;
                            totalMoneySpent += 19.99;
                        }

                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "Honored 2":
                        if (currentBalance >= 59.99)
                        {
                            Console.WriteLine($"Bought {gameToPurchace}");
                            currentBalance -= 59.99;
                            totalMoneySpent += 59.99;
                        }

                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch":
                        if (currentBalance >= 29.99)
                        {
                            Console.WriteLine($"Bought {gameToPurchace}");
                            currentBalance -= 29.99;
                            totalMoneySpent += 29.99;
                        }

                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        if (currentBalance >= 39.99)
                        {
                            Console.WriteLine($"Bought {gameToPurchace}");
                            currentBalance -= 39.99;
                            totalMoneySpent += 39.99;
                        }

                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                if (currentBalance == 0)
                {
                    isMoneyEnough = false;
                }
                gameToPurchace = Console.ReadLine();
            }
            if (!isMoneyEnough)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                double moneyLeft = startBalance - totalMoneySpent;
                Console.WriteLine($"Total spent: ${totalMoneySpent:f2}. Remaining: ${moneyLeft:f2}");
            }
        }
    }
}