using MaxTemp.Common;

namespace MaxTemp.Data;

public interface ITemperatureRepository
{
    IEnumerable<TemperatureEntry> GetAllEntries();
    IEnumerable<TemperatureEntry> GetEntryForSensor(string sensorId);
    IEnumerable<string> GetAllSensors();
}