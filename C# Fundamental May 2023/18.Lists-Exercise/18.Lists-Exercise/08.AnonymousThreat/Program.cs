using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Transactions;
/*
asdfgasdfga asdf
divide 0 4
3:1
 
 
 */
namespace _08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();
            string command;
            while ((command = Console.ReadLine())!= "3:1")
            {
                string[] currentCommand = command.Split();
                if (currentCommand[0] == "merge")
                {
                    int startIndex = int.Parse(currentCommand[1]);
                    int endIndex = int.Parse(currentCommand[2]);
                    MergeElementsInList(input, startIndex, endIndex);
                }

                else if (currentCommand[0] == "divide")
                {
                    int index = int.Parse(currentCommand[1]);
                    int partitions = int.Parse(currentCommand[2]);
                    DivideElementsInList(input, index, partitions);
                }
            }

            Console.WriteLine(string.Join(" ", input));
        }

        static void MergeElementsInList(List<string> input, int startIndex, int endIndex)
        {
            if (startIndex >= 0 && startIndex < input.Count && endIndex >= 0 && endIndex < input.Count)
            {
                string temporaryString = "";
                for (int i = startIndex; i <= endIndex; i++)
                {
                    temporaryString += input[i];
                }

                input.RemoveRange(startIndex, endIndex - startIndex + 1);
                input.Insert(startIndex, temporaryString);
            }

            else if (startIndex >= 0 && startIndex < input.Count)
            {
                string temporaryString = "";
                for (int i = startIndex; i <= input.Count - 1; i++)
                {
                    temporaryString += input[i];
                }

                input.RemoveRange(startIndex, input.Count - startIndex);
                input.Insert(startIndex, temporaryString);
            }

            else if (endIndex >= 0 && endIndex < input.Count)
            {
                string temporaryString = "";
                for (int i = 0; i <= endIndex; i++)
                {
                    temporaryString += input[i];
                }

                input.RemoveRange(0, endIndex + 1);
                input.Insert(0, temporaryString);
            }

            else if (startIndex < 0 && endIndex >= input.Count)
            {
                {
                    string temporaryString = "";
                    for (int i = 0; i <= input.Count - 1; i++)
                    {
                        temporaryString += input[i];
                    }

                    input.RemoveRange(0, input.Count);
                    input.Insert(0, temporaryString);
                }
            }
        }

        static void DivideElementsInList(List<string> input, int index, int partitions)
        {
            if (index >= 0 && index < input.Count)
            {
                string temporaryString = input[index];
                double elementsPerIterations = Math.Floor(temporaryString.Length / (double)partitions);
                int countElementsPerIteration = 0;
                int remainingDivideElement = 0;
                string temporaryStringToAddToList = "";
                for (int i = 0; i < temporaryString.Length; i++)
                {
                    temporaryStringToAddToList += temporaryString[i];
                    countElementsPerIteration++;
                    if (countElementsPerIteration == elementsPerIterations && remainingDivideElement < partitions - 1)
                    {
                        temporaryStringToAddToList += " ";
                        countElementsPerIteration = 0;
                        remainingDivideElement++;
                    }
                }
                List<string> tempList = temporaryStringToAddToList
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                input.RemoveAt(index);
                input.InsertRange(index, tempList);
            }
        }
    }
}