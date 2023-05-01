using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SS23_SWEN2_TourPlanner.ViewModels;
using TourPlanner.Models;

namespace SS23_SWEN2_TourPlanner.Views;

[QueryProperty(nameof(Tour), "Tour")]
public partial class TourDetailView : ContentView
{
    private ToursViewModel _toursViewModel;
    private Tour tour;

    public Tour Tour
    {
        get => tour;
        set
        {
            tour = value;
            OnPropertyChanged();
        }
    }
    public TourDetailView()
    {
        InitializeComponent();
        _toursViewModel = Helpers.ServiceHelper.GetService<ToursViewModel>();
        BindingContext = _toursViewModel.SelectedTour;
        
        //Console.WriteLine($"{tour.Id}, {tour.Name}, {tour.Description}");
    }
}