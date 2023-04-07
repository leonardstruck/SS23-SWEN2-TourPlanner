using System;
using System.Runtime.InteropServices;

namespace TourPlanner.Models
{
	public class Tour
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public Point From { get; set; }
        public Point To { get; set; }
		public string TransportType { get; set; }
		public double Distance { get; set; }
        public double Time { get; set; }
        public string Information { get; set; }
		public List<TourLog> TourLogs { get; } = new();

        public Tour()
        {
			Name = "TourName";
			Description = "This is a very cool tour! Your should try it :)";
			Distance = 4.3;
			From = new Point(1,1);
			To = new Point(2,2);
			Information = "coole Strecke";
			Time = 5.4;
			TransportType = "Bike";

		}
    }
}

