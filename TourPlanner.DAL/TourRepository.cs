using System.Data;
using TourPlanner.Models;

namespace TourPlanner.DAL;

public class TourRepository
{
    private readonly TourDbContext _tourDbContext;
    
    public TourRepository(TourDbContext tourDbContext)
    {
        _tourDbContext = tourDbContext;
    }
    
    public ICollection<Tour> GetTours()
    {
        return _tourDbContext.Tours.ToList();
    }

    public void AddTour(Tour newTour)
    {
        _tourDbContext.Tours.Add(newTour);
        _tourDbContext.SaveChanges();
    }
}