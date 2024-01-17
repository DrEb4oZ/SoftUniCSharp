using MilitaryElite.Core.Contracts;
using MilitaryElite.Enums;
using MilitaryElite.IO.Contracts;
using MilitaryElite.Models;
using MilitaryElite.Models.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader reader, IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            Dictionary<int, ISoldier> privateers = new Dictionary<int, ISoldier>();

            string command = string.Empty;
            while ((command = reader.ReadLine()) != "End")
            {
                try
                {
                    string[] commandTokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string soldierType = commandTokens[0];
                    int id = int.Parse(commandTokens[1]);
                    string firstName = commandTokens[2];
                    string lastName = commandTokens[3];

                    ISoldier soldier = null;
                    switch (soldierType)
                    {
                        case "Private":
                            soldier = CreatePrivate(id, firstName, lastName, commandTokens);
                            privateers.Add(id, soldier);
                            break;
                        case "LieutenantGeneral":
                            soldier = CreateLieutenantGeneral(id, firstName, lastName, commandTokens, privateers);
                            break;
                        case "Engineer":
                            soldier = CreateEngineer(id, firstName, lastName, commandTokens);
                            break;
                        case "Commando":
                            soldier = CreateCommando(id, firstName, lastName, commandTokens);
                            break;
                        case "Spy":
                            soldier = CreateSpy(id, firstName, lastName, commandTokens);
                            break;

                    }
                    writer.WriteLine(soldier.ToString());
                }
                catch (Exception)
                {
                }
                

            }
        }

        

        private ISoldier CreatePrivate(int id, string firstName, string lastName, string[] commandTokens)
        {
            decimal salary = decimal.Parse(commandTokens[4]);
            return new Private(id, firstName, lastName, salary);
        }

        private ISoldier CreateLieutenantGeneral(int id, string firstName, string lastName, string[] commandTokens, Dictionary<int, ISoldier> privateers)
        {
            decimal salary = decimal.Parse(commandTokens[4]);
            List<IPrivate> privates = new List<IPrivate>();
            for (int i = 5; i < commandTokens.Length; i++)
            {
                IPrivate currentPrivate = (IPrivate)privateers[int.Parse(commandTokens[i])];
                privates.Add(currentPrivate);
            }
            return new LieutenantGeneral(id, firstName, lastName, salary, privates.AsReadOnly());
        }
        private ISoldier CreateEngineer(int id, string firstName, string lastName, string[] commandTokens)
        {
            decimal salary = decimal.Parse(commandTokens[4]);
            bool isValidCorps = Enum.TryParse(commandTokens[5], out Corps corps);

            if (!isValidCorps)
            {
                throw new Exception();
            }

            List<IRepair> repairs = new List<IRepair>();

            for (int i = 6; i < commandTokens.Length; i+=2)
            {
                string partName = commandTokens[i];
                int hoursWorked = int.Parse(commandTokens[i + 1]);
                IRepair repair = new Repair(partName, hoursWorked);
                repairs.Add(repair);
            }

            return new Engineer(id, firstName, lastName, salary, corps, repairs);

        }

        private ISoldier CreateCommando(int id, string firstName, string lastName, string[] commandTokens)
        {
            decimal salary = decimal.Parse(commandTokens[4]);
            bool isValidCorps = Enum.TryParse(commandTokens[5], out Corps corps);
            if (!isValidCorps)
            {
                throw new Exception();
            }
            List<IMission> missions = new List<IMission>();

            for (int i = 6; i < commandTokens.Length; i+=2)
            {
                string missionName = commandTokens[i];
                bool isValidMission = Enum.TryParse(commandTokens[i + 1], out State state);
                if (!isValidMission)
                {
                    continue;
                }
                IMission currentMission = new Mission(missionName, state);
                missions.Add(currentMission);
            }

            return new Commando(id,firstName,lastName,salary,corps, missions);

        }

        private ISoldier CreateSpy(int id, string firstName, string lastName, string[] commandTokens)
        {
            int codeNumber = int.Parse(commandTokens[4]);
            return new Spy(id, firstName, lastName, codeNumber);
        }
    }
}
