namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> inputs = new SortedDictionary<string, List<FileInfo>>();
            string[] files = Directory.GetFiles(inputFolderPath);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (!inputs.ContainsKey(fileInfo.Extension))
                {
                    inputs.Add(fileInfo.Extension, new List<FileInfo>());
                }
                inputs[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder sb = new StringBuilder();
            foreach (var input in inputs.OrderByDescending(x => x.Value.Count))
            {
                sb.AppendLine(input.Key);
                foreach (var info in input.Value.OrderBy(x => x.Length))
                {
                    sb.AppendLine($"--{info.Name} - {(double)info.Length / 1024:f3}kb");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

            File.WriteAllText(filePath, textContent);
        }
    }
}
