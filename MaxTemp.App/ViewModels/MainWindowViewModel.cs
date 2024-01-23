using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using MaxTemp.App.Models;
using MaxTemp.Data;
using MaxTemp.Logic;
using ReactiveUI;
using Splat;

namespace MaxTemp.App.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly ITemperatureRepository _temperatureRepository;

    public ObservableCollection<SelectableSensor> Sensors { get; }
    
    private SensorViewModel _selectedSensor;
    public SensorViewModel SelectedSensor
    {
        get => _selectedSensor;
        set => this.RaiseAndSetIfChanged(ref _selectedSensor, value);
    }
    
    public MainWindowViewModel()
    {
        _temperatureRepository = Locator.Current.GetService<ITemperatureRepository>() ?? throw new ArgumentNullException(nameof(_temperatureRepository));
        var sensors = _temperatureRepository.GetAllSensors().OrderBy(s => s)!;
        var firstSensor = sensors.First();
        SelectedSensor = new SensorViewModel(firstSensor);
        Sensors = new ObservableCollection<SelectableSensor>(sensors.Select(s => new SelectableSensor {Id = s, IsSelected = s == firstSensor}));
    }
    
    public void UpdateSelectedSensor(string sensorId)
    {
        SelectedSensor = new SensorViewModel(sensorId);
    }
}