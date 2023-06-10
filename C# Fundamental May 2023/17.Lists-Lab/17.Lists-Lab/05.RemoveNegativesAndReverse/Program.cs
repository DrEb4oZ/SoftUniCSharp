namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            listOfNumbers.RemoveAll(n => n < 0);

            listOfNumbers.Reverse();
            if (listOfNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }

            else
            {
                Console.WriteLine(string.Join(" ", listOfNumbers));
            }
        }
    }
}