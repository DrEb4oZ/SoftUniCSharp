using System.Runtime.CompilerServices;
using System.Text;

namespace SmartDevice.Tests
{
    public class Tests
    {
        private Device device;
        private const int memoryCapacity = 1000;
        private const int photoSize = 400;
        private const int appSize = 500;

        [SetUp]
        public void Setup()
        {
            device = new Device(memoryCapacity);
            
        }

        [Test]
        public void ConstructorShouldWorkCorrectly()
        {
            Assert.AreEqual(memoryCapacity, device.MemoryCapacity);
            Assert.AreEqual(memoryCapacity, device.AvailableMemory);
            Assert.AreEqual(0, device.Photos);
            Assert.IsNotNull(device.Applications);
        }
        [Test]
        public void WhenTakePhotoAvailableMemoryShouldDecreaseWithPhotoSize()
        {
            device.TakePhoto(photoSize);
            Assert.AreEqual(memoryCapacity - photoSize, device.AvailableMemory);

        }
        [Test]
        public void WhenTakePhotoPhotosCountShouldIncreaseByOne()
        {
            device.TakePhoto(photoSize);
            int expectedResult = 1;
            Assert.AreEqual(expectedResult, device.Photos);
        }
        [Test]
        public void WhenTakePhotoIfPhotoSizeIsGreaterThanAvailableMemoryShouldNotDecreaseAvailableMemory()
        {
            device.TakePhoto(photoSize + 1000);
            int expectedResult = 1000;
            Assert.AreEqual(expectedResult, device.AvailableMemory);
        }
        [Test]
        public void WhenTakePhotoIfPhotoSizeIsGreaterThanAvailableMemoryShouldNotIncreasePhotos()
        {
            device.TakePhoto(photoSize + 1000);
            int expectedResult = 0;
            Assert.AreEqual(expectedResult, device.Photos);
        }
        [Test]
        public void WhenInstallAppAvailableMemoryShouldDecreaseWithPhotoSize()
        {
            device.InstallApp("TestApp", appSize);
            Assert.AreEqual(memoryCapacity - appSize, device.AvailableMemory);

        }
        [Test]
        public void WhenInstallAppAppsCountShouldIncreaseByOne()
        {
            device.InstallApp("TestApp", appSize);
            int expectedResult = 1;
            Assert.AreEqual(expectedResult, device.Applications.Count);
        }
        [Test]
        public void WhenInstallAppStringShouldBeReturned()
        {
            string appName = "TestApp";
            Assert.AreEqual($"{appName} is installed successfully. Run application?", device.InstallApp(appName, appSize));
        }
        [Test]
        public void WhenInstallAppAndThereIsNotEnoughMemoryExceptionShouldBeThrown()
        {
            Assert.Throws<InvalidOperationException>(() => device.InstallApp("TestApp", appSize + 1000));
        }
        [Test]
        public void WhenFormatDeviceItShouldWorkCorrectly()
        {
            device.TakePhoto(photoSize);
            device.InstallApp("TestApp", appSize);
            Assert.AreEqual(1, device.Photos);
            Assert.AreEqual(1, device.Applications.Count);
            device.FormatDevice();
            Assert.AreEqual(memoryCapacity, device.AvailableMemory);
            Assert.AreEqual(memoryCapacity, device.MemoryCapacity);
            Assert.AreEqual(0, device.Photos);
            Assert.AreEqual(0, device.Applications.Count);
        }
        [Test]
        public void GetDeviceStatusShouldWorkCorrectly()
        {
            List<string> applications = new List<string> { "TestApp" };
            device.TakePhoto(photoSize);
            device.InstallApp("TestApp", appSize);
            Assert.AreEqual(1, device.Photos);
            Assert.AreEqual(1, device.Applications.Count);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Memory Capacity: {memoryCapacity} MB, Available Memory: {memoryCapacity - photoSize - appSize} MB");
            stringBuilder.AppendLine($"Photos Count: 1");
            stringBuilder.AppendLine($"Applications Installed: {string.Join(", ", applications)}");

            Assert.AreEqual(stringBuilder.ToString().TrimEnd(), device.GetDeviceStatus());
        }
    }
}