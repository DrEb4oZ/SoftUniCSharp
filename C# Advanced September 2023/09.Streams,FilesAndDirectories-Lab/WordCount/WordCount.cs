namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader firstText = new StreamReader(wordsFilePath))
            {
                string firstTextWords = firstText.ReadToEnd();
                string[] words = firstTextWords.ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                List<string> wordsList = new List<string>(words);

                using (StreamReader secondText = new StreamReader(textFilePath))
                {
                    string pattern = @"[^a-zA-Z]";
                    Regex splitter = new Regex(pattern);
                    string[] secondTextWords = splitter.Split(secondText.ReadToEnd().ToLower());
                    Dictionary<string, int> wordsCounts = new Dictionary<string, int>();
                    for (int i = 0; i < secondTextWords.Length; i++)
                    {
                        if (wordsList.Contains(secondTextWords[i]))
                        {
                            if (!wordsCounts.ContainsKey(secondTextWords[i]))
                            {
                                wordsCounts.Add(secondTextWords[i], 0);
                            }
                            wordsCounts[secondTextWords[i]]++;
                        }
                    }

                    using (StreamWriter textWrite = new StreamWriter(outputFilePath))
                    {
                        foreach (KeyValuePair<string, int> word in wordsCounts.OrderByDescending(x => x.Value))
                        {
                            textWrite.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                }
            }
        }
    }
}
