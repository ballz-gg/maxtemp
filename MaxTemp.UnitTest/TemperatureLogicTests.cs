using MaxTemp.Common;
using MaxTemp.Logic;
using MaxTemp.Data;

namespace MaxTemp.UnitTest
{
    [TestClass]
    public class TemperatureLogicTests
    {
        [TestMethod]
        public void TestGetMinForSensor()
        {
            // Arrange
            var testData = "sensor1,2021-01-01 00:00:00,10.0\nsensor1,2021-01-02 00:00:00,5.0\nsensor1,2021-01-03 00:00:00,15.0";
            var repository = new TemperatureRepository(testData);
            var expected = new TemperatureEntry("sensor1", new DateTime(2021,1,2,0,0,0), 5.0);
            var service = new TemperatureService(repository);

            // Act
            var actual = service.GetMinForSensor("sensor1");
        
            // Assert
            Assert.AreEqual(expected.Temperature, actual.Temperature);
        }

        [TestMethod]
        public void TestGetMaxForSensor()
        {
            // Arrange
            var testData = "sensor1,2021-01-01 00:00:00,10.0\nsensor1,2021-01-02 00:00:00,5.0\nsensor1,2021-01-03 00:00:00,15.0";
            var repository = new TemperatureRepository(testData);
            var expected = new TemperatureEntry("sensor1", new DateTime(2021, 1, 3, 0, 0, 0), 15.0);
            var service = new TemperatureService(repository);

            // Act
            var actual = service.GetMaxForSensor("sensor1");

            // Assert
            Assert.AreEqual(expected.Temperature, actual.Temperature);
        }

        [TestMethod]
        public void TestGetAverageForSensor()
        {
            // Arrange
            var testData = "sensor1,2021-01-01 00:00:00,10.0\nsensor1,2021-01-02 00:00:00,5.0\nsensor1,2021-01-03 00:00:00,15.0";
            var repository = new TemperatureRepository(testData);
            var expected = new TemperatureEntry("sensor1", new DateTime(2021, 1, 2, 0, 0, 0), 10.0);
            var service = new TemperatureService(repository);

            // Act
            var actual = service.GetMinForSensor("sensor1");

            // Assert
            Assert.AreEqual(expected.Temperature, actual.Temperature);
        }
    }
}
