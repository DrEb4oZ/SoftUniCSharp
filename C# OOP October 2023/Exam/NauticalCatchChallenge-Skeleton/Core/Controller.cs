using NauticalCatchChallenge.Core.Contracts;
using NauticalCatchChallenge.Models;
using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories;
using NauticalCatchChallenge.Repositories.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NauticalCatchChallenge.Core
{
    public class Controller : IController
    {
        private IRepository<IDiver> divers;
        private IRepository<IFish> fishes;
        private string[] diverTypes = { "FreeDiver", "ScubaDiver" };
        private string[] fishTypes = { "ReefFish", "PredatoryFish", "DeepSeaFish" };
        public Controller()
        {
            divers = new DiverRepository();
            fishes = new FishRepository();
        }
        public string ChaseFish(string diverName, string fishName, bool isLucky)
        {
            if(divers.GetModel(diverName) == null)
            {
                return string.Format(OutputMessages.DiverNotFound, divers.GetType().Name, diverName);
            }

            if (fishes.GetModel(fishName) == null)
            {
                return string.Format(OutputMessages.FishNotAllowed, fishName);
            }

            IDiver diver = divers.GetModel(diverName);
            IFish fish = fishes.GetModel(fishName);

            if (diver.HasHealthIssues)
            {
                return string.Format(OutputMessages.DiverHealthCheck, diverName);
            }

            if(diver.OxygenLevel < fish.TimeToCatch)
            {
                diver.Miss(fish.TimeToCatch);
                if (diver.OxygenLevel <= 0)
                {
                    diver.UpdateHealthStatus();
                }
                return string.Format(OutputMessages.DiverMisses, diverName, fishName);
            }

            else if(diver.OxygenLevel == fish.TimeToCatch)
            {
                if (isLucky)
                {
                    diver.Hit(fish);
                    if (diver.OxygenLevel <= 0)
                    {
                        diver.UpdateHealthStatus();
                    }
                    return string.Format(OutputMessages.DiverHitsFish, diverName, fish.Points, fishName);
                }
                else
                {
                    diver.Miss(fish.TimeToCatch);
                    if (diver.OxygenLevel <= 0)
                    {
                        diver.UpdateHealthStatus();
                    }
                    return string.Format(OutputMessages.DiverMisses, diverName, fishName);
                }
            }

            else if (diver.OxygenLevel > fish.TimeToCatch)
            {
                diver.Hit(fish);
                if (diver.OxygenLevel <= 0)
                {
                    diver.UpdateHealthStatus();
                }
                return string.Format(OutputMessages.DiverHitsFish, diverName, fish.Points, fishName);
            }


            return default; //??? check it later
        }

        public string CompetitionStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**Nautical-Catch-Challenge**");
            foreach (var diver in divers.Models
                .OrderByDescending(d => d.CompetitionPoints)
                .ThenByDescending(d => d.Catch.Count)
                .ThenBy(d => d.Name))
            {
                if (!diver.HasHealthIssues)
                {
                    sb.AppendLine(diver.ToString());
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            if (!diverTypes.Contains(diverType))
            {
                return string.Format(OutputMessages.DiverTypeNotPresented, diverType);
            }

            IDiver diver = divers.GetModel(diverName);
            if(diver != null) 
            {
                return string.Format(OutputMessages.DiverNameDuplication, diverName, divers.GetType().Name);
            }

            if(diverType == "FreeDiver")
            {
                diver = new FreeDiver(diverName);
            }
            
            else if (diverType == "ScubaDiver")
            {
                diver = new ScubaDiver(diverName);
            }

            divers.AddModel(diver);
            return string.Format(OutputMessages.DiverRegistered, diverName, divers.GetType().Name);
        }

        public string DiverCatchReport(string diverName)
        {
            IDiver diver = divers.GetModel(diverName);   // there is no check if it exist
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Diver [ Name: {diver.Name}, Oxygen left: {diver.OxygenLevel}, Fish caught: {diver.Catch.Count}, Points earned: {diver.CompetitionPoints} ]");
            sb.AppendLine("Catch Report:");
            FishRepository fishCought = new FishRepository();
            foreach (var fish in diver.Catch)
            {
                IFish currentFish = fishes.GetModel(fish);
                fishCought.AddModel(currentFish);
            }
            foreach (var fish in fishCought.Models)
            {
                sb.AppendLine(fish.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string HealthRecovery()
        {
            var diversWithHealthIssues = divers.Models.Where(d => d.HasHealthIssues == true);
            int recoveredDiversCounter = 0;
            foreach (var  diver in diversWithHealthIssues)
            {
                diver.UpdateHealthStatus();
                diver.RenewOxy();
                recoveredDiversCounter++;
            }
            return string.Format(OutputMessages.DiversRecovered, recoveredDiversCounter);
        }

        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
            if (!fishTypes.Contains(fishType))
            {
                return string.Format(OutputMessages.FishTypeNotPresented, fishType);
            }

            IFish fish = fishes.GetModel(fishName);
            if (fish != null)
            {
                return string.Format(OutputMessages.FishNameDuplication, fishName, fishes.GetType().Name);
            }

            if(fishType == "ReefFish")
            {
                fish = new ReefFish(fishName, points);
            }
            
            else if (fishType == "PredatoryFish")
            {
                fish = new PredatoryFish(fishName, points);
            }

            else if (fishType == "DeepSeaFish")
            {
                fish = new DeepSeaFish(fishName, points);
            }

            fishes.AddModel(fish);
            return string.Format(OutputMessages.FishCreated, fishName);
        }
    }
}
