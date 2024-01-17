namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;
        [SetUp]
        public void SetUp()
        {
            car = new Car("Opel", "Corsa", 5, 100);
        }
        [Test]
        public void WhenCarIsCreatedWithConstructorItShouldWorkCorrectly()
        {
            car = new Car("Opel", "Corsa", 5, 100);
            Assert.IsNotNull(car);
            Assert.AreEqual("Opel", car.Make);
            Assert.AreEqual("Corsa", car.Model);
            Assert.AreEqual(5, car.FuelConsumption);
            Assert.AreEqual(100, car.FuelCapacity);
            Assert.AreEqual(0, car.FuelAmount);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void WhenCarPropertyMakeIsNullOrEmptyExceptionShouldBeThrown(string make)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car(make, "Corsa", 5, 100));
            Assert.AreEqual("Make cannot be null or empty!", exception.Message);
        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void WhenCarPropertyModelIsNullOrEmptyExceptionShouldBeThrown(string model)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Opel", model, 5, 100));
            Assert.AreEqual("Model cannot be null or empty!", exception.Message);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-50)]
        public void WhenCarPropertyFuelConsumptionIsNullOrEmptyExceptionShouldBeThrown(double fuelConsumption)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Opel", "Corsa",fuelConsumption , 100));
            Assert.AreEqual("Fuel consumption cannot be zero or negative!", exception.Message);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-50)]
        public void WhenCarPropertyFuelCapacityIsNullOrEmptyExceptionShouldBeThrown(double fuelCapacity)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Car("Opel", "Corsa", 5, fuelCapacity));
            Assert.AreEqual("Fuel capacity cannot be zero or negative!", exception.Message);
        }
        [Test]
        public void WhenRefuelMethodIsCalledItShouldRefillCorrectly()
        {
            car.Refuel(20);
            Assert.AreEqual(20, car.FuelAmount);
        }
        [Test]
        public void WhenRefuelMethodIsCalledAndTheAmountIsGreaterThanCapacityItShouldRefillToMaxCapacity()
        {
            car.Refuel(120);
            Assert.AreEqual(100, car.FuelAmount);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-50)]
        public void WhenRefuelMethodIsCalledAndTheAmountIsNotPositiveExceptionShouldBeThrown(double fuel)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(() => car.Refuel(fuel));
            Assert.AreEqual("Fuel amount cannot be zero or negative!", exception.Message);
        }
        [Test]
        public void WhenDriveMethodIsCalledItShouldWorkCorrectly()
        {
            car.Refuel(100);
            car.Drive(100);
            Assert.AreEqual(95, car.FuelAmount);
        }
        [Test]
        public void WhenDriveMethodIsCalledAndFuelIsNotEnoughExceptionShouldBeThrown()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => car.Drive(100));
            Assert.AreEqual("You don't have enough fuel to drive!", exception.Message);
        }
    }
}
