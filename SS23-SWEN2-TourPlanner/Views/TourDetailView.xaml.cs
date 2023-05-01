using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourPlanner.Models;

namespace SS23_SWEN2_TourPlanner.Views;

[QueryProperty(nameof(Tour), "Tour")]
public partial class TourDetailView : ContentPage
{
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
        BindingContext = this.tour;
        
        Console.WriteLine($"{tour.Id}, {tour.Name}, {tour.Description}");
    }
}