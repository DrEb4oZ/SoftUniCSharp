namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader inputStreamReader = new StreamReader(inputFilePath))
            {
                StringBuilder revSb = new StringBuilder();
                int lineCount = 0;
                while (inputStreamReader.EndOfStream == false)
                {
                    if (lineCount % 2 == 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        string line = inputStreamReader.ReadLine();
                        sb.Append(line);


                        for (int i = 0; i < line.Length; i++)
                        {
                            if (!Char.IsLetter(line[i]) && line[i] != ' ')
                            {
                                sb.Replace(line[i], '@');

                            }
                        }
                        string[] temp = sb.ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
                        revSb.AppendLine(string.Join(" ", temp));
                    }
                    else
                    {
                        string lineEmpty = inputStreamReader.ReadLine();

                    }
                    lineCount++;
                }

                return revSb.ToString();


            }
        }
    }
}
