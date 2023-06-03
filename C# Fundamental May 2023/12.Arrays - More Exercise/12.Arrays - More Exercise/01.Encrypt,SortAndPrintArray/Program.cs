namespace _01.Encrypt_SortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());
            int codeSum = 0;
            int[] inputSort = new int[inputCount];
            for (int i = 0; i < inputCount; i++)
            {
                string input = Console.ReadLine();
                codeSum = 0;
                char[] inputChar = new char[input.Length];
                for (int k = 0; k < input.Length; k++)
                {
                    inputChar[k] = input[k];
                }
                for (int j = 0; j < input.Length; j++)
                {
                    if (inputChar[j] == 'A' || inputChar[j] == 'a' || inputChar[j] == 'E' || inputChar[j] == 'e' || inputChar[j] == 'I' || inputChar[j] == 'i' || inputChar[j] == 'O' || inputChar[j] == 'o' || inputChar[j] == 'U' || inputChar[j] == 'u')
                    {
                        int vowelCode = inputChar[j] * input.Length;
                        codeSum += vowelCode;
                    }
                    else
                    {
                        int consonantCode = inputChar[j] / input.Length;
                        codeSum += consonantCode;
                    }
                }
                inputSort[i] = codeSum;
            }
            Array.Sort(inputSort);
            for (int i = 0; i < inputSort.Length; i++)
            {
                Console.WriteLine(inputSort[i]);
            }
        }
    }
}