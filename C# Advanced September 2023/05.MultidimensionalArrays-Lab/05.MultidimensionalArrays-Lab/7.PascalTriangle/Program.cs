namespace _7.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[rowCount][];
            pascalTriangle[0] = new long[1] { 1 };
            for (int row = 1; row < rowCount; row++)
            {
                pascalTriangle[row] = new long[row + 1];
                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    if (col < pascalTriangle[row - 1].Length)
                    {
                        pascalTriangle[row][col] += pascalTriangle[row - 1][col];
                    }

                    if (col > 0)
                    {
                        pascalTriangle[row][col] += pascalTriangle[row - 1][col - 1];
                    }
                }
            }

            foreach (var row in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}