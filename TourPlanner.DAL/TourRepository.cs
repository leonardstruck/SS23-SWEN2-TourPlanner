using System.Data;
using TourPlanner.Models;

namespace TourPlanner.DAL;

public class TourRepository
{
    /*public DataTable Execute(string query, Dictionary<string, object> args)  
    {  
        if (string.IsNullOrEmpty(query.Trim()))  
            return null;  
  
        using (var con = new SQLiteConnection(@"Data Source=/.Students.db;"))  
        {  
            con.Open();  
            using (var cmd = new SQLiteCommand(query, con))  
            {  
                foreach (KeyValuePair<string, object> entry in args)  
                {  
                    cmd.Parameters.AddWithValue(entry.Key, entry.Value);  
                }  
  
                var da = new SQLiteDataAdapter(cmd);  
  
                var dt = new DataTable();  
                da.Fill(dt);  
  
                da.Dispose();  
                return dt;  
            }  
        }  
    }
    
    public void AddTour(Tour newTour)
    {
        using (var db = new TourDbContext())
        {
            db.Add(newTour);
            db.SaveChanges();
        }
    }
    
    public List<Tour> GetTours()
    {
        using (var db = new TourDbContext())
        {
            var tour = new Tour();  
  
            var query = "SELECT * FROM tour";  // wie heißt die Tabelle in der Datenbank?
  
            var args = new Dictionary<string, object>  
            {  
                {"@stdId", tour.Id}  
            };  
  
            DataTable dt = Execute(query, args);  
  
            if (dt == null || dt.Rows.Count == 0)  
            {  
                return null;  
            }  
  
            tour = new Tour  
            {  
                Id = Convert.ToInt32(dt.Rows[0]["Id"]),
                Name = Convert.ToString(dt.Rows[0]["Name"]) ?? String.Empty,  
                Description = Convert.ToString(dt.Rows[0]["Description"]) ?? string.Empty,  
                Distance = Convert.ToInt32(dt.Rows[0]["Distance"]),  
                From = Convert.ToString(dt.Rows[0]["From"]) ?? string.Empty,
                To = Convert.ToString(dt.Rows[0]["To"]) ?? string.Empty,
                Information = Convert.ToString(dt.Rows[0]["Information"]) ?? string.Empty,
                Time = Convert.ToDouble(dt.Rows[0]["Time"]),
                TransportType = Convert.ToString(dt.Rows[0]["TransportationType"]) ?? string.Empty
            };  
  
            return tour.ToList();  
        }
    }*/

}