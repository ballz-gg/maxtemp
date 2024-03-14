using Avalonia.Controls;
using Avalonia.Interactivity;
using MaxTemp.App.ViewModels;

namespace MaxTemp.App.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void RadioButton_OnClick(object? sender, RoutedEventArgs e)
    {
        var button = (RadioButton)sender!;
        var vm = (MainWindowViewModel)DataContext!;
        vm.UpdateSelectedSensor(button.Content!.ToString()!);
    }
}