namespace _01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> doublesInput = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < doublesInput.Count - 1; i++)
            {
                if (doublesInput[i] == doublesInput[i + 1])
                {
                    doublesInput[i] += doublesInput[i + 1];
                    doublesInput.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", doublesInput));
        }
    }
}