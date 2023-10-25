namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream source = new FileStream(sourceFilePath, FileMode.Open))
            {
                byte[] sourceBytes = new byte[source.Length];
                source.Read(sourceBytes,0, sourceBytes.Length);
                int bytesCount = sourceBytes.Length;
                using (FileStream firstPart = new FileStream(partOneFilePath, FileMode.Create))
                {
                    if (bytesCount % 2 != 0)
                    {
                        firstPart.Write(sourceBytes, 0, bytesCount / 2 + 1);
                    }

                    else
                    {
                        firstPart.Write(sourceBytes, 0, bytesCount / 2);
                    }
                }
                using (FileStream secondPart = new FileStream(partTwoFilePath, FileMode.Create))
                {
                    secondPart.Write(sourceBytes, bytesCount / 2, bytesCount / 2);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream output = new FileStream(joinedFilePath, FileMode.Create))
            {
                //FileStream part1 = new FileStream(partOneFilePath, FileMode.Open);
                //FileStream part2 = new FileStream(partTwoFilePath, FileMode.Open);
                byte[] partOne = File.ReadAllBytes(partOneFilePath);
                //part1.ReadByte();
                byte[] partTwo = File.ReadAllBytes(partTwoFilePath);
                //part2.ReadByte();
                byte[] combine = new byte[partOneFilePath.Length + partTwoFilePath.Length];
                //for (int i = 0; i < partOneFilePath.Length; i++)
                //{
                //    combine[i] = partOne[i];
                //}
                //for (int j = partOneFilePath.Length; j < partOneFilePath.Length + partTwoFilePath.Length; j++)
                //{
                //    combine[j] = partTwo[j - partOneFilePath.Length];
                //}
                output.Write(partOne,0, partOne.Length);
                output.Write(partTwo,0, partTwo.Length);
            }
        }
    }
}