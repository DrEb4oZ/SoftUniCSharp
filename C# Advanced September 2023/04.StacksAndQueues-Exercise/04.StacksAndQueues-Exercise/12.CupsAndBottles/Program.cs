namespace _12.CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] bottles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> cupsQueue = new Queue<int>(cups);
            Stack<int> bottleQueue = new Stack<int>(bottles);
            int wastedWater = 0;
            while (cupsQueue.Count > 0 && bottleQueue.Count > 0)
            {
                int currentCup = cupsQueue.Peek();
                while (currentCup > 0)
                {
                    int currentBottle = bottleQueue.Pop();
                    if (currentCup > currentBottle)
                    {
                        currentCup -= currentBottle;
                    }

                    else
                    {
                        currentBottle -= currentCup;
                        currentCup = 0;
                        cupsQueue.Dequeue();
                        wastedWater += currentBottle;
                    }
                }
            }

            if (cupsQueue.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottleQueue)}");
            }

            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsQueue)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}