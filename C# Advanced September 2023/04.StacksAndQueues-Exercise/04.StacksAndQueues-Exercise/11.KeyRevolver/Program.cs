namespace _11.KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] locks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int value = int.Parse(Console.ReadLine());
            Queue<int> locksStack = new Queue<int>(locks);
            Stack<int> bulletsStack = new Stack<int>(bullets);
            int bulletsShot = 0;
            while (locksStack.Count > 0 && bulletsStack.Count > 0)
            {
                int currentGunBarrelSize = gunBarrelSize;
                while (currentGunBarrelSize != 0 && locksStack.Count > 0 && bulletsStack.Count > 0)
                {
                    int currentLock = locksStack.Peek();
                    int currentBullet = bulletsStack.Pop();
                    currentGunBarrelSize--;
                    bulletsShot++;
                    if (currentBullet <= currentLock)
                    {
                        Console.WriteLine("Bang!");
                        locksStack.Dequeue();
                    }

                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                }
                if (bulletsStack.Count > 0 && currentGunBarrelSize == 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (bulletsStack.Count == 0 && locksStack.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksStack.Count}");
            }

            else
            {
                int earnValue = value - bulletsShot * bulletPrice;
                Console.WriteLine($"{bulletsStack.Count} bullets left. Earned ${earnValue}");
            }
        }
    }
}