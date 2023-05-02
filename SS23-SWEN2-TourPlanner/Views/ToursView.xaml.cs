using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SS23_SWEN2_TourPlanner.ViewModels;
using TourPlanner.Models;

namespace SS23_SWEN2_TourPlanner.Views;

public partial class ToursView : ContentPage
{
    //public ToursView()
    //{
    //    InitializeComponent();
    //}
    private ToursViewModel _toursViewModel;
    private Tour _currentTour;
    
    //Todo: Hier stimmt noch was nicht.. ich glaube man muss das ViewModel im Konstruktor mitgeben??
    public ToursView()
    {
        InitializeComponent();
        _toursViewModel = Helpers.ServiceHelper.GetService<ToursViewModel>();
        
        BindingContext = _toursViewModel;
    }

    //private async void Button_OnClicked(object sender, EventArgs e)
    //{
    //    await Navigation.PushModalAsync(new ModalPage());
    //    toursViewModel.addTour();
    //}

    public async void Button_OnClicked(object sender, EventArgs e)
    {
        Console.WriteLine("HALLO");
        // _toursViewModel.AddTour();
        await Navigation.PushModalAsync(new ModalPage());
        Debug.WriteLine("Button clicked");
    }

    private async void Button_Remove_OnClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage/test");
    }
}