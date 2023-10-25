namespace OddLines
{
    using System.IO;
	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader textRead = new StreamReader(@"..\..\..\Files\input.txt"))
            {
                using (StreamWriter textWrite = new StreamWriter(@"..\..\..\Files\output.txt"))
                {
                    int lineNeumber = 0;
                    while (textRead.EndOfStream == false)
                    {
                        string line = textRead.ReadLine();
                        lineNeumber++;
                        if (lineNeumber % 2 != 0)
                        {
                            textWrite.WriteLine(line);
                        }
                    }
                }
            }
        }
    }
}
