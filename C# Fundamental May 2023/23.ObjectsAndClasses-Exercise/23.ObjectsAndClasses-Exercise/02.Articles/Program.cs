using System.ComponentModel.DataAnnotations;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine()
                .Split(", ")
                .ToArray();
            string title = article[0];
            string content = article[1];
            string author = article[2];
            Articles currentArticle = new Articles(title, content, author);
            int operationCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < operationCount; i++)
            {
                string[] operationType = Console.ReadLine().Split(": ").ToArray();
                string currentOperation = operationType[0];
                string currentOperationValue = operationType[1];
                if (currentOperation == "Edit")
                {
                    currentArticle.Edit(currentOperationValue);
                }

                else if (currentOperation == "ChangeAuthor")
                {
                    currentArticle.ChangeAuthor(currentOperationValue);
                }

                else if (currentOperation == "Rename")
                {
                    currentArticle.Rename(currentOperationValue);
                }
            }

            Console.WriteLine(currentArticle.PrintResult());
        }
    }
    public class Articles
    {
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public string Edit(string content)
        {
            return Content = content;
        }

        public string ChangeAuthor(string content)
        {
            return Author = content;
        }

        public string Rename(string content)
        {
            return Title = content;
        }

        public string PrintResult()
        {
            string result = $"{Title} - {Content}: {Author}";
            return result;
        }
    }
}