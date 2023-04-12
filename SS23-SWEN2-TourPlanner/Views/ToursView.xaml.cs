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


    ToursViewModel toursViewModel = new();


    //Todo: Hier stimmt noch was nicht.. ich glaube man muss das ViewModel im Konstruktor mitgeben??
    public ToursView()
    {
        InitializeComponent();
        BindingContext = toursViewModel;
    }

    //private async void Button_OnClicked(object sender, EventArgs e)
    //{
    //    await Navigation.PushModalAsync(new ModalPage());
    //    toursViewModel.addTour();
    //}

    public void Button_OnClicked(object sender, EventArgs e)
    {
        Console.WriteLine("HALLO");
        
        //await Navigation.PushModalAsync(new ModalPage());
        toursViewModel.addTour();
        
        Debug.WriteLine("Button clicked");
    }
}