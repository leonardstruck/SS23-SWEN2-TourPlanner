using System;
using System.Collections.Generic;
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

    public ToursView()
    {
        InitializeComponent();
        BindingContext = new ToursViewModel();
    }

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ModalPage());
    }
}