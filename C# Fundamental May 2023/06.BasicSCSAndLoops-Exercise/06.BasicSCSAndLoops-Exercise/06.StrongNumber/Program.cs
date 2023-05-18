namespace _06.StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumFactorial = 0;
            for (int i = 0; i < number.ToString().Length; i++)
            {
                int factorial = 1;
                for (int j = 1; j <= (int)char.GetNumericValue(number.ToString()[i]); j++)
                {
                    factorial *= j;
                }
                sumFactorial += factorial;
            }
            if (sumFactorial == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}