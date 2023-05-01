﻿//using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using SS23_SWEN2_TourPlanner.DAL;
using TourPlanner.Models;

namespace SS23_SWEN2_TourPlanner.ViewModels;

public partial class ToursViewModel : BaseViewModel
{
    public ObservableCollection<Tour> Tours { get; set; }
    // Service

    private readonly TourRepository _tourRepository;

    public ToursViewModel()
    {
        _tourRepository = Helpers.ServiceHelper.GetService<TourRepository>();
        Tours = new ObservableCollection<Tour>(_tourRepository.GetTours());
    }

    [RelayCommand]
    public void AddTour()
    {
        Debug.WriteLine("adding Tour");
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            Debug.WriteLine("adding tour");
            Tours.Add(new Tour());
            _tourRepository.AddTour(new Tour());
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
        }
        finally
        {
            IsBusy = false;
        }

        
    }
}
