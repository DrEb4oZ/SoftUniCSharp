namespace _03.Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "Craft!")
            {
                string[] currentCommand = command
                    .Split(" - ")
                    .ToArray();
                if (currentCommand[0] == "Collect")
                {
                    if (!inventory.Contains(currentCommand[1]))
                    {
                        inventory.Add(currentCommand[1]);
                    }
                }

                else if (currentCommand[0] == "Drop")
                {
                    if (inventory.Contains(currentCommand[1]))
                    {
                        inventory.Remove(currentCommand[1]);
                    }
                }

                else if (currentCommand[0] == "Combine Items")
                {
                    string[] itemsToCombine = currentCommand[1]
                        .Split(":")
                        .ToArray();
                    if (inventory.Contains(itemsToCombine[0]))
                    {
                        int indexOfCumbineItem = inventory.IndexOf(itemsToCombine[0]);
                        inventory.Insert(indexOfCumbineItem + 1, itemsToCombine[1]);
                    }
                }

                else if (currentCommand[0] == "Renew")
                {
                    if (inventory.Contains(currentCommand[1]))
                    {
                        inventory.Add(currentCommand[1]);
                        inventory.Remove(currentCommand[1]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}