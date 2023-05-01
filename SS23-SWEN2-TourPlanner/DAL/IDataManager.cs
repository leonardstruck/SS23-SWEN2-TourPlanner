using System;
using TourPlanner.Models;


namespace SS23_SWEN2_TourPlanner.DAL
{
	public interface IDataManager
	{

        public ICollection<Tour> GetTours();
		public void AddTour(Tour newTour);
    }
}

