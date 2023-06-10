namespace _06.ListManipulationBasics
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
            while ((command = Console.ReadLine()) != "end")
            {
                string[] currentCommand = command.Split(" ");

                if (currentCommand[0] == "Add")
                {
                    int addNumber = int.Parse(currentCommand[1]);
                    AddNumberToList(listOfNumbers, addNumber);
                }

                else if (currentCommand[0] == "Remove")
                {
                    int removeNumber = int.Parse(currentCommand[1]);
                    RemoveNumberFromList(listOfNumbers, removeNumber);
                }

                else if (currentCommand[0] == "RemoveAt")
                {
                    int removeAtIndex = int.Parse(currentCommand[1]);
                    RomoveIndexFromList(listOfNumbers, removeAtIndex);
                }

                else if (currentCommand[0] == "Insert")
                {
                    int insertNumber = int.Parse(currentCommand[1]);
                    int insertIndex = int.Parse(currentCommand[2]);
                    InsertNumberInList(listOfNumbers, insertNumber, insertIndex);
                }
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
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