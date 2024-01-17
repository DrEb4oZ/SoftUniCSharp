using Handball.Core.Contracts;
using Handball.Models;
using Handball.Models.Contracts;
using Handball.Repositories;
using Handball.Repositories.Contracts;
using Handball.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handball.Core
{
    public class Controller : IController
    {
        private IRepository<IPlayer> players;
        private IRepository<ITeam> teams;
        private List<string> playerTypes;

        public Controller()
        {
            players = new PlayerRepository();
            teams = new TeamRepository();
            playerTypes = new List<string> { "Goalkeeper", "CenterBack", "ForwardWing" };
        }
        public string LeagueStandings()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***League Standings***");
            foreach (var team in teams.Models.OrderByDescending(t => t.PointsEarned).ThenByDescending(t => t.OverallRating).ThenBy(t => t.Name))
            {
                sb.AppendLine(team.ToString());
            }
            return sb.ToString().Trim();
        }

        public string NewContract(string playerName, string teamName)
        {
            if (players.ExistsModel(playerName))
            {
                return string.Format(OutputMessages.PlayerNotExisting, playerName, typeof(PlayerRepository).Name);
            }

            if (teams.ExistsModel(teamName))
            {
                return string.Format(OutputMessages.TeamNotExisting, teamName, nameof(TeamRepository));
            }

            IPlayer player = players.GetModel(playerName);
            ITeam team = teams.GetModel(teamName);
            if (player.Team != null)
            {
                return string.Format(OutputMessages.PlayerAlreadySignedContract, playerName, player.Team);
            }

            player.JoinTeam(teamName);
            team.SignContract(player);
            return string.Format(OutputMessages.SignContract, playerName, teamName);
        }

        public string NewGame(string firstTeamName, string secondTeamName)
        {
            ITeam firstTeam = teams.GetModel(firstTeamName);
            ITeam secondTeam = teams.GetModel(secondTeamName);

            ITeam winingTeam = null;
            ITeam losingTeam = null;

            if (firstTeam.OverallRating != secondTeam.OverallRating)
            {
                if (firstTeam.OverallRating > secondTeam.OverallRating)
                {
                    winingTeam = firstTeam;
                    losingTeam = secondTeam;
                }

                else if (firstTeam.OverallRating < secondTeam.OverallRating)
                {
                    winingTeam = secondTeam;
                    losingTeam = firstTeam;

                }

                winingTeam.Win();
                losingTeam.Lose();

                return string.Format(OutputMessages.GameHasWinner, winingTeam.Name, losingTeam.Name);
            }

            else
            {
                firstTeam.Draw();
                secondTeam.Draw();
                return string.Format(OutputMessages.GameIsDraw, firstTeam.Name, secondTeam.Name);
            }
        }

        public string NewPlayer(string typeName, string name)
        {
            if (!playerTypes.Contains(typeName))
            {
                return string.Format(OutputMessages.InvalidTypeOfPosition, typeName);
            }

            IPlayer player = null;
            if (players.ExistsModel(name))
            {
                player = players.GetModel(name);
                return string.Format(OutputMessages.PlayerIsAlreadyAdded, name, typeof(PlayerRepository).Name, player.GetType().Name);
            }

            if (typeName == "Goalkeeper")
            {
                player = new Goalkeeper(name);
            }
            else if (typeName == "CenterBack")
            {
                player = new CenterBack(name);
            }
            else if (typeName == "ForwardWing")
            {
                player = new ForwardWing(name);
            }


            players.AddModel(player);
            return string.Format(OutputMessages.PlayerAddedSuccessfully, name);
        }

        public string NewTeam(string name)
        {
            ITeam team = new Team(name);
            if (teams.ExistsModel(name))
            {
                return string.Format(OutputMessages.TeamAlreadyExists, team.Name, typeof(TeamRepository).Name);
            }
            teams.AddModel(team);
            return string.Format(OutputMessages.TeamSuccessfullyAdded, team.Name, typeof(TeamRepository).Name);
        }

        public string PlayerStatistics(string teamName)
        {
            ITeam team = teams.GetModel(teamName);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"***{teamName}***");
            foreach (var player in team.Players.OrderByDescending(p => p.Rating).ThenBy(p => p.Name))
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
