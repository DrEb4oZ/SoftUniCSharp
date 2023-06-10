namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integersInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] currentCommand = command.Split();
                if (currentCommand[0] == "Delete")
                {
                    int element = int.Parse(currentCommand[1]);
                    DeleteAllElementsFromList(integersInput, element);
                }

                else if (currentCommand[0] == "Insert")
                {
                    int element = int.Parse(currentCommand[1]);
                    int index = int.Parse(currentCommand[2]);
                    InsertElementAtIndex(integersInput, element, index);
                }
            }

            Console.WriteLine(string.Join(" ", integersInput));
        }

        static List<int> DeleteAllElementsFromList(List<int> integersInput, int element)
        {
            integersInput.RemoveAll(n => n == element);
            return integersInput;
        }

        static List<int> InsertElementAtIndex(List<int> integersInput, int element, int index)
        {
            integersInput.Insert(index, element);
            return integersInput;
        }
    }
}