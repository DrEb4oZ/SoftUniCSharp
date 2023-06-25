namespace _05.TeamworkProjects

/*
5
John-PowerPuffsCoders
Tony-Tony is the best
Ton-Tony3 is the best
Pet2-Tony3 is the best
Pet1-Tony1 is the best
Peter->PowerPuffsCoders
Pet3->Tony is the best
Pet4->Tony is the best
Pet5->PowerPuffsCoders
end of assignment


0
George->softUni
George->SoftUni
Tatyana->Leda
John->SoftUni
Cossima->CloneClub
end of assignment
*/

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Teams> teams = new List<Teams>();
            for (int i = 0; i < teamCount; i++)
            {
                string[] newTeam = Console.ReadLine()
                    .Split("-")
                    .ToArray();
                string creator = newTeam[0];
                string name = newTeam[1];
                if (teams.Any(t => t.Name == name))
                {
                    Console.WriteLine($"Team {name} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                Teams currentTeam = new Teams(name, creator);
                teams.Add(currentTeam);
                Console.WriteLine($"Team {name} has been created by {creator}!");
            }

            string newMember;
            while ((newMember = Console.ReadLine()) != "end of assignment")
            {
                string[] currentMember = newMember
                    .Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string member = currentMember[0];
                string teamName = currentMember[1];
                Teams validTeam = teams.FirstOrDefault(t => t.Name == teamName);
                if (validTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(t => t.Creator == member) || teams.Any(t => t.Member.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                validTeam.Member.Add(member);
            }

            List<Teams> validTeams = teams.Where(t => t.Member.Count > 0).ToList();
            List<Teams> invalidTeams = teams.Where(t => t.Member.Count == 0).ToList();
            List<Teams> orderedValidTeams = validTeams
                .OrderByDescending(t => t.Member.Count)
                .ThenBy(t => t.Name)
                .ToList();
            List<Teams> orderedInvalidTeams = invalidTeams
                .OrderBy(t => t.Name)
                .ToList();
            foreach (Teams team in orderedValidTeams)
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("Teams to disband:");
            foreach (Teams team in orderedInvalidTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Teams
    {
        public Teams(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Member = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Member { get; set; }

        public override string ToString()
        {
            string result = "";
            result += $"{Name}\n";
            result += $"- {Creator}\n";
            foreach (string member in Member.OrderBy(t => t))
            {
                result += $"-- {member}\n";
            }
            return result.Trim();
        }
    }
}