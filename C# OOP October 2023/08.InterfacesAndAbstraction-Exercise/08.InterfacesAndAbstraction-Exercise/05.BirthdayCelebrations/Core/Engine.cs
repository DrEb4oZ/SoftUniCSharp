using BirthdayCelebrations.Core.Interfaces;
using BirthdayCelebrations.IO.Interfaces;
using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations.Core
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
            List<IBirthdate> citizensAndPets = new List<IBirthdate>();
            string command = string.Empty;
            while ((command = reader.ReadLine()) != "End")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string citizenType = tokens[0];
                IBirthdate birthdateCitizenAndPet;
                switch (citizenType)
                {
                    case "Citizen":
                        string citizenName = tokens[1];
                        int citizenAge = int.Parse(tokens[2]);
                        string citizenId = tokens[3];
                        string citizenBirthdate = tokens[4];
                        birthdateCitizenAndPet = new Citizen(citizenName, citizenAge, citizenId, citizenBirthdate);
                        citizensAndPets.Add(birthdateCitizenAndPet);
                        break;
                    case "Pet":
                        string petName = tokens[1];
                        string petBirthdate = tokens[2];
                        birthdateCitizenAndPet = new Pet(petName, petBirthdate);
                        citizensAndPets.Add(birthdateCitizenAndPet);
                        break;
                }
            }
            string yearToSearch = reader.ReadLine();
            List<IBirthdate> validCitizensAndPets = new List<IBirthdate>();
            foreach (var citizenAndPet in citizensAndPets)
            {
                if (citizenAndPet.Birthdate.EndsWith(yearToSearch))
                {
                    validCitizensAndPets.Add(citizenAndPet);
                }
            }

            foreach (var validCitizenAndPet in validCitizensAndPets)
            {
                writer.WriteLine(validCitizenAndPet.Birthdate);
            }
        }
    }
}
