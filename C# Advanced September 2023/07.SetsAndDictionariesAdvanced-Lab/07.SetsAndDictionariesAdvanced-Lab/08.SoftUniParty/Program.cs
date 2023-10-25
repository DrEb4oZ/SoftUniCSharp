namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> regulars = new HashSet<string>();
            HashSet<string> vIPs = new HashSet<string>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "PARTY")
            {
                if (command != "PARTY")
                {
                    guests.Add(command);
                }
            }
            while ((command = Console.ReadLine()) != "END")
            {
                if (guests.Contains(command) && char.IsDigit(command[0]))
                {
                    guests.Remove(command);
                }

                else if (guests.Contains(command))
                {
                    guests.Remove(command);
                }
            }
            foreach (var guest in guests)
            {
                if (char.IsDigit(guest[0]))
                {
                    vIPs.Add(guest);
                }
                else
                {
                    regulars.Add(guest);
                }
            }
            Console.WriteLine(guests.Count);
            foreach (var vip in vIPs)
            {
                Console.WriteLine(vip);
            }

            foreach (var regular in regulars)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
