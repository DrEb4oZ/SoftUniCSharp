namespace Railway.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Tests
    {
        private RailwayStation station;
        [SetUp]
        public void Setup()
        {
            station = new RailwayStation("GO");
        }

        [Test]
        public void ConstructorWorksCorrectly()
        {
            Assert.IsNotNull(station);
        }

        [Test]
        public void ArrivalTrainShouldBeNullWhenInstanced()
        {
            Assert.IsNotNull(station.ArrivalTrains);
        }
        [Test]
        public void DepartureTrainsShouldBeNullWhenInstanced()
        {
            Assert.IsNotNull(station.DepartureTrains);
        }

        [Test]
        public void WhenGivingNameItShouldWorkCorrectly()
        {
            string name = "Sofia";
            station = new RailwayStation(name);
            Assert.AreEqual(name, station.Name);
        }
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("     ")]
        public void WhenGivingNullOrWhiteSpaceNameItShouldThrowException(string data)
        {
            Assert.Throws<ArgumentException>(() => station = new RailwayStation(data));
        }
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("     ")]
        public void WhenGivingNullOrWhiteSpaceNameItShouldThrowExceptionWithMessage(string data)
        {
            string expectedMessage = "Name cannot be null or empty!";
            ArgumentException ex =  Assert.Throws<ArgumentException>(() => station = new RailwayStation(data));
            Assert.AreEqual(expectedMessage, ex.Message);
        }
        [Test]
        public void WhenNewArrivalOnBoardItShouldIncreaseCountOfArrivalTrains()
        {
            string train1 = "train1";
            string train2 = "train2";
            string train3 = "train3";
            station.NewArrivalOnBoard(train1);
            station.NewArrivalOnBoard(train2);
            station.NewArrivalOnBoard(train3);
            int expectedResult = 3;
            Assert.AreEqual(expectedResult, station.ArrivalTrains.Count());
        }
        [Test]
        public void WhenTrainHasArrivedShouldIncreaseDepartureTrainCountAndDecreaseArrivalTrainCount()
        {
            string train1 = "train1";
            string train2 = "train2";
            string train3 = "train3";
            station.NewArrivalOnBoard(train1);
            station.NewArrivalOnBoard(train2);
            station.NewArrivalOnBoard(train3);
            station.TrainHasArrived(train1);
            int expectedArrivalCountResult = 2;
            int expectedDepartureCountResult = 1;
            Assert.AreEqual(expectedArrivalCountResult, station.ArrivalTrains.Count());
            Assert.AreEqual(expectedDepartureCountResult, station.DepartureTrains.Count());
        }
        [Test]
        public void WhenTrainHasArrivedAndWorkCorrectlyShouldReturnMessage()
        {
            string train1 = "train1";
            string train2 = "train2";
            string train3 = "train3";
            station.NewArrivalOnBoard(train1);
            station.NewArrivalOnBoard(train2);
            station.NewArrivalOnBoard(train3);
            string expectedMessage = $"train1 is on the platform and will leave in 5 minutes.";

            Assert.AreEqual(expectedMessage, station.TrainHasArrived(train1));
        }
        [Test]
        public void WhenTrainHasArrivedButDepartureTrainIsNotFirstInQueCountShouldStayTheSame()
        {
            string train1 = "train1";
            string train2 = "train2";
            string train3 = "train3";
            station.NewArrivalOnBoard(train1);
            station.NewArrivalOnBoard(train2);
            station.NewArrivalOnBoard(train3);
            station.TrainHasArrived(train3);
            int expectedArrivalCountResult = 3;
            int expectedDepartureCountResult = 0;
            Assert.AreEqual(expectedArrivalCountResult, station.ArrivalTrains.Count());
            Assert.AreEqual(expectedDepartureCountResult, station.DepartureTrains.Count());
        }
        [Test]
        public void WhenTrainHasArrivedButDepartureTrainIsNotFirstInQueShouldReturnMessage()
        {
            string train1 = "train1";
            string train2 = "train2";
            string train3 = "train3";
            station.NewArrivalOnBoard(train1);
            station.NewArrivalOnBoard(train2);
            station.NewArrivalOnBoard(train3);
            string expectedMessage = "There are other trains to arrive before train3.";

            Assert.AreEqual(expectedMessage, station.TrainHasArrived(train3));
        }
        [Test]
        public void WhenTrainHasLeftAndTheGivenTrainExistInTheDepartureTrainsCollectionItShouldReturnTrue()
        {
            string train1 = "train1";
            string train2 = "train2";
            string train3 = "train3";
            station.NewArrivalOnBoard(train1);
            station.NewArrivalOnBoard(train2);
            station.NewArrivalOnBoard(train3);
            station.TrainHasArrived(train1);
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, station.TrainHasLeft(train1));
        }
        [Test]
        public void WhenTrainHasLeftAndTheGivenTrainExistInTheDepartureTrainsCollectionItShouldDecreaseCoutnWithOne()
        {
            string train1 = "train1";
            string train2 = "train2";
            string train3 = "train3";
            station.NewArrivalOnBoard(train1);
            station.NewArrivalOnBoard(train2);
            station.NewArrivalOnBoard(train3);
            station.TrainHasArrived(train1);
            int expectedResult = station.DepartureTrains.Count() - 1;
            station.TrainHasLeft(train1);
            Assert.AreEqual(expectedResult, station.DepartureTrains.Count());
        }
        [Test]
        public void WhenTrainHasLeftAndTheGivenTrainDoesNotExistInTheDepartureTrainsCollectionItShouldReturnFalse()
        {
            string train1 = "train1";
            string train2 = "train2";
            string train3 = "train3";
            station.NewArrivalOnBoard(train1);
            station.NewArrivalOnBoard(train2);
            station.NewArrivalOnBoard(train3);
            station.TrainHasArrived(train1);
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, station.TrainHasLeft(train3));
        }
        [Test]
        public void WhenTrainHasLeftAndTheGivenTrainExistInTheDepartureTrainsCollectionItShouldNotChangeDepratureTrainsCount()
        {
            string train1 = "train1";
            string train2 = "train2";
            string train3 = "train3";
            station.NewArrivalOnBoard(train1);
            station.NewArrivalOnBoard(train2);
            station.NewArrivalOnBoard(train3);
            station.TrainHasArrived(train1);
            int expectedResult = station.DepartureTrains.Count();
            station.TrainHasLeft(train3);
            Assert.AreEqual(expectedResult, station.DepartureTrains.Count());
        }
    }
}