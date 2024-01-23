using MaxTemp.Common;

namespace MaxTemp.Data;

public class TemperatureRepository: ITemperatureRepository
{
    private readonly Func<TextReader> _getReader;
    
    private IEnumerable<TemperatureEntry>? _cachedData;
    private IEnumerable<TemperatureEntry> Data => _cachedData ??= ReadInData(_getReader());

    /// <summary>
    /// Construct a new TemperatureRepository using the default data file
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public TemperatureRepository()
    {
        _getReader = () => new StreamReader("temps.csv");
    }
    /// <summary>
    /// Construct a new TemperatureRepository using the specified data from string
    /// </summary>
    /// <param name="testData"></param>
    /// <exception cref="NotImplementedException"></exception>
    public TemperatureRepository(string testData)
    {
        _getReader = () => new StringReader(testData);
    }

    private IEnumerable<TemperatureEntry> ReadInData(TextReader reader) {
        var result = new List<TemperatureEntry>();
        while (reader.ReadLine() is { } line)
        {
            var fields = line.Split(',');
            if (fields.Length != 3)
            {
                Console.Error.Write($"TemperatureRepository: data has row with wrong length of arguments:\n\tExpected 3 got {fields.Length}\n\tThis row will be ignored");
                continue;
            }

            var serverId = fields[0];
            var dt = DateTime.Parse(fields[1]);
            var temperature =  Double.Parse(fields[2]);
            
            result.Add(new (serverId, dt, temperature));
        }
        return result;
    }
    
    public IEnumerable<TemperatureEntry> GetAllEntries()
    {
        return Data;
    }
}
