namespace FightingArena.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ArenaTests
    {
        private Arena arena;
        [SetUp]
        public void SetUp()
        {
            arena = new Arena();
        }
        [Test]
        public void WhenArenaConstructorIsCalledItShouldNotBeNull()
        {
            arena = new Arena();
            Assert.IsNotNull(arena);
        }
        [Test]
        public void WarriorsPropertyShouldGetListOfWarriors()
        {
            arena.Enroll(new Warrior("Ivan", 10, 50));
            Assert.AreEqual(1, arena.Warriors.Count);
        }
        [Test]
        public void CountPropertyShouldGiveTheCountOfWarriors()
        {
            arena.Enroll(new Warrior("Ivan", 10, 50));
            Assert.AreEqual(1, arena.Count);
        }
        [Test]
        public void WhenEnrollMethodIsCalledItShouldAddWarriorToTheArena()
        {
            arena.Enroll(new Warrior("Ivan", 10, 50));
            arena.Enroll(new Warrior("Asen", 20, 60));
            arena.Enroll(new Warrior("Kiro", 5, 40));

            Assert.AreEqual(3, arena.Count);
        }
        [Test]
        [TestCase("Ivan")]
        public void WhenEnrollMethodIsCalledAndTheWarriorNameIsInTheArenaExceptionShouldBeThrown(string name)
        {
            arena.Enroll(new Warrior(name, 10, 50));
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => arena.Enroll(new Warrior (name, 20, 40)));
            Assert.AreEqual("Warrior is already enrolled for the fights!", exception.Message);
        }

        [Test]
        public void WhenFightMethodIsCalledItShouldCallWarriorAttackMethod()
        {
            Warrior attacker = new Warrior("Ivan", 10, 50);
            Warrior defender = new Warrior("Asen", 20, 60);
            arena.Enroll(attacker);
            arena.Enroll(defender);
            arena.Fight("Ivan", "Asen");
            Assert.AreEqual(30, attacker.HP);
            Assert.AreEqual(50, defender.HP);

        }
        [Test]
        public void WhenFightMethodIsCalledAndAttackerNameIsNotInWarriorsListExceptionShouldBeThrown()
        {
            Warrior attacker = new Warrior("Ivan", 10, 50);
            Warrior defender = new Warrior("Asen", 20, 60);
            arena.Enroll(defender);
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => arena.Fight("Ivan", "Asen"));
            Assert.AreEqual($"There is no fighter with name {attacker.Name} enrolled for the fights!", exception.Message);
        }
        [Test]
        public void WhenFightMethodIsCalledAndDeffenderNameIsNotInWarriorsListExceptionShouldBeThrown()
        {
            Warrior attacker = new Warrior("Ivan", 10, 50);
            Warrior defender = new Warrior("Asen", 20, 60);
            arena.Enroll(attacker);
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => arena.Fight("Ivan", "Asen"));
            Assert.AreEqual($"There is no fighter with name {defender.Name} enrolled for the fights!", exception.Message);
        }
    }
}
