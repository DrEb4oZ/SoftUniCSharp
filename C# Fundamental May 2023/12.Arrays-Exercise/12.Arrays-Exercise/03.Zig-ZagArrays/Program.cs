namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraysLength = int.Parse(Console.ReadLine());
            int[] firstArray = new int[arraysLength];
            int[] secondArray = new int[arraysLength];

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int[] currentArray = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
                    firstArray[i] = currentArray[0];
                    secondArray[i] = currentArray[1];
                }

                else
                {
                    int[] currentArray = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
                    firstArray[i] = currentArray[1];
                    secondArray[i] = currentArray[0];
                }

            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}