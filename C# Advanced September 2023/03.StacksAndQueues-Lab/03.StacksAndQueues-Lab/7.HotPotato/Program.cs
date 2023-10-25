namespace _7.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            int tossCountRule = int.Parse(Console.ReadLine());
            int tossCount = 0;
            Queue<string> players = new Queue<string>(input);

            while (players.Count != 1)
            {
                tossCount++;
                string currentPlayer = players.Dequeue();
                if (tossCount != tossCountRule)
                {
                    players.Enqueue(currentPlayer);
                }
                else
                {
                    tossCount = 0;
                    Console.WriteLine($"Removed {currentPlayer}");
                }
            }

            Console.WriteLine($"Last is {players.Peek()}");
        }
    }
}