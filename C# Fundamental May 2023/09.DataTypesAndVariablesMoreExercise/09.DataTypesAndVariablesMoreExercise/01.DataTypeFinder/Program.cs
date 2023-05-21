using System.Data;

namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string dataType = "";
            while (input != "END")
            {
                if (int.TryParse(input, out _))
                {
                    dataType = "integer";
                    Console.WriteLine($"{input} is {dataType} type");
                }

                else if (char.TryParse(input, out _))
                {
                    dataType = "character";
                    Console.WriteLine($"{input} is {dataType} type");
                }

                else if (bool.TryParse(input, out _))
                {
                    dataType = "boolean";
                    Console.WriteLine($"{input} is {dataType} type");
                }

                else if (double.TryParse(input, out _))
                {
                    dataType = "floating point";
                    Console.WriteLine($"{input} is {dataType} type");
                }

                else
                {
                    dataType = "string";
                    Console.WriteLine($"{input} is {dataType} type");
                }

                input = Console.ReadLine();
            }
        }
    }
}