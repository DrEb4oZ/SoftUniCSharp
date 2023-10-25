namespace _5.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> intQueue = new Queue<int>(numbers);
            Queue<int> evenNumbers = new Queue<int>();
            while (intQueue.Count > 0)
            {
                int tempNumber = intQueue.Dequeue();
                if (tempNumber % 2 == 0)
                {
                    evenNumbers.Enqueue(tempNumber);
                }
            }

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}