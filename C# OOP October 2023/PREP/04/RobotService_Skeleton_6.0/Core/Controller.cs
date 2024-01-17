using RobotService.Core.Contracts;
using RobotService.Models;
using RobotService.Models.Contracts;
using RobotService.Repositories;
using RobotService.Repositories.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private IRepository<ISupplement> supplements;
        private IRepository<IRobot> robots;
        private string[] robotTypes = { "DomesticAssistant", "IndustrialAssistant" };
        private string[] supplementTypes = { "LaserRadar", "SpecializedArm" };
        public Controller()
        {
            supplements = new SupplementRepository();
            robots = new RobotRepository();
        }
        public string CreateRobot(string model, string typeName)
        {
            if (!robotTypes.Contains(typeName))
            {
                return string.Format(OutputMessages.RobotCannotBeCreated, typeName);
            }
            IRobot robot = null;
            if (typeName == "DomesticAssistant")
            {
                robot = new DomesticAssistant(model);
            }

            else if (typeName == "IndustrialAssistant")
            {
                robot = new IndustrialAssistant(model);
            }

            robots.AddNew(robot);
            return string.Format(OutputMessages.RobotCreatedSuccessfully, typeName, model);
        }

        public string CreateSupplement(string typeName)
        {
            if (!supplementTypes.Contains(typeName))
            {
                return string.Format(OutputMessages.SupplementCannotBeCreated, typeName);
            }

            ISupplement supplement = null;
            if (typeName == "LaserRadar")
            {
                supplement = new LaserRadar();
            }

            else if (typeName == "SpecializedArm")
            {
                supplement = new SpecializedArm();
            }

            supplements.AddNew(supplement);
            return string.Format(OutputMessages.SupplementCreatedSuccessfully, typeName);
        }

        public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded)
        {
            IRepository<IRobot> filteredRobots = new RobotRepository();
            foreach (var robot in robots.Models())
            {
                if (robot.InterfaceStandards.Any(s => s == intefaceStandard))
                {
                    filteredRobots.AddNew(robot);
                }
            }

            if (filteredRobots.Models().Count == 0)
            {
                return string.Format(OutputMessages.UnableToPerform, intefaceStandard);
            }

            int sum = filteredRobots.Models().OrderByDescending(r => r.BatteryLevel).Sum(r => r.BatteryLevel);
            int robotCount = 0;
            if ( sum < totalPowerNeeded)
            {
                return string.Format(OutputMessages.MorePowerNeeded, serviceName, totalPowerNeeded - sum);
            }

            else
            {
                foreach (var robot in filteredRobots.Models().OrderByDescending(r => r.BatteryLevel))
                {
                    if (robot.BatteryLevel >= totalPowerNeeded)
                    {
                        robot.ExecuteService(totalPowerNeeded);
                        robotCount++;
                        break;
                    }
                    totalPowerNeeded -= robot.BatteryLevel;
                    robot.ExecuteService(robot.BatteryLevel);
                    robotCount++;
                }
                return string.Format(OutputMessages.PerformedSuccessfully, serviceName, robotCount);
            }
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var robot in robots.Models().OrderByDescending(r => r.BatteryLevel).ThenBy(r => r.BatteryCapacity))
            {
                sb.AppendLine(robot.ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string RobotRecovery(string model, int minutes)
        {
            int fedRobotCount = 0;
            foreach (var robot in robots.Models().Where(r => r.Model == model && r.BatteryLevel <= (50 /100 * r.BatteryCapacity)))
            {
                robot.Eating(minutes);
                fedRobotCount++;
            }

            return string.Format(OutputMessages.RobotsFed, fedRobotCount);
        }

        public string UpgradeRobot(string model, string supplementTypeName)
        {
            ISupplement supplement = supplements.Models().FirstOrDefault(s => s.GetType().Name == supplementTypeName);
            IRepository<IRobot> filteredRobots = new RobotRepository();
            foreach (var robot in robots.Models())
            {
                if ((!robot.InterfaceStandards.Any(s => s == supplement.InterfaceStandard)) && robot.Model == model)
                {
                    filteredRobots.AddNew(robot);
                }
            }

            if (filteredRobots.Models().Count == 0)
            {
                return string.Format(OutputMessages.AllModelsUpgraded, model);
            }

            else
            {
                filteredRobots.Models().First().InstallSupplement(supplement);
                supplements.RemoveByName(supplementTypeName);
                return string.Format(OutputMessages.UpgradeSuccessful, model, supplementTypeName);
            }
        }
    }
}
