namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command;
            bool isListChanged = false;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] currentCommand = command.Split();
                if (currentCommand[0] == "Add")
                {
                    int addNumber = int.Parse(currentCommand[1]);
                    AddNumberToList(listOfNumbers, addNumber);
                    isListChanged = true;
                }

                else if (currentCommand[0] == "Remove")
                {
                    int removeNumber = int.Parse(currentCommand[1]);
                    RemoveNumberFromList(listOfNumbers, removeNumber);
                    isListChanged = true;
                }

                else if (currentCommand[0] == "RemoveAt")
                {
                    int removeAtIndex = int.Parse(currentCommand[1]);
                    RomoveIndexFromList(listOfNumbers, removeAtIndex);
                    isListChanged = true;
                }

                else if (currentCommand[0] == "Insert")
                {
                    int insertNumber = int.Parse(currentCommand[1]);
                    int insertIndex = int.Parse(currentCommand[2]);
                    InsertNumberInList(listOfNumbers, insertNumber, insertIndex);
                    isListChanged = true;
                }
                switch (currentCommand[0])
                {
                    case "Contains":
                        int containsNumber = int.Parse(currentCommand[1]);
                        PrintIsListContainsNumber(listOfNumbers, containsNumber);
                        break;
                    case "PrintEven":
                        PrintEvenNumbersInList(listOfNumbers);
                        break;
                    case "PrintOdd":
                        PrintOddNumbersInList(listOfNumbers);
                        break;
                    case "GetSum":
                        PrintSumOfNumbersInList(listOfNumbers);
                        break;
                    case "Filter":
                        int numberInCondition = int.Parse(currentCommand[2]);
                        PrintFilteredWithConditionList(listOfNumbers, currentCommand[1], numberInCondition);
                        break;
                }
            }

            if (isListChanged)
            {
            Console.WriteLine(string.Join(" ", listOfNumbers));
            }
        }

        static void PrintIsListContainsNumber(List<int> listOfNumbers, int containsNumber)
        {
            if (listOfNumbers.Contains(containsNumber))
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No such number");
            }
        }

        static void PrintEvenNumbersInList(List<int> listOfNumbers)
        {
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] % 2 == 0)
                {
                    Console.Write(listOfNumbers[i] + " ");
                }
            }

            Console.WriteLine();
        }

        static void PrintOddNumbersInList(List<int> listOfNumbers)
        {
            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] % 2 != 0)
                {
                    Console.Write(listOfNumbers[i] + " ");
                }
            }

            Console.WriteLine();
        }

        static void PrintSumOfNumbersInList(List<int> listOfNumbers)
        {
            Console.WriteLine(listOfNumbers.Sum());
        }

        static void PrintFilteredWithConditionList(List<int> listOfNumbers, string condition, int numberInCondition)
        {
            switch (condition)
            {
                case "<":
                    for (int i = 0; i < listOfNumbers.Count; i++)
                    {
                        if (listOfNumbers[i] < numberInCondition)
                        {
                            Console.Write(listOfNumbers[i] + " ");
                        }
                    }

                    Console.WriteLine();
                    break;
                case ">":
                    for (int i = 0; i < listOfNumbers.Count; i++)
                    {
                        if (listOfNumbers[i] > numberInCondition)
                        {
                            Console.Write(listOfNumbers[i] + " ");
                        }
                    }

                    Console.WriteLine();
                    break;
                case "<=":
                    for (int i = 0; i < listOfNumbers.Count; i++)
                    {
                        if (listOfNumbers[i] <= numberInCondition)
                        {
                            Console.Write(listOfNumbers[i] + " ");
                        }
                    }

                    Console.WriteLine();
                    break;
                case ">=":
                    for (int i = 0; i < listOfNumbers.Count; i++)
                    {
                        if (listOfNumbers[i] >= numberInCondition)
                        {
                            Console.Write(listOfNumbers[i] + " ");
                        }
                    }

                    Console.WriteLine();
                    break;
            }
        }
        static List<int> AddNumberToList(List<int> listOfNumbers, int addNumber)
        {
            listOfNumbers.Add(addNumber);
            return listOfNumbers;
        }

        static List<int> RemoveNumberFromList(List<int> listOfNumbers, int removeNumber)
        {
            listOfNumbers.Remove(removeNumber);
            return listOfNumbers;
        }

        static List<int> RomoveIndexFromList(List<int> listOfNumbers, int removeAtIndex)
        {
            listOfNumbers.RemoveAt(removeAtIndex);
            return listOfNumbers;
        }

        static List<int> InsertNumberInList(List<int> listOfNumbers, int insertNumber, int insertIndex)
        {
            listOfNumbers.Insert(insertIndex, insertNumber);
            return listOfNumbers;
        }
    }
}