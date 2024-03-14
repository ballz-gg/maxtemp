namespace MaxTemp.Common;

public class TemperatureEntry
{
    public TemperatureEntry(string sensorId, DateTime timestamp, decimal temperature)
    {
        SensorId = sensorId;
        Timestamp = timestamp;
        Temperature = temperature;
    }

    public string SensorId { get; set; }
    public DateTime Timestamp { get; set; }
    public decimal Temperature { get; set; }
}