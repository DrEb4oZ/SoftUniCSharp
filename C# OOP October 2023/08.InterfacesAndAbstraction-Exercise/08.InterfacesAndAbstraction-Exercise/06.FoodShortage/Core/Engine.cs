using FoodShortage.Core.Interfaces;
using FoodShortage.IO.Interfaces;
using FoodShortage.Models;
using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        public Engine(IReader redaer, IWriter writer)
        {
            this.reader = redaer;
            this.writer = writer;
        }

        public void Run()
        {
            int peopleCount = int.Parse(reader.ReadLine());
            List<IBuyer> people = new List<IBuyer>();
            for (int i = 0; i < peopleCount; i++)
            {
                string[] tokens = reader.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                IBuyer person = default;
                switch (tokens.Count())
                {
                    case 4:
                        string citizenName = tokens[0];
                        int citizenAge = int.Parse(tokens[1]);
                        string citizenId = tokens[2];
                        string citizenBirthdate = tokens[3];
                        person = new Citizen(citizenName, citizenAge, citizenId, citizenBirthdate);
                        break;
                    case 3:
                        string rebelName = tokens[0];
                        int rebelAge = int.Parse(tokens[1]);
                        string rebelGroup = tokens[2];
                        person = new Rebel(rebelName, rebelAge, rebelGroup);
                        break;

                }

                people.Add(person);
            }
            string personName = string.Empty;
            while ((personName = reader.ReadLine()) != "End")
            {
                IBuyer currentPerson = people.FirstOrDefault(p => p.Name == personName);
                if (currentPerson != null)
                {
                    currentPerson.BuyFood();
                }
            }
            writer.WriteLine(people.Sum(p => p.Food).ToString());
        }
    }
}
