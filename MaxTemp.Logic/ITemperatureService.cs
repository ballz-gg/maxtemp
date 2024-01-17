using MaxTemp.Common;

namespace MaxTemp.Logic;

public interface ITemperatureService
{
    public TemperatureEntry GetMaxForSensor(string sensorId);
}