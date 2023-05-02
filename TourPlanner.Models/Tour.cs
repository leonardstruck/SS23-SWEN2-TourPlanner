using System;
using System.Runtime.InteropServices;

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
        public string Information { get; set; } // path to image
		public List<TourLog> TourLogs { get; } = new();

        public Tour()
        {
	        //make sure images Folder exists
	        var folder = Environment.SpecialFolder.LocalApplicationData;
	        var path = Environment.GetFolderPath(folder);
	        Information = System.IO.Path.Join(path, "TourPlanner", "Maps", $"{Name}.png");
        
	        // ToDo: outsource this to a config class or something
	        if (!System.IO.Directory.Exists(System.IO.Path.Join(path, "TourPlanner", "Maps")))
	        {
		        System.IO.Directory.CreateDirectory(System.IO.Path.Join(path, "TourPlanner", "Maps"));
	        }
	        
			Name = "";
			Description = ""; ;
			From = "";
			To = "";
			TransportType = "";
        }
        
    }
}

