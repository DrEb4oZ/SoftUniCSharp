namespace _01.BaristaContest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> coffeeQuantities = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> milkQuantities = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Dictionary<string, int> coffeesMade = new Dictionary<string, int>();

            while (coffeeQuantities.Any() && milkQuantities.Any())
            {
                int coffee = coffeeQuantities.Dequeue();
                int milk = milkQuantities.Pop();
                int result = coffee + milk;

                if (result == 50)
                {
                    if (!coffeesMade.ContainsKey("Cortado"))
                    {
                        coffeesMade.Add("Cortado", 0);
                    }
                    coffeesMade["Cortado"]++;
                    continue;
                }

                else if (result == 75)
                {
                    if (!coffeesMade.ContainsKey("Espresso"))
                    {
                        coffeesMade.Add("Espresso", 0);
                    }
                    coffeesMade["Espresso"]++;
                    continue;
                }

                else if (result == 100)
                {
                    if (!coffeesMade.ContainsKey("Capuccino"))
                    {
                        coffeesMade.Add("Capuccino", 0);
                    }
                    coffeesMade["Capuccino"]++;
                    continue;
                }

                else if (result == 150)
                {
                    if (!coffeesMade.ContainsKey("Americano"))
                    {
                        coffeesMade.Add("Americano", 0);
                    }
                    coffeesMade["Americano"]++;
                    continue;

                }

                else if (result == 200)
                {
                    if (!coffeesMade.ContainsKey("Latte"))
                    {
                        coffeesMade.Add("Latte", 0);
                    }
                    coffeesMade["Latte"]++;
                    continue;
                }

                milk -= 5;
                milkQuantities.Push(milk);

            }

            if (!coffeeQuantities.Any() && !milkQuantities.Any())
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }

            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }

            if (!coffeeQuantities.Any())
            {
                Console.WriteLine("Coffee left: none");
            }

            else
            {
                Console.WriteLine($"Coffee left: {string.Join(", ", coffeeQuantities)}");
            }

            if (!milkQuantities.Any())
            {
                Console.WriteLine("Milk left: none");
            }

            else
            {
                Console.WriteLine($"Milk left: {string.Join(", ", milkQuantities)}");
            }

            foreach (KeyValuePair<string, int> drink in coffeesMade.OrderBy(d => d.Value).ThenByDescending(d => d.Key))
            {
                Console.WriteLine($"{drink.Key}: {drink.Value}");
            }
        }
    }
}