namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            while((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(input));
            }
        }

        static bool IsPalindrome(string input)
        {
            char[] originalString = input.ToCharArray();
            Array.Reverse(originalString);
            string reversedString = new string(originalString);

            return input == reversedString;
        }
    }
}