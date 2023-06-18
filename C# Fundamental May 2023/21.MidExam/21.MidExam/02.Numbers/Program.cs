namespace _02.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] currentCommand = command
                    .Split();
                if (currentCommand[0] == "Add")
                {
                    int amount = int.Parse(currentCommand[1]);
                    numbersInput.Add(amount);
                }

                else if (currentCommand[0] == "Remove")
                {
                    int amount = int.Parse(currentCommand[1]);
                    numbersInput.Remove(amount);
                }

                else if (currentCommand[0] == "Replace")
                {
                    int amount = int.Parse(currentCommand[1]);
                    int replacementAmount = int.Parse(currentCommand[2]);
                    int replacementIndex = numbersInput.IndexOf(amount);
                    numbersInput.RemoveAt(replacementIndex);
                    numbersInput.Insert(replacementIndex, replacementAmount);
                }

                else if (currentCommand[0] == "Collapse")
                {
                    int amount = int.Parse(currentCommand[1]);
                    List<int> tempList = new List<int>();
                    for (int i = 0; i < numbersInput.Count; i++)
                    {
                        if (numbersInput[i] >= amount)
                        {
                            tempList.Add(numbersInput[i]);
                        }
                    }

                    numbersInput = tempList;
                }
            }

            Console.WriteLine(string.Join(" ", numbersInput));
        }
    }
}