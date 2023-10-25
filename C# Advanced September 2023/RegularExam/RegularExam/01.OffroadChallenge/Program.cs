/*
20 20 20 20
10 10 10 10
10 10 10 11

 */


namespace _01.OffroadChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> fuelConsumptions = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> additionalConsumptionIndexes = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> fuelQuantities = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int altitudeCount = 0;
            List<int> altitudeNumber = new List<int> ();
            while (fuelQuantities.Any())
            {
                int fuelConsumption = fuelConsumptions.Pop();
                int additionalConsumption = additionalConsumptionIndexes.Dequeue();
                int fuelQuantity = fuelQuantities.Dequeue();
                int result = fuelConsumption - additionalConsumption;

                if (result >= fuelQuantity)
                {
                    altitudeCount++;
                    altitudeNumber.Add(altitudeCount);
                    Console.WriteLine($"John has reached: Altitude {altitudeCount}");
                }

                else
                {
                    Console.WriteLine($"John did not reach: Altitude {altitudeCount + 1}");
                    break;
                }

            }

            if (altitudeCount > 0 && altitudeCount != 4)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.Write($"Reached altitudes: Altitude {string.Join(", Altitude ", altitudeNumber)}");
                //for (int i = 0; i < altitudeNumber.Count; i++)
                //{
                //    if (i == altitudeNumber.Count - 1)
                //    {
                //        Console.Write($"Altitude {altitudeNumber[i]}");
                //    }

                //    else
                //    {
                //        Console.Write($"Altitude {altitudeNumber[i]}, ");
                //    }
                //}
            }

            else if (altitudeCount != 4)
            {
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine("John didn't reach any altitude.");
            }

            else if (altitudeCount == 4)
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }

        }
    }
}