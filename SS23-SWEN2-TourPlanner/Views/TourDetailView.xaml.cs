using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using SS23_SWEN2_TourPlanner.ViewModels;
using TourPlanner.Models;

namespace SS23_SWEN2_TourPlanner.Views;

//[QueryProperty(nameof(Tour), "Tour")]
public partial class TourDetailView : ContentView
{
    private readonly ToursViewModel _toursViewModel;

    public TourDetailView()
    {
        InitializeComponent();
        _toursViewModel = Helpers.ServiceHelper.GetService<ToursViewModel>();
        BindingContext = _toursViewModel.SelectedTour;
    }
}