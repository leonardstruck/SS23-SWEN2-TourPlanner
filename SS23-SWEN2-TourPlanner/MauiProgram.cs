using Microsoft.Extensions.Logging;
using System.Diagnostics;
using SS23_SWEN2_TourPlanner.Views;
using Tourplanner.ViewModels;

namespace SS23_SWEN2_TourPlanner;

public static class MauiProgram
{
    
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<ToursViewModel>();
        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
    }
}