using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        private int capacity;
        private List<Vehicle> vehicles;

        public RepairShop(int capacity)
        {
            Capacity = capacity;
            vehicles = new List<Vehicle>();
        }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }

        public List<Vehicle> Vehicles
        {
            get
            {
                return this.vehicles;
            }
            set
            {
                this.vehicles = value;
            }
        }

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicles.Count < this.Capacity)
            {
                this.vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            if (this.vehicles.Any(v => v.VIN == vin))
            {
                Vehicles.Remove(Vehicles.FirstOrDefault(v => v.VIN == vin));
                return true;
            }


            return false;
        }

        public int GetCount()
        {
            return this.Vehicles.Count;
        }

        public Vehicle GetLowestMileage() => Vehicles.MinBy(v => v.Mileage);

        public string Report()
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine("Vehicles in the preparatory:");
            foreach (Vehicle vehicle in this.Vehicles)
            {
                report.AppendLine(vehicle.ToString());
            }

            return report.ToString().TrimEnd();
        }
    }
}
