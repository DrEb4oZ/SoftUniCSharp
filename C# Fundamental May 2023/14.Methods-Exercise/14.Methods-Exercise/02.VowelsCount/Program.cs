namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            int countVowels = VowelsCount(inputString);
            Console.WriteLine(countVowels);
        }

        static int VowelsCount(string inputString)
        {
            int countVowels = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'a' || inputString[i] == 'A' || inputString[i] == 'E' || inputString[i] == 'e' || inputString[i] == 'I' || inputString[i] == 'i' || inputString[i] == 'O' || inputString[i] == 'o' || inputString[i] == 'U' || inputString[i] == 'u')
                {
                    countVowels++;
                }
            }
            return countVowels;
        }
    }
}