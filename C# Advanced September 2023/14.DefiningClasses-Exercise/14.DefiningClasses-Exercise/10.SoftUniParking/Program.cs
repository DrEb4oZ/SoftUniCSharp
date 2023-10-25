using System.Xml;

namespace SoftUniParking
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");
            var car3 = new Car("car3", "three", 100, "BT0000BT");
            var car4 = new Car("car4", "FOUR", 100, "BT0001BT");
            var car5 = new Car("car5", "FIVE", 100, "BT0002BT");

            Console.WriteLine(car.ToString());
            // Make: Skoda
            // Model: Fabia
            // HorsePower: 65
            // RegistrationNumber: CC1856BG

            var parking = new Parking(10);
            Console.WriteLine(parking.AddCar(car));
            // Successfully added new car Skoda CC1856BG
            parking.AddCar(car3);
            parking.AddCar(car4);
            parking.AddCar(car5);
            Console.WriteLine(parking.AddCar(car));
            // Car with that registration number, already exists!

            Console.WriteLine(parking.AddCar(car2));
            // Successfully added new car Audi EB8787MN

            Console.WriteLine(parking.GetCar("EB8787MN").ToString());
            // Make: Audi
            // Model: A3
            // HorsePower: 110
            // RegistrationNumber: EB8787MN

            Console.WriteLine(parking.RemoveCar("EB8787MN"));
            // Successfullyremoved EB8787MN

            Console.WriteLine(parking.Count);
            // 1
            List<string> regNums = new List<string>()
            {
                "BT0000BT",
                "BT0001BT",
                "BT0002BT",
            };
            parking.RemoveSetOfRegistrationNumber(regNums);
            Console.WriteLine();
        }
    }
}