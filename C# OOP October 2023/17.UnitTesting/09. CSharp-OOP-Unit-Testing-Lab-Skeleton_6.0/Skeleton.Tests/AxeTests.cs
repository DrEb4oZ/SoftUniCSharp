using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        private Axe axe;
        private Dummy dummy;
        [SetUp]
        public void SetUp()
        {
            axe = new Axe(5, 10);
            dummy = new Dummy(20, 2);
        }
        [Test]
        public void WhenAttackWithAxe_ItLoseDurability()
        {
            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints);
        }
        [Test]
        public void WhenAttackWithAxeWithoutDurability_ThrowBreakError()
        {
            axe = new Axe(5, 0);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));

            Assert.AreEqual("Axe is broken.", exception.Message);
        }
    }
}