namespace _04.RefactoringPrimeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int imputNumber = int.Parse(Console.ReadLine());
            for (int i = 2; i <= imputNumber; i++)
            {
                bool isInputNumberPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isInputNumberPrime = false;
                        break;
                    }
                }
                if (isInputNumberPrime) Console.WriteLine($"{i} -> true");
                else Console.WriteLine($"{i} -> true");
            }
        }
    }
}