namespace _02.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] integersInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string commands;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] currentCommands = commands
                    .Split()
                    .ToArray();
                string command = currentCommands[0];
                if (command == "swap")
                {
                    int index1 = int.Parse(currentCommands[1]);
                    int index2 = int.Parse(currentCommands[2]);
                    int tempIndex = integersInput[index1];
                    integersInput[index1] = integersInput[index2];
                    integersInput[index2] = tempIndex;
                }

                else if (command == "multiply")
                {
                    int index1 = int.Parse(currentCommands[1]);
                    int index2 = int.Parse(currentCommands[2]);
                    integersInput[index1] *= integersInput[index2];
                }

                else if (command == "decrease")
                {
                    for (int i = 0; i < integersInput.Length; i++)
                    {
                        integersInput[i]--;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", integersInput));
        }
    }
}