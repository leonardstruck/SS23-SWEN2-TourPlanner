using System;
namespace TourPlanner.Models
{
	public class TourLog
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public string? Comment { get; set; }
		public int Difficulty { get; set; } // 1-5
		public double Time { get; set; }
		public int Rating { get; set; } // 1-5

		public TourLog()
		{
		}
	}
}

