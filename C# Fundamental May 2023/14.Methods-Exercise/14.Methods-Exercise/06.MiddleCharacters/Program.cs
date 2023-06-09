namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            Console.WriteLine(PrintMidCharOfString(stringInput)); 
        }

        static string PrintMidCharOfString(string stringInput)
        {
            if (stringInput.Length % 2 == 0)
            {
                return $"{stringInput[stringInput.Length / 2 - 1]}{stringInput[(stringInput.Length / 2)]}";
            }
            else
            {
                return $"{stringInput[stringInput.Length / 2]}";
            }
        }
    }
}