namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int songCount = int.Parse(Console.ReadLine());
            List<SongList> songs = new List<SongList>();

            for (int i = 0; i < songCount; i++)
            {
                string[] currentSong = Console.ReadLine()
                    .Split("_")
                    .ToArray();
                string typeList = currentSong[0];
                string songName = currentSong[1];
                string time = currentSong[2];
                SongList songToAdd = new SongList(typeList, songName, time);
                songs.Add(songToAdd);
            }

            string command = Console.ReadLine();
            if (songs.Exists(s => s.TypeList == command)) // code provided via Chat GPT държах да е с конкретна команд не просто else или както пъвоначално го направих command != "all"
            {
                List<SongList> typeSortedList = songs
                    .Where(t => t.TypeList == command)
                    .ToList();
                foreach (SongList song in typeSortedList)
                {
                    Console.WriteLine(song.Name);
                }
            }

            else if (command == "all")
            {
                foreach (SongList song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }


    class SongList
    {
        public SongList(string typeList, string songName, string time)
        {
            TypeList = typeList;
            Name = songName;
            Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}