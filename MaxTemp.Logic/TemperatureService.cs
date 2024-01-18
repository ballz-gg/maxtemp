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

    public TemperatureEntry GetMaxForSensor(string sensorId)
    {
        throw new NotImplementedException();
    }
}