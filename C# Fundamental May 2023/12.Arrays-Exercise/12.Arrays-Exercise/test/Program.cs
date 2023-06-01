namespace _09.KaminoFactory

/*
5
0!1!1!0!0
1!0!1!1!0
1!1!1!0!0
Clone them!

4 
1!1!0!1
1!0!0!1 
1!1!0!0
Clone them!

3
0!0!0
0!1!0
0!0!0
Clone them!

4
1!1!0!1
0!1!1!1
Clone them!

1
0
1
Clone them!

2
1!0!0!0!0
1!1!0!0!0
Clone them!


 */





{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sequencesLength = int.Parse(Console.ReadLine());

            string[] sequencesArray = new string[sequencesLength];
            sequencesArray = Console.ReadLine().Split("!").ToArray();
            int bestCountOf1 = 0;
            string bestSequence = "";  // може с масив и copy
            int currentSequenceIndex = 0;
            int bestSequenceIndex = 0;
            int bestFirstNumber1 = 0;
            int bestCountNumberOfSubsequence1 = 0;
            while (sequencesArray[0] != "Clone them")
            {
                int countOf1 = 0;
                currentSequenceIndex++;

                int currentFirstNumber1 = -1;
                int countNumberOfSubsequence1 = 0;
                int currentBestCountNumberOfSubsequence1 = 0;

                for (int i = 0; i < sequencesLength; i++)
                {
                    if (sequencesArray[i] == "1")
                    {
                        countOf1++;
                        countNumberOfSubsequence1++;
                        if (i == sequencesArray.Length - 1)
                        {
                            if (currentBestCountNumberOfSubsequence1 < countNumberOfSubsequence1)
                            {
                                currentBestCountNumberOfSubsequence1 = countNumberOfSubsequence1;
                                currentFirstNumber1 = i - currentBestCountNumberOfSubsequence1 + 1;
                            }
                        }
                    }

                    else if (sequencesArray[i] == "0")
                    {
                        if (currentBestCountNumberOfSubsequence1 < countNumberOfSubsequence1)
                        {
                            currentBestCountNumberOfSubsequence1 = countNumberOfSubsequence1;
                            currentFirstNumber1 = i - currentBestCountNumberOfSubsequence1;
                        }
                        countNumberOfSubsequence1 = 0;
                    }
                }
                string currentSequence = string.Empty;
                for (int i = 0; i < sequencesArray.Length; i++)
                {
                    currentSequence += (sequencesArray[i] + " ");
                }
                if (currentBestCountNumberOfSubsequence1 > bestCountNumberOfSubsequence1 || bestFirstNumber1 > currentFirstNumber1 && currentBestCountNumberOfSubsequence1 == bestCountNumberOfSubsequence1 || bestFirstNumber1 == currentFirstNumber1 && currentBestCountNumberOfSubsequence1 == bestCountNumberOfSubsequence1 && countOf1 > bestCountOf1)
                {
                    bestCountOf1 = countOf1;
                    bestSequence = currentSequence;
                    bestFirstNumber1 = currentFirstNumber1;
                    bestSequenceIndex = currentSequenceIndex;
                    bestCountNumberOfSubsequence1 = currentBestCountNumberOfSubsequence1;
                }
                sequencesArray = Console.ReadLine().Split("!").ToArray();
            }
            string[] bestSequenceArray = bestSequence
                .Split(" ")
                .ToArray();

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestCountOf1}.");
            Console.WriteLine(string.Join(" ", bestSequenceArray));
        }
    }
}