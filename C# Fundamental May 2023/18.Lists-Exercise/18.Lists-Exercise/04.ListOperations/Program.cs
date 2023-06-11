namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] currentCommand = command.Split();
                if (currentCommand[0] == "Add")
                {
                    int numberToAdd = int.Parse(currentCommand[1]);
                    AddNumberToList(integerList, numberToAdd);
                }

                else if (currentCommand[0] == "Insert")
                {
                    int numberToInsert = int.Parse(currentCommand[1]);
                    int index = int.Parse(currentCommand[2]);
                    if (!IsInRange(integerList, index))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else if (IsInRange(integerList, index))
                    {
                        InsertNumberToList(integerList, numberToInsert, index);
                    }
                }

                else if (currentCommand[0] == "Remove")
                {
                    int index = int.Parse(currentCommand[1]);
                    if (!IsInRange(integerList, index))
                    {
                        Console.WriteLine("Invalid index");
                    }

                    else if (IsInRange(integerList, index))
                    {
                        RemoveIndexFromList(integerList, index);
                    }
                }

                else if (currentCommand[0] == "Shift")
                {
                    if (currentCommand[1] == "left")
                    {
                        int repeatCount = int.Parse(currentCommand[2]);
                        ShiftList(integerList, currentCommand[1], repeatCount);
                    }

                    else if (currentCommand[1] == "right")
                    {
                        int repeatCount = int.Parse(currentCommand[2]);
                        ShiftList(integerList, currentCommand[1], repeatCount);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", integerList));
        }

        static List<int> AddNumberToList(List<int> integerList, int numberToAdd)
        {
            integerList.Add(numberToAdd);
            return integerList;
        }

        static List<int> InsertNumberToList(List<int> integerList, int numberToInsert, int index)
        {
            integerList.Insert(index, numberToInsert);
            return integerList;
        }

        static List<int> RemoveIndexFromList(List<int> integerList, int index)
        {
            integerList.RemoveAt(index);
            return integerList;
        }

        static List<int> ShiftList(List<int> integerList, string direction, int repeatCount)
        {
            if (direction == "left")
            {
                int listCountToMove = repeatCount % integerList.Count;
                List<int> tempList = new List<int>();
                tempList.AddRange(integerList);
                tempList.RemoveRange(listCountToMove, tempList.Count - listCountToMove);
                integerList.RemoveRange(0, listCountToMove);
                integerList.AddRange(tempList);
            }

            else if (direction == "right")
            {
                int listCountToMove = repeatCount % integerList.Count;
                List<int> tempList = new List<int>();
                tempList.AddRange(integerList);
                tempList.RemoveRange(integerList.Count - listCountToMove, listCountToMove);
                integerList.RemoveRange(0, integerList.Count - listCountToMove);
                integerList.AddRange(tempList);
            }

            return integerList;
        }

        static bool IsInRange(List<int> integerList, int index)
        {
            return index >= 0 && index < integerList.Count;
        }
    }
}