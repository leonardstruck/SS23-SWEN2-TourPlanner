using System;
namespace TourPlanner.Models
{
	public class User
	{
		public int Id { get; private set; }
		public string Username { get; private set; }
		public List<Tour> Tours { get; set; }

		public User()
		{
		}
	}
}

