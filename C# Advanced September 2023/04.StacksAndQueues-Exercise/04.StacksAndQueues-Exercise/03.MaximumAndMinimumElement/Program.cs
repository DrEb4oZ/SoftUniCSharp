namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operationCount = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < operationCount; i++)
            {
                string[] operation = Console.ReadLine()
                    .Split();
                if (int.Parse(operation[0]) == 1)
                {
                    stack.Push(int.Parse(operation[1]));
                }

                else if (int.Parse(operation[0]) == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }

                else if (int.Parse(operation[0]) == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }

                else if (int.Parse(operation[0]) == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}