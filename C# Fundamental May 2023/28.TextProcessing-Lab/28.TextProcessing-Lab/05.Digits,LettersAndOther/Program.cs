using System.Text;

namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();
            foreach (var character in input)
            {
                if (!char.IsLetterOrDigit(character))
                {
                    symbols.Append(character);
                }

                else if (char.IsDigit(character))
                {
                    digits.Append(character);
                }

                else if (char.IsLetter(character))
                {
                    letters.Append(character);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);

            //Console.WriteLine(string.Join("", input.Where(char.IsDigit)));    // от лекцията
            //Console.WriteLine(string.Join("", input.Where(char.IsLetter)));   // от лекцията
            //Console.WriteLine(string.Join("", input.Where(x => !char.IsLetterOrDigit(x))));   // от лекцията
        }
    }
}