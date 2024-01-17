using System.Linq;
namespace VehicleGarage.Tests
{
    public class Tests
    {
        private Garage garage;
        private int capacity = 50;
        Vehicle vehicle1;
        Vehicle vehicle2;

        [SetUp]
        public void Setup()
        {
            garage = new Garage(capacity);
            vehicle1 = new Vehicle("Opel", "Corsa", "6666");
            vehicle2 = new Vehicle("Opel", "Astra", "5555");
        }

        [Test]
        public void ConstructorShouldWorkCorrectly()
        {
            Assert.AreEqual(capacity, garage.Capacity);
            Assert.IsNotNull(garage);
            Assert.IsNotNull(garage.Vehicles);
        }
        [Test]
        public void CapacityPropertyWorksCorrectly()
        {
            int newCapacity = 100;
            garage.Capacity = newCapacity;
            Assert.AreEqual(newCapacity, garage.Capacity);
        }
        [Test]
        public void VehiclePropertyWorksCorrectly()
        {
            garage.Vehicles.Add(vehicle1);
            int expectedResult = 1;
            Assert.AreEqual(expectedResult, garage.Vehicles.Count());
            Assert.AreEqual(vehicle1, garage.Vehicles.FirstOrDefault(v => v.LicensePlateNumber == "6666"));
            Assert.IsNotNull(garage.Vehicles);
            Assert.IsNotNull(garage);
        }
        [Test]
        public void WhenAddVehicleShouldAddVehicle()
        {
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            int expectedResult = 2;
            Assert.AreEqual(expectedResult, garage.Vehicles.Count);
        }
        [Test]
        public void WhenAddVehicleAndThereIsNoCapacityShouldDoNothingAndContinue()
        {
            garage.Capacity = 1;
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            int expectedResult = 1;
            Assert.AreEqual(expectedResult, garage.Vehicles.Count);
        }
        [Test]
        public void WhenAddVehicleAndCarIsAlreadyInTheListShouldDoNothingAndContinue()
        {
            garage.Capacity = 1;
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle1);
            int expectedResult = 1;
            Assert.AreEqual(expectedResult, garage.Vehicles.Count);
        }
        [Test]
        public void WhenAddVehicleSuccessfulyShouldReturnTrue()
        {
            Assert.AreEqual(true, garage.AddVehicle(vehicle1));
            Assert.AreEqual(true, garage.AddVehicle(vehicle2));
        }
        [Test]
        public void WhenAddVehicleAndThereIsNoCapacityShouldReturnFalse()
        {
            garage.Capacity = 1;
            garage.AddVehicle(vehicle1);
            Assert.AreEqual(false, garage.AddVehicle(vehicle2));
        }
        [Test]
        public void WhenAddVehicleAndCarIsAlreadyInTheListShouldReturnFalse()
        {
            garage.Capacity = 1;
            garage.AddVehicle(vehicle1);
            Assert.AreEqual(false, garage.AddVehicle(vehicle1));
        }
        [Test]
        public void WhenChargeVehicleItShouldChargeAllVehiclesWithBatteriesBelowAndEqualBatteryChargeAmount()
        {
            vehicle1.BatteryLevel = 50;
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            int expectedResult = 1;
            Assert.AreEqual(expectedResult, garage.ChargeVehicles(90));

        }
        [Test]
        public void WhenChargeVehicleItShouldChargeAllCapableVehiclesTo100()
        {
            vehicle1.BatteryLevel = 50;
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            int expectedResult = 100;
            garage.ChargeVehicles(90);
            Assert.AreEqual(expectedResult, vehicle1.BatteryLevel);

        }
        [Test]
        public void WhenDriveVehicleShouldReduceBatteryChargeWithBatteryDrainageAmount()
        {
            int batteriDrainage = 40;
            garage.AddVehicle(vehicle1);
            int expectedResult = vehicle1.BatteryLevel - batteriDrainage;
            garage.DriveVehicle("6666", batteriDrainage, false);
            Vehicle testVehicle = garage.Vehicles.FirstOrDefault(v => v.LicensePlateNumber == "6666");
            Assert.AreEqual(expectedResult, testVehicle.BatteryLevel);
        }
        [Test]
        public void WhenDriveVehicleIfAccidentOccurredVehicleIsDamageShouldBeTrue()
        {
            int batteriDrainage = 40;
            garage.AddVehicle(vehicle1);
            bool expectedResult = true;
            garage.DriveVehicle("6666", batteriDrainage, true);
            Vehicle testVehicle = garage.Vehicles.FirstOrDefault(v => v.LicensePlateNumber == "6666");
            Assert.AreEqual(expectedResult, testVehicle.IsDamaged);
        }
        [Test]
        public void WhenDriveVehicleVehicleIsDamageShouldBeFalse()
        {
            int batteriDrainage = 40;
            garage.AddVehicle(vehicle1);
            bool expectedResult = false; ;
            garage.DriveVehicle("6666", batteriDrainage, false);
            Vehicle testVehicle = garage.Vehicles.FirstOrDefault(v => v.LicensePlateNumber == "6666");
            Assert.AreEqual(expectedResult, testVehicle.IsDamaged);
        }
        [Test]
        public void WhenDriveVehicleIfBatteryLevelIsBelowBatteryDrainageNothingShouldHappen()
        {
            int batteryDrainage = 60;
            garage.AddVehicle(vehicle1);
            vehicle1.BatteryLevel = 40;
            int expectedResult = vehicle1.BatteryLevel;
            garage.DriveVehicle("6666", batteryDrainage, false);
            Vehicle testVehicle = garage.Vehicles.FirstOrDefault(v => v.LicensePlateNumber == "6666");
            Assert.AreEqual(expectedResult, testVehicle.BatteryLevel);
        }
        [Test]
        [TestCase(101)]
        [TestCase(120)]
        public void WhenDriveVehicleIfBatteryDrainageIsAbove100NothingShouldHappen(int data)
        {
            int batteryDrainage = data;
            garage.AddVehicle(vehicle1);
            vehicle1.BatteryLevel = 40;
            int expectedResult = vehicle1.BatteryLevel;
            garage.DriveVehicle("6666", batteryDrainage, false);
            Vehicle testVehicle = garage.Vehicles.FirstOrDefault(v => v.LicensePlateNumber == "6666");
            Assert.AreEqual(expectedResult, testVehicle.BatteryLevel);
        }
        [Test]
        public void WhenDriveVehicleIfVehicleIsDamagedNothingShouldHappen()
        {
            int batteryDrainage = 70;
            garage.AddVehicle(vehicle1);
            vehicle1.IsDamaged = true;
            int expectedResult = vehicle1.BatteryLevel;
            garage.DriveVehicle("6666", batteryDrainage, false);
            Vehicle testVehicle = garage.Vehicles.FirstOrDefault(v => v.LicensePlateNumber == "6666");
            Assert.AreEqual(expectedResult, testVehicle.BatteryLevel);
            Assert.AreEqual(true, testVehicle.IsDamaged);
        }
        [Test]
        public void WhenRepairVehiclesMessageShouldBeReturnedWithTheCountOfRepairedVehicles()
        {
            vehicle1.IsDamaged = true;
            vehicle2.IsDamaged = true;
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            int expectedResult = 2;
            Assert.AreEqual($"Vehicles repaired: {expectedResult}", garage.RepairVehicles());
        }
        [Test]
        public void WhenRepairVehiclesIsDamageShouldBecameFalse()
        {
            vehicle1.IsDamaged = true;
            vehicle2.IsDamaged = true;
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            int expectedResult = 2;
            garage.RepairVehicles();
            Assert.AreEqual(false, garage.Vehicles.FirstOrDefault(v => v.LicensePlateNumber == "6666").IsDamaged);
            Assert.AreEqual(false, garage.Vehicles.FirstOrDefault(v => v.LicensePlateNumber == "5555").IsDamaged);
        }
    }
}
