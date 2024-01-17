namespace SmartDevice.Tests
{
    using NUnit.Framework;
    using System;
    using System.Text;

    public class Tests
    {
        private Device device;
        [SetUp]
        public void Setup()
        {
            device = new Device(1000);
        }

        [Test]
        public void WhenCreatingNewInstanceConstructorShouldWorkCorrectly()
        {
        }
    }
}