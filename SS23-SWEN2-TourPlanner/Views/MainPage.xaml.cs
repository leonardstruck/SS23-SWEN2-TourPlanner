using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.Models;
using Tourplanner.ViewModels;

namespace SS23_SWEN2_TourPlanner.Views;

public partial class MainPage : ContentPage
{
   
    public MainPage(ToursViewModel toursViewModel)
    {
        InitializeComponent();
        BindingContext = toursViewModel;   
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ModalPage());
    }
}