using System.Data;
using TourPlanner.Models;

namespace SS23_SWEN2_TourPlanner.DAL;

public class TourRepository
{
    private readonly TourDbContext _tourDbContext;
    
    public TourRepository()
    {
        _tourDbContext = Helpers.ServiceHelper.GetService<TourDbContext>();
    }
    
    public ICollection<Tour> GetTours()
    {
        return _tourDbContext.Tours.ToList();
    }

    public async void AddTour(Tour newTour)
    {
        var mapApi = new MapApi(newTour);
        await mapApi.CreateMap();
        _tourDbContext.Tours.Add(newTour);
        _tourDbContext.SaveChanges();
    }
}