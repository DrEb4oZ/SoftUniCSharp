namespace _01.RubberDuckDebugers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> programersTimes = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Stack<int> tasksCount = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            int darthVaderDuckyCount = 0;
            int thorDuckyCount = 0;
            int bigBlueRubberDuckyCount = 0;
            int smallYellowRubberDuckyCount = 0;

            while (programersTimes.Count != 0)
            {
                int programerTime = programersTimes.Dequeue();
                int task = tasksCount.Pop();
                int result = programerTime * task;

                if (result <= 60)
                {
                    darthVaderDuckyCount++;
                }

                else if (result > 61 && result <= 120)
                {
                    thorDuckyCount++;
                }

                else if (result > 121 && result <= 180)
                {
                    bigBlueRubberDuckyCount++;
                }

                else if (result > 181 && result <= 240)
                {
                    smallYellowRubberDuckyCount++;
                }

                else
                {
                    task -= 2;
                    tasksCount.Push(task);
                    programersTimes.Enqueue(programerTime);
                }
            }

            Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
            Console.WriteLine($"Darth Vader Ducky: {darthVaderDuckyCount}");
            Console.WriteLine($"Thor Ducky: {thorDuckyCount}");
            Console.WriteLine($"Big Blue Rubber Ducky: {bigBlueRubberDuckyCount}");
            Console.WriteLine($"Small Yellow Rubber Ducky: {smallYellowRubberDuckyCount}");
        }
    }
}