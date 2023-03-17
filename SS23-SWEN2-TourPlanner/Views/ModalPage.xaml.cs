using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SS23_SWEN2_TourPlanner.Views;

public partial class ModalPage : ContentPage
{
    public ModalPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}