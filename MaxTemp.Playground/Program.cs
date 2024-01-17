using MaxTemp.Data;
using MaxTemp.Logic;


var repo = new TemperatureRepository();

var service = new TemperatureService(repo);

var maxTemp = service.GetMaxForSensor("sensor1");

Console.WriteLine($"Max temperature for sensor1 is {maxTemp.Temperature} at {maxTemp.Timestamp}");