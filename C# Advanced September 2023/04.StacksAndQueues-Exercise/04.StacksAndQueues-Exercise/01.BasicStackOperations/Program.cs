namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int pushElements = input[0];
            int popElements = input[1];
            int elementToLook = input[2];

            int[] elemets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Take(pushElements)
                .ToArray();

            Stack<int> StackElements = new Stack<int>(elemets);

            for (int i = 0; i < popElements && StackElements.Count > 0; i++)
            {
                StackElements.Pop();
            }

            if (StackElements.Contains(elementToLook))
            {
                Console.WriteLine("true");
            }
            else if (StackElements.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(StackElements.Min());
            }
        }
    }
}