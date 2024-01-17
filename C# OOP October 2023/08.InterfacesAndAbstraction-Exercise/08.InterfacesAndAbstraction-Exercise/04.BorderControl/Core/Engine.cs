using BorderControl.Core.Interfaces;
using BorderControl.IO.Interfaces;
using BorderControl.Models;
using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Core
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
            string command = string.Empty;
            List<IId> borderPassers = new List<IId>();
            while ((command = reader.ReadLine()) != "End")
            {
                string[] tokens = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                IId passer;
                switch (tokens.Length)
                {
                    case 3:
                        string citizenName = tokens[0];
                        int citizenAge = int.Parse(tokens[1]);
                        string citizenId = tokens[2];
                        passer = new Citizen(citizenName, citizenAge, citizenId);
                        borderPassers.Add(passer);
                        break;
                    case 2:
                        string robotModel = tokens[0];
                        string robotId = tokens[1];
                        passer = new Robot(robotModel, robotId);
                        borderPassers.Add(passer);
                        break;
                }
            }
            string fakeIds = reader.ReadLine();
            List<IId> fakeIdPassers = new List<IId>();
            foreach (var borderPasser in borderPassers)
            {
                if (fakeIds == borderPasser.Id.Substring(borderPasser.Id.Length - fakeIds.Length))
                {
                    fakeIdPassers.Add(borderPasser);
                }
            }
            foreach (var fakeIdPasser in fakeIdPassers)
            {
                writer.WriteLine(fakeIdPasser.Id);
            }

        }
    }
}
