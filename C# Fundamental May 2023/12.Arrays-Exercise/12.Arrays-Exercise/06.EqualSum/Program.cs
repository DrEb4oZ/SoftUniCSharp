namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isExisting = false;
            for (int i = 0; i < numbers.Length &&!isExisting; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    if (i == 0)
                    {
                        leftSum += 0;
                    }
                    else
                    {
                        leftSum += numbers[j];
                    }
                }
                    for (int k = i + 1; k < numbers.Length; k++)
                    {
                        if (i == numbers.Length)
                        {
                            rightSum += 0;
                        }
                        else
                        {
                            rightSum += numbers[k];
                        }
                    }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isExisting = true;

                }

            }
            if (!isExisting)
            {
                Console.WriteLine("no");
            }
        }
    }
}