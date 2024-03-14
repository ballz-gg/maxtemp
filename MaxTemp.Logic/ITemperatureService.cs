using MaxTemp.Common;

namespace MaxTemp.Logic;

public interface ITemperatureService
{
    public TemperatureEntry GetMaxForSensor(string sensorId);
    public TemperatureEntry GetMinForSensor(string sensorId);
    public decimal GetAverageForSensor(string sensorId);

}