using System.ComponentModel.DataAnnotations;

namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            
            int lenght = numbersArray.Length - 1;
            while (lenght != 0)
            {
                int[] condensed = new int[lenght];
                for (int i = 0; i < lenght; i++)
                {
                    
                    if (i + 1 < numbersArray.Length)
                    {
                        condensed[i] = numbersArray[i] + numbersArray[i + 1];
                    }

                }

                numbersArray = condensed;
                lenght--;
            }

            Console.WriteLine(string.Join(" ", numbersArray));
        }
    }
}