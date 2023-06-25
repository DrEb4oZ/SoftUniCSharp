namespace TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] teamData = Console.ReadLine().Split('-');
                string creator = teamData[0];
                string teamName = teamData[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creator);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string input;
            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] userData = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string member = userData[0];
                string teamName = userData[1];

                Team team = teams.FirstOrDefault(t => t.Name == teamName);
                if (team == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(t => t.Creator == member) || teams.Any(t => t.Members.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                team.Members.Add(member);
            }

            List<Team> validTeams = teams.Where(t => t.Members.Count > 0).ToList();
            List<Team> invalidTeams = teams.Where(t => t.Members.Count == 0).ToList();

            validTeams = validTeams
                .OrderBy(t => t.Name)
                .ToList();

            invalidTeams = invalidTeams
                .OrderBy(t => t.Name)
                .ToList();

            foreach (Team team in validTeams.OrderByDescending(t => t.Members.Count))
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team team in invalidTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    public class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }

        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            string result = $"{Name}" + Environment.NewLine;
            result += $"- {Creator}" + Environment.NewLine;
            foreach (string member in Members.OrderBy(m => m))
            {
                result += $"-- {member}" + Environment.NewLine;
            }
            return result.Trim();
        }
    }
}
