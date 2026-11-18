using CourierApp.Services;
using CourierApp.ViewModels;
using CourierApp.Views;

namespace CourierApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();

        builder.Services.AddSingleton<DriverIdentity>();
        builder.Services.AddSingleton<ApiClient>();

        builder.Services.AddTransient<StopsViewModel>();
        builder.Services.AddTransient<StopsPage>();
        builder.Services.AddTransient<StopViewModel>();
        builder.Services.AddTransient<StopPage>();

        return builder.Build();
    }
}
