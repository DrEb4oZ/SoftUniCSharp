namespace Database.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DatabaseTests
    {
        Database database;
        [SetUp]
        public void SetUp()
        {
            database = new Database(1,2,3);
        }
        [TestCase(new int[] { })]
        [TestCase(new int[] { 2, 3, 4})]
        [TestCase(new int[] { 2, 3, 4,5,6,7,8,9,10,11,12,13,14,15,16})]
        [Test]
        public void ConstructorShouldWorkCorrectly(int[] data)
        {
            database = new Database(data);

            Assert.IsNotNull(database);
            Assert.AreEqual(data, database.Fetch());
        }
        [Test]
        public void CreateConstructorWithMoreThan16ElementsThrowsException()
        {
            InvalidOperationException exception =  Assert.Throws<InvalidOperationException>(() => database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17));

            Assert.AreEqual("Array's capacity must be exactly 16 integers!", exception.Message);
        }
        [Test]
        public void CountPropertyWorkCorrectly()
        {
            Assert.AreEqual(3, database.Count);
        }

        [Test]
        public void WhenAddNewElementItShouldWorkAddItAtTheEnd()
        {
            database.Add(4);
            Assert.AreEqual(4, database.Count);
            Assert.AreEqual(new int[] { 1, 2, 3, 4 }, database.Fetch());
        }
        [Test]
        public void WhenAddNewElementItShouldIncreaseCount()
        {
            database = new Database();
            database.Add(1);
            Assert.AreEqual(1, database.Count);
        }

        [Test]
        public void WhenDatabaseHave16ElementsAndTryAddNewElementExceptionIsThrown()
        {
            int[] data = new int[16];
            for (int i = 0; i < 16; i++)
            {
                data[i] = i;
            }
            database = new Database(data);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.Add(100));
            Assert.AreEqual("Array's capacity must be exactly 16 integers!", exception.Message);
        }
        [Test]
        public void DatabaseRemoveMethodShouldWorkCorrectly()
        {
            database.Remove();

            Assert.AreEqual(new int[] { 1, 2 }, database.Fetch());
        }
        [Test]
        public void WhenDatabaseRemoveMethodIsCalledCountDecreaseWithOne()
        {
            database.Remove();
            Assert.AreEqual(2, database.Count);
        }
        [Test]
        public void WhenDatabaseIsEmptyAndRemoveMethodIsCalledExceptionIsThrown()
        {
            database = new Database();
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.Remove());
            Assert.AreEqual("The collection is empty!", exception.Message);
        }
        [Test]
        public void WhenFetchIsCalledDatabaseArrayIsReturned()
        {
            Assert.AreEqual(new int[] { 1, 2, 3 }, database.Fetch());
        }
    }
}
