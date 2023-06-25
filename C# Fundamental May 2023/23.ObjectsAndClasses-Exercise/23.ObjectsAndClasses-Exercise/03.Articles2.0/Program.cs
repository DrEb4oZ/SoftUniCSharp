using System.ComponentModel.DataAnnotations;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Articles> articles = new List<Articles>();
            int operationCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < operationCount; i++)
            {
                string[] newArticleInput = Console.ReadLine().Split(", ").ToArray();
                string title = newArticleInput[0];
                string content = newArticleInput[1];
                string author = newArticleInput[2];
                Articles currentArticle = new Articles(title, content, author);
                articles.Add(currentArticle);
            }

            foreach (Articles article in articles)
            {
                Console.WriteLine(article.PrintResult());
            }
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


        public string PrintResult()
        {
            string result = $"{Title} - {Content}: {Author}";
            return result;
        }
    }
}