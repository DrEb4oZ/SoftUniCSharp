namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int[], int[]> ArithmeticsAndPrint = (command, numbers) =>
            {
                switch (command)
                {
                    case "add":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i]++;
                        }
                        break;
                    case "multiply":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] *= 2;
                        }
                        break;
                    case "subtract":
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i]--;
                        }

                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }
                return numbers;
            };

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                ArithmeticsAndPrint(command, numbers);
            }
        }
    }
}