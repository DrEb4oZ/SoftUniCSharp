using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double firstTirePressure, int firstTireAge, double secondTirePressure, int secondTireAge, double thirdTirePressure, int thirdTireAge, double fourthTirePressure, int fourthTireAge)
        {
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo()
            {
                Type = cargoType,
                Weight = cargoWeight
            };
            Tires = new Tire[4];
            Tires[0] = new Tire(firstTireAge,firstTirePressure);
            Tires[1] = new Tire(secondTireAge,secondTirePressure);
            Tires[2] = new Tire(thirdTireAge,thirdTirePressure);
            Tires[3] = new Tire(fourthTireAge,fourthTirePressure);
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }

        public Cargo Cargo
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }
        }

        public Tire[] Tires
        {
            get
            {
                return this.tires;
            }
            set
            {
                this.tires = value;
            }
        }
    }
}
