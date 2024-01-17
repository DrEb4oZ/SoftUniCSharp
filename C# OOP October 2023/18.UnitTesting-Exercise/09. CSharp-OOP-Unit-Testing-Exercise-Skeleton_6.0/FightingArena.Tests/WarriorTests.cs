namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class WarriorTests
    {
        private Warrior warrior;
        [SetUp]
        public void SetUp()
        {
            warrior = new Warrior("Ivan", 10, 50);
        }
        [Test]
        public void CreateWarriorWithConstructorShouldWorkCorrectly()
        {
            Assert.AreEqual("Ivan", warrior.Name);
            Assert.AreEqual(10, warrior.Damage);
            Assert.AreEqual(50, warrior.HP);
            Assert.IsNotNull(warrior);
        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("    ")]
        public void WhenWarriorNamePropertyIsNullOrWhiteSpaceExceptionShouldBeThrown(string name)
        {


            ArgumentException exception = Assert.Throws<ArgumentException>(() => warrior = new Warrior(name, 10, 50));
            Assert.AreEqual("Name should not be empty or whitespace!", exception.Message);
        }
        [Test]
        [TestCase(0)]
        [TestCase(-50)]
        public void WhenWarriorDamagePropertyIsNotPositiveExceptionShouldBeThrown(int damage)
        {


            ArgumentException exception = Assert.Throws<ArgumentException>(() => warrior = new Warrior("Ivan", damage, 50));
            Assert.AreEqual("Damage value should be positive!", exception.Message);
        }
        [Test]
        [TestCase(-1)]
        [TestCase(-50)]
        public void WhenWarriorHPPropertyIsNotPositiveExceptionShouldBeThrown(int hP)
        {


            ArgumentException exception = Assert.Throws<ArgumentException>(() => warrior = new Warrior("Ivan", 10, hP));
            Assert.AreEqual("HP should not be negative!", exception.Message);
        }

        [Test]
        public void WhenAttackMethodIsCalledWarriorsShouldDecreaseHPBasedOnDamage()
        {
            Warrior attacker = new Warrior("Ivan", 20, 100);
            Warrior defender = new Warrior("Asen", 10, 50);
            attacker.Attack(defender);
            Assert.AreEqual(30, defender.HP);
            Assert.AreEqual(90, attacker.HP);
        }
        [Test]
        public void WhenAttackMethodIsCalledAndAttackerDamageIsGreaterThanDefenderDefendersHPShouldNotGoBelowZero()
        {
            Warrior attacker = new Warrior("Ivan", 70, 100);
            Warrior defender = new Warrior("Asen", 10, 50);
            attacker.Attack(defender);
            Assert.AreEqual(0, defender.HP);
            Assert.AreEqual(90, attacker.HP);
        }
        [Test]
        [TestCase(30)]
        [TestCase(20)]
        public void WhenAttackMethodIsCalledAndAttackerHPIsEqualOrLowerThan30ExceptionShouldBeThrown(int hp)
        {
            Warrior attacker = new Warrior("Ivan", 20, hp);
            Warrior defender = new Warrior("Asen", 10, 50);
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));
            Assert.AreEqual("Your HP is too low in order to attack other warriors!", exception.Message);
        }
        [Test]
        [TestCase(30)]
        [TestCase(20)]
        public void WhenAttackMethodIsCalledAndDefenderHPIsEqualOrLowerThan30ExceptionShouldBeThrown(int hp)
        {
            Warrior attacker = new Warrior("Ivan", 20, 100);
            Warrior defender = new Warrior("Asen", 10, hp);
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));
            Assert.AreEqual($"Enemy HP must be greater than 30 in order to attack him!", exception.Message);
        }
        [Test]
        public void WhenAttackMethodIsCalledAndAttackerHPIsLowerThanDefenderDamageExceptionShouldBeThrown()
        {
            Warrior attacker = new Warrior("Ivan", 20, 40);
            Warrior defender = new Warrior("Asen", 50, 50);
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => attacker.Attack(defender));
            Assert.AreEqual($"You are trying to attack too strong enemy", exception.Message);
        }
    }
}