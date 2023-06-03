namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] firstArray = new int[number];
            int[] secondArray = new int[number];
            int row = 1;

            while (row <= number)
            {
                Console.Write(1 + " ");
                for (int i = 1; i < row; i++)
                {
                    if (i == 1)
                    {
                    secondArray[i] = firstArray[i] + firstArray[i - 1] + 1;
                    Console.Write(secondArray[i] + " ");
                    }
                    else
                    {
                        secondArray[i] = firstArray[i] + firstArray[i - 1];
                        Console.Write(secondArray[i] + " ");
                    }

                }
                for (int j = 1; j < row; j++)
                {
                    firstArray[j] = secondArray[j];
                }
                row++;
                Console.WriteLine();
            }
        }
    }
}