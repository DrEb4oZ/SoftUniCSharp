namespace _01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double,int> numbersCount = new Dictionary<double, int> ();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numbersCount.ContainsKey(numbers[i]))
                {
                    numbersCount.Add(numbers[i], 0);
                }
                numbersCount[numbers[i]]++;
            }

            foreach (KeyValuePair<double, int> item in numbersCount)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}