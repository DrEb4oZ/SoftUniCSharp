using FootballTeamGenerator.Models;
using System.Net.Http.Headers;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] commandTokens = command
                                        .Split(";", StringSplitOptions.RemoveEmptyEntries);
                    string currentCommand = commandTokens[0];
                    string teamName = commandTokens[1];
                    switch (currentCommand)
                    {

                        case "Team":
                            teams.Add(new Team(teamName));
                            break;

                        case "Add":
                            string addPlayerName = commandTokens[2];
                            int addPlayerEndurance = int.Parse(commandTokens[3]);
                            int addPlayerSprint = int.Parse(commandTokens[4]);
                            int addPlayerDribble = int.Parse(commandTokens[5]);
                            int addPlayerPassing = int.Parse(commandTokens[6]);
                            int addPlayerShooting = int.Parse(commandTokens[7]);

                            if (!teams.Any(t => t.Name == teamName))
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                                break;
                            }
                            Team addPlayerTeam = teams.FirstOrDefault(t => t.Name == teamName);
                            addPlayerTeam.AddPlayer(new Player(addPlayerName, addPlayerEndurance, addPlayerSprint, addPlayerDribble, addPlayerPassing, addPlayerShooting));
                            break;

                        case "Remove":
                            string removePlayerName = commandTokens[2];
                            if (!teams.Any(t => t.Name == teamName))
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                                break;
                            }
                            Team removePlayerTeam = teams.FirstOrDefault(t => t.Name == teamName);
                            removePlayerTeam.RemovePlayer(removePlayerName);
                            break;

                        case "Rating":
                            if (!teams.Any(t => t.Name == teamName))
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                                break;
                            }
                            Team getRatingTeam = teams.FirstOrDefault(t => t.Name == teamName);
                            Console.WriteLine($"{getRatingTeam.Name} - {getRatingTeam.Rating}");
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}