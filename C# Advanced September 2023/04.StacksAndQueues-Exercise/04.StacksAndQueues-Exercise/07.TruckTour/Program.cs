using System.Xml;

namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<int[]> petrolPumpsQueue = new Queue<int[]>();
            for (int i = 0; i < petrolPumps; i++)
            {
                int[] currentPump = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                petrolPumpsQueue.Enqueue(currentPump);
            }

            int bestRoute = 0;
            while (bestRoute <= petrolPumps)
            {
                int totalPetrol = 0;
                foreach (int[] pump in petrolPumpsQueue)
                {
                    int currentPetrol = pump[0];
                    int kmToNextPump = pump[1];
                    totalPetrol += currentPetrol;

                    if (totalPetrol - kmToNextPump < 0)
                    {
                        totalPetrol = 0;
                        break;
                    }

                    else
                    {
                        totalPetrol -= kmToNextPump;
                    }
                }

                if (totalPetrol > 0)
                {
                    break;
                }

                bestRoute++;
                petrolPumpsQueue.Enqueue(petrolPumpsQueue.Dequeue());
            }

            if (bestRoute <= petrolPumps)
            {
                Console.WriteLine(bestRoute);
            }

            else
            {
                Console.WriteLine("There is no eligible route!");
            }
        }
    }
}