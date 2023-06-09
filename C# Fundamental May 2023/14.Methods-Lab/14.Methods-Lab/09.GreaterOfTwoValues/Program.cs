namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            if (valueType == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                Console.WriteLine(GreaterValue(firstValue, secondValue));
            }

            else if (valueType == "char")
            {
                char firstValue = char.Parse(Console.ReadLine());
                char secondValue = char.Parse(Console.ReadLine());
                Console.WriteLine(GreaterValue(firstValue, secondValue));
            }

            else if (valueType == "string")
            {
                string firstValue = Console.ReadLine();
                string secondValue = Console.ReadLine();
                Console.WriteLine(GreaterValue(firstValue, secondValue));
            }

        }

        static int GreaterValue(int firstValue, int secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }

            else
            {
                return secondValue;
            }

        }
        static char GreaterValue(char firstValue, char secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }

            else
            {
                return secondValue;
            }

        }
        static string GreaterValue(string firstValue, string secondValue)
        {
            if (string.Compare(firstValue, secondValue) > 0)
            {
                return firstValue;
            }

            else
            {
                return secondValue;
            }

        }
    }
}