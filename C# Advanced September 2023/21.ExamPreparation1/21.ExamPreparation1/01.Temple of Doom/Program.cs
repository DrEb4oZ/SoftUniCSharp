﻿namespace _01.Temple_of_Doom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> tools = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            Stack<int> substances = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            List<int> challenges = new List<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            bool isAdventureSuccessfull = true;
            while (true)
            {
                int tool = tools.Dequeue();
                int substance = substances.Pop();
                int result = tool * substance;

                if (challenges.Contains(result))
                {
                    challenges.Remove(result);
                }

                else
                {
                    tool++;
                    tools.Enqueue(tool);
                    substance--;
                    if (substance > 0)
                    {
                        substances.Push(substance);
                    }
                }

                if ((tools.Count == 0 || substances.Count == 0) && challenges.Count > 0)
                {
                    Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
                    isAdventureSuccessfull = false;
                    break;
                }

                if (challenges.Count == 0)
                {
                    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
                    break;
                }

            }

            if (tools.Count > 0) Console.WriteLine($"Tools: {string.Join(", ", tools)}");
            if (substances.Count > 0)Console.WriteLine($"Substances: {string.Join(", ", substances)}");
            if (challenges.Count > 0) Console.WriteLine($"Challenges: {string.Join(", ", challenges)}");
        }
    }
}