namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            triangleTopPart(number);
            triangleBottomPart(number);
        }


        static void triangleTopPart(int number)
        {
            int row = 1;
            for (int i = 0; i < number; i++)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
                row++;
            }
        }

        static void triangleBottomPart(int number)
        {
            int row = number - 1;
            for (int i = number - 1; i >= 0; i--)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write($"{j} ");
                }

                Console.WriteLine();
                row--;
            }

        }
    }
}