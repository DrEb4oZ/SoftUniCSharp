namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> func = numbers =>
            {
                int min = int.MaxValue;
                foreach (int num in numbers)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                return min;
            };
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Console.WriteLine(func(numbers));
        }
    }
}