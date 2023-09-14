using System.Xml.Linq;
/*
New follower: George
Like: George: 5
New follower: George
Log out
*/
namespace _03.Followers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            Dictionary<string, Follower> followers = new Dictionary<string, Follower>();
            while ((command = Console.ReadLine()) != "Log out")
            {
                string[] commandTokens = command
                    .Split(": ");
                string currentCommand = commandTokens[0];
                string username = commandTokens[1];
                switch (currentCommand)
                {
                    case "New follower":
                        AddNewFollower(followers, username);
                        break;
                    case "Like":
                        int likeCount = int.Parse(commandTokens[2]);
                        AddLikes(followers, username, likeCount);
                        break;
                    case "Comment":
                        AddComment(followers, username);
                        break;
                    case "Blocked":
                        RemoveFollower(followers, username);
                        break;
                }
            }

            Console.WriteLine($"{followers.Count} followers");
            foreach (Follower follower in followers.Values)
            {
                Console.WriteLine($"{follower.Name}: {follower.LikesCount + follower.CommentsCount}");
            }
        }

        private static void RemoveFollower(Dictionary<string, Follower> followers, string username)
        {
            if (followers.ContainsKey(username))
            {
                followers.Remove(username);
            }

            else
            {
                Console.WriteLine($"{username} doesn't exist.");
            }
        }

        private static void AddComment(Dictionary<string, Follower> followers, string username)
        {
            if (!followers.ContainsKey(username))
            {
                Follower currentFollower = new Follower(username, 0, 1);
                followers.Add(username, currentFollower);
            }

            else
            {
                followers[username].CommentsCount++;
            }
        }

        private static void AddLikes(Dictionary<string, Follower> followers, string username, int likeCount)
        {
            if (!followers.ContainsKey(username))
            {
                Follower currentFollower = new Follower(username, likeCount, 0);
                followers.Add(username, currentFollower);
            }

            else
            {
                followers[username].LikesCount += likeCount;
            }
        }

        private static void AddNewFollower(Dictionary<string, Follower> followers, string username)
        {
            if (!followers.ContainsKey(username))
            {
                Follower currentFollower = new Follower(username, 0, 0);
                followers.Add(username, currentFollower);
            }
        }
    }
    
    public class Follower
    {
        public Follower(string name, int likesCount, int commentsCount)
        {
            Name = name;
            LikesCount = likesCount;
            CommentsCount = commentsCount;
        }

        public string Name { get; set; }
        public int LikesCount { get; set; }
        public int CommentsCount { get; set; }
    }
}