using System.Diagnostics.Contracts;
using System.Xml.Linq;

namespace VendingRetail.Test
{
    public class Tests
    {
        private CoffeeMat coffeeMat;

        private const double Income = 0;
        private const int WaterTankLevel = 0;
        private const int WaterCapacity = 200;
        private const int ButtonCount = 3;

        [SetUp]
        public void Setup()
        {
            coffeeMat = new CoffeeMat(WaterCapacity, ButtonCount);
        }

        [Test]
        public void ConstructorShouldWorkCorrectly()
        {
            Assert.AreEqual(WaterCapacity, coffeeMat.WaterCapacity);
            Assert.AreEqual(ButtonCount, coffeeMat.ButtonsCount);
            Assert.AreEqual(Income, coffeeMat.Income);
            Assert.IsNotNull(coffeeMat);
        }
        [Test]
        public void IncomeShouldReturnTheIncome()
        {
            double drinkPrice = 5d;
            coffeeMat.FillWaterTank();
            coffeeMat.AddDrink("TestDrink", drinkPrice);
            coffeeMat.BuyDrink("TestDrink");
            Assert.AreEqual(drinkPrice, coffeeMat.Income);
        }
        [Test]
        public void WhenFillWaterTankCoffeeMatWaterTankShouldBeFilledAndMessageShouldBePrint()
        {
            
            Assert.AreEqual($"Water tank is filled with {WaterCapacity}ml", coffeeMat.FillWaterTank());
            Assert.AreEqual(WaterTankLevel + WaterCapacity, coffeeMat.WaterCapacity);
        }
        [Test]
        public void WhenFillWaterTankIfCoffeeMatWaterTankIsFullShouldReturnMessage()
        {
            coffeeMat.FillWaterTank();
            
            Assert.AreEqual("Water tank is already full!", coffeeMat.FillWaterTank());
        }
        [Test]
        public void WhenAddDrinkShouldAddDrinkToTheCoffeeMatAndReturnTrue()
        {
            Assert.AreEqual(true, coffeeMat.AddDrink("Test", 3));
        }
        [Test]
        public void WhenAddDrinkAndDrinkAlreadyExistShouldReturnFalse()
        {
            coffeeMat.AddDrink("Test", 3);
            Assert.AreEqual(false, coffeeMat.AddDrink("Test", 3));
        }
        [Test]
        public void WhenBuyDrinkAndWaterIsUnder80MessageShouldBePrint()
        {
            coffeeMat.AddDrink("Test", 3);
            Assert.AreEqual("CoffeeMat is out of water!" , coffeeMat.BuyDrink("Test"));
        }
        [Test]
        public void WhenBuyDrinkShouldGiveADrinkAndMessageWithBillPrints()
        {
            coffeeMat.FillWaterTank();
            coffeeMat.AddDrink("Test", 3);
            Assert.AreEqual($"Your bill is {3:f2}$", coffeeMat.BuyDrink("Test"));
        }
        //[Test]
        //public void WhenBuyDrinkShouldGiveADrinkWaterTankLevelMustDecreaseBy80()
        //{
        //    coffeeMat.FillWaterTank();
        //    coffeeMat.AddDrink("Test", 3);
        //    coffeeMat.BuyDrink("Test");
        //}
        [Test]
        public void WhenBuyDrinkAndThereIsNoSuchDrinkMessageMustBePrinted()
        {
            coffeeMat.FillWaterTank();
            Assert.AreEqual($"{"Test"} is not available!", coffeeMat.BuyDrink("Test"));
        }
        [Test]
        public void WhenCollectIncomeItShouldReturnTotalIncome()
        {
            coffeeMat.FillWaterTank();
            coffeeMat.AddDrink("Test", 3);
            coffeeMat.BuyDrink("Test");
            coffeeMat.BuyDrink("Test");
            Assert.AreEqual(6, coffeeMat.CollectIncome());
        }
        [Test]
        public void AfterCollectIncomeTheIncomeShouldBeZero()
        {
            coffeeMat.FillWaterTank();
            coffeeMat.AddDrink("Test", 3);
            coffeeMat.BuyDrink("Test");
            coffeeMat.BuyDrink("Test");
            Assert.AreEqual(6, coffeeMat.Income);
            Assert.AreEqual(6, coffeeMat.CollectIncome());
            Assert.AreEqual(0, coffeeMat.Income);
        }
        [Test]
        public void WhenFillWaterTankCoffeeMatWaterTankShouldBeFilledAndMessageShouldBePrintSecond()
        {
            coffeeMat.FillWaterTank();
            coffeeMat.AddDrink("Test", 3);
            coffeeMat.BuyDrink("Test");
            Assert.AreEqual($"Water tank is filled with {80}ml", coffeeMat.FillWaterTank());
            Assert.AreEqual(200, coffeeMat.WaterCapacity);
        }
    }
}