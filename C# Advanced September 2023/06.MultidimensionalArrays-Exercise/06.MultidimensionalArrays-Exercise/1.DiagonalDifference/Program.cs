namespace _1.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                int[] rowInput = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            for (int i = 0; i < size; i++)
            {
                primaryDiagonalSum += matrix[i, i];
            }

            for (int i = 0; i < size; i++)
            {
                secondaryDiagonalSum += matrix[i, size - i - 1];
            }

            int absoluteDifference = Math.Abs(primaryDiagonalSum -  secondaryDiagonalSum);
            Console.WriteLine(absoluteDifference);
        }
    }
}