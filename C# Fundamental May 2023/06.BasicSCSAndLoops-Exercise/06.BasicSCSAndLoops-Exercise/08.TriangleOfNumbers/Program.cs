namespace _08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int row = 1;

            while (row <= number)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write($"{row} ");
                }
                row++;
                Console.WriteLine();
            }
        }
    }
}