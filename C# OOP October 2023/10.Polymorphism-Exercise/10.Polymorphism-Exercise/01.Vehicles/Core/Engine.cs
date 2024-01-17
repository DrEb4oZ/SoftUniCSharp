using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Core.Interfaces;
using Vehicles.Factories;
using Vehicles.Factories.Inferfaces;
using Vehicles.IO.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IVehicleFactory vehicleFactory;
        private ICollection<IVehicle> vehicles;

        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
            vehicles = new List<IVehicle>();
        }

        public void Run()
        {
            vehicles.Add(CreateVehicle());
            vehicles.Add(CreateVehicle());

            int commandsCount = int.Parse(reader.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                try
                {
                    ProcessCommand();
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }

            }
            foreach (var vehicle in vehicles)
            {
                writer.WriteLine(vehicle);
            }
        }

        private void ProcessCommand()
        {
            string[] commandTokens = reader.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string commandType = commandTokens[0];
            string vehicleType = commandTokens[1];
            double value = double.Parse(commandTokens[2]);
            IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType);
            if (vehicle == null)
            {
                throw new ArgumentException("Invalid vehicle type");
            }
            switch (commandType)
            {
                case "Drive":
                    writer.WriteLine(vehicle.Drive(value));
                    break;

                case "Refuel":
                    vehicle.Refuel(value);
                    break;
            }
        }

        private IVehicle CreateVehicle()
        {
            string[] tokens = reader.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return vehicleFactory.Create(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2]));
        }
    }
}
