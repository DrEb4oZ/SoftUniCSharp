using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Serialization;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int engineCount = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < engineCount; i++)
            {
                string[] engineProperties = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineProperties[0];
                int enginePower = int.Parse(engineProperties[1]);
                Engine engine = new Engine(engineModel, enginePower);
                if(engineProperties.Length >= 3)
                {
                    if (int.TryParse(engineProperties[2], out int engineDisplacement))
                    {
                        engine.Displacement = engineDisplacement;
                    }

                    else
                    {
                        string engineEfficiency = engineProperties[2];
                        engine.Efficiency = engineEfficiency;
                    }
                }

                if(engineProperties.Length == 4)
                {
                    string engineEfficiency = engineProperties[3];
                    engine.Efficiency = engineEfficiency;
                }

                engines.Add(engine);
            }

            int carCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < carCount; i++)
            {
                string[] carProperties = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = carProperties[0];
                string carEngineModel = carProperties[1];
                Car car = new Car(carModel, carEngineModel);
                car.Engine = engines.First(e => e.Model == carEngineModel);
                int a = 0;
                if (carProperties.Length >= 3)
                {
                    if (int.TryParse(carProperties[2], out int carWeight))
                    {
                        car.Weight = carWeight;
                    }

                    else
                    {
                        string carColor = carProperties[2];
                        car.Color = carColor;
                    }
                    
                }
                if (carProperties.Length == 4)
                {
                    string carColor = carProperties[3];
                    car.Color = carColor;
                }

                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                StringBuilder carPrint = new StringBuilder();
                carPrint.AppendLine($"{car.Model}:");
                carPrint.AppendLine($"  {car.Engine.Model}:");
                carPrint.AppendLine($"    Power: {car.Engine.Power}");
                if (car.Engine.Displacement != default)
                {
                    carPrint.AppendLine($"    Displacement: {car.Engine.Displacement}");
                }
                
                else
                {
                    carPrint.AppendLine($"    Displacement: n/a");
                }

                if (car.Engine.Efficiency != default)
                {
                    carPrint.AppendLine($"    Efficiency: {car.Engine.Efficiency}");
                }

                else
                {
                    carPrint.AppendLine($"    Efficiency: n/a");
                }

                if (car.Weight != default)
                {
                    carPrint.AppendLine($"  Weight: {car.Weight}");
                }

                else
                {
                    carPrint.AppendLine($"  Weight: n/a");
                }

                if (car.Color != default)
                {
                    carPrint.AppendLine($"  Color: {car.Color}");
                }

                else
                {
                    carPrint.AppendLine($"  Color: n/a");
                }

                Console.WriteLine(carPrint.ToString().TrimEnd());
            }
        }
    }
}