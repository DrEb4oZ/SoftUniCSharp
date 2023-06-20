namespace _09.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command;
            int shotTargetsCount = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                int currentIndex = int.Parse(command);
                if (currentIndex >= 0 && currentIndex < targets.Count)
                {
                    if (targets[currentIndex] != -1)
                    {
                        int currentTargetValue = targets[currentIndex];
                        targets[currentIndex] = -1;
                        shotTargetsCount++;
                        for (int i = 0; i < targets.Count; i++)
                        {
                            if (targets[i] != -1 && targets[i] > currentTargetValue)
                            {
                                targets[i] -= currentTargetValue;
                            }

                            else if (targets[i] != -1 && targets[i] <= currentTargetValue)
                            {
                                targets[i] += currentTargetValue;
                            }
                        }
                    }
                }
            }

            Console.Write($"Shot targets: {shotTargetsCount} -> ");
            Console.WriteLine(string.Join(" ", targets));
        }
    }
}