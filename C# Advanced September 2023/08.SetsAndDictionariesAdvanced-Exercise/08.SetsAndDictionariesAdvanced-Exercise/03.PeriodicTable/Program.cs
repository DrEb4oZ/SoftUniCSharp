namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            SortedSet<string> chemicals = new SortedSet<string>();
            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                chemicals.UnionWith(input);
            }
            Console.WriteLine(string.Join(" ", chemicals));
        }
    }
}