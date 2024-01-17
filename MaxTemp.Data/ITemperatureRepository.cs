using MaxTemp.Common;

namespace MaxTemp.Data;

public interface ITemperatureRepository
{
    IEnumerable<TemperatureEntry> GetAllEntries();
}