using MaxTemp.Common;
using MaxTemp.Data;

namespace MaxTemp.Logic;

public class TemperatureService: ITemperatureService
{
    private readonly ITemperatureRepository _repository;
    
    public TemperatureService(ITemperatureRepository repository)
    {
        _repository = repository;
    }

    public TemperatureEntry GetMaxForSensor(string sensorId)
    {
        throw new NotImplementedException();
    }
}