namespace _07.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integersInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int sumOfIntegersInput = integersInput.Sum();
            double avarageNumber = (double)sumOfIntegersInput / integersInput.Count();
            List<int> intInputGreaterThanAvNum = new List<int>();
            for (int i = 0; i < integersInput.Count; i++)
            {
                if (avarageNumber < integersInput[i])
                {
                    intInputGreaterThanAvNum.Add(integersInput[i]);
                }
            }

            intInputGreaterThanAvNum.Sort((a, b) => b.CompareTo(a));
            if (intInputGreaterThanAvNum.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(intInputGreaterThanAvNum[i] + " ");
                }
            }

            else if (intInputGreaterThanAvNum.Count < 5 && intInputGreaterThanAvNum.Count > 0)
            {
                for (int i = 0; i < intInputGreaterThanAvNum.Count; i++)
                {
                    Console.Write(intInputGreaterThanAvNum[i] + " ");
                }
            }

            else if (intInputGreaterThanAvNum.Count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}