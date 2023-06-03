namespace _03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = FIbonacciNumber(n);
            Console.WriteLine(result);
        }
        static int FIbonacciNumber(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return FIbonacciNumber(n - 1) + FIbonacciNumber(n - 2);
        }
    }
}