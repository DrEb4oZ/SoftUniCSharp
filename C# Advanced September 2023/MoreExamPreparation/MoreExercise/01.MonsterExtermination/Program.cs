/*
5,4,4,3,1
1,2,3,4,6

 */



namespace _01.MonsterExtermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // monster armor collection - monster at the front is first ( first armor value? ) Queue
            // soldier strike collection - last striking strenght - Stack

            Queue<int> monstersArmors = new Queue<int>(Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Stack<int> soldierStrikes = new Stack<int>(Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            int monsterKilledCount = 0;
            while (monstersArmors.Count != 0 && soldierStrikes.Count != 0)
            {
                int monsterArmor = monstersArmors.Dequeue();
                int soldierStrike = soldierStrikes.Pop();

                if (soldierStrike >= monsterArmor)
                {
                    soldierStrike -= monsterArmor;
                    monsterKilledCount++;
                    if (soldierStrike > 0)
                    {
                        if (soldierStrikes.Any())
                        {
                            soldierStrike += soldierStrikes.Pop();
                        }
                        soldierStrikes.Push(soldierStrike);
                    }
                }

                else
                {
                    monsterArmor -= soldierStrike;
                    monstersArmors.Enqueue(monsterArmor);
                }
            }

            if (monstersArmors.Count == 0)
            {
                Console.WriteLine("All monsters have been killed!");
            }
            if (soldierStrikes.Count == 0)
            {
                Console.WriteLine("The soldier has been defeated.");
            }
            Console.WriteLine($"Total monsters killed: {monsterKilledCount}");
        }
    }
}