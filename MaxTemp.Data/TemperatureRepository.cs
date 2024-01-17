using MaxTemp.Common;

namespace MaxTemp.Data;

public class TemperatureRepository: ITemperatureRepository
{
    /// <summary>
    /// Construct a new TemperatureRepository using the default data file
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public TemperatureRepository()
    {
        throw new NotImplementedException();
    }
    /// <summary>
    /// Construct a new TemperatureRepository using the specified data from string
    /// </summary>
    /// <param name="testData"></param>
    /// <exception cref="NotImplementedException"></exception>
    public TemperatureRepository(string testData)
    {
        throw new NotImplementedException();
    }
    
    public IEnumerable<TemperatureEntry> GetAllEntries()
    {
        throw new NotImplementedException();
    }
}