namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] currentCommand = command.Split();
                if (currentCommand[0] == "Add")
                {
                    int numberOfpassangers = int.Parse(currentCommand[1]);
                    wagons.Add(numberOfpassangers);
                }

                else
                {
                    int numberOfpassangers = int.Parse(currentCommand[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                    if ((wagonCapacity - wagons[i]) >= numberOfpassangers)
                        {
                            wagons[i] += numberOfpassangers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}