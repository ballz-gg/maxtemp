using MaxTemp.Common;

namespace MaxTemp.Logic;

public interface ITemperatureService
{
    public TemperatureEntry GetMaxForSensor(string sensorId);
    public TemperatureEntry GetMinForSensor(string sensorId);
    public double GetAverageForSensor(string sensorId);

}