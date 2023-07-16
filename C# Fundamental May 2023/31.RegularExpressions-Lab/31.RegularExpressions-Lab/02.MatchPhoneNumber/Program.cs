using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = Console.ReadLine();
            string regex = @"\+359( 2 \d{3} \d{4}|-2-\d{3}-\d{4})\b";
            MatchCollection phoneNumerbers = Regex.Matches(phoneNumber, regex);
            Console.WriteLine(string.Join(", ", phoneNumerbers));
        }
    }
}