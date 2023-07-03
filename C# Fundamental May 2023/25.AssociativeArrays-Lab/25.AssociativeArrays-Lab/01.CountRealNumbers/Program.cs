namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> numbersCount = new Dictionary<double, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numbersCount.ContainsKey(numbers[i]))
                {
                    numbersCount.Add(numbers[i], 0);
                }
                numbersCount[numbers[i]]++;
            }
            foreach (KeyValuePair<double, int> kvp in numbersCount.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}