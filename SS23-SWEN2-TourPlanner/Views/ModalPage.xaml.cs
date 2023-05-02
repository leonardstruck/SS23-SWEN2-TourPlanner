using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SS23_SWEN2_TourPlanner.ViewModels;
using TourPlanner.Models;

namespace SS23_SWEN2_TourPlanner.Views;

public partial class ModalPage : ContentPage
{
    
    private ToursViewModel _toursViewModel;
    
    public ModalPage()
    {
        InitializeComponent();
        BindingContext = new Tour();
        
        _toursViewModel = Helpers.ServiceHelper.GetService<ToursViewModel>();

    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    private void AddTour_OnClicked(object sender, EventArgs e)
    {
        var tour = (Tour)BindingContext;
        Console.WriteLine("Add Tour");

        _toursViewModel.AddTour(tour);
        Navigation.PopModalAsync();
    }
}