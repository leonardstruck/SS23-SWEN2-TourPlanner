using System.Collections.ObjectModel;
using System.Diagnostics;
using TourPlanner.Models;

namespace Tourplanner.ViewModels;
public class ToursViewModel
{
    public ObservableCollection<Tour> Tours { get; } = new();

    public ToursViewModel()
    {
        Debug.WriteLine("Konstruktor");
        Tours.Add(new Tour());
        foreach (var tour in Tours) {
            Debug.WriteLine(tour.Name);
        }
        
    }

}

