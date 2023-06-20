namespace _08.Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command;
            int roundCount = 0;
            int wonBattles = 0;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                roundCount++;
                int distance = int.Parse(command);
                if (energy >= distance)
                {
                    wonBattles++;
                    energy -= distance;
                    if (wonBattles % 3 == 0)
                    {
                        energy += roundCount;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    return;
                }
            }
            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
        }
    }
}