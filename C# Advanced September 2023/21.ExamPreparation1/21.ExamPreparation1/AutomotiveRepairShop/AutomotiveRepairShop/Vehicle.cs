namespace AutomotiveRepairShop
{
    public class Vehicle
    {
        private string vin;
        private int mileage;
        private string damage;

        public Vehicle(string vin, int mileage, string damage)
        {
            VIN = vin;
            Mileage = mileage;
            Damage = damage;
        }

        public string VIN
        {
            get
            {
                return this.vin;
            }
            set
            {
                this.vin = value;
            }
        }

        public int Mileage
        {
            get
            {
                return this.mileage;
            }
            set
            {
                this.mileage = value;
            }
        }

        public string Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }

        public override string ToString()
        {
            return $"Damage: {this.Damage}, Vehicle: {this.VIN} ({this.Mileage} km)";
        }
    }
}
