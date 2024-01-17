namespace UniversityLibrary.Test
{
    using NUnit.Framework;
    using System.Linq;

    public class Tests
    {
        private UniversityLibrary library;
        private TextBook LordOfTheRings;
        private TextBook Hobbit;
        [SetUp]
        public void Setup()
        {
            library = new UniversityLibrary();
            LordOfTheRings = new TextBook("Lord of the Rings", "Tolkin", "Fantasy");
            Hobbit = new TextBook("Hobbit", "Tolkin", "Fantasy");
        }

        [Test]
        public void ConstructorWorksCorrectly()
        {
            Assert.IsNotNull(library);
        }
        [Test]
        public void CataloguePropertyIsNotNull()
        {
            Assert.IsNotNull(library.Catalogue);
        }

        [Test]
        public void CataloguePropertyCountIsZero()
        {
            Assert.AreEqual(0, library.Catalogue.Count);
        }
        [Test]
        public void WhenAddTextBookShouldReturnMessage()
        {
            Assert.AreEqual("Book: Lord of the Rings - 1\r\nCategory: Fantasy\r\nAuthor: Tolkin", library.AddTextBookToLibrary(LordOfTheRings));

        }
        [Test]
        public void WhenAddTextBookShouldAddToCatalogue()
        {
            library.AddTextBookToLibrary(LordOfTheRings);
            Assert.AreEqual(LordOfTheRings, library.Catalogue.FirstOrDefault(b => b.Title == "Lord of the Rings"));

        }
        [Test]
        public void WhenAddTextBookShouldIncreaseInventoryNumber()
        {
            library.AddTextBookToLibrary(LordOfTheRings);
            Assert.AreEqual(1, LordOfTheRings.InventoryNumber);

        }
        [Test]
        public void WhenAddTextBookShouldIncreaseInventoryNumberSecondWay()
        {
            library.AddTextBookToLibrary(LordOfTheRings);
            Assert.AreEqual(library.Catalogue.Count, LordOfTheRings.InventoryNumber);

        }
        [Test]
        public void WhenAddTextBookShouldIncreaseTheirCount()
        {
            int expectedResult = 2;
            library.AddTextBookToLibrary(LordOfTheRings);
            library.AddTextBookToLibrary(Hobbit);
            Assert.AreEqual(expectedResult, library.Catalogue.Count);
        }
        
        [Test]
        public void WhenLoanTextbookSuccessfullyShouldReturnMessage()
        {
            library.AddTextBookToLibrary(LordOfTheRings);
            Assert.AreEqual("Lord of the Rings loaned to Ivan.", library.LoanTextBook(LordOfTheRings.InventoryNumber, "Ivan"));
        }
        [Test]
        public void WhenLoanTextbookAndItsNotReturnedShouldReturnMessage()
        {
            library.AddTextBookToLibrary(LordOfTheRings);
            LordOfTheRings.Holder = "Ivan";
            Assert.AreEqual("Ivan still hasn't returned Lord of the Rings!", library.LoanTextBook(LordOfTheRings.InventoryNumber, "Ivan"));
        }
        [Test]
        public void WhenLoanTextbookAndItsNotReturnedHolderShouldBeTheStudent()
        {
            library.AddTextBookToLibrary(LordOfTheRings);
            LordOfTheRings.Holder = "Ivan";
            library.LoanTextBook(LordOfTheRings.InventoryNumber, "Ivan");
            Assert.AreEqual("Ivan", LordOfTheRings.Holder );
        }
        [Test]
        public void WhenLoanTextbookSuccessfullyShouldChangeItsHolder()
        {
            library.AddTextBookToLibrary(LordOfTheRings);
            library.LoanTextBook(LordOfTheRings.InventoryNumber, "Ivan");
            Assert.AreEqual("Ivan", LordOfTheRings.Holder);
        }
        [Test]
        public void WhenReturnTextBookShouldReturnMessage()
        {
            library.AddTextBookToLibrary(LordOfTheRings);
            library.LoanTextBook(LordOfTheRings.InventoryNumber, "Ivan");
            Assert.AreEqual("Lord of the Rings is returned to the library.", library.ReturnTextBook(LordOfTheRings.InventoryNumber));
        }
        [Test]
        public void WhenReturnTextBookShouldRemoveHolder()
        {
            library.AddTextBookToLibrary(LordOfTheRings);
            library.LoanTextBook(LordOfTheRings.InventoryNumber, "Ivan");
            library.ReturnTextBook(LordOfTheRings.InventoryNumber);
            Assert.AreEqual(string.Empty, LordOfTheRings.Holder );
        }
    }
}