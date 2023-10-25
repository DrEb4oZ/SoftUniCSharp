namespace _4.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            int charRow = 0, charCol = 0;
            bool charToLookForFound = false;
            for (int row = 0; row < size; row++)
            {
                char[] rowInput = Console.ReadLine()
                    .ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowInput[col];

                }
            }

            char charToLookFor = char.Parse(Console.ReadLine());
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == charToLookFor && !charToLookForFound)
                    {
                        charRow = row;
                        charCol = col;
                        charToLookForFound = true;
                    }

                }
            }

            if (charToLookForFound)
            {
                Console.WriteLine($"({charRow}, {charCol})");
            }

            else
            {
                Console.WriteLine($"{charToLookFor} does not occur in the matrix");
            }
        }
    }
}