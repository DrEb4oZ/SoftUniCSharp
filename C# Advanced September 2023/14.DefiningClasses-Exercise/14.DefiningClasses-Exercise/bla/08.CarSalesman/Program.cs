using System;
using System.Collections.Generic;
using System.Linq;
namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carsCount; i++)
            {
                string[] carProperties = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carProperties[0];
                int engineSpeed = int.Parse(carProperties[1]);
                int enginePower = int.Parse(carProperties[2]);
                int cargoWeight = int.Parse(carProperties[3]);
                string cargoType = carProperties[4];
                double firstTirePressure = double.Parse(carProperties[5]);
                int firstTireAge = int.Parse(carProperties[6]);
                double secondTirePressure = double.Parse(carProperties[7]);
                int secondTireAge = int.Parse(carProperties[8]);
                double thirdTirePressure = double.Parse(carProperties[9]);
                int thirdTireAge = int.Parse(carProperties[10]);
                double fourthTirePressure = double.Parse(carProperties[11]);
                int fourthTireAge = int.Parse(carProperties[12]);

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, firstTirePressure, firstTireAge, secondTirePressure, secondTireAge, thirdTirePressure, thirdTireAge, fourthTirePressure, fourthTireAge);
                cars.Add(car);
            }
            string commandForCargoType = Console.ReadLine();
            foreach (Car singleCar in cars)
            {
                if (singleCar.Cargo.Type == commandForCargoType && singleCar.Tires.Any(x => x.Pressure < 1))
                {
                    Console.WriteLine(singleCar.Model);
                }

                else if (singleCar.Cargo.Type == commandForCargoType && singleCar.Engine.Power > 250)
                {
                    Console.WriteLine(singleCar.Model);
                }
            }
        }
    }
}