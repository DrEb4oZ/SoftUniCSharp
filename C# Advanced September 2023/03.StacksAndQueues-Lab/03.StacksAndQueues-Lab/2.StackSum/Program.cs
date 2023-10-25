namespace _2.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            string command = string.Empty;
            while((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] tokens = command.Split();
                string currentCommand = tokens[0];
                if (currentCommand == "add")
                {
                    int firstNumber = int.Parse(tokens[1]);
                    int secondNumber = int.Parse(tokens[2]);
                    numbers.Push(firstNumber);
                    numbers.Push(secondNumber);
                }
                
                else if (currentCommand == "remove")
                {
                    int removeCount = int.Parse(tokens[1]);
                    if (removeCount <= numbers.Count)
                    {
                        for (int i = 0; i < removeCount; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }

            int sum = 0;
            while (numbers.Count > 0)
            {
                sum += numbers.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}