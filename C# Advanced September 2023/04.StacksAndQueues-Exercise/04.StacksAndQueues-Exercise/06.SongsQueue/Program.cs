namespace _06.SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                .Split(", ");
            Queue<string> songsQueue = new Queue<string>(songs);
            bool isSongsListEmpty = false;
            while (!isSongsListEmpty)
            {
                string[] command = Console.ReadLine()
                    .Split();
                switch (command[0])
                {
                    case "Play":
                        if (songsQueue.Count > 0)
                        {
                            songsQueue.Dequeue();
                        }

                        if (songsQueue.Count == 0)
                        {
                            isSongsListEmpty = true;
                            Console.WriteLine("No more songs!");
                        }

                        break;

                    case "Add":
                        string currentSong = string.Join(" ", command.Skip(1));
                        if (songsQueue.Contains(currentSong))
                        {
                            Console.WriteLine($"{currentSong} is already contained!");
                        }

                        else
                        {
                            songsQueue.Enqueue(currentSong);
                        }

                        break;

                    case "Show":
                        Console.WriteLine(string.Join(", ", songsQueue));
                        break;
                }
            }
        }
    }
}