using System;
using MaxTemp.App.ViewModels;
using MaxTemp.Common;
using MaxTemp.Logic;
using Splat;

namespace MaxTemp.App.ViewModels;

public class SensorViewModel: ViewModelBase
{
    public string SensorId { get; internal set; } = null!;
    public decimal Average { get; internal set; }
    public TemperatureEntry Max { get; internal set; } = null!;
    public TemperatureEntry Min { get; internal set; } = null!;

    public SensorViewModel(string sensorId)
    {
        var temperatureService = Locator.Current.GetService<ITemperatureService>() ?? throw new ArgumentNullException(nameof(ITemperatureService));
        SensorId = sensorId;
        Average = temperatureService.GetAverageForSensor(sensorId);
        Max = temperatureService.GetMaxForSensor(sensorId);
        Min = temperatureService.GetMinForSensor(sensorId);
    }

    [Obsolete("For design time only", false)]
    protected SensorViewModel() { }
}

public class DesignSensorViewModel: SensorViewModel
{
    [Obsolete("For design time only", false)]
    public DesignSensorViewModel()
    {
        SensorId = "Sensor 1";
        Average = 20.0m;
        Max = new TemperatureEntry("Sensor 1", DateTime.Now, 100.0m);
        Min = new TemperatureEntry("Sensor 1", DateTime.Now, 15.0m);
    }
}