using System;

namespace Basketball
{
    public class Team
    {
        public class Team
        {
            public Team(string name, int openPositions, char group)
            {
                Name = name;
                OpenPositions = openPositions;
                Group = group;
                Players = new List<Player>();
                MaxPosition = openPositions;
            }

            public string Name { get; set; }

            public int OpenPositions { get; set; }

            public char Group { get; set; }

            public List<Player> Players { get; set; }

            public int Count => Players.Count;

            public int MaxPosition { get; private set; }

            public string AddPlayer(Player player)
            {
                if (player.Name == null && player.Position == null)
                {
                    return "Invalid player's information.";
                }

                else if (Players.Count >= MaxPosition)
                {
                    return "There are no more open positions.";
                }

                else if (player.Rating < 80)
                {
                    return "Invalid player's rating.";
                }

                else
                {
                    Players.Add(player);
                    OpenPositions--;
                    return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}";
                }
            }

            public bool RemovePlayer(string name)
            {
                bool result = Players.Remove(Players.FirstOrDefault(p => p.Name == name));
                if (result)
                {
                    OpenPositions--;
                }
                return result;
            }

            public int RemovePlayerByPosition(string position)
            {
                int removedPlayers = Players.RemoveAll(p => p.Position == position);
                if (removedPlayers > 0)
                {
                    OpenPositions -= removedPlayers;
                }
                return removedPlayers;
            }

            public Player RetirePlayer(string name)
            {
                Player player = Players.FirstOrDefault(p => p.Name == name);
                player.Retired = true;
                return player;
            }

            public List<Player> AwardPlayers(int games)
            {
                List<Player> awardedPlayers = new List<Player>();
                foreach (Player player in Players)
                {
                    if (player.Games >= games)
                    {
                        awardedPlayers.Add(player);
                    }
                }
                return awardedPlayers;
            }

            public string Report()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");
                foreach (Player player in Players)
                {
                    if (!player.Retired)
                    {
                        sb.AppendLine(player.ToString());
                    }
                }
                return sb.ToString().TrimEnd();
            }
        }
    }
}
