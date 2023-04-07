using System;
namespace TourPlanner.Models
{
	public class Point
	{
		public double Latitide { get; set; }
        public double Longitude { get; set; }

        public Point()
		{
		}
		public Point(double latitude, double longitude) {
			Latitide = latitude;
			Longitude = longitude;
		}
	}
}

