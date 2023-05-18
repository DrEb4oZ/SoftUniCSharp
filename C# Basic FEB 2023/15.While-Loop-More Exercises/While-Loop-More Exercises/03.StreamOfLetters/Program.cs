using System;

namespace _03.StreamOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            string word = "";
            bool isCUsed = false;
            bool isOUsed = false;
            bool isNused = false;
            while (letter != "End")
            {
                char currentLetter = char.Parse(letter);
                
                if (char.IsLetter(currentLetter))
                {
                    if (currentLetter == 'c' && !isCUsed)
                    {
                        isCUsed = true;
                    }
                    else if (currentLetter == 'o' && !isOUsed)
                    {
                        isOUsed = true;
                    }
                    else if (currentLetter == 'n' && !isNused)
                    {
                        isNused = true;
                    }
                    else
                    {
                        word += currentLetter;
                    }
                    if (isNused && isOUsed && isCUsed)
                    {
                        Console.Write(word + " ");
                        isCUsed = false;
                        isOUsed = false;
                        isNused = false;
                        word = "";
                    }
                }
                letter = Console.ReadLine();
            }
        }
    }
}
