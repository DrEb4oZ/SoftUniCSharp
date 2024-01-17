using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public abstract class Diver : IDiver
    {
        private string name;
        private int oxygenLevel;
        private List<string> catchList;
        private double competitionPoints;
        private bool hasHealthIssues;

        protected Diver(string name, int oxygenLevel)
        {
            Name = name;
            OxygenLevel = oxygenLevel;
            catchList = new List<string>();
            competitionPoints = 0;
            hasHealthIssues = false;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.DiversNameNull);
                }
                name = value;
            }
        }

        public int OxygenLevel
        {
            get => oxygenLevel;
            protected set
            {
                if (value < 0)
                {
                    oxygenLevel = 0;
                }
                oxygenLevel = value;
            }
        }

        public IReadOnlyCollection<string> Catch => catchList.AsReadOnly();

        public double CompetitionPoints
        {
            get => competitionPoints;
            private set
            {
                if (value % 10 == 0)
                {
                    competitionPoints = value;
                }
                else
                {
                    competitionPoints = Math.Round(value, 1);

                }
            }
        }

        public bool HasHealthIssues
        {
            get => hasHealthIssues;
            private set
            {
                hasHealthIssues = value;
            }
        }

        public void Hit(IFish fish)
        {
            oxygenLevel -= fish.TimeToCatch;
            catchList.Add(fish.Name);
            competitionPoints += fish.Points;
            if (competitionPoints % 10 != 0)
            {
                competitionPoints = Math.Round(competitionPoints, 1);
            }
        }

        public abstract void Miss(int TimeToCatch);

        public abstract void RenewOxy();

        public void UpdateHealthStatus()
        {
            if (hasHealthIssues)
            {
                hasHealthIssues = false;
            }
            else
            {
                hasHealthIssues = true;
            }
        }
        public override string ToString()
        {
            return $"Diver [ Name: {Name}, Oxygen left: {OxygenLevel}, Fish caught: {catchList.Count}, Points earned: {CompetitionPoints} ]";
        }
    }
}
