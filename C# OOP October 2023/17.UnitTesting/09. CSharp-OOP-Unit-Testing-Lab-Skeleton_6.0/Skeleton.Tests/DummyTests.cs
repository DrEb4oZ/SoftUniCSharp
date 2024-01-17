using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private Axe axe;
        private Dummy dummy;
        [SetUp]
        public void SetUp()
        {
            axe = new Axe(10, 10);
            dummy = new Dummy(30, 5);
        }
        [Test]
        public void DummyLoosesHealthIfAttacked()
        {
            dummy.TakeAttack(axe.AttackPoints);

            Assert.That(dummy.Health, Is.EqualTo(20));
        }

        [Test]
        public void DeadDummyThrowsExceptionIfAttacked()
        {
            dummy = new Dummy(0, 5);

            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(axe.AttackPoints));

        }
        [Test]
        public void DeadDummyGivesExperience()
        {
            dummy = new Dummy(0, 5);

            Assert.AreEqual(5, dummy.GiveExperience());
        }

        [Test]
        public void AliveDummyDoesNotGiveExperience()
        {
            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}