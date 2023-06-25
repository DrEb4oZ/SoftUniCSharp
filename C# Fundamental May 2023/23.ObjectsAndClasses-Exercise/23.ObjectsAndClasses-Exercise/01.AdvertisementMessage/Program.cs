namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            //int advertisementCount = int.Parse(Console.ReadLine());
            //for (int i = 0; i < advertisementCount; i++)
            //{
            //    List<string> fakeAdvertisement = new List<string>();
            //    Random rnd = new Random();
            //    fakeAdvertisement.Add(phrases[rnd.Next(0, phrases.Count)]);
            //    fakeAdvertisement.Add(events[rnd.Next(0, events.Count)]);
            //    fakeAdvertisement.Add(authors[rnd.Next(0, authors.Count)]);
            //    fakeAdvertisement.Add(cities[rnd.Next(0, cities.Count)]);
            //    Console.WriteLine($"{fakeAdvertisement[0]} {fakeAdvertisement[1]} {fakeAdvertisement[2]} – {fakeAdvertisement[3]}.");
            //}
            Advertisement fakeAddvertisement = new Advertisement();
            fakeAddvertisement.Phrases = phrases;
            fakeAddvertisement.Events = events;
            fakeAddvertisement.Authors = authors;
            fakeAddvertisement.Cities = cities;
            int advertisementCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < advertisementCount; i++)
            {
                Random rnd = new Random();
                string phrase = fakeAddvertisement.Phrases[rnd.Next(0, fakeAddvertisement.Phrases.Count)];
                string @event = fakeAddvertisement.Events[rnd.Next(0, fakeAddvertisement.Events.Count)];
                string author = fakeAddvertisement.Authors[rnd.Next(0, fakeAddvertisement.Authors.Count)];
                string city = fakeAddvertisement.Cities[rnd.Next(0, fakeAddvertisement.Cities.Count)];
                Console.WriteLine($"{phrase} {@event} {author} – {city}.");
            }
        }
        public class Advertisement
        {

            public List<string> Phrases { get; set; }

            public List<string> Events { get; set; }

            public List<string> Authors { get; set; }

            public List<string> Cities { get; set; }
        }
    }
}