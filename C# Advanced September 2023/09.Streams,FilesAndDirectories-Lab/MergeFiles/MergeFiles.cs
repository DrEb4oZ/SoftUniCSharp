namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader firstText = new StreamReader(firstInputFilePath))
            {
                using (StreamReader secondText = new StreamReader(secondInputFilePath))
                {
                    Queue<string> firstList = new Queue<string>();
                    Queue<string> secondList = new Queue<string>();
                    while (firstText.EndOfStream == false)
                    {
                        firstList.Enqueue(firstText.ReadLine());
                    }

                    while (secondText.EndOfStream == false)
                    {
                        secondList.Enqueue(secondText.ReadLine());
                    }

                    using (StreamWriter textWrite = new StreamWriter(outputFilePath))
                    {
                        if (firstList.Count > secondList.Count)
                        {
                            while(firstList.Count > 0)
                            {
                                textWrite.WriteLine(firstList.Dequeue());
                                textWrite.WriteLine(secondList.Dequeue());
                            }
                            while(secondList.Count > 0)
                            {
                                textWrite.WriteLine(secondList.Dequeue());
                            }
                        }

                        else
                        {
                            while (firstList.Count > 0)
                            {
                                textWrite.WriteLine(firstList.Dequeue());
                                textWrite.WriteLine(secondList.Dequeue());
                            }
                            while (firstList.Count > 0)
                            {
                                textWrite.WriteLine(secondList.Dequeue());
                            }
                        }
                    }
                }
            }
        }
    }
}
