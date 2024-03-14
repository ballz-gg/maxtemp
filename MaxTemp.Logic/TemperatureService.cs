using MaxTemp.Common;
using MaxTemp.Data;
using Splat;

namespace MaxTemp.Logic;

public class TemperatureService: ITemperatureService
{
    private readonly ITemperatureRepository _repository;
    
    public TemperatureService(ITemperatureRepository? repository = null)
    {
        _repository = repository ?? Locator.Current.GetService<ITemperatureRepository>() ?? throw new ArgumentNullException(nameof(repository));
    }

    public decimal GetAverageForSensor(string sensorId)
    {
        var sensorData = _repository.GetEntryForSensor(sensorId);
        return sensorData.Average(x => x.Temperature);
    }

    public TemperatureEntry GetMaxForSensor(string sensorId)
    {
        var sensorData = _repository.GetEntryForSensor(sensorId);
        return sensorData.OrderByDescending(x => x.Temperature).First();
    }

    public TemperatureEntry GetMinForSensor(string sensorId)
    {
        var sensorData = _repository.GetEntryForSensor(sensorId);
        return sensorData.OrderBy(x => x.Temperature).First();
    }
}