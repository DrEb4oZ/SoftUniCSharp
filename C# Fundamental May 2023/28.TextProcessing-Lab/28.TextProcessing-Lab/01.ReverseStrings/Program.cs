namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textInput;
            while ((textInput = Console.ReadLine()) != "end")
            {
                string reversedText = string.Empty;
                for (int i = textInput.Length - 1; i >= 0; i--)
                {
                    reversedText += textInput[i];
                }

                Console.WriteLine($"{textInput} = {reversedText}");
            }
        }
    }
}