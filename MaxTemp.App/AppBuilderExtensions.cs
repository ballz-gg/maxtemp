using Avalonia;
using MaxTemp.Data;
using MaxTemp.Logic;
using Splat;

namespace MaxTemp.App;

public static class AppBuilderExtensions
{
    public static AppBuilder UseMaxTempServices(this AppBuilder builder)
    {
        builder.AfterPlatformServicesSetup(_ =>
        {
            Locator.CurrentMutable.RegisterLazySingleton(() => new TemperatureRepository(),
                typeof(ITemperatureRepository));
            Locator.CurrentMutable.RegisterLazySingleton(() => new TemperatureService(), typeof(ITemperatureService));
        });
        return builder;
    }
}