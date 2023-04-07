using System;
using TourPlanner.Models;
namespace TourPlanner.DAL;

public class DataManagerMemory : IDataManager
{
	private ICollection<Tour> tours = new List<Tour>();

	public DataManagerMemory()
	{
		tours.Add(new Tour{ Distance = 0, Description = "", From = new Point(), Information = "", Name = "", Time = 0, To = new Point(), TransportType = "" });
	}

	public ICollection<Tour> GetTours() {

	}

	public void AddTour(Tour newTour) {

	}
}

