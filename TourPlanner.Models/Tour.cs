using System;
using System.Runtime.InteropServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TourPlanner.Models
{
	public class Tour
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string From { get; set; }
        public string To { get; set; }
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
			From = "1010 Wien";
			To = "1200 Wien";
			Information = "coole Strecke";
			Time = 5.4;
			TransportType = "Bicycle";
			
		}
    }
}

