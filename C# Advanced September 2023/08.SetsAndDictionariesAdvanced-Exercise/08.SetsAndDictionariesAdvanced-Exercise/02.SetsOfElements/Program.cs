namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersCountInSet = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            HashSet<int> firstIntSet = new HashSet<int>();
            HashSet<int> secondIntSet = new HashSet<int>();
            for (int i = 0; i < numbersCountInSet[0]; i++)
            {
                firstIntSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < numbersCountInSet[1]; i++)
            {
                secondIntSet.Add(int.Parse(Console.ReadLine()));
            }

            firstIntSet.IntersectWith(secondIntSet);    

            Console.WriteLine(string.Join(" ", firstIntSet));
        }
    }
}