using System;
using Microsoft.EntityFrameworkCore;

namespace TourPlanner.DAL
{
	
	public class TourDbContext : DbContext
	{
		public string DbPath { get; }
		public TourDbContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = System.IO.Path.Join(path, "tour.db");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlite($"Data Source={DbPath}");
			Database.EnsureCreated();
		}
	}
}

