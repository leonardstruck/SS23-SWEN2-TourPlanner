using System;
using Microsoft.EntityFrameworkCore;
using TourPlanner.Models;

namespace SS23_SWEN2_TourPlanner.DAL
{

	public class TourDbContext : DbContext
	{
		public string DbPath { get; }
		public DbSet<Tour> Tours { get; set; }

		public TourDbContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = System.IO.Path.Join(path, "tour.db");
		}

		public TourDbContext(string dbPath)
		{
			DbPath = dbPath;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			Console.WriteLine("ensure db");
			options.UseSqlite($"Data Source={DbPath}");
		}

	}
}

