using TourPlanner.Models;
namespace TourPlanner.DAL;

public class DataManagerMemory : IDataManager
{
	// ReSharper disable once CollectionNeverQueried.Local
	private readonly ICollection<Tour> _tours = new List<Tour>();

	public DataManagerMemory()
	{
		_tours.Add(new Tour{ Distance = 0, Description = "", From = new Point(), Information = "", Name = "", Time = 0, To = new Point(), TransportType = "" });
	}

	public ICollection<Tour> GetTours() {
		return _tours;
	}

	public void AddTour(Tour newTour) {

	}
}

