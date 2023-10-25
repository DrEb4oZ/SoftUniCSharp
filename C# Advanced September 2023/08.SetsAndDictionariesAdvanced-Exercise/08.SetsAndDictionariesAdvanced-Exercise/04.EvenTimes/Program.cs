namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            Dictionary<int, int> evenNumber = new Dictionary<int, int>();
            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (!evenNumber.ContainsKey(currentNumber))
                {
                    evenNumber.Add(currentNumber, 0);
                }
                evenNumber[currentNumber]++;
            }

            foreach (KeyValuePair<int,int> number in evenNumber)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}