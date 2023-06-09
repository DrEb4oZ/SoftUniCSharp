namespace _02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intsInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> intsOutput = new List<int>();

            for (int i = 0; i < intsInput.Count / 2; i++)
            {
                intsOutput.Add(intsInput[i] + intsInput[intsInput.Count - i - 1]);
            }
            if (intsInput.Count % 2 != 0)
            {
                intsOutput.Add(intsInput[intsInput.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", intsOutput));
        }
    }
}