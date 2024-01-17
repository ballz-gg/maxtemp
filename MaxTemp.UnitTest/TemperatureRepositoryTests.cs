using MaxTemp.Common;
using MaxTemp.Data;

namespace MaxTemp.UnitTest;

[TestClass]
public class TemperatureRepositoryTests
{
    
    [TestMethod]
    public void TestGetMaxForSensorSingleRow()
    {
        // Arrange
        const string testData = "sensor1,2021-01-01 00:00:00,10.0";
        var repository = new TemperatureRepository(testData);
        var expected = new TemperatureEntry("sensor1", new DateTime(2021,1,1,0,0,0), 10.0);
        
        // Act
        var actual = repository.GetAllEntries().First();
        
        // Assert
        Assert.AreEqual(expected.SensorId, actual.SensorId);
    }
}