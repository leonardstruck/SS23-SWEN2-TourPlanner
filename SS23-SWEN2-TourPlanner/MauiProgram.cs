using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using SS23_SWEN2_TourPlanner.Views;
using Tourplanner.ViewModels;
using TourPlanner.DAL;
using TourPlanner.Models;

namespace SS23_SWEN2_TourPlanner;

public static class MauiProgram
{
    
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        // using var db = new TourDbContext();
        // builder.Services.AddDbContext<TourDbContext>(options => options.UseSqlite(db.DbPath));
        // db.Database.EnsureCreated();
        // db.Add(new Tour());
        // db.SaveChanges();
        // Console.WriteLine($"Database path: {db.DbPath}");

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
        
        builder.Services.AddSingleton<TourDbContext>();
        builder.Services.AddSingleton<ToursViewModel>(x => new ToursViewModel());
        builder.Services.AddTransient<ToursView>();
        
        builder.Services.AddSingleton<MainPage>();
        
        builder.Services.AddSingleton<TourRepository>();

        var app = builder.Build();

        // initialize db
        using var db = app.Services.GetService<TourDbContext>();
        db.Database.EnsureCreated();

        return app;
    }
}