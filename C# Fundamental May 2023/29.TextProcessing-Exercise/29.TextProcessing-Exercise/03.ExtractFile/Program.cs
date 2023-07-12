namespace _03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            int lastSlashIndex = filePath.LastIndexOf('\\');
            int lastDotIndex = filePath.LastIndexOf('.');
            string fileName = string.Empty;
            string fileExtension = string.Empty;
            if (lastSlashIndex < lastDotIndex)
            {
                fileExtension = filePath.Substring(lastDotIndex + 1);
                int fileNameLength = lastDotIndex - lastSlashIndex - 1;
                fileName = filePath.Substring(lastSlashIndex + 1, fileNameLength);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}