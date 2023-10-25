namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader textRead = new StreamReader(inputFilePath))
            {
                using (StreamWriter textWrite = new StreamWriter(outputFilePath))
                {
                    int counter = 1;
                    while (textRead.EndOfStream == false)
                    {
                        string line = textRead.ReadLine();
                        textWrite.WriteLine($"{counter}. {line}");
                        counter++;
                    }
                }
            }
        }
    }
}
