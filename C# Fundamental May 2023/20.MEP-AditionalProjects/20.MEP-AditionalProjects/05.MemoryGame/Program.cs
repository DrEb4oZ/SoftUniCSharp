using System.Xml.Linq;

namespace _05.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string indexOfElements;
            int countTurns = 0;
            while ((indexOfElements = Console.ReadLine()) != "end")
            {
                string[] currentIndexes = indexOfElements
                    .Split();
                countTurns++;
                int index1 = int.Parse(currentIndexes[0]);
                int index2 = int.Parse(currentIndexes[1]);
                if (index1 == index2 || index1 < 0 || index1 >= inputElements.Count || index2 < 0 || index2 >= inputElements.Count)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    inputElements.Insert(inputElements.Count / 2, $"-{countTurns}a");
                    inputElements.Insert(inputElements.Count / 2, $"-{countTurns}a");
                    continue;
                }

                if (inputElements[index1] == inputElements[index2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {inputElements[index1]}!");
                    if (index1 > index2)
                    {
                        inputElements.RemoveAt(index1);
                        inputElements.RemoveAt(index2);
                    }
                    else
                    {
                        inputElements.RemoveAt(index2);
                        inputElements.RemoveAt(index1);
                    }
                }

                else
                {
                    Console.WriteLine("Try again!");
                }
                if (inputElements.Count == 0)
                {
                    Console.WriteLine($"You have won in {countTurns} turns!");
                    return;
                }
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", inputElements));
        }
    }
}