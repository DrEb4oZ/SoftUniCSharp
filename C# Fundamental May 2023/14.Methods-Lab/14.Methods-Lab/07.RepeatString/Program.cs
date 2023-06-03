namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            int stringRepeat = int.Parse(Console.ReadLine());

            Console.WriteLine(NewString(stringInput, stringRepeat));
        }

        static string NewString(string stringInput, int stringRepeat)
        {
            string newString = "";
            for (int i = 0; i < stringRepeat; i++)
            {
                newString += stringInput;
            }
            return newString;
        }
    }
}