using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator.Models
{
    public class Team
    {
        private const string EmptyNameException = "A name should not be empty.";
        private const string PlayerDoesntExistException = "Player {0} is not in {1} team.";
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            players = new List<Player>();
            Name = name;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(EmptyNameException);
                }
                name = value;
            }
        }

        public double Rating
        {
            get
            {
                if (players.Any())
                {
                    return Math.Round(players.Average(p => p.Stats),0);

                }
                return 0;
            }
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            Player player = players.FirstOrDefault(p => p.Name == playerName);
            if (player != null)
            {
                players.Remove(player);
            }
            else
            {
                throw new ArgumentException(string.Format(PlayerDoesntExistException, playerName, Name));
            }
        }
    }
}
