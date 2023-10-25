namespace ExtractSpecialBytes
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            using (FileStream binarySource = new FileStream(binaryFilePath, FileMode.Open))
            {
                using (StreamReader textFilterSource = new StreamReader(bytesFilePath))
                {
                    using (FileStream output = new FileStream(outputPath, FileMode.Create))
                    {
                        byte[] binarySourceToBytes = new byte[binarySource.Length];
                        binarySource.Read(binarySourceToBytes, 0, binarySourceToBytes.Length);
                        while (textFilterSource.EndOfStream == false)
                        {
                            string line = textFilterSource.ReadLine();

                            for (int i = 0; i < binarySourceToBytes.Length; i++)
                            {
                                byte[] current = new byte[binarySourceToBytes[i]];
                                if (binarySourceToBytes[i] == int.Parse(line))
                                {
                                    output.Write(current);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}