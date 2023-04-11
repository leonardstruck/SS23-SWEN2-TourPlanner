//using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using TourPlanner.Models;

namespace Tourplanner.ViewModels;

public partial class ToursViewModel : BaseViewModel
{
    public ObservableCollection<Tour> Tours { get; } = new();
    // Service

    public ToursViewModel()
    {
        Title = "Tours";
        Tours.Add(new Tour());
        Tours.Add(new Tour());
        foreach (var tour in Tours) {
            Debug.WriteLine(tour.Name);
        }
        
    }

    [RelayCommand]
    public void addTour()
    {
        Debug.WriteLine("adding Tour");
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            Debug.WriteLine("adding tour");
            Tours.Add(new Tour());

        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
        }
        finally
        {
            IsBusy = false;
        }

        
    }
}

