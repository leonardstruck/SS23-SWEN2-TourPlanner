using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tourplanner.ViewModels;

namespace SS23_SWEN2_TourPlanner.Views;

public partial class ToursView : ContentView
{
    //public ToursView()
    //{
    //    InitializeComponent();
    //}
    private ToursViewModel _toursViewModel;
    
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

    public void Button_OnClicked(object sender, EventArgs e)
    {
        Console.WriteLine("HALLO");
        _toursViewModel.addTour();
        //await Navigation.PushModalAsync(new ModalPage());
        Debug.WriteLine("Button clicked");
    }
}