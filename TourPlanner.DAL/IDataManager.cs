using System;
using TourPlanner.Models;

namespace TourPlanner.DAL
{
	public interface IDataManager
	{

        public ICollection<Tour> GetTours();
		public void AddTour(Tour newTour);
    }
}

