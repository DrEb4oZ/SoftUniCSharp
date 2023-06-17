using System.Text;

namespace _04.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            List<int> liftWagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            for (int i = 0; i < liftWagons.Count; i++)
            {
                if (liftWagons[i] < 4 && peopleCount > 0)
                {
                    int currentSeatsAvailable = 4 - liftWagons[i];
                    if (currentSeatsAvailable >= peopleCount)
                    {
                        liftWagons[i] += peopleCount;
                        peopleCount = 0;
                        break;
                    }

                    else
                    {
                        peopleCount -= currentSeatsAvailable;
                        liftWagons[i] = 4;
                    }
                }
            }
            if (peopleCount == 0 && liftWagons[liftWagons.Count - 1] < 4)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", liftWagons));
            }

            else if (peopleCount == 0 && liftWagons[liftWagons.Count - 1] == 4)
            {
                Console.WriteLine(string.Join(" ", liftWagons));
            }

            else
            {
                Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!");
                Console.WriteLine(string.Join(" ", liftWagons));
            }
        }
    }
}