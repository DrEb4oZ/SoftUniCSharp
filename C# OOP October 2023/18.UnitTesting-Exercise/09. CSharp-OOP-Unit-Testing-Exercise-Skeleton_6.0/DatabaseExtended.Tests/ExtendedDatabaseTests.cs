namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private Database database;
        [SetUp]
        public void SetUp()
        {
            Person[] persons =
            {
                new Person(1, "Ivan"),
                new Person(2, "Gosho"),
                new Person(3, "Asen")
            };


            database = new Database(persons);
        }
        [Test]
        public void PersonClassConstructorWorksCorrectly()
        {
            Person person1 = new Person(5, "Pesho");

            Assert.AreEqual(5, person1.Id);
            Assert.AreEqual("Pesho", person1.UserName);
            Assert.IsNotNull(person1);
        }
        [Test]
        public void DatabaseConstructorWorksCorrectly()
        {
            database = new Database();
            Assert.IsNotNull(database);
        }

        [Test]
        public void DatabaseConstructorWithPersons()
        {
            Person[] persons =
            {
                new Person(1, "Ivan"),
                new Person(2, "Gosho"),
                new Person(3, "Asen"),
                new Person(4, "Miro"),
                new Person(5, "Pesho"),
                new Person(6, "Ivan_Ivan"),
                new Person(7, "Asen_Asen"),
                new Person(8, "Ivan_Asen"),
                new Person(9, "Asen_Ivan"),
                new Person(10, "Asen_Pesho"),
                new Person(11, "Asen_Miro"),
                new Person(12, "Kiro"),
                new Person(13, "Kokorcho"),
                new Person(14, "Oshteedin"),
                new Person(15, "Predposleden"),
                new Person(16, "posleden")
            };
            Database database = new Database(persons);
            Assert.AreEqual(persons.Length, database.Count);
        }
        [Test]
        public void DatabaseConstructWithMoreThan16Persons()
        {
            Person[] persons =
            {
                new Person(1, "Ivan"),
                new Person(2, "Gosho"),
                new Person(3, "Asen"),
                new Person(4, "Miro"),
                new Person(5, "Pesho"),
                new Person(6, "Ivan_Ivan"),
                new Person(7, "Asen_Asen"),
                new Person(8, "Ivan_Asen"),
                new Person(9, "Asen_Ivan"),
                new Person(10, "Asen_Pesho"),
                new Person(11, "Asen_Miro"),
                new Person(12, "Kiro"),
                new Person(13, "Kokorcho"),
                new Person(14, "Oshteedin"),
                new Person(15, "Predposleden"),
                new Person(16, "posleden"),
                new Person(17, "Exceptional"),

            };
            ArgumentException exception = Assert.Throws<ArgumentException>(() => database = new Database(persons));
            Assert.AreEqual("Provided data length should be in range [0..16]!", exception.Message);
        }
        [Test]
        public void CountPropertyWorksCorrectly()
        {
            Assert.AreEqual(3, database.Count);
        }

        [Test]
        public void WhenAddMethodIsCalledPersonIsAddCorrectly()
        {
            Person person1 = new Person(101, "Agent");
            database.Add(person1);
            Assert.AreEqual(4, database.Count);
            Assert.AreEqual(person1, database.FindById(101));
        }
        //[TestCase(null)]
        //public void WhenAddingPersonWithNullOrEmptyNameValueShouldThrowException(string name)
        //{
        //    Person person1 = new Person(80, name);
        //    //database = new Database();

        //    ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => database.Add(person1));
        //    Assert.AreEqual("Username parameter is null!", exception.Message);
        //}
        [Test]
        public void WhenAddMoreThan16PeopleShouldThrowException()
        {
            Person[] persons =
            {
                new Person(1, "Ivan"),
                new Person(2, "Gosho"),
                new Person(3, "Asen"),
                new Person(4, "Miro"),
                new Person(5, "Pesho"),
                new Person(6, "Ivan_Ivan"),
                new Person(7, "Asen_Asen"),
                new Person(8, "Ivan_Asen"),
                new Person(9, "Asen_Ivan"),
                new Person(10, "Asen_Pesho"),
                new Person(11, "Asen_Miro"),
                new Person(12, "Kiro"),
                new Person(13, "Kokorcho"),
                new Person(14, "Oshteedin"),
                new Person(15, "Predposleden"),
                new Person(16, "posleden"),
            };
            database = new Database(persons);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.Add(new Person(500, "Exceptional")));

            Assert.AreEqual("Array's capacity must be exactly 16 integers!", exception.Message);
        }
        [Test]
        public void WhenAddPersonWithSameUsernameShouldThrowException()
        {
            Person person = new Person(555, "Ivan");
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.Add(person));
            Assert.AreEqual("There is already user with this username!", exception.Message);
        }
        [Test]
        public void WhenAddPersonWithSameIdShouldThrowException()
        {
            Person person = new Person(1, "Exceptional");
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.Add(person));
            Assert.AreEqual("There is already user with this Id!", exception.Message);
        }
        [Test]
        public void WhenAddPerson_CountShouldIncrease()
        {
            Person person = new Person(555, "Counter");
            database.Add(person);
            Assert.AreEqual(4, database.Count);
        }
        [Test]
        public void WhenRemoveMethodIsCalledItRemovesPersonCorrectly()
        {
            database.Remove();
            Assert.AreEqual(2, database.Count);
        }

        [Test]
        public void WhenRemovePersonFromEmptyDatabaseExceptionIsThrown()
        {
            database = new Database();
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
        [Test]
        public void WhenFindByUserNameIsCalledItWorksCorrectly()
        {
            Person person = new Person(1, "Ivan");
            database = new Database(person);
            Assert.AreEqual(person, database.FindByUsername("Ivan"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void WhenFindByUserNameIsCalledWithNullOrEmptyExceptionIsThrown(string name)
        {

            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => database.FindByUsername(name));
            Assert.AreEqual("Username parameter is null!", exception.ParamName);
        }

        [Test]
        public void WhenFindByUserNameIsCalledWithNonExistedNameExceptionShouldBeThrown()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.FindByUsername("NonExistent"));
            Assert.AreEqual("No user is present by this username!", exception.Message);
        }

        [Test]
        public void WhenFindByIdIsCalledItWorksCorrectly()
        {
            Person person = new Person(1, "Ivan");
            database = new Database(person);
            Assert.AreEqual(person, database.FindById(1));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-10)]
        public void WhenFindByIdIsCalledWithNegativeNumberExceptionShouldBeThrown(int id)
        {
            ArgumentOutOfRangeException exception = Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(id));
            Assert.AreEqual("Id should be a positive number!", exception.ParamName);
        }
        [Test]
        public void WhenFindByIdICalledWithNonExistentIdExceptionShouldBeThrown()
        {
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => database.FindById(385));
            Assert.AreEqual("No user is present by this ID!", exception.Message);
        }
    }
}